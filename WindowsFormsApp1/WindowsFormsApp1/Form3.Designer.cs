namespace OrvosRendelo
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        // Fejléc
        private System.Windows.Forms.Panel pnlFejlec;
        private System.Windows.Forms.Label lblCim;

        // Lépésjelző sáv
        private System.Windows.Forms.Panel pnlLepesek;
        private System.Windows.Forms.Label lblLep1Jelzo;
        private System.Windows.Forms.Label lblLep1Szoveg;
        private System.Windows.Forms.Label lblElvalaszto;
        private System.Windows.Forms.Label lblLep2Jelzo;
        private System.Windows.Forms.Label lblLep2Szoveg;

        // ── 1. lépés panel ──
        private System.Windows.Forms.Panel pnlLep1;

        private System.Windows.Forms.Label lblNev;
        private System.Windows.Forms.TextBox txtNev;
        private System.Windows.Forms.Label lblTaj;
        private System.Windows.Forms.TextBox txtTaj;
        private System.Windows.Forms.Label lblSzuletes;
        private System.Windows.Forms.DateTimePicker dtpSzuletes;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblHiba1;
        private System.Windows.Forms.Button btnTovabb;
        private System.Windows.Forms.Button btnVissza1;

        // ── 2. lépés panel ──
        private System.Windows.Forms.Panel pnlLep2;

        private System.Windows.Forms.Label lblOsszefoglalo;
        private System.Windows.Forms.Label lblOrvos;
        private System.Windows.Forms.ComboBox cmbOrvos;
        private System.Windows.Forms.Label lblIdopont;
        private System.Windows.Forms.DateTimePicker dtpIdopont;
        private System.Windows.Forms.Label lblMegjegyzes;
        private System.Windows.Forms.TextBox txtMegjegyzes;
        private System.Windows.Forms.Label lblHiba2;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.Button btnVissza2;

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
            this.pnlLepesek = new System.Windows.Forms.Panel();
            this.lblLep1Jelzo = new System.Windows.Forms.Label();
            this.lblLep1Szoveg = new System.Windows.Forms.Label();
            this.lblElvalaszto = new System.Windows.Forms.Label();
            this.lblLep2Jelzo = new System.Windows.Forms.Label();
            this.lblLep2Szoveg = new System.Windows.Forms.Label();

            this.pnlLep1 = new System.Windows.Forms.Panel();
            this.lblNev = new System.Windows.Forms.Label();
            this.txtNev = new System.Windows.Forms.TextBox();
            this.lblTaj = new System.Windows.Forms.Label();
            this.txtTaj = new System.Windows.Forms.TextBox();
            this.lblSzuletes = new System.Windows.Forms.Label();
            this.dtpSzuletes = new System.Windows.Forms.DateTimePicker();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblHiba1 = new System.Windows.Forms.Label();
            this.btnTovabb = new System.Windows.Forms.Button();
            this.btnVissza1 = new System.Windows.Forms.Button();

            this.pnlLep2 = new System.Windows.Forms.Panel();
            this.lblOsszefoglalo = new System.Windows.Forms.Label();
            this.lblOrvos = new System.Windows.Forms.Label();
            this.cmbOrvos = new System.Windows.Forms.ComboBox();
            this.lblIdopont = new System.Windows.Forms.Label();
            this.dtpIdopont = new System.Windows.Forms.DateTimePicker();
            this.lblMegjegyzes = new System.Windows.Forms.Label();
            this.txtMegjegyzes = new System.Windows.Forms.TextBox();
            this.lblHiba2 = new System.Windows.Forms.Label();
            this.btnMentes = new System.Windows.Forms.Button();
            this.btnVissza2 = new System.Windows.Forms.Button();

            this.pnlFejlec.SuspendLayout();
            this.pnlLepesek.SuspendLayout();
            this.pnlLep1.SuspendLayout();
            this.pnlLep2.SuspendLayout();
            this.SuspendLayout();

            // ── pnlFejlec ──────────────────────────────────────────────
            this.pnlFejlec.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.pnlFejlec.Controls.Add(this.lblCim);
            this.pnlFejlec.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFejlec.Size = new System.Drawing.Size(500, 65);

            this.lblCim.AutoSize = false;
            this.lblCim.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblCim.ForeColor = System.Drawing.Color.White;
            this.lblCim.Location = new System.Drawing.Point(16, 16);
            this.lblCim.Size = new System.Drawing.Size(460, 34);
            this.lblCim.Text = "Új beteg és időpont felvétele";

            // ── pnlLepesek (wizard sáv) ────────────────────────────────
            this.pnlLepesek.BackColor = System.Drawing.Color.FromArgb(31, 97, 141);
            this.pnlLepesek.Location = new System.Drawing.Point(0, 65);
            this.pnlLepesek.Size = new System.Drawing.Size(500, 46);
            this.pnlLepesek.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblLep1Jelzo, this.lblLep1Szoveg,
                this.lblElvalaszto,
                this.lblLep2Jelzo, this.lblLep2Szoveg
            });

            // Kör 1
            this.lblLep1Jelzo.AutoSize = false;
            this.lblLep1Jelzo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblLep1Jelzo.ForeColor = System.Drawing.Color.White;
            this.lblLep1Jelzo.Location = new System.Drawing.Point(60, 12);
            this.lblLep1Jelzo.Size = new System.Drawing.Size(26, 26);
            this.lblLep1Jelzo.Text = "1";
            this.lblLep1Jelzo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLep1Jelzo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblLep1Szoveg.AutoSize = false;
            this.lblLep1Szoveg.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLep1Szoveg.ForeColor = System.Drawing.Color.White;
            this.lblLep1Szoveg.Location = new System.Drawing.Point(90, 14);
            this.lblLep1Szoveg.Size = new System.Drawing.Size(120, 22);
            this.lblLep1Szoveg.Text = "Beteg adatai";

            // Elválasztó
            this.lblElvalaszto.AutoSize = false;
            this.lblElvalaszto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblElvalaszto.ForeColor = System.Drawing.Color.FromArgb(155, 188, 220);
            this.lblElvalaszto.Location = new System.Drawing.Point(218, 14);
            this.lblElvalaszto.Size = new System.Drawing.Size(30, 22);
            this.lblElvalaszto.Text = "──";
            this.lblElvalaszto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Kör 2
            this.lblLep2Jelzo.AutoSize = false;
            this.lblLep2Jelzo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblLep2Jelzo.ForeColor = System.Drawing.Color.FromArgb(155, 188, 220);
            this.lblLep2Jelzo.Location = new System.Drawing.Point(256, 12);
            this.lblLep2Jelzo.Size = new System.Drawing.Size(26, 26);
            this.lblLep2Jelzo.Text = "2";
            this.lblLep2Jelzo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLep2Jelzo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblLep2Szoveg.AutoSize = false;
            this.lblLep2Szoveg.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLep2Szoveg.ForeColor = System.Drawing.Color.FromArgb(155, 188, 220);
            this.lblLep2Szoveg.Location = new System.Drawing.Point(286, 14);
            this.lblLep2Szoveg.Size = new System.Drawing.Size(120, 22);
            this.lblLep2Szoveg.Text = "Időpont adatai";

            // ── pnlLep1 ────────────────────────────────────────────────
            this.pnlLep1.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.pnlLep1.Location = new System.Drawing.Point(0, 111);
            this.pnlLep1.Size = new System.Drawing.Size(500, 390);
            this.pnlLep1.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblNev, this.txtNev,
                this.lblTaj, this.txtTaj,
                this.lblSzuletes, this.dtpSzuletes,
                this.lblTelefon, this.txtTelefon,
                this.lblEmail, this.txtEmail,
                this.lblHiba1,
                this.btnTovabb, this.btnVissza1
            });

            int lx = 30;   // label X
            int fx = 180;  // field X
            int fw = 270;  // field width
            int lw = 140;  // label width
            int lh = 28;
            int fh = 28;

            // Sor 1 – Név
            SetLabel(this.lblNev, "Teljes név: *", lx, 26, lw, lh);
            SetText(this.txtNev, fx, 24, fw, fh);

            // Sor 2 – TAJ
            SetLabel(this.lblTaj, "TAJ szám: *", lx, 72, lw, lh);
            SetText(this.txtTaj, fx, 70, fw, fh);
            this.txtTaj.MaxLength = 9;

            // Sor 3 – Születés
            SetLabel(this.lblSzuletes, "Születési dátum:", lx, 118, lw, lh);
            this.dtpSzuletes.Location = new System.Drawing.Point(fx, 116);
            this.dtpSzuletes.Size = new System.Drawing.Size(fw, fh);
            this.dtpSzuletes.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSzuletes.Value = System.DateTime.Today.AddYears(-30);
            this.dtpSzuletes.Font = new System.Drawing.Font("Segoe UI", 10F);

            // Sor 4 – Telefon
            SetLabel(this.lblTelefon, "Telefonszám:", lx, 164, lw, lh);
            SetText(this.txtTelefon, fx, 162, fw, fh);

            // Sor 5 – Email
            SetLabel(this.lblEmail, "E-mail cím:", lx, 210, lw, lh);
            SetText(this.txtEmail, fx, 208, fw, fh);

            // Hiba label
            this.lblHiba1.AutoSize = false;
            this.lblHiba1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblHiba1.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.lblHiba1.Location = new System.Drawing.Point(lx, 256);
            this.lblHiba1.Size = new System.Drawing.Size(440, 22);
            this.lblHiba1.Visible = false;

            // Gombok
            SetBtn(this.btnTovabb, "Tovább →", System.Drawing.Color.FromArgb(39, 174, 96), 330, 310, 120, 38);
            SetBtn(this.btnVissza1, "Vissza", System.Drawing.Color.FromArgb(231, 76, 60), 30, 310, 100, 38);
            this.btnTovabb.Click += new System.EventHandler(this.btnTovabb_Click);
            this.btnVissza1.Click += new System.EventHandler(this.btnVissza1_Click);

            // ── pnlLep2 ────────────────────────────────────────────────
            this.pnlLep2.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.pnlLep2.Location = new System.Drawing.Point(0, 111);
            this.pnlLep2.Size = new System.Drawing.Size(500, 390);
            this.pnlLep2.Visible = false;
            this.pnlLep2.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblOsszefoglalo,
                this.lblOrvos, this.cmbOrvos,
                this.lblIdopont, this.dtpIdopont,
                this.lblMegjegyzes, this.txtMegjegyzes,
                this.lblHiba2,
                this.btnMentes, this.btnVissza2
            });

            // Összefoglaló sáv
            this.lblOsszefoglalo.AutoSize = false;
            this.lblOsszefoglalo.BackColor = System.Drawing.Color.FromArgb(212, 230, 241);
            this.lblOsszefoglalo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblOsszefoglalo.ForeColor = System.Drawing.Color.FromArgb(31, 97, 141);
            this.lblOsszefoglalo.Location = new System.Drawing.Point(0, 0);
            this.lblOsszefoglalo.Size = new System.Drawing.Size(500, 34);
            this.lblOsszefoglalo.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblOsszefoglalo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // Orvos
            SetLabel(this.lblOrvos, "Orvos: *", lx, 60, lw, lh);
            this.cmbOrvos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrvos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbOrvos.Location = new System.Drawing.Point(fx, 58);
            this.cmbOrvos.Size = new System.Drawing.Size(fw, fh);

            // Időpont
            SetLabel(this.lblIdopont, "Időpont: *", lx, 108, lw, lh);
            this.dtpIdopont.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIdopont.CustomFormat = "yyyy.MM.dd HH:mm";
            this.dtpIdopont.ShowUpDown = true;
            this.dtpIdopont.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpIdopont.Location = new System.Drawing.Point(fx, 106);
            this.dtpIdopont.Size = new System.Drawing.Size(fw, fh);
            this.dtpIdopont.Value = System.DateTime.Now.AddDays(1);

            // Megjegyzés
            SetLabel(this.lblMegjegyzes, "Megjegyzés:", lx, 156, lw, lh);
            this.txtMegjegyzes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMegjegyzes.Location = new System.Drawing.Point(fx, 154);
            this.txtMegjegyzes.Multiline = true;
            this.txtMegjegyzes.Size = new System.Drawing.Size(fw, 80);

            // Hiba label
            this.lblHiba2.AutoSize = false;
            this.lblHiba2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblHiba2.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.lblHiba2.Location = new System.Drawing.Point(lx, 248);
            this.lblHiba2.Size = new System.Drawing.Size(440, 22);
            this.lblHiba2.Visible = false;

            // Gombok
            SetBtn(this.btnMentes, "Mentés", System.Drawing.Color.FromArgb(39, 174, 96), 330, 310, 120, 38);
            SetBtn(this.btnVissza2, "← Vissza", System.Drawing.Color.FromArgb(41, 128, 185), 30, 310, 120, 38);
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            this.btnVissza2.Click += new System.EventHandler(this.btnVissza2_Click);

            // ── Form3 ──────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.ClientSize = new System.Drawing.Size(500, 502);
            this.Controls.Add(this.pnlFejlec);
            this.Controls.Add(this.pnlLepesek);
            this.Controls.Add(this.pnlLep1);
            this.Controls.Add(this.pnlLep2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orvosi Rendelő – Új beteg felvétele";

            this.pnlFejlec.ResumeLayout(false);
            this.pnlLepesek.ResumeLayout(false);
            this.pnlLep1.ResumeLayout(false);
            this.pnlLep1.PerformLayout();
            this.pnlLep2.ResumeLayout(false);
            this.pnlLep2.PerformLayout();
            this.ResumeLayout(false);
        }

        // ── Segéd: egységes label / textbox / gomb beállítás ──────────

        private void SetLabel(System.Windows.Forms.Label lbl, string text, int x, int y, int w, int h)
        {
            lbl.AutoSize = false;
            lbl.Font = new System.Drawing.Font("Segoe UI", 10F);
            lbl.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lbl.Location = new System.Drawing.Point(x, y + 2);
            lbl.Size = new System.Drawing.Size(w, h);
            lbl.Text = text;
            lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        }

        private void SetText(System.Windows.Forms.TextBox tb, int x, int y, int w, int h)
        {
            tb.Font = new System.Drawing.Font("Segoe UI", 10F);
            tb.Location = new System.Drawing.Point(x, y);
            tb.Size = new System.Drawing.Size(w, h);
        }

        private void SetBtn(System.Windows.Forms.Button btn, string text,
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