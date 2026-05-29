using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OrvosRendelo
{
    public partial class Form6 : Form
    {
        private readonly string connectionString =
            "Server=localhost;Port=3306;Database=orvosirendelo;Uid=root;Pwd=mysql;CharSet=utf8;";

        // Rendelési idő: 08:00 – 16:00, 30 perces slotok
        private readonly TimeSpan rendelesTol = new TimeSpan(8, 0, 0);
        private readonly TimeSpan rendelesIg = new TimeSpan(16, 0, 0);
        private readonly int slotPercben = 30;

        public Form6()
        {
            InitializeComponent();
            dtpDatum.Value = DateTime.Today;
            ToltOrvosok();
        }

        // ── Orvos ComboBox feltöltése ──────────────────────────────────

        private void ToltOrvosok()
        {
            cmbOrvos.Items.Clear();
            cmbOrvos.Items.Add(new ComboItem("— Összes orvos —", -1));

            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    var cmd = new MySqlCommand(
                        "SELECT orvos_id, CONCAT(nev, '  –  ', szakterulet) AS megj FROM ORVOS ORDER BY nev",
                        conn);
                    using (var r = cmd.ExecuteReader())
                        while (r.Read())
                            cmbOrvos.Items.Add(new ComboItem(
                                r["megj"].ToString(),
                                Convert.ToInt32(r["orvos_id"])));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Orvosok betöltése sikertelen:\n" + ex.Message,
                    "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cmbOrvos.SelectedIndex = 0;
        }

        // ── Keresés gomb ───────────────────────────────────────────────

        private void btnKeres_Click(object sender, EventArgs e)
        {
            lblAllapot.Visible = false;
            dgvEredmeny.Rows.Clear();

            DateTime datum = dtpDatum.Value.Date;

            if (datum < DateTime.Today)
            {
                MutuzAllapot("Múltbeli dátumra nem érdemes szabad időpontot keresni.", false);
                return;
            }

            int szurtOrvosId = ((ComboItem)cmbOrvos.SelectedItem).Id;

            // Foglalt időpontok lekérése az adott napra
            var foglalt = FoglaltIdopontok(datum, szurtOrvosId);

            // Orvosok listája (szűréstől függően)
            var orvosok = OrvosokListaja(szurtOrvosId);

            int szabadSzamlalo = 0;

            foreach (var orvos in orvosok)
            {
                // Összes slot generálása a napra
                var slot = rendelesTol;
                while (slot < rendelesIg)
                {
                    var slotIdopont = datum.Add(slot);

                    // Foglalt? (az adott orvosnál)
                    bool foglaLt = foglalt.ContainsKey(orvos.Id) &&
                                   foglalt[orvos.Id].Contains(slot);

                    if (!foglaLt)
                    {
                        string idoStr = slotIdopont.ToString("yyyy.MM.dd  HH:mm");
                        string napStr = MagyarNap(slotIdopont.DayOfWeek);

                        int rowIdx = dgvEredmeny.Rows.Add(
                            orvos.Szoveg,
                            idoStr,
                            napStr,
                            "Szabad"
                        );

                        dgvEredmeny.Rows[rowIdx].DefaultCellStyle.BackColor =
                            Color.FromArgb(212, 237, 218);
                        dgvEredmeny.Rows[rowIdx].DefaultCellStyle.ForeColor =
                            Color.FromArgb(21, 87, 36);

                        szabadSzamlalo++;
                    }

                    slot = slot.Add(TimeSpan.FromMinutes(slotPercben));
                }
            }

            if (szabadSzamlalo == 0)
            {
                MutuzAllapot("Ezen a napon nincs szabad időpont a kiválasztott orvosnál.", false);
            }
            else
            {
                MutuzAllapot(
                    $"{szabadSzamlalo} szabad időpont találat  –  {datum:yyyy.MM.dd} ({MagyarNap(datum.DayOfWeek)})",
                    true);
            }
        }

        // ── Foglalt időpontok lekérése adott napra ─────────────────────

        private Dictionary<int, HashSet<TimeSpan>> FoglaltIdopontok(DateTime datum, int orvosId)
        {
            var eredmeny = new Dictionary<int, HashSet<TimeSpan>>();

            string sql = @"
                SELECT orvos_id, idopont_datum
                FROM IDOPONT
                WHERE DATE(idopont_datum) = @datum
                  AND statusz <> 'lemondott'";

            if (orvosId != -1)
                sql += " AND orvos_id = @orvosId";

            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@datum", datum.ToString("yyyy-MM-dd"));
                        if (orvosId != -1)
                            cmd.Parameters.AddWithValue("@orvosId", orvosId);

                        using (var r = cmd.ExecuteReader())
                        {
                            while (r.Read())
                            {
                                int oid = Convert.ToInt32(r["orvos_id"]);
                                var ido = Convert.ToDateTime(r["idopont_datum"]).TimeOfDay;

                                if (!eredmeny.ContainsKey(oid))
                                    eredmeny[oid] = new HashSet<TimeSpan>();

                                eredmeny[oid].Add(ido);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lekérdezési hiba:\n" + ex.Message,
                    "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return eredmeny;
        }

        // ── Orvosok listája (szűrt vagy összes) ───────────────────────

        private List<ComboItem> OrvosokListaja(int orvosId)
        {
            var lista = new List<ComboItem>();
            string sql = "SELECT orvos_id, CONCAT(nev, '  –  ', szakterulet) AS megj FROM ORVOS";
            if (orvosId != -1)
                sql += " WHERE orvos_id = @id";
            sql += " ORDER BY nev";

            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        if (orvosId != -1)
                            cmd.Parameters.AddWithValue("@id", orvosId);

                        using (var r = cmd.ExecuteReader())
                            while (r.Read())
                                lista.Add(new ComboItem(
                                    r["megj"].ToString(),
                                    Convert.ToInt32(r["orvos_id"])));
                    }
                }
            }
            catch { }

            return lista;
        }

        // ── Sor dupla kattintás – azonnali foglalás indítása ───────────

        private void dgvEredmeny_CellDoubleClick(object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string orvosNev = dgvEredmeny.Rows[e.RowIndex].Cells["colOrvos"].Value?.ToString() ?? "";
            string idoStr = dgvEredmeny.Rows[e.RowIndex].Cells["colIdo"].Value?.ToString() ?? "";

            var eredmeny = MessageBox.Show(
                $"Szeretne időpontot foglalni?\n\n" +
                $"Orvos:    {orvosNev}\n" +
                $"Időpont:  {idoStr}\n\n" +
                "Az új beteg felvételéhez megnyílik a felvételi ablak.",
                "Foglalás indítása",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (eredmeny == DialogResult.Yes)
            {
                Form3 f3 = new Form3();
                f3.Show();
            }
        }

        // ── Vissza gomb ────────────────────────────────────────────────

        private void btnVissza_Click(object sender, EventArgs e)
        {
            this.Close();
            foreach (Form f in Application.OpenForms)
            {
                if (f is Form1) { f.Show(); break; }
            }
        }

        // ── Enter a dátummezőn ─────────────────────────────────────────

        private void dtpDatum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnKeres_Click(sender, e);
        }

        // ── Segédmetódusok ─────────────────────────────────────────────

        private void MutuzAllapot(string szoveg, bool siker)
        {
            lblAllapot.Text = szoveg;
            lblAllapot.ForeColor = siker
                ? Color.FromArgb(21, 87, 36)
                : Color.FromArgb(114, 28, 36);
            lblAllapot.Visible = true;
        }

        private string MagyarNap(DayOfWeek nap)
        {
            switch (nap)
            {
                case DayOfWeek.Monday: return "Hétfő";
                case DayOfWeek.Tuesday: return "Kedd";
                case DayOfWeek.Wednesday: return "Szerda";
                case DayOfWeek.Thursday: return "Csütörtök";
                case DayOfWeek.Friday: return "Péntek";
                case DayOfWeek.Saturday: return "Szombat";
                case DayOfWeek.Sunday: return "Vasárnap";
                default: return "";
            }
        }
    }
}