namespace OrvosRendelo
{
    partial class Form7
    {
        private System.ComponentModel.IContainer components = null;

        // Fejléc
        private System.Windows.Forms.Panel pnlFejlec;
        private System.Windows.Forms.Label lblCim;
        private System.Windows.Forms.Label lblAlcim;

        // Szűrősáv
        private System.Windows.Forms.Panel pnlSzuro;
        private System.Windows.Forms.Label lblSzuroStatusz;
        private System.Windows.Forms.ComboBox cmbSzuroStatusz;
        private System.Windows.Forms.Label lblOrvosKereses;
        private System.Windows.Forms.TextBox txtOrvosKereses;
        private System.Windows.Forms.Label lblBetegKereses;
        private System.Windows.Forms.TextBox txtBetegKereses;
        private System.Windows.Forms.Button btnSzur;
        private System.Windows.Forms.Button btnSzuroTorles;
        private System.Windows.Forms.Button btnVissza;
        private System.Windows.Forms.Label lblTalalatok;

        // Időpont táblázat
        private System.Windows.Forms.DataGridView dgvIdopontok;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBeteg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrvos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSzak;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatusz;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMegj;

        // Szerkesztő panel (jobb oldal)
        private System.Windows.Forms.Panel pnlSzerkeszt;

        private System.Windows.Forms.Label lblSzerkCim;

        private System.Windows.Forms.Label lblBetegCimke;
        private System.Windows.Forms.Label lblKivalasztottBeteg;
        private System.Windows.Forms.Label lblOrvosCimke;
        private System.Windows.Forms.Label lblKivalasztottOrvos;
        private System.Windows.Forms.Label lblDatumCimke;
        private System.Windows.Forms.Label lblKivalasztottDatum;
        private System.Windows.Forms.Label lblJelenlegiCimke;
        private System.Windows.Forms.Label lblKivalasztottStatusz;

        private System.Windows.Forms.Label lblUjStatuszCimke;
        private System.Windows.Forms.Panel pnlRadiok;
        private System.Windows.Forms.RadioButton rbFoglalt;
        private System.Windows.Forms.RadioButton rbTeljesitett;
        private System.Windows.Forms.RadioButton rbLemondott;

        private System.Windows.Forms.Label lblSzerkHiba;
        private System.Windows.Forms.Label lblMentesUzenet;
        private System.Windows.Forms.Button btnMentes;

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

            this.pnlSzuro = new System.Windows.Forms.Panel();
            this.lblSzuroStatusz = new System.Windows.Forms.Label();
            this.cmbSzuroStatusz = new System.Windows.Forms.ComboBox();
            this.lblOrvosKereses = new System.Windows.Forms.Label();
            this.txtOrvosKereses = new System.Windows.Forms.TextBox();
            this.lblBetegKereses = new System.Windows.Forms.Label();
            this.txtBetegKereses = new System.Windows.Forms.TextBox();
            this.btnSzur = new System.Windows.Forms.Button();
            this.btnSzuroTorles = new System.Windows.Forms.Button();
            this.btnVissza = new System.Windows.Forms.Button();
            this.lblTalalatok = new System.Windows.Forms.Label();

            this.dgvIdopontok = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBeteg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrvos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSzak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatusz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMegj = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlSzerkeszt = new System.Windows.Forms.Panel();
            this.lblSzerkCim = new System.Windows.Forms.Label();
            this.lblBetegCimke = new System.Windows.Forms.Label();
            this.lblKivalasztottBeteg = new System.Windows.Forms.Label();
            this.lblOrvosCimke = new System.Windows.Forms.Label();
            this.lblKivalasztottOrvos = new System.Windows.Forms.Label();
            this.lblDatumCimke = new System.Windows.Forms.Label();
            this.lblKivalasztottDatum = new System.Windows.Forms.Label();
            this.lblJelenlegiCimke = new System.Windows.Forms.Label();
            this.lblKivalasztottStatusz = new System.Windows.Forms.Label();
            this.lblUjStatuszCimke = new System.Windows.Forms.Label();
            this.pnlRadiok = new System.Windows.Forms.Panel();
            this.rbFoglalt = new System.Windows.Forms.RadioButton();
            this.rbTeljesitett = new System.Windows.Forms.RadioButton();
            this.rbLemondott = new System.Windows.Forms.RadioButton();
            this.lblSzerkHiba = new System.Windows.Forms.Label();
            this.lblMentesUzenet = new System.Windows.Forms.Label();
            this.btnMentes = new System.Windows.Forms.Button();

            this.pnlFejlec.SuspendLayout();
            this.pnlSzuro.SuspendLayout();
            this.pnlSzerkeszt.SuspendLayout();
            this.pnlRadiok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdopontok)).BeginInit();
            this.SuspendLayout();

            // ── pnlFejlec ──────────────────────────────────────────────
            this.pnlFejlec.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.pnlFejlec.Controls.Add(this.lblCim);
            this.pnlFejlec.Controls.Add(this.lblAlcim);
            this.pnlFejlec.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFejlec.Size = new System.Drawing.Size(1100, 78);

            this.lblCim.AutoSize = false;
            this.lblCim.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblCim.ForeColor = System.Drawing.Color.White;
            this.lblCim.Location = new System.Drawing.Point(16, 12);
            this.lblCim.Size = new System.Drawing.Size(600, 34);
            this.lblCim.Text = "Időpont státuszának módosítása";

            this.lblAlcim.AutoSize = false;
            this.lblAlcim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAlcim.ForeColor = System.Drawing.Color.FromArgb(200, 230, 255);
            this.lblAlcim.Location = new System.Drawing.Point(18, 50);
            this.lblAlcim.Size = new System.Drawing.Size(700, 20);
            this.lblAlcim.Text = "Kattintson egy időpontra a listában, majd válassza ki az új státuszt a jobb oldali panelen";

            // ── pnlSzuro ───────────────────────────────────────────────
            this.pnlSzuro.BackColor = System.Drawing.Color.FromArgb(245, 248, 250);
            this.pnlSzuro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSzuro.Controls.Add(this.lblSzuroStatusz);
            this.pnlSzuro.Controls.Add(this.cmbSzuroStatusz);
            this.pnlSzuro.Controls.Add(this.lblOrvosKereses);
            this.pnlSzuro.Controls.Add(this.txtOrvosKereses);
            this.pnlSzuro.Controls.Add(this.lblBetegKereses);
            this.pnlSzuro.Controls.Add(this.txtBetegKereses);
            this.pnlSzuro.Controls.Add(this.btnSzur);
            this.pnlSzuro.Controls.Add(this.btnSzuroTorles);
            this.pnlSzuro.Controls.Add(this.btnVissza);
            this.pnlSzuro.Controls.Add(this.lblTalalatok);
            this.pnlSzuro.Location = new System.Drawing.Point(0, 78);
            this.pnlSzuro.Size = new System.Drawing.Size(1100, 56);

            SzuroLabel(this.lblSzuroStatusz, "Státusz:", 12, 16, 62);
            this.cmbSzuroStatusz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSzuroStatusz.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbSzuroStatusz.Location = new System.Drawing.Point(78, 14);
            this.cmbSzuroStatusz.Size = new System.Drawing.Size(120, 26);
            this.cmbSzuroStatusz.Items.AddRange(new object[] { "Mind", "foglalt", "teljesitett", "lemondott" });
            this.cmbSzuroStatusz.SelectedIndex = 0;

            SzuroLabel(this.lblOrvosKereses, "Orvos:", 216, 16, 52);
            this.txtOrvosKereses.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOrvosKereses.Location = new System.Drawing.Point(272, 13);
            this.txtOrvosKereses.Size = new System.Drawing.Size(160, 26);
            this.txtOrvosKereses.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKereses_KeyDown);

            SzuroLabel(this.lblBetegKereses, "Beteg:", 446, 16, 50);
            this.txtBetegKereses.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBetegKereses.Location = new System.Drawing.Point(500, 13);
            this.txtBetegKereses.Size = new System.Drawing.Size(160, 26);
            this.txtBetegKereses.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKereses_KeyDown);

            KeszitGomb(this.btnSzur, "Szűrés",
                System.Drawing.Color.FromArgb(41, 128, 185), 674, 12, 90, 30);
            this.btnSzur.Click += new System.EventHandler(this.btnSzur_Click);

            KeszitGomb(this.btnSzuroTorles, "Törlés",
                System.Drawing.Color.FromArgb(149, 165, 166), 772, 12, 80, 30);
            this.btnSzuroTorles.Click += new System.EventHandler(this.btnSzuroTorles_Click);

            KeszitGomb(this.btnVissza, "Vissza",
                System.Drawing.Color.FromArgb(231, 76, 60), 998, 12, 90, 30);
            this.btnVissza.Click += new System.EventHandler(this.btnVissza_Click);

            this.lblTalalatok.AutoSize = false;
            this.lblTalalatok.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblTalalatok.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblTalalatok.Location = new System.Drawing.Point(862, 18);
            this.lblTalalatok.Size = new System.Drawing.Size(120, 18);
            this.lblTalalatok.Visible = false;

            // ── dgvIdopontok ───────────────────────────────────────────
            this.dgvIdopontok.AllowUserToAddRows = false;
            this.dgvIdopontok.AllowUserToDeleteRows = false;
            this.dgvIdopontok.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIdopontok.BackgroundColor = System.Drawing.Color.White;
            this.dgvIdopontok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvIdopontok.ColumnHeadersHeight = 32;
            this.dgvIdopontok.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvIdopontok.ColumnHeadersDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(41, 128, 185);
            this.dgvIdopontok.ColumnHeadersDefaultCellStyle.ForeColor =
                System.Drawing.Color.White;
            this.dgvIdopontok.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvIdopontok.DefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI", 9F);
            this.dgvIdopontok.EnableHeadersVisualStyles = false;
            this.dgvIdopontok.GridColor = System.Drawing.Color.FromArgb(189, 195, 199);
            this.dgvIdopontok.Location = new System.Drawing.Point(0, 134);
            this.dgvIdopontok.MultiSelect = false;
            this.dgvIdopontok.ReadOnly = true;
            this.dgvIdopontok.RowHeadersVisible = false;
            this.dgvIdopontok.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIdopontok.Size = new System.Drawing.Size(780, 530);
            this.dgvIdopontok.SelectionChanged +=
                new System.EventHandler(this.dgvIdopontok_SelectionChanged);

            // Oszlopok
            OszlopKeszit(this.colId, "colId", "#", 3);
            OszlopKeszit(this.colBeteg, "colBeteg", "Beteg neve", 17);
            OszlopKeszit(this.colTaj, "colTaj", "TAJ szám", 11);
            OszlopKeszit(this.colOrvos, "colOrvos", "Orvos neve", 17);
            OszlopKeszit(this.colSzak, "colSzak", "Szakterület", 13);
            OszlopKeszit(this.colDatum, "colDatum", "Időpont", 14);
            OszlopKeszit(this.colStatusz, "colStatusz", "Státusz", 10);
            OszlopKeszit(this.colMegj, "colMegj", "Megjegyzés", 15);

            this.dgvIdopontok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                this.colId, this.colBeteg, this.colTaj, this.colOrvos,
                this.colSzak, this.colDatum, this.colStatusz, this.colMegj
            });

            // ── pnlSzerkeszt (jobb oldali panel) ──────────────────────
            this.pnlSzerkeszt.BackColor = System.Drawing.Color.FromArgb(245, 248, 250);
            this.pnlSzerkeszt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSzerkeszt.Location = new System.Drawing.Point(790, 134);
            this.pnlSzerkeszt.Size = new System.Drawing.Size(306, 530);
            this.pnlSzerkeszt.Visible = false;
            this.pnlSzerkeszt.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                this.lblSzerkCim,
                this.lblBetegCimke,    this.lblKivalasztottBeteg,
                this.lblOrvosCimke,    this.lblKivalasztottOrvos,
                this.lblDatumCimke,    this.lblKivalasztottDatum,
                this.lblJelenlegiCimke, this.lblKivalasztottStatusz,
                this.lblUjStatuszCimke,
                this.pnlRadiok,
                this.lblSzerkHiba,
                this.lblMentesUzenet,
                this.btnMentes
            });

            // Szerkesztő panel – fejléc csík
            this.lblSzerkCim.AutoSize = false;
            this.lblSzerkCim.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.lblSzerkCim.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSzerkCim.ForeColor = System.Drawing.Color.White;
            this.lblSzerkCim.Location = new System.Drawing.Point(0, 0);
            this.lblSzerkCim.Size = new System.Drawing.Size(306, 34);
            this.lblSzerkCim.Text = "  Kiválasztott időpont";
            this.lblSzerkCim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSzerkCim.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);

            // Info sorok
            int cx = 14;
            int cy = 46;
            int cr = 14;
            int cw = 278;

            InfoCimke(this.lblBetegCimke, "Beteg:", cx, cy, cr);
            InfoErtek(this.lblKivalasztottBeteg, cx, cy + 18, cw);

            InfoCimke(this.lblOrvosCimke, "Orvos:", cx, cy + 54, cr);
            InfoErtek(this.lblKivalasztottOrvos, cx, cy + 72, cw);

            InfoCimke(this.lblDatumCimke, "Időpont:", cx, cy + 108, cr);
            InfoErtek(this.lblKivalasztottDatum, cx, cy + 126, cw);

            // Jelenlegi státusz
            this.lblJelenlegiCimke.AutoSize = false;
            this.lblJelenlegiCimke.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblJelenlegiCimke.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblJelenlegiCimke.Location = new System.Drawing.Point(cx, cy + 162);
            this.lblJelenlegiCimke.Size = new System.Drawing.Size(cw, 18);
            this.lblJelenlegiCimke.Text = "Jelenlegi státusz:";

            this.lblKivalasztottStatusz.AutoSize = false;
            this.lblKivalasztottStatusz.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblKivalasztottStatusz.Location = new System.Drawing.Point(cx, cy + 180);
            this.lblKivalasztottStatusz.Size = new System.Drawing.Size(cw, 30);

            // Elválasztó vonal helyett panel
            var pnlVonal = new System.Windows.Forms.Panel();
            pnlVonal.BackColor = System.Drawing.Color.FromArgb(189, 195, 199);
            pnlVonal.Location = new System.Drawing.Point(cx, cy + 218);
            pnlVonal.Size = new System.Drawing.Size(cw, 1);
            this.pnlSzerkeszt.Controls.Add(pnlVonal);

            // Új státusz felirat
            this.lblUjStatuszCimke.AutoSize = false;
            this.lblUjStatuszCimke.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUjStatuszCimke.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblUjStatuszCimke.Location = new System.Drawing.Point(cx, cy + 228);
            this.lblUjStatuszCimke.Size = new System.Drawing.Size(cw, 24);
            this.lblUjStatuszCimke.Text = "Új státusz kiválasztása:";

            // Radio gombok panel
            this.pnlRadiok.BackColor = System.Drawing.Color.Transparent;
            this.pnlRadiok.Location = new System.Drawing.Point(cx, cy + 258);
            this.pnlRadiok.Size = new System.Drawing.Size(cw, 116);
            this.pnlRadiok.Controls.Add(this.rbFoglalt);
            this.pnlRadiok.Controls.Add(this.rbTeljesitett);
            this.pnlRadiok.Controls.Add(this.rbLemondott);

            RadioKeszit(this.rbFoglalt,
                "Foglalt",
                System.Drawing.Color.FromArgb(133, 79, 11),
                0, 0);

            RadioKeszit(this.rbTeljesitett,
                "Teljesített",
                System.Drawing.Color.FromArgb(21, 87, 36),
                0, 38);

            RadioKeszit(this.rbLemondott,
                "Lemondott",
                System.Drawing.Color.FromArgb(114, 28, 36),
                0, 76);

            // Hiba és siker üzenetek
            this.lblSzerkHiba.AutoSize = false;
            this.lblSzerkHiba.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblSzerkHiba.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.lblSzerkHiba.Location = new System.Drawing.Point(cx, cy + 388);
            this.lblSzerkHiba.Size = new System.Drawing.Size(cw, 18);
            this.lblSzerkHiba.Visible = false;

            this.lblMentesUzenet.AutoSize = false;
            this.lblMentesUzenet.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblMentesUzenet.Location = new System.Drawing.Point(cx, cy + 408);
            this.lblMentesUzenet.Size = new System.Drawing.Size(cw, 36);
            this.lblMentesUzenet.Visible = false;

            // Mentés gomb
            KeszitGomb(this.btnMentes, "Státusz mentése",
                System.Drawing.Color.FromArgb(39, 174, 96),
                cx, cy + 450, cw, 44);
            this.btnMentes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);

            // ── Form7 ──────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.ClientSize = new System.Drawing.Size(1100, 666);
            this.Controls.Add(this.pnlFejlec);
            this.Controls.Add(this.pnlSzuro);
            this.Controls.Add(this.dgvIdopontok);
            this.Controls.Add(this.pnlSzerkeszt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orvosi Rendelő – Státusz módosítás";

            this.pnlFejlec.ResumeLayout(false);
            this.pnlSzuro.ResumeLayout(false);
            this.pnlSzuro.PerformLayout();
            this.pnlSzerkeszt.ResumeLayout(false);
            this.pnlRadiok.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdopontok)).EndInit();
            this.ResumeLayout(false);
        }

        // ── Segédmetódusok ─────────────────────────────────────────────

        private void OszlopKeszit(System.Windows.Forms.DataGridViewTextBoxColumn col,
            string name, string header, int fillWeight)
        {
            col.Name = name;
            col.HeaderText = header;
            col.FillWeight = fillWeight;
        }

        private void SzuroLabel(System.Windows.Forms.Label lbl,
            string text, int x, int y, int w)
        {
            lbl.AutoSize = false;
            lbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            lbl.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lbl.Location = new System.Drawing.Point(x, y + 2);
            lbl.Size = new System.Drawing.Size(w, 22);
            lbl.Text = text;
            lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        }

        private void InfoCimke(System.Windows.Forms.Label lbl,
            string text, int x, int y, int indent)
        {
            lbl.AutoSize = false;
            lbl.Font = new System.Drawing.Font("Segoe UI", 8F);
            lbl.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            lbl.Location = new System.Drawing.Point(x + indent, y);
            lbl.Size = new System.Drawing.Size(260, 16);
            lbl.Text = text;
        }

        private void InfoErtek(System.Windows.Forms.Label lbl,
            int x, int y, int w)
        {
            lbl.AutoSize = false;
            lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lbl.ForeColor = System.Drawing.Color.FromArgb(31, 97, 141);
            lbl.Location = new System.Drawing.Point(x, y);
            lbl.Size = new System.Drawing.Size(w, 26);
        }

        private void RadioKeszit(System.Windows.Forms.RadioButton rb,
            string text, System.Drawing.Color szin, int x, int y)
        {
            rb.AutoSize = false;
            rb.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            rb.ForeColor = szin;
            rb.Location = new System.Drawing.Point(x, y);
            rb.Size = new System.Drawing.Size(260, 32);
            rb.Text = text;
            rb.Cursor = System.Windows.Forms.Cursors.Hand;
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