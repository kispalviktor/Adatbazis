using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace OrvosRendelo
{
    public partial class Form2 : Form
    {
        // Kapcsolati string – módosítsd a saját AMPPS adataidat szerint
        private readonly string connectionString =
            "Server=localhost;Port=3306;Database=orvosirendelo;Uid=root;Pwd=mysql;CharSet=utf8;";

        public Form2()
        {
            InitializeComponent();
        }

        // Keresés gomb kattintáskor
        private void btnKeres_Click(object sender, EventArgs e)
        {
            string taj = txtTaj.Text.Trim();

            if (string.IsNullOrEmpty(taj))
            {
                MutuzUzenet("Kérjük, adja meg a TAJ számot!", false);
                return;
            }

            if (taj.Length != 9 || !long.TryParse(taj, out _))
            {
                MutuzUzenet("A TAJ szám pontosan 9 számjegyből áll!", false);
                return;
            }

            Kereses(taj);
        }

        private void Kereses(string taj)
        {
            dgvEredmeny.Rows.Clear();
            lblUzenet.Visible = false;

            string sql = @"
                SELECT
                    b.nev            AS beteg_nev,
                    b.taj_szam,
                    o.nev            AS orvos_nev,
                    o.szakterulet,
                    i.idopont_datum,
                    i.statusz,
                    i.megjegyzes
                FROM IDOPONT i
                INNER JOIN BETEG  b ON i.beteg_id  = b.beteg_id
                INNER JOIN ORVOS  o ON i.orvos_id  = o.orvos_id
                WHERE b.taj_szam = @taj
                ORDER BY i.idopont_datum DESC";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@taj", taj);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                MutuzUzenet("Nem található időpont ezzel a TAJ számmal.", false);
                                return;
                            }

                            while (reader.Read())
                            {
                                string statusz = reader["statusz"].ToString();
                                string datum = Convert.ToDateTime(reader["idopont_datum"])
                                                    .ToString("yyyy.MM.dd HH:mm");
                                string megj = reader["megjegyzes"] == DBNull.Value
                                                    ? "—"
                                                    : reader["megjegyzes"].ToString();

                                int rowIdx = dgvEredmeny.Rows.Add(
                                    reader["beteg_nev"].ToString(),
                                    reader["taj_szam"].ToString(),
                                    reader["orvos_nev"].ToString(),
                                    reader["szakterulet"].ToString(),
                                    datum,
                                    statusz,
                                    megj
                                );

                                // Sorok színezése státusz szerint
                                SzinezSor(dgvEredmeny.Rows[rowIdx], statusz);
                            }

                            MutuzUzenet(
                                $"{dgvEredmeny.Rows.Count} időpont találat.",
                                true);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MutuzUzenet("Adatbázis hiba: " + ex.Message, false);
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
            }
        }

        private void MutuzUzenet(string szoveg, bool siker)
        {
            lblUzenet.Text = szoveg;
            lblUzenet.ForeColor = siker
                ? Color.FromArgb(21, 87, 36)
                : Color.FromArgb(114, 28, 36);
            lblUzenet.Visible = true;
        }

        // Enter billentyűre is keres
        private void txtTaj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnKeres_Click(sender, e);
        }

        // Vissza gomb
        private void btnVissza_Click(object sender, EventArgs e)
        {
            this.Close();
            foreach (Form f in Application.OpenForms)
            {
                if (f is Form1)
                {
                    f.Show();
                    break;
                }
            }
        }
    }
}