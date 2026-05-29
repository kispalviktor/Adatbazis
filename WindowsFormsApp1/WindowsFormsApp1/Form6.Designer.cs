namespace OrvosRendelo
{
    partial class Form6
    {
        private System.ComponentModel.IContainer components = null;

        // Fejléc
        private System.Windows.Forms.Panel pnlFejlec;
        private System.Windows.Forms.Label lblCim;
        private System.Windows.Forms.Label lblAlcim;

        // Szűrősáv
        private System.Windows.Forms.Panel pnlSzuro;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label lblOrvos;
        private System.Windows.Forms.ComboBox cmbOrvos;
        private System.Windows.Forms.Button btnKeres;
        private System.Windows.Forms.Button btnVissza;

        // Infó sáv
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblInfoIdo;
        private System.Windows.Forms.Label lblInfoSlot;
        private System.Windows.Forms.Label lblInfoDupla;

        // Eredmény
        private System.Windows.Forms.Label lblAllapot;
        private System.Windows.Forms.DataGridView dgvEredmeny;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrvos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAllapot;

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
            this.lblDatum = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.lblOrvos = new System.Windows.Forms.Label();
            this.cmbOrvos = new System.Windows.Forms.ComboBox();
            this.btnKeres = new System.Windows.Forms.Button();
            this.btnVissza = new System.Windows.Forms.Button();

            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblInfoIdo = new System.Windows.Forms.Label();
            this.lblInfoSlot = new System.Windows.Forms.Label();
            this.lblInfoDupla = new System.Windows.Forms.Label();

            this.lblAllapot = new System.Windows.Forms.Label();
            this.dgvEredmeny = new System.Windows.Forms.DataGridView();
            this.colOrvos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAllapot = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlFejlec.SuspendLayout();
            this.pnlSzuro.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEredmeny)).BeginInit();
            this.SuspendLayout();

            // ── pnlFejlec ──────────────────────────────────────────────
            this.pnlFejlec.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.pnlFejlec.Controls.Add(this.lblCim);
            this.pnlFejlec.Controls.Add(this.lblAlcim);
            this.pnlFejlec.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFejlec.Size = new System.Drawing.Size(860, 80);

            this.lblCim.AutoSize = false;
            this.lblCim.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblCim.ForeColor = System.Drawing.Color.White;
            this.lblCim.Location = new System.Drawing.Point(16, 12);
            this.lblCim.Size = new System.Drawing.Size(600, 34);
            this.lblCim.Text = "Szabad időpont keresése";

            this.lblAlcim.AutoSize = false;
            this.lblAlcim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAlcim.ForeColor = System.Drawing.Color.FromArgb(200, 230, 255);
            this.lblAlcim.Location = new System.Drawing.Point(18, 50);
            this.lblAlcim.Size = new System.Drawing.Size(700, 20);
            this.lblAlcim.Text = "Rendelési idő: 08:00 – 16:00  |  Slot: 30 perc  |  Dupla kattintással foglalás indítható";

            // ── pnlSzuro ───────────────────────────────────────────────
            this.pnlSzuro.BackColor = System.Drawing.Color.FromArgb(245, 248, 250);
            this.pnlSzuro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSzuro.Controls.Add(this.lblDatum);
            this.pnlSzuro.Controls.Add(this.dtpDatum);
            this.pnlSzuro.Controls.Add(this.lblOrvos);
            this.pnlSzuro.Controls.Add(this.cmbOrvos);
            this.pnlSzuro.Controls.Add(this.btnKeres);
            this.pnlSzuro.Controls.Add(this.btnVissza);
            this.pnlSzuro.Location = new System.Drawing.Point(0, 80);
            this.pnlSzuro.Size = new System.Drawing.Size(860, 58);

            // Dátum
            SzuroLabel(this.lblDatum, "Dátum:", 14, 15, 60);
            this.dtpDatum.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(80, 13);
            this.dtpDatum.Size = new System.Drawing.Size(130, 28);
            this.dtpDatum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpDatum_KeyDown);

            // Orvos
            SzuroLabel(this.lblOrvos, "Orvos:", 228, 15, 56);
            this.cmbOrvos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrvos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbOrvos.Location = new System.Drawing.Point(290, 12);
            this.cmbOrvos.Size = new System.Drawing.Size(300, 28);

            // Gombok
            KeszitGomb(this.btnKeres, "Keresés",
                System.Drawing.Color.FromArgb(41, 128, 185), 606, 12, 110, 32);
            this.btnKeres.Click += new System.EventHandler(this.btnKeres_Click);

            KeszitGomb(this.btnVissza, "Vissza",
                System.Drawing.Color.FromArgb(231, 76, 60), 728, 12, 110, 32);
            this.btnVissza.Click += new System.EventHandler(this.btnVissza_Click);

            // ── pnlInfo ────────────────────────────────────────────────
            this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(232, 244, 253);
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfo.Controls.Add(this.lblInfoIdo);
            this.pnlInfo.Controls.Add(this.lblInfoSlot);
            this.pnlInfo.Controls.Add(this.lblInfoDupla);
            this.pnlInfo.Location = new System.Drawing.Point(12, 148);
            this.pnlInfo.Size = new System.Drawing.Size(836, 30);

            InfoLabel(this.lblInfoIdo, "Rendelési idő: 08:00 – 16:00", 12, 7);
            InfoLabel(this.lblInfoSlot, "Slot hossza: 30 perc", 240, 7);
            InfoLabel(this.lblInfoDupla, "Dupla kattintás = foglalás indítása", 420, 7);

            // ── lblAllapot ─────────────────────────────────────────────
            this.lblAllapot.AutoSize = false;
            this.lblAllapot.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAllapot.Location = new System.Drawing.Point(12, 186);
            this.lblAllapot.Size = new System.Drawing.Size(836, 22);
            this.lblAllapot.Visible = false;

            // ── dgvEredmeny ────────────────────────────────────────────
            this.dgvEredmeny.AllowUserToAddRows = false;
            this.dgvEredmeny.AllowUserToDeleteRows = false;
            this.dgvEredmeny.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEredmeny.BackgroundColor = System.Drawing.Color.White;
            this.dgvEredmeny.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvEredmeny.ColumnHeadersHeight = 34;
            this.dgvEredmeny.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEredmeny.ColumnHeadersDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(41, 128, 185);
            this.dgvEredmeny.ColumnHeadersDefaultCellStyle.ForeColor =
                System.Drawing.Color.White;
            this.dgvEredmeny.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvEredmeny.DefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI", 9F);
            this.dgvEredmeny.EnableHeadersVisualStyles = false;
            this.dgvEredmeny.GridColor = System.Drawing.Color.FromArgb(189, 195, 199);
            this.dgvEredmeny.Location = new System.Drawing.Point(12, 212);
            this.dgvEredmeny.ReadOnly = true;
            this.dgvEredmeny.RowHeadersVisible = false;
            this.dgvEredmeny.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEredmeny.Size = new System.Drawing.Size(836, 390);
            this.dgvEredmeny.CellDoubleClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEredmeny_CellDoubleClick);

            // Oszlopok
            this.colOrvos.Name = "colOrvos";
            this.colOrvos.HeaderText = "Orvos neve – szakterület";
            this.colOrvos.FillWeight = 38;

            this.colIdo.Name = "colIdo";
            this.colIdo.HeaderText = "Szabad időpont";
            this.colIdo.FillWeight = 26;

            this.colNap.Name = "colNap";
            this.colNap.HeaderText = "Nap";
            this.colNap.FillWeight = 18;

            this.colAllapot.Name = "colAllapot";
            this.colAllapot.HeaderText = "Állapot";
            this.colAllapot.FillWeight = 18;

            this.dgvEredmeny.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                this.colOrvos, this.colIdo, this.colNap, this.colAllapot
            });

            // ── Form6 ──────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.ClientSize = new System.Drawing.Size(860, 616);
            this.Controls.Add(this.pnlFejlec);
            this.Controls.Add(this.pnlSzuro);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.lblAllapot);
            this.Controls.Add(this.dgvEredmeny);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orvosi Rendelő – Szabad időpontok";

            this.pnlFejlec.ResumeLayout(false);
            this.pnlSzuro.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEredmeny)).EndInit();
            this.ResumeLayout(false);
        }

        // ── Segédmetódusok ─────────────────────────────────────────────

        private void SzuroLabel(System.Windows.Forms.Label lbl,
            string text, int x, int y, int w)
        {
            lbl.AutoSize = false;
            lbl.Font = new System.Drawing.Font("Segoe UI", 10F);
            lbl.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lbl.Location = new System.Drawing.Point(x, y + 2);
            lbl.Size = new System.Drawing.Size(w, 26);
            lbl.Text = text;
            lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        }

        private void InfoLabel(System.Windows.Forms.Label lbl,
            string text, int x, int y)
        {
            lbl.AutoSize = false;
            lbl.Font = new System.Drawing.Font("Segoe UI", 8F);
            lbl.ForeColor = System.Drawing.Color.FromArgb(31, 97, 141);
            lbl.Location = new System.Drawing.Point(x, y);
            lbl.Size = new System.Drawing.Size(220, 18);
            lbl.Text = text;
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