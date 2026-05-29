using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OrvosRendelo
{
    public partial class Form7 : Form
    {
        private readonly string connectionString =
            "Server=localhost;Port=3306;Database=orvosirendelo;Uid=root;Pwd=mysql;CharSet=utf8;";

        private int kivalasztottIdopontId = -1;
        private string eredetiStatusz = "";

        public Form7()
        {
            InitializeComponent();
            ToltIdopontok();
        }

        // ── Táblázat feltöltése ────────────────────────────────────────

        private void ToltIdopontok()
        {
            dgvIdopontok.Rows.Clear();

            string szuro = cmbSzuroStatusz.SelectedItem?.ToString() ?? "Mind";
            string orvosKereses = txtOrvosKereses.Text.Trim();
            string betegKereses = txtBetegKereses.Text.Trim();

            string sql = @"
                SELECT
                    i.idopont_id,
                    b.nev           AS beteg_nev,
                    b.taj_szam,
                    o.nev           AS orvos_nev,
                    o.szakterulet,
                    i.idopont_datum,
                    i.statusz,
                    i.megjegyzes
                FROM IDOPONT i
                INNER JOIN BETEG b ON i.beteg_id = b.beteg_id
                INNER JOIN ORVOS o ON i.orvos_id = o.orvos_id
                WHERE 1=1";

            if (szuro != "Mind")
                sql += " AND i.statusz = @statusz";
            if (!string.IsNullOrEmpty(orvosKereses))
                sql += " AND o.nev LIKE @orvos";
            if (!string.IsNullOrEmpty(betegKereses))
                sql += " AND b.nev LIKE @beteg";

            sql += " ORDER BY i.idopont_datum DESC";

            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        if (szuro != "Mind")
                            cmd.Parameters.AddWithValue("@statusz", szuro);
                        if (!string.IsNullOrEmpty(orvosKereses))
                            cmd.Parameters.AddWithValue("@orvos", "%" + orvosKereses + "%");
                        if (!string.IsNullOrEmpty(betegKereses))
                            cmd.Parameters.AddWithValue("@beteg", "%" + betegKereses + "%");

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string datum = Convert.ToDateTime(reader["idopont_datum"])
                                                    .ToString("yyyy.MM.dd HH:mm");
                                string statusz = reader["statusz"].ToString();
                                string megj = reader["megjegyzes"] == DBNull.Value
                                                    ? "—" : reader["megjegyzes"].ToString();

                                int rowIdx = dgvIdopontok.Rows.Add(
                                    reader["idopont_id"].ToString(),
                                    reader["beteg_nev"].ToString(),
                                    reader["taj_szam"].ToString(),
                                    reader["orvos_nev"].ToString(),
                                    reader["szakterulet"].ToString(),
                                    datum,
                                    statusz,
                                    megj
                                );

                                SzinezSor(dgvIdopontok.Rows[rowIdx], statusz);
                            }
                        }
                    }
                }

                lblTalalatok.Text = $"{dgvIdopontok.Rows.Count} időpont";
                lblTalalatok.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Betöltési hiba:\n" + ex.Message,
                    "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Szerkesztőpanel ürítése
            PanelAllapot(false);
        }

        // ── Sor kiválasztás ────────────────────────────────────────────

        private void dgvIdopontok_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvIdopontok.SelectedRows.Count == 0)
            {
                PanelAllapot(false);
                return;
            }

            var sor = dgvIdopontok.SelectedRows[0];

            kivalasztottIdopontId = Convert.ToInt32(sor.Cells["colId"].Value);
            eredetiStatusz = sor.Cells["colStatusz"].Value?.ToString() ?? "";

            lblKivalasztottBeteg.Text = sor.Cells["colBeteg"].Value?.ToString() ?? "";
            lblKivalasztottOrvos.Text = sor.Cells["colOrvos"].Value?.ToString() ?? "";
            lblKivalasztottDatum.Text = sor.Cells["colDatum"].Value?.ToString() ?? "";
            lblKivalasztottStatusz.Text = ErederiStatuszSzoveg(eredetiStatusz);
            lblKivalasztottStatusz.ForeColor = StatuszSzin(eredetiStatusz);

            // Radio gombok beállítása
            rbFoglalt.Checked = (eredetiStatusz == "foglalt");
            rbTeljesitett.Checked = (eredetiStatusz == "teljesitett");
            rbLemondott.Checked = (eredetiStatusz == "lemondott");

            lblMentesUzenet.Visible = false;
            lblSzerkHiba.Visible = false;
            PanelAllapot(true);
        }

        // ── Mentés gomb ────────────────────────────────────────────────

        private void btnMentes_Click(object sender, EventArgs e)
        {
            lblSzerkHiba.Visible = false;
            lblMentesUzenet.Visible = false;

            if (kivalasztottIdopontId == -1)
            {
                MutuzHiba("Nincs kiválasztott időpont!"); return;
            }

            string ujStatusz = rbFoglalt.Checked ? "foglalt"
                             : rbTeljesitett.Checked ? "teljesitett"
                             : rbLemondott.Checked ? "lemondott"
                             : "";

            if (string.IsNullOrEmpty(ujStatusz))
            {
                MutuzHiba("Válasszon státuszt!"); return;
            }

            if (ujStatusz == eredetiStatusz)
            {
                MutuzUzenet("A státusz nem változott.", false); return;
            }

            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    var cmd = new MySqlCommand(
                        "UPDATE IDOPONT SET statusz = @statusz WHERE idopont_id = @id",
                        conn);
                    cmd.Parameters.AddWithValue("@statusz", ujStatusz);
                    cmd.Parameters.AddWithValue("@id", kivalasztottIdopontId);
                    cmd.ExecuteNonQuery();
                }

                eredetiStatusz = ujStatusz;

                // Táblázat sor frissítése helyben
                var sor = dgvIdopontok.SelectedRows[0];
                sor.Cells["colStatusz"].Value = ujStatusz;
                SzinezSor(sor, ujStatusz);

                lblKivalasztottStatusz.Text = ErederiStatuszSzoveg(ujStatusz);
                lblKivalasztottStatusz.ForeColor = StatuszSzin(ujStatusz);

                MutuzUzenet($"Státusz sikeresen módosítva: {ErederiStatuszSzoveg(ujStatusz)}", true);
            }
            catch (Exception ex)
            {
                MutuzHiba("Mentési hiba: " + ex.Message);
            }
        }

        // ── Szűrő / keresés gombok ─────────────────────────────────────

        private void btnSzur_Click(object sender, EventArgs e)
        {
            ToltIdopontok();
        }

        private void btnSzuroTorles_Click(object sender, EventArgs e)
        {
            cmbSzuroStatusz.SelectedIndex = 0;
            txtOrvosKereses.Clear();
            txtBetegKereses.Clear();
            ToltIdopontok();
        }

        private void txtKereses_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ToltIdopontok();
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

        // ── Segédmetódusok ─────────────────────────────────────────────

        private void PanelAllapot(bool latszik)
        {
            pnlSzerkeszt.Visible = latszik;
            if (!latszik)
            {
                kivalasztottIdopontId = -1;
                eredetiStatusz = "";
                lblMentesUzenet.Visible = false;
                lblSzerkHiba.Visible = false;
            }
        }

        private void SzinezSor(DataGridViewRow sor, string statusz)
        {
            switch (statusz.ToLower())
            {
                case "teljesitett":
                    sor.DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 218);
                    sor.DefaultCellStyle.ForeColor = Color.FromArgb(21, 87, 36);
                    break;
                case "lemondott":
                    sor.DefaultCellStyle.BackColor = Color.FromArgb(248, 215, 218);
                    sor.DefaultCellStyle.ForeColor = Color.FromArgb(114, 28, 36);
                    break;
                case "foglalt":
                    sor.DefaultCellStyle.BackColor = Color.FromArgb(255, 243, 205);
                    sor.DefaultCellStyle.ForeColor = Color.FromArgb(133, 79, 11);
                    break;
                default:
                    sor.DefaultCellStyle.BackColor = Color.White;
                    sor.DefaultCellStyle.ForeColor = Color.Black;
                    break;
            }
        }

        private Color StatuszSzin(string statusz)
        {
            switch (statusz.ToLower())
            {
                case "teljesitett": return Color.FromArgb(21, 87, 36);
                case "lemondott": return Color.FromArgb(114, 28, 36);
                case "foglalt": return Color.FromArgb(133, 79, 11);
                default: return Color.FromArgb(52, 73, 94);
            }
        }

        private string ErederiStatuszSzoveg(string statusz)
        {
            switch (statusz.ToLower())
            {
                case "foglalt": return "Foglalt";
                case "teljesitett": return "Teljesített";
                case "lemondott": return "Lemondott";
                default: return statusz;
            }
        }

        private void MutuzHiba(string szoveg)
        {
            lblSzerkHiba.Text = szoveg;
            lblSzerkHiba.Visible = true;
        }

        private void MutuzUzenet(string szoveg, bool siker)
        {
            lblMentesUzenet.Text = szoveg;
            lblMentesUzenet.ForeColor = siker
                ? Color.FromArgb(21, 87, 36)
                : Color.FromArgb(133, 79, 11);
            lblMentesUzenet.Visible = true;
        }
    }
}