using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OrvosRendelo
{
    public partial class Form4 : Form
    {
        private readonly string connectionString =
            "Server=localhost;Port=3306;Database=orvosirendelo;Uid=root;Pwd=mysql;CharSet=utf8;";

        public Form4()
        {
            InitializeComponent();
            ToltOrvosok();
            ToltBetegek();
            ToltIdopontok();
        }

        // ── Orvosok betöltése ──────────────────────────────────────────

        private void ToltOrvosok()
        {
            dgvOrvosok.Rows.Clear();
            string sql = "SELECT orvos_id, nev, szakterulet, telefonszam, email FROM ORVOS ORDER BY nev";

            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvOrvosok.Rows.Add(
                                reader["orvos_id"].ToString(),
                                reader["nev"].ToString(),
                                reader["szakterulet"].ToString(),
                                reader["telefonszam"].ToString(),
                                reader["email"].ToString()
                            );
                        }
                    }
                }
                lblOrvosokDb.Text = $"{dgvOrvosok.Rows.Count} orvos";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba az orvosok betöltésekor:\n" + ex.Message,
                    "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Betegek betöltése ──────────────────────────────────────────

        private void ToltBetegek()
        {
            dgvBetegek.Rows.Clear();
            string sql = @"
                SELECT
                    b.beteg_id,
                    b.nev,
                    b.szuletesi_datum,
                    b.taj_szam,
                    b.telefonszam,
                    b.email,
                    COUNT(i.idopont_id) AS idopontok_szama
                FROM BETEG b
                LEFT JOIN IDOPONT i ON b.beteg_id = i.beteg_id
                GROUP BY b.beteg_id
                ORDER BY b.nev";

            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string szul = reader["szuletesi_datum"] == DBNull.Value
                                ? "—"
                                : Convert.ToDateTime(reader["szuletesi_datum"]).ToString("yyyy.MM.dd");

                            dgvBetegek.Rows.Add(
                                reader["beteg_id"].ToString(),
                                reader["nev"].ToString(),
                                szul,
                                reader["taj_szam"].ToString(),
                                reader["telefonszam"].ToString(),
                                reader["email"].ToString(),
                                reader["idopontok_szama"].ToString()
                            );
                        }
                    }
                }
                lblBetegekDb.Text = $"{dgvBetegek.Rows.Count} beteg";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba a betegek betöltésekor:\n" + ex.Message,
                    "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Időpontok betöltése ────────────────────────────────────────

        private void ToltIdopontok()
        {
            dgvIdopontok.Rows.Clear();
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
                ORDER BY i.idopont_datum DESC";

            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string datum = Convert.ToDateTime(reader["idopont_datum"]).ToString("yyyy.MM.dd HH:mm");
                            string statusz = reader["statusz"].ToString();
                            string megj = reader["megjegyzes"] == DBNull.Value ? "—" : reader["megjegyzes"].ToString();

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

                            SzinezIdopontSor(dgvIdopontok.Rows[rowIdx], statusz);
                        }
                    }
                }
                lblIdopontokDb.Text = $"{dgvIdopontok.Rows.Count} időpont";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba az időpontok betöltésekor:\n" + ex.Message,
                    "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Sor színezés státusz szerint ──────────────────────────────

        private void SzinezIdopontSor(DataGridViewRow sor, string statusz)
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
            }
        }

        // ── Frissítés gomb ─────────────────────────────────────────────

        private void btnFrissit_Click(object sender, EventArgs e)
        {
            ToltOrvosok();
            ToltBetegek();
            ToltIdopontok();
        }

        // ── Szűrő – Időpontok tab ──────────────────────────────────────

        private void cmbSzuro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string szuro = cmbSzuro.SelectedItem?.ToString() ?? "Mind";

            foreach (DataGridViewRow sor in dgvIdopontok.Rows)
            {
                if (szuro == "Mind")
                {
                    sor.Visible = true;
                }
                else
                {
                    string statusz = sor.Cells["colIStatusz"].Value?.ToString() ?? "";
                    sor.Visible = string.Equals(statusz, szuro, StringComparison.OrdinalIgnoreCase);
                }
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
    }
}