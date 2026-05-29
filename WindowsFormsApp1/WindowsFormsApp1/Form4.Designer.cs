namespace OrvosRendelo
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;

        // Fejléc
        private System.Windows.Forms.Panel pnlFejlec;
        private System.Windows.Forms.Label lblCim;

        // Eszközsáv
        private System.Windows.Forms.Panel pnlEszkoz;
        private System.Windows.Forms.Button btnFrissit;
        private System.Windows.Forms.Button btnVissza;

        // TabControl
        private System.Windows.Forms.TabControl tabFok;

        // ── Tab 1: Orvosok ──
        private System.Windows.Forms.TabPage tabOrvosok;
        private System.Windows.Forms.Label lblOrvosokDb;
        private System.Windows.Forms.DataGridView dgvOrvosok;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colONev;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOSzak;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOEmail;

        // ── Tab 2: Betegek ──
        private System.Windows.Forms.TabPage tabBetegek;
        private System.Windows.Forms.Label lblBetegekDb;
        private System.Windows.Forms.DataGridView dgvBetegek;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBNev;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBSzul;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBTaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBIdb;

        // ── Tab 3: Időpontok ──
        private System.Windows.Forms.TabPage tabIdopontok;
        private System.Windows.Forms.Label lblSzuroFelirat;
        private System.Windows.Forms.ComboBox cmbSzuro;
        private System.Windows.Forms.Label lblIdopontokDb;
        private System.Windows.Forms.DataGridView dgvIdopontok;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIBeteg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colITaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIOrvos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colISzak;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIStatusz;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIMegj;

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
            this.pnlEszkoz = new System.Windows.Forms.Panel();
            this.btnFrissit = new System.Windows.Forms.Button();
            this.btnVissza = new System.Windows.Forms.Button();
            this.tabFok = new System.Windows.Forms.TabControl();

            // Tab 1
            this.tabOrvosok = new System.Windows.Forms.TabPage();
            this.lblOrvosokDb = new System.Windows.Forms.Label();
            this.dgvOrvosok = new System.Windows.Forms.DataGridView();
            this.colOId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colONev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOSzak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();

            // Tab 2
            this.tabBetegek = new System.Windows.Forms.TabPage();
            this.lblBetegekDb = new System.Windows.Forms.Label();
            this.dgvBetegek = new System.Windows.Forms.DataGridView();
            this.colBId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBNev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBSzul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBTaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBIdb = new System.Windows.Forms.DataGridViewTextBoxColumn();

            // Tab 3
            this.tabIdopontok = new System.Windows.Forms.TabPage();
            this.lblSzuroFelirat = new System.Windows.Forms.Label();
            this.cmbSzuro = new System.Windows.Forms.ComboBox();
            this.lblIdopontokDb = new System.Windows.Forms.Label();
            this.dgvIdopontok = new System.Windows.Forms.DataGridView();
            this.colIId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIBeteg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colITaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIOrvos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colISzak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIStatusz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIMegj = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlFejlec.SuspendLayout();
            this.pnlEszkoz.SuspendLayout();
            this.tabFok.SuspendLayout();
            this.tabOrvosok.SuspendLayout();
            this.tabBetegek.SuspendLayout();
            this.tabIdopontok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrvosok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBetegek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdopontok)).BeginInit();
            this.SuspendLayout();

            // ── pnlFejlec ──────────────────────────────────────────────
            this.pnlFejlec.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.pnlFejlec.Controls.Add(this.lblCim);
            this.pnlFejlec.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFejlec.Size = new System.Drawing.Size(960, 65);

            this.lblCim.AutoSize = false;
            this.lblCim.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblCim.ForeColor = System.Drawing.Color.White;
            this.lblCim.Location = new System.Drawing.Point(16, 16);
            this.lblCim.Size = new System.Drawing.Size(600, 34);
            this.lblCim.Text = "Összes orvos, beteg és időpont";

            // ── pnlEszkoz ──────────────────────────────────────────────
            this.pnlEszkoz.BackColor = System.Drawing.Color.FromArgb(245, 248, 250);
            this.pnlEszkoz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEszkoz.Controls.Add(this.btnFrissit);
            this.pnlEszkoz.Controls.Add(this.btnVissza);
            this.pnlEszkoz.Location = new System.Drawing.Point(0, 65);
            this.pnlEszkoz.Size = new System.Drawing.Size(960, 50);

            KeszitGomb(this.btnFrissit, "Frissítés",
                System.Drawing.Color.FromArgb(41, 128, 185), 16, 8, 120, 32);
            this.btnFrissit.Click += new System.EventHandler(this.btnFrissit_Click);

            KeszitGomb(this.btnVissza, "Vissza a főmenübe",
                System.Drawing.Color.FromArgb(231, 76, 60), 824, 8, 120, 32);
            this.btnVissza.Click += new System.EventHandler(this.btnVissza_Click);

            // ── tabFok ─────────────────────────────────────────────────
            this.tabFok.Controls.Add(this.tabOrvosok);
            this.tabFok.Controls.Add(this.tabBetegek);
            this.tabFok.Controls.Add(this.tabIdopontok);
            this.tabFok.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tabFok.Location = new System.Drawing.Point(0, 115);
            this.tabFok.Size = new System.Drawing.Size(960, 520);
            this.tabFok.ItemSize = new System.Drawing.Size(140, 30);

            // ══════════════════════════════════════════════════════════
            // TAB 1 – Orvosok
            // ══════════════════════════════════════════════════════════
            this.tabOrvosok.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.tabOrvosok.Controls.Add(this.lblOrvosokDb);
            this.tabOrvosok.Controls.Add(this.dgvOrvosok);
            this.tabOrvosok.Location = new System.Drawing.Point(4, 34);
            this.tabOrvosok.Size = new System.Drawing.Size(952, 482);
            this.tabOrvosok.Text = "  Orvosok  ";

            this.lblOrvosokDb.AutoSize = false;
            this.lblOrvosokDb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblOrvosokDb.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblOrvosokDb.Location = new System.Drawing.Point(8, 6);
            this.lblOrvosokDb.Size = new System.Drawing.Size(200, 20);

            BeallitDgv(this.dgvOrvosok, 8, 30, 936, 440);
            this.dgvOrvosok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                OszlopKeszit(this.colOId,    "colOId",    "#",            4),
                OszlopKeszit(this.colONev,   "colONev",   "Név",         22),
                OszlopKeszit(this.colOSzak,  "colOSzak",  "Szakterület", 20),
                OszlopKeszit(this.colOTel,   "colOTel",   "Telefon",     18),
                OszlopKeszit(this.colOEmail, "colOEmail", "E-mail",      36)
            });

            // ══════════════════════════════════════════════════════════
            // TAB 2 – Betegek
            // ══════════════════════════════════════════════════════════
            this.tabBetegek.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.tabBetegek.Controls.Add(this.lblBetegekDb);
            this.tabBetegek.Controls.Add(this.dgvBetegek);
            this.tabBetegek.Location = new System.Drawing.Point(4, 34);
            this.tabBetegek.Size = new System.Drawing.Size(952, 482);
            this.tabBetegek.Text = "  Betegek  ";

            this.lblBetegekDb.AutoSize = false;
            this.lblBetegekDb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblBetegekDb.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblBetegekDb.Location = new System.Drawing.Point(8, 6);
            this.lblBetegekDb.Size = new System.Drawing.Size(200, 20);

            BeallitDgv(this.dgvBetegek, 8, 30, 936, 440);
            this.dgvBetegek.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                OszlopKeszit(this.colBId,    "colBId",    "#",              4),
                OszlopKeszit(this.colBNev,   "colBNev",   "Név",           20),
                OszlopKeszit(this.colBSzul,  "colBSzul",  "Születési dát.",14),
                OszlopKeszit(this.colBTaj,   "colBTaj",   "TAJ szám",      12),
                OszlopKeszit(this.colBTel,   "colBTel",   "Telefon",       14),
                OszlopKeszit(this.colBEmail, "colBEmail", "E-mail",        24),
                OszlopKeszit(this.colBIdb,   "colBIdb",   "Időpontok",     12)
            });

            // ══════════════════════════════════════════════════════════
            // TAB 3 – Időpontok
            // ══════════════════════════════════════════════════════════
            this.tabIdopontok.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.tabIdopontok.Controls.Add(this.lblSzuroFelirat);
            this.tabIdopontok.Controls.Add(this.cmbSzuro);
            this.tabIdopontok.Controls.Add(this.lblIdopontokDb);
            this.tabIdopontok.Controls.Add(this.dgvIdopontok);
            this.tabIdopontok.Location = new System.Drawing.Point(4, 34);
            this.tabIdopontok.Size = new System.Drawing.Size(952, 482);
            this.tabIdopontok.Text = "  Időpontok  ";

            // Szűrő sor
            this.lblSzuroFelirat.AutoSize = false;
            this.lblSzuroFelirat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSzuroFelirat.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblSzuroFelirat.Location = new System.Drawing.Point(8, 7);
            this.lblSzuroFelirat.Size = new System.Drawing.Size(80, 22);
            this.lblSzuroFelirat.Text = "Szűrés:";
            this.lblSzuroFelirat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.cmbSzuro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSzuro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbSzuro.Location = new System.Drawing.Point(92, 5);
            this.cmbSzuro.Size = new System.Drawing.Size(140, 24);
            this.cmbSzuro.Items.AddRange(new object[] { "Mind", "foglalt", "teljesitett", "lemondott" });
            this.cmbSzuro.SelectedIndex = 0;
            this.cmbSzuro.SelectedIndexChanged += new System.EventHandler(this.cmbSzuro_SelectedIndexChanged);

            this.lblIdopontokDb.AutoSize = false;
            this.lblIdopontokDb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblIdopontokDb.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblIdopontokDb.Location = new System.Drawing.Point(248, 7);
            this.lblIdopontokDb.Size = new System.Drawing.Size(200, 20);

            BeallitDgv(this.dgvIdopontok, 8, 32, 936, 438);
            this.dgvIdopontok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                OszlopKeszit(this.colIId,      "colIId",      "#",            3),
                OszlopKeszit(this.colIBeteg,   "colIBeteg",   "Beteg neve",  16),
                OszlopKeszit(this.colITaj,     "colITaj",     "TAJ szám",     9),
                OszlopKeszit(this.colIOrvos,   "colIOrvos",   "Orvos neve",  16),
                OszlopKeszit(this.colISzak,    "colISzak",    "Szakterület", 12),
                OszlopKeszit(this.colIDatum,   "colIDatum",   "Időpont",     12),
                OszlopKeszit(this.colIStatusz, "colIStatusz", "Státusz",      9),
                OszlopKeszit(this.colIMegj,    "colIMegj",    "Megjegyzés",  23)
            });

            // ── Form4 ──────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.ClientSize = new System.Drawing.Size(960, 636);
            this.Controls.Add(this.pnlFejlec);
            this.Controls.Add(this.pnlEszkoz);
            this.Controls.Add(this.tabFok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orvosi Rendelő – Összes adat";

            this.pnlFejlec.ResumeLayout(false);
            this.pnlEszkoz.ResumeLayout(false);
            this.tabFok.ResumeLayout(false);
            this.tabOrvosok.ResumeLayout(false);
            this.tabBetegek.ResumeLayout(false);
            this.tabIdopontok.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrvosok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBetegek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdopontok)).EndInit();
            this.ResumeLayout(false);
        }

        // ── Segédmetódusok ─────────────────────────────────────────────

        private void BeallitDgv(System.Windows.Forms.DataGridView dgv,
            int x, int y, int w, int h)
        {
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = System.Drawing.Color.White;
            dgv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dgv.ColumnHeadersHeight = 34;
            dgv.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(41, 128, 185);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor =
                System.Drawing.Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dgv.DefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI", 9F);
            dgv.EnableHeadersVisualStyles = false;
            dgv.GridColor = System.Drawing.Color.FromArgb(189, 195, 199);
            dgv.Location = new System.Drawing.Point(x, y);
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new System.Drawing.Size(w, h);
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn OszlopKeszit(
            System.Windows.Forms.DataGridViewTextBoxColumn col,
            string name, string header, int fillWeight)
        {
            col.Name = name;
            col.HeaderText = header;
            col.FillWeight = fillWeight;
            return col;
        }

        private void KeszitGomb(System.Windows.Forms.Button btn, string text,
            System.Drawing.Color bg, int x, int y, int w, int h)
        {
            btn.BackColor = bg;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btn.ForeColor = System.Drawing.Color.White;
            btn.Location = new System.Drawing.Point(x, y);
            btn.Size = new System.Drawing.Size(w, h);
            btn.Text = text;
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
        }
    }
}