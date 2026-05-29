namespace OrvosRendelo
{
    partial class Form5
    {
        private System.ComponentModel.IContainer components = null;

        // Fejléc
        private System.Windows.Forms.Panel pnlFejlec;
        private System.Windows.Forms.Label lblCim;
        private System.Windows.Forms.Label lblAlcim;

        // Keresősáv
        private System.Windows.Forms.Panel pnlKereses;
        private System.Windows.Forms.Label lblKeresTaj;
        private System.Windows.Forms.TextBox txtKeresTaj;
        private System.Windows.Forms.Button btnKeres;
        private System.Windows.Forms.Button btnVissza;
        private System.Windows.Forms.Label lblKereresHiba;

        // Szerkesztő panel
        private System.Windows.Forms.Panel pnlSzerkeszt;

        // Csak olvasható infó sor
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblIdCimke;
        private System.Windows.Forms.Label lblIdErtek;
        private System.Windows.Forms.Label lblSzulCimke;
        private System.Windows.Forms.Label lblSzulErtek;

        // Szerkeszthető mezők
        private System.Windows.Forms.Label lblNev;
        private System.Windows.Forms.TextBox txtNev;
        private System.Windows.Forms.Label lblTaj;
        private System.Windows.Forms.TextBox txtTaj;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;

        private System.Windows.Forms.Label lblSzerkHiba;
        private System.Windows.Forms.Label lblMentesUzenet;

        // Gombok a szerkesztő alján
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.Button btnVisszaAllit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlFejlec = new System.Windows.Forms.Panel();
            this.lblCim = new System.Windows.Forms.Label();
            this.lblAlcim = new System.Windows.Forms.Label();

            this.pnlKereses = new System.Windows.Forms.Panel();
            this.lblKeresTaj = new System.Windows.Forms.Label();
            this.txtKeresTaj = new System.Windows.Forms.TextBox();
            this.btnKeres = new System.Windows.Forms.Button();
            this.btnVissza = new System.Windows.Forms.Button();
            this.lblKereresHiba = new System.Windows.Forms.Label();

            this.pnlSzerkeszt = new System.Windows.Forms.Panel();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblIdCimke = new System.Windows.Forms.Label();
            this.lblIdErtek = new System.Windows.Forms.Label();
            this.lblSzulCimke = new System.Windows.Forms.Label();
            this.lblSzulErtek = new System.Windows.Forms.Label();

            this.lblNev = new System.Windows.Forms.Label();
            this.txtNev = new System.Windows.Forms.TextBox();
            this.lblTaj = new System.Windows.Forms.Label();
            this.txtTaj = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();

            this.lblSzerkHiba = new System.Windows.Forms.Label();
            this.lblMentesUzenet = new System.Windows.Forms.Label();
            this.btnMentes = new System.Windows.Forms.Button();
            this.btnVisszaAllit = new System.Windows.Forms.Button();

            this.pnlFejlec.SuspendLayout();
            this.pnlKereses.SuspendLayout();
            this.pnlSzerkeszt.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();

            // ── pnlFejlec ──────────────────────────────────────────────
            this.pnlFejlec.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.pnlFejlec.Controls.Add(this.lblCim);
            this.pnlFejlec.Controls.Add(this.lblAlcim);
            this.pnlFejlec.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFejlec.Size = new System.Drawing.Size(520, 80);

            this.lblCim.AutoSize = false;
            this.lblCim.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblCim.ForeColor = System.Drawing.Color.White;
            this.lblCim.Location = new System.Drawing.Point(16, 12);
            this.lblCim.Size = new System.Drawing.Size(488, 34);
            this.lblCim.Text = "Beteg adatainak szerkesztése";

            this.lblAlcim.AutoSize = false;
            this.lblAlcim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAlcim.ForeColor = System.Drawing.Color.FromArgb(200, 230, 255);
            this.lblAlcim.Location = new System.Drawing.Point(18, 50);
            this.lblAlcim.Size = new System.Drawing.Size(488, 20);
            this.lblAlcim.Text = "Keresse meg a beteget TAJ szám alapján, majd szerkessze az adatokat";

            // ── pnlKereses ─────────────────────────────────────────────
            this.pnlKereses.BackColor = System.Drawing.Color.FromArgb(245, 248, 250);
            this.pnlKereses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKereses.Controls.Add(this.lblKeresTaj);
            this.pnlKereses.Controls.Add(this.txtKeresTaj);
            this.pnlKereses.Controls.Add(this.btnKeres);
            this.pnlKereses.Controls.Add(this.btnVissza);
            this.pnlKereses.Controls.Add(this.lblKereresHiba);
            this.pnlKereses.Location = new System.Drawing.Point(0, 80);
            this.pnlKereses.Size = new System.Drawing.Size(520, 70);

            this.lblKeresTaj.AutoSize = false;
            this.lblKeresTaj.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblKeresTaj.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblKeresTaj.Location = new System.Drawing.Point(14, 10);
            this.lblKeresTaj.Size = new System.Drawing.Size(90, 26);
            this.lblKeresTaj.Text = "TAJ szám:";
            this.lblKeresTaj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.txtKeresTaj.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtKeresTaj.Location = new System.Drawing.Point(110, 8);
            this.txtKeresTaj.MaxLength = 9;
            this.txtKeresTaj.Size = new System.Drawing.Size(150, 28);
            this.txtKeresTaj.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKeresTaj_KeyDown);

            KeszitGomb(this.btnKeres, "Keresés",
                System.Drawing.Color.FromArgb(41, 128, 185), 272, 7, 100, 32);
            this.btnKeres.Click += new System.EventHandler(this.btnKeres_Click);

            KeszitGomb(this.btnVissza, "Vissza",
                System.Drawing.Color.FromArgb(231, 76, 60), 402, 7, 100, 32);
            this.btnVissza.Click += new System.EventHandler(this.btnVissza_Click);

            this.lblKereresHiba.AutoSize = false;
            this.lblKereresHiba.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblKereresHiba.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.lblKereresHiba.Location = new System.Drawing.Point(14, 46);
            this.lblKereresHiba.Size = new System.Drawing.Size(490, 18);
            this.lblKereresHiba.Visible = false;

            // ── pnlSzerkeszt ───────────────────────────────────────────
            this.pnlSzerkeszt.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.pnlSzerkeszt.Location = new System.Drawing.Point(0, 150);
            this.pnlSzerkeszt.Size = new System.Drawing.Size(520, 380);
            this.pnlSzerkeszt.Visible = false;
            this.pnlSzerkeszt.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.pnlInfo,
                this.lblNev,    this.txtNev,
                this.lblTaj,    this.txtTaj,
                this.lblTelefon, this.txtTelefon,
                this.lblEmail,  this.txtEmail,
                this.lblSzerkHiba,
                this.lblMentesUzenet,
                this.btnMentes, this.btnVisszaAllit
            });

            // ── pnlInfo (csak olvasható sáv) ───────────────────────────
            this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(212, 230, 241);
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Size = new System.Drawing.Size(520, 36);
            this.pnlInfo.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblIdCimke, this.lblIdErtek,
                this.lblSzulCimke, this.lblSzulErtek
            });

            InfoLabel(this.lblIdCimke, "Beteg ID:", 14, 10, 72, 20);
            InfoLabel(this.lblIdErtek, "—", 90, 10, 60, 20, true);
            InfoLabel(this.lblSzulCimke, "Születési dátum:", 180, 10, 130, 20);
            InfoLabel(this.lblSzulErtek, "—", 316, 10, 110, 20, true);

            // ── Szerkeszthető mezők ────────────────────────────────────
            int lx = 20;
            int fx = 180;
            int fw = 300;
            int lw = 150;

            MezoSor(this.lblNev, "Teljes név: *", lx, 56, lw, fx, fw);
            MezoSor(this.lblTaj, "TAJ szám: *", lx, 102, lw, fx, fw);
            MezoSor(this.lblTelefon, "Telefonszám:", lx, 148, lw, fx, fw);
            MezoSor(this.lblEmail, "E-mail cím:", lx, 194, lw, fx, fw);

            this.txtTaj.MaxLength = 9;

            // TextChanged események – változásjelzés
            this.txtNev.TextChanged += new System.EventHandler(this.Mezo_TextChanged);
            this.txtTaj.TextChanged += new System.EventHandler(this.Mezo_TextChanged);
            this.txtTelefon.TextChanged += new System.EventHandler(this.Mezo_TextChanged);
            this.txtEmail.TextChanged += new System.EventHandler(this.Mezo_TextChanged);

            // Hibacímkék
            this.lblSzerkHiba.AutoSize = false;
            this.lblSzerkHiba.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblSzerkHiba.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.lblSzerkHiba.Location = new System.Drawing.Point(lx, 244);
            this.lblSzerkHiba.Size = new System.Drawing.Size(480, 18);
            this.lblSzerkHiba.Visible = false;

            this.lblMentesUzenet.AutoSize = false;
            this.lblMentesUzenet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMentesUzenet.Location = new System.Drawing.Point(lx, 268);
            this.lblMentesUzenet.Size = new System.Drawing.Size(480, 22);
            this.lblMentesUzenet.Visible = false;

            // Gombok
            KeszitGomb(this.btnMentes, "Mentés",
                System.Drawing.Color.FromArgb(150, 180, 150), 350, 306, 130, 40);
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);

            KeszitGomb(this.btnVisszaAllit, "Mégse",
                System.Drawing.Color.FromArgb(149, 165, 166), lx, 306, 130, 40);
            this.btnVisszaAllit.Enabled = false;
            this.btnVisszaAllit.Click += new System.EventHandler(this.btnVisszaAllit_Click);

            // ── Form5 ──────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.ClientSize = new System.Drawing.Size(520, 530);
            this.Controls.Add(this.pnlFejlec);
            this.Controls.Add(this.pnlKereses);
            this.Controls.Add(this.pnlSzerkeszt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orvosi Rendelő – Beteg szerkesztése";

            this.pnlFejlec.ResumeLayout(false);
            this.pnlKereses.ResumeLayout(false);
            this.pnlKereses.PerformLayout();
            this.pnlSzerkeszt.ResumeLayout(false);
            this.pnlSzerkeszt.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        // ── Segédmetódusok ─────────────────────────────────────────────

        private void MezoSor(System.Windows.Forms.Label lbl, string szoveg,
            int lx, int y, int lw,
            int fx, int fw)
        {
            lbl.AutoSize = false;
            lbl.Font = new System.Drawing.Font("Segoe UI", 10F);
            lbl.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lbl.Location = new System.Drawing.Point(lx, y + 3);
            lbl.Size = new System.Drawing.Size(lw, 26);
            lbl.Text = szoveg;
            lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            System.Windows.Forms.TextBox tb = null;
            if (lbl == lblNev) tb = txtNev;
            else if (lbl == lblTaj) tb = txtTaj;
            else if (lbl == lblTelefon) tb = txtTelefon;
            else if (lbl == lblEmail) tb = txtEmail;

            if (tb != null)
            {
                tb.Font = new System.Drawing.Font("Segoe UI", 10F);
                tb.Location = new System.Drawing.Point(fx, y);
                tb.Size = new System.Drawing.Size(fw, 30);
            }
        }

        private void InfoLabel(System.Windows.Forms.Label lbl, string text,
            int x, int y, int w, int h, bool bold = false)
        {
            lbl.AutoSize = false;
            lbl.Font = new System.Drawing.Font("Segoe UI", 9F,
                bold ? System.Drawing.FontStyle.Bold : System.Drawing.FontStyle.Regular);
            lbl.ForeColor = System.Drawing.Color.FromArgb(31, 97, 141);
            lbl.Location = new System.Drawing.Point(x, y);
            lbl.Size = new System.Drawing.Size(w, h);
            lbl.Text = text;
        }

        private void KeszitGomb(System.Windows.Forms.Button btn, string text,
            System.Drawing.Color bg, int x, int y, int w, int h)
        {
            btn.BackColor = bg;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btn.ForeColor = System.Drawing.Color.White;
            btn.Location = new System.Drawing.Point(x, y);
            btn.Size = new System.Drawing.Size(w, h);
            btn.Text = text;
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
        }
    }
}