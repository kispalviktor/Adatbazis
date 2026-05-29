namespace OrvosRendelo
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlFejlec;
        private System.Windows.Forms.Label lblCim;
        private System.Windows.Forms.Label lblAlcim;
        private System.Windows.Forms.Label lblMenuCim;
        private System.Windows.Forms.Button btnNyit;
        private System.Windows.Forms.Button btnUjBeteg;
        private System.Windows.Forms.Button btnOsszesAdat;
        private System.Windows.Forms.Button btnSzerkeszt;
        private System.Windows.Forms.Button btnSzabadIdopont;
        private System.Windows.Forms.Button btnStatusz;

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
            this.lblMenuCim = new System.Windows.Forms.Label();
            this.btnNyit = new System.Windows.Forms.Button();
            this.btnUjBeteg = new System.Windows.Forms.Button();
            this.btnOsszesAdat = new System.Windows.Forms.Button();
            this.btnSzerkeszt = new System.Windows.Forms.Button();
            this.btnSzabadIdopont = new System.Windows.Forms.Button();
            this.btnStatusz = new System.Windows.Forms.Button();

            this.pnlFejlec.SuspendLayout();
            this.SuspendLayout();

            // Fejléc panel
            this.pnlFejlec.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.pnlFejlec.Controls.Add(this.lblCim);
            this.pnlFejlec.Controls.Add(this.lblAlcim);
            this.pnlFejlec.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFejlec.Size = new System.Drawing.Size(460, 110);

            this.lblCim.AutoSize = false;
            this.lblCim.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblCim.ForeColor = System.Drawing.Color.White;
            this.lblCim.Location = new System.Drawing.Point(20, 18);
            this.lblCim.Size = new System.Drawing.Size(420, 42);
            this.lblCim.Text = "Orvosi Rendelő";

            this.lblAlcim.AutoSize = false;
            this.lblAlcim.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAlcim.ForeColor = System.Drawing.Color.FromArgb(200, 230, 255);
            this.lblAlcim.Location = new System.Drawing.Point(22, 62);
            this.lblAlcim.Size = new System.Drawing.Size(420, 24);
            this.lblAlcim.Text = "Időpontkezelő rendszer";

            // Menü felirat
            this.lblMenuCim.AutoSize = false;
            this.lblMenuCim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMenuCim.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblMenuCim.Location = new System.Drawing.Point(30, 126);
            this.lblMenuCim.Size = new System.Drawing.Size(400, 22);
            this.lblMenuCim.Text = "Válasszon műveletet:";

            // 1 – kék
            KeszitGomb(this.btnNyit,
                "Beteg keresése  (TAJ szám)",
                System.Drawing.Color.FromArgb(41, 128, 185),
                30, 156, 400, 46);
            this.btnNyit.Click += new System.EventHandler(this.btnNyit_Click);

            // 2 – zöld
            KeszitGomb(this.btnUjBeteg,
                "Új beteg és időpont felvétele",
                System.Drawing.Color.FromArgb(39, 174, 96),
                30, 210, 400, 46);
            this.btnUjBeteg.Click += new System.EventHandler(this.btnUjBeteg_Click);

            // 3 – lila
            KeszitGomb(this.btnOsszesAdat,
                "Összes adat listázása",
                System.Drawing.Color.FromArgb(142, 68, 173),
                30, 264, 400, 46);
            this.btnOsszesAdat.Click += new System.EventHandler(this.btnOsszesAdat_Click);

            // 4 – narancs
            KeszitGomb(this.btnSzerkeszt,
                "Beteg adatainak szerkesztése",
                System.Drawing.Color.FromArgb(211, 84, 0),
                30, 318, 400, 46);
            this.btnSzerkeszt.Click += new System.EventHandler(this.btnSzerkeszt_Click);

            // 5 – türkiz
            KeszitGomb(this.btnSzabadIdopont,
                "Szabad időpont keresése",
                System.Drawing.Color.FromArgb(22, 160, 133),
                30, 372, 400, 46);
            this.btnSzabadIdopont.Click += new System.EventHandler(this.btnSzabadIdopont_Click);

            // 6 – sötétvörös
            KeszitGomb(this.btnStatusz,
                "Időpont státuszának módosítása",
                System.Drawing.Color.FromArgb(146, 43, 33),
                30, 426, 400, 46);
            this.btnStatusz.Click += new System.EventHandler(this.btnStatusz_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.ClientSize = new System.Drawing.Size(460, 494);
            this.Controls.Add(this.pnlFejlec);
            this.Controls.Add(this.lblMenuCim);
            this.Controls.Add(this.btnNyit);
            this.Controls.Add(this.btnUjBeteg);
            this.Controls.Add(this.btnOsszesAdat);
            this.Controls.Add(this.btnSzerkeszt);
            this.Controls.Add(this.btnSzabadIdopont);
            this.Controls.Add(this.btnStatusz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orvosi Rendelő – Főmenü";

            this.pnlFejlec.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void KeszitGomb(System.Windows.Forms.Button btn, string text,
            System.Drawing.Color bg, int x, int y, int w, int h)
        {
            btn.BackColor = bg;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btn.ForeColor = System.Drawing.Color.White;
            btn.Location = new System.Drawing.Point(x, y);
            btn.Size = new System.Drawing.Size(w, h);
            btn.Text = text;
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
        }
    }
}