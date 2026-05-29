using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OrvosRendelo
{
    public partial class Form5 : Form
    {
        private readonly string connectionString =
            "Server=localhost;Port=3306;Database=orvosirendelo;Uid=root;Pwd=mysql;CharSet=utf8;";

        private int betaltBetegId = -1;

        public Form5()
        {
            InitializeComponent();
            PanelAllapot(false);
        }

        // ── Keresés TAJ szám alapján ───────────────────────────────────

        private void btnKeres_Click(object sender, EventArgs e)
        {
            string taj = txtKeresTaj.Text.Trim();
            lblKereresHiba.Visible = false;

            if (taj.Length != 9 || !long.TryParse(taj, out _))
            {
                MutuzKereresHiba("A TAJ szám pontosan 9 számjegyből áll!");
                return;
            }

            BetegBetoltes(taj);
        }

        private void BetegBetoltes(string taj)
        {
            string sql = @"
                SELECT beteg_id, nev, szuletesi_datum, taj_szam, telefonszam, email
                FROM BETEG
                WHERE taj_szam = @taj";

            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@taj", taj);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MutuzKereresHiba("Nem található beteg ezzel a TAJ számmal.");
                                PanelAllapot(false);
                                return;
                            }

                            betaltBetegId = Convert.ToInt32(reader["beteg_id"]);

                            // Mezők feltöltése
                            txtNev.Text = reader["nev"].ToString();
                            txtTaj.Text = reader["taj_szam"].ToString();
                            txtTelefon.Text = reader["telefonszam"] == DBNull.Value
                                ? "" : reader["telefonszam"].ToString();
                            txtEmail.Text = reader["email"] == DBNull.Value
                                ? "" : reader["email"].ToString();

                            string szul = reader["szuletesi_datum"] == DBNull.Value
                                ? ""
                                : Convert.ToDateTime(reader["szuletesi_datum"]).ToString("yyyy.MM.dd");

                            lblSzulErtek.Text = szul == "" ? "—" : szul;
                            lblIdErtek.Text = betaltBetegId.ToString();

                            // Eredeti értékek mentése az összehasonlításhoz
                            txtNev.Tag = txtNev.Text;
                            txtTaj.Tag = txtTaj.Text;
                            txtTelefon.Tag = txtTelefon.Text;
                            txtEmail.Tag = txtEmail.Text;

                            PanelAllapot(true);
                            lblMentesUzenet.Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MutuzKereresHiba("Adatbázis hiba: " + ex.Message);
            }
        }

        // ── Mentés gomb ────────────────────────────────────────────────

        private void btnMentes_Click(object sender, EventArgs e)
        {
            lblSzerkHiba.Visible = false;
            lblMentesUzenet.Visible = false;

            string ujNev = txtNev.Text.Trim();
            string ujTaj = txtTaj.Text.Trim();
            string ujTel = txtTelefon.Text.Trim();
            string ujEmail = txtEmail.Text.Trim();

            // Validáció
            if (string.IsNullOrEmpty(ujNev))
            {
                MutuzSzerkHiba("A beteg neve nem lehet üres!"); return;
            }
            if (ujTaj.Length != 9 || !long.TryParse(ujTaj, out _))
            {
                MutuzSzerkHiba("A TAJ szám pontosan 9 számjegyből áll!"); return;
            }

            // TAJ duplikáció ellenőrzés (csak ha változott)
            if (ujTaj != txtTaj.Tag?.ToString())
            {
                if (TajMasBetagnel(ujTaj, betaltBetegId))
                {
                    MutuzSzerkHiba("Ez a TAJ szám már egy másik beteghez tartozik!"); return;
                }
            }

            // Nincs változás?
            if (ujNev == txtNev.Tag?.ToString() &&
                ujTaj == txtTaj.Tag?.ToString() &&
                ujTel == txtTelefon.Tag?.ToString() &&
                ujEmail == txtEmail.Tag?.ToString())
            {
                MutuzMentesUzenet("Nem történt változás az adatokban.", false);
                return;
            }

            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    var cmd = new MySqlCommand(@"
                        UPDATE BETEG
                        SET nev         = @nev,
                            taj_szam    = @taj,
                            telefonszam = @tel,
                            email       = @email
                        WHERE beteg_id  = @id", conn);

                    cmd.Parameters.AddWithValue("@nev", ujNev);
                    cmd.Parameters.AddWithValue("@taj", ujTaj);
                    cmd.Parameters.AddWithValue("@tel", string.IsNullOrEmpty(ujTel) ? (object)DBNull.Value : ujTel);
                    cmd.Parameters.AddWithValue("@email", string.IsNullOrEmpty(ujEmail) ? (object)DBNull.Value : ujEmail);
                    cmd.Parameters.AddWithValue("@id", betaltBetegId);

                    cmd.ExecuteNonQuery();
                }

                // Tag-ek frissítése az új értékekre
                txtNev.Tag = ujNev;
                txtTaj.Tag = ujTaj;
                txtTelefon.Tag = ujTel;
                txtEmail.Tag = ujEmail;

                // Keresőmező frissítése ha TAJ változott
                txtKeresTaj.Text = ujTaj;

                MutuzMentesUzenet("Az adatok sikeresen mentve!", true);
                ValtozzottJelzes(false);
            }
            catch (Exception ex)
            {
                MutuzSzerkHiba("Mentési hiba: " + ex.Message);
            }
        }

        // ── Visszaállítás (mégse) gomb ─────────────────────────────────

        private void btnVisszaAllit_Click(object sender, EventArgs e)
        {
            txtNev.Text = txtNev.Tag?.ToString() ?? "";
            txtTaj.Text = txtTaj.Tag?.ToString() ?? "";
            txtTelefon.Text = txtTelefon.Tag?.ToString() ?? "";
            txtEmail.Text = txtEmail.Tag?.ToString() ?? "";
            lblSzerkHiba.Visible = false;
            lblMentesUzenet.Visible = false;
            ValtozzottJelzes(false);
        }

        // ── Változás jelzés (sárga keret) ─────────────────────────────

        private void Mezo_TextChanged(object sender, EventArgs e)
        {
            if (betaltBetegId == -1) return;
            bool valtozott =
                txtNev.Text != txtNev.Tag?.ToString() ||
                txtTaj.Text != txtTaj.Tag?.ToString() ||
                txtTelefon.Text != txtTelefon.Tag?.ToString() ||
                txtEmail.Text != txtEmail.Tag?.ToString();

            ValtozzottJelzes(valtozott);
        }

        private void ValtozzottJelzes(bool valtozott)
        {
            var szin = valtozott
                ? Color.FromArgb(230, 126, 34)
                : Color.FromArgb(189, 195, 199);

            txtNev.BackColor = valtozott && txtNev.Text != txtNev.Tag?.ToString() ? Color.FromArgb(254, 249, 231) : Color.White;
            txtTaj.BackColor = valtozott && txtTaj.Text != txtTaj.Tag?.ToString() ? Color.FromArgb(254, 249, 231) : Color.White;
            txtTelefon.BackColor = valtozott && txtTelefon.Text != txtTelefon.Tag?.ToString() ? Color.FromArgb(254, 249, 231) : Color.White;
            txtEmail.BackColor = valtozott && txtEmail.Text != txtEmail.Tag?.ToString() ? Color.FromArgb(254, 249, 231) : Color.White;

            btnMentes.BackColor = valtozott
                ? Color.FromArgb(39, 174, 96)
                : Color.FromArgb(150, 180, 150);
            btnVisszaAllit.Enabled = valtozott;
        }

        // ── TAJ duplikáció ellenőrzés ──────────────────────────────────

        private bool TajMasBetagnel(string taj, int sajatId)
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    var cmd = new MySqlCommand(
                        "SELECT COUNT(*) FROM BETEG WHERE taj_szam = @taj AND beteg_id <> @id", conn);
                    cmd.Parameters.AddWithValue("@taj", taj);
                    cmd.Parameters.AddWithValue("@id", sajatId);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
            catch { return false; }
        }

        // ── Panel láthatóság ───────────────────────────────────────────

        private void PanelAllapot(bool latszik)
        {
            pnlSzerkeszt.Visible = latszik;
            if (!latszik) betaltBetegId = -1;
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

        // ── Enter a keresőmezőben ──────────────────────────────────────

        private void txtKeresTaj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnKeres_Click(sender, e);
        }

        // ── Segédmetódusok ─────────────────────────────────────────────

        private void MutuzKereresHiba(string szoveg)
        {
            lblKereresHiba.Text = szoveg;
            lblKereresHiba.Visible = true;
        }

        private void MutuzSzerkHiba(string szoveg)
        {
            lblSzerkHiba.Text = szoveg;
            lblSzerkHiba.Visible = true;
        }

        private void MutuzMentesUzenet(string szoveg, bool siker)
        {
            lblMentesUzenet.Text = szoveg;
            lblMentesUzenet.ForeColor = siker
                ? Color.FromArgb(21, 87, 36)
                : Color.FromArgb(133, 79, 11);
            lblMentesUzenet.Visible = true;
        }
    }
}