using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OrvosRendelo
{
    public partial class Form3 : Form
    {
        private readonly string connectionString =
            "Server=localhost;Port=3306;Database=orvosirendelo;Uid=root;Pwd=mysql;CharSet=utf8;";

        // Az 1. lépésben mentett beteg adatok
        private string ujBetegNev;
        private string ujBetegTaj;
        private string ujBetegSzulDatum;
        private string ujBetegTelefon;
        private string ujBetegEmail;

        public Form3()
        {
            InitializeComponent();
            MutasLepest(1);
            ToltOrvosok();
        }

        // ── Lépés váltás ───────────────────────────────────────────────

        private void MutasLepest(int lepesszam)
        {
            pnlLep1.Visible = (lepesszam == 1);
            pnlLep2.Visible = (lepesszam == 2);

            lblLep1Jelzo.ForeColor = lepesszam == 1
                ? Color.White
                : Color.FromArgb(155, 188, 220);
            lblLep2Jelzo.ForeColor = lepesszam == 2
                ? Color.White
                : Color.FromArgb(155, 188, 220);

            lblLep1Szoveg.ForeColor = lepesszam == 1
                ? Color.White
                : Color.FromArgb(155, 188, 220);
            lblLep2Szoveg.ForeColor = lepesszam == 2
                ? Color.White
                : Color.FromArgb(155, 188, 220);
        }

        // ── 1. lépés: Beteg adatok – Tovább gomb ──────────────────────

        private void btnTovabb_Click(object sender, EventArgs e)
        {
            lblHiba1.Visible = false;

            string nev = txtNev.Text.Trim();
            string taj = txtTaj.Text.Trim();
            string szul = dtpSzuletes.Value.ToString("yyyy-MM-dd");
            string tel = txtTelefon.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(nev))
            {
                MutuzHiba1("A beteg neve kötelező!"); return;
            }
            if (taj.Length != 9 || !long.TryParse(taj, out _))
            {
                MutuzHiba1("A TAJ szám pontosan 9 számjegyből áll!"); return;
            }
            if (TajLetezik(taj))
            {
                MutuzHiba1("Ez a TAJ szám már szerepel az adatbázisban!"); return;
            }

            // Adatok eltárolása
            ujBetegNev = nev;
            ujBetegTaj = taj;
            ujBetegSzulDatum = szul;
            ujBetegTelefon = tel;
            ujBetegEmail = email;

            // Összefoglaló a 2. lépés tetején
            lblOsszefoglalo.Text =
                $"Beteg: {nev}   |   TAJ: {taj}   |   Születés: {szul}";

            MutasLepest(2);
        }

        private bool TajLetezik(string taj)
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    var cmd = new MySqlCommand(
                        "SELECT COUNT(*) FROM BETEG WHERE taj_szam = @taj", conn);
                    cmd.Parameters.AddWithValue("@taj", taj);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
            catch { return false; }
        }

        // ── 2. lépés: Időpont – orvos ComboBox töltése ────────────────

        private void ToltOrvosok()
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    var cmd = new MySqlCommand(
                        "SELECT orvos_id, CONCAT(nev, ' – ', szakterulet) AS megj FROM ORVOS ORDER BY nev",
                        conn);
                    using (var reader = cmd.ExecuteReader())
                    {
                        cmbOrvos.Items.Clear();
                        while (reader.Read())
                        {
                            cmbOrvos.Items.Add(new ComboItem(
                                reader["megj"].ToString(),
                                Convert.ToInt32(reader["orvos_id"])
                            ));
                        }
                    }
                }
                if (cmbOrvos.Items.Count > 0)
                    cmbOrvos.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MutuzHiba2("Orvosok betöltése sikertelen: " + ex.Message);
            }
        }

        // ── 2. lépés: Mentés gomb ──────────────────────────────────────

        private void btnMentes_Click(object sender, EventArgs e)
        {
            lblHiba2.Visible = false;

            if (cmbOrvos.SelectedItem == null)
            {
                MutuzHiba2("Válasszon orvost!"); return;
            }

            int orvosId = ((ComboItem)cmbOrvos.SelectedItem).Id;
            string datum = dtpIdopont.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string megjegy = txtMegjegyzes.Text.Trim();

            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (var trx = conn.BeginTransaction())
                    {
                        // 1. Beteg INSERT
                        var cmdBeteg = new MySqlCommand(@"
                            INSERT INTO BETEG (nev, szuletesi_datum, taj_szam, telefonszam, email)
                            VALUES (@nev, @szul, @taj, @tel, @email);
                            SELECT LAST_INSERT_ID();", conn, trx);

                        cmdBeteg.Parameters.AddWithValue("@nev", ujBetegNev);
                        cmdBeteg.Parameters.AddWithValue("@szul", ujBetegSzulDatum);
                        cmdBeteg.Parameters.AddWithValue("@taj", ujBetegTaj);
                        cmdBeteg.Parameters.AddWithValue("@tel", ujBetegTelefon);
                        cmdBeteg.Parameters.AddWithValue("@email", ujBetegEmail);

                        int ujBetegId = Convert.ToInt32(cmdBeteg.ExecuteScalar());

                        // 2. Időpont INSERT
                        var cmdIdopont = new MySqlCommand(@"
                            INSERT INTO IDOPONT (orvos_id, beteg_id, idopont_datum, statusz, megjegyzes)
                            VALUES (@orvos, @beteg, @datum, 'foglalt', @megj)", conn, trx);

                        cmdIdopont.Parameters.AddWithValue("@orvos", orvosId);
                        cmdIdopont.Parameters.AddWithValue("@beteg", ujBetegId);
                        cmdIdopont.Parameters.AddWithValue("@datum", datum);
                        cmdIdopont.Parameters.AddWithValue("@megj",
                            string.IsNullOrEmpty(megjegy) ? (object)DBNull.Value : megjegy);

                        cmdIdopont.ExecuteNonQuery();
                        trx.Commit();
                    }
                }

                MessageBox.Show(
                    $"Sikeresen mentve!\n\nBeteg: {ujBetegNev}\nIdőpont: {dtpIdopont.Value:yyyy.MM.dd HH:mm}",
                    "Mentés sikeres",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Visszaallitas();
            }
            catch (Exception ex)
            {
                MutuzHiba2("Mentési hiba: " + ex.Message);
            }
        }

        // ── Vissza az 1. lépésre ───────────────────────────────────────

        private void btnVissza2_Click(object sender, EventArgs e)
        {
            lblHiba2.Visible = false;
            MutasLepest(1);
        }

        // ── Főmenüre vissza ────────────────────────────────────────────

        private void btnVissza1_Click(object sender, EventArgs e)
        {
            this.Close();
            foreach (Form f in Application.OpenForms)
            {
                if (f is Form1) { f.Show(); break; }
            }
        }

        // ── Segéd metódusok ────────────────────────────────────────────

        private void Visszaallitas()
        {
            txtNev.Clear();
            txtTaj.Clear();
            txtTelefon.Clear();
            txtEmail.Clear();
            dtpSzuletes.Value = DateTime.Today.AddYears(-30);
            txtMegjegyzes.Clear();
            if (cmbOrvos.Items.Count > 0) cmbOrvos.SelectedIndex = 0;
            dtpIdopont.Value = DateTime.Now.AddDays(1);
            lblHiba1.Visible = false;
            lblHiba2.Visible = false;
            MutasLepest(1);
        }

        private void MutuzHiba1(string szoveg)
        {
            lblHiba1.Text = szoveg;
            lblHiba1.Visible = true;
        }

        private void MutuzHiba2(string szoveg)
        {
            lblHiba2.Text = szoveg;
            lblHiba2.Visible = true;
        }
    }

    // ComboBox segédosztály: szöveg + ID együtt tárolva
    public class ComboItem
    {
        public string Szoveg { get; set; }
        public int Id { get; set; }

        public ComboItem(string szoveg, int id)
        {
            Szoveg = szoveg;
            Id = id;
        }

        public override string ToString() => Szoveg;
    }
}