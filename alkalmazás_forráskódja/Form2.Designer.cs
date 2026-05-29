namespace OrvosRendelo
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlFejlec;
        private System.Windows.Forms.Label lblCim;
        private System.Windows.Forms.Panel pnlKereses;
        private System.Windows.Forms.Label lblTajFelirat;
        private System.Windows.Forms.TextBox txtTaj;
        private System.Windows.Forms.Button btnKeres;
        private System.Windows.Forms.Button btnVissza;
        private System.Windows.Forms.Label lblUzenet;
        private System.Windows.Forms.DataGridView dgvEredmeny;

        // DataGridView oszlopok
        private System.Windows.Forms.DataGridViewTextBoxColumn colBetegNev;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrvosNev;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSzakterulet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatusz;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMegjegyzes;

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
            this.pnlKereses = new System.Windows.Forms.Panel();
            this.lblTajFelirat = new System.Windows.Forms.Label();
            this.txtTaj = new System.Windows.Forms.TextBox();
            this.btnKeres = new System.Windows.Forms.Button();
            this.btnVissza = new System.Windows.Forms.Button();
            this.lblUzenet = new System.Windows.Forms.Label();
            this.dgvEredmeny = new System.Windows.Forms.DataGridView();

            this.colBetegNev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrvosNev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSzakterulet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatusz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMegjegyzes = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlFejlec.SuspendLayout();
            this.pnlKereses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEredmeny)).BeginInit();
            this.SuspendLayout();

            // ── pnlFejlec ──────────────────────────────────────────────
            this.pnlFejlec.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.pnlFejlec.Controls.Add(this.lblCim);
            this.pnlFejlec.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFejlec.Size = new System.Drawing.Size(820, 70);

            // lblCim
            this.lblCim.AutoSize = false;
            this.lblCim.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblCim.ForeColor = System.Drawing.Color.White;
            this.lblCim.Location = new System.Drawing.Point(16, 18);
            this.lblCim.Size = new System.Drawing.Size(500, 36);
            this.lblCim.Text = "Beteg időpont keresése";

            // ── pnlKereses ─────────────────────────────────────────────
            this.pnlKereses.BackColor = System.Drawing.Color.FromArgb(245, 248, 250);
            this.pnlKereses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKereses.Controls.Add(this.lblTajFelirat);
            this.pnlKereses.Controls.Add(this.txtTaj);
            this.pnlKereses.Controls.Add(this.btnKeres);
            this.pnlKereses.Controls.Add(this.btnVissza);
            this.pnlKereses.Location = new System.Drawing.Point(12, 82);
            this.pnlKereses.Size = new System.Drawing.Size(796, 60);

            // lblTajFelirat
            this.lblTajFelirat.AutoSize = false;
            this.lblTajFelirat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTajFelirat.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblTajFelirat.Location = new System.Drawing.Point(12, 18);
            this.lblTajFelirat.Size = new System.Drawing.Size(90, 24);
            this.lblTajFelirat.Text = "TAJ szám:";

            // txtTaj
            this.txtTaj.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTaj.Location = new System.Drawing.Point(108, 14);
            this.txtTaj.MaxLength = 9;
            this.txtTaj.Size = new System.Drawing.Size(160, 28);
            this.txtTaj.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTaj_KeyDown);

            // btnKeres
            this.btnKeres.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnKeres.FlatAppearance.BorderSize = 0;
            this.btnKeres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeres.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnKeres.ForeColor = System.Drawing.Color.White;
            this.btnKeres.Location = new System.Drawing.Point(280, 12);
            this.btnKeres.Size = new System.Drawing.Size(110, 34);
            this.btnKeres.Text = "Keresés";
            this.btnKeres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeres.Click += new System.EventHandler(this.btnKeres_Click);

            // btnVissza
            this.btnVissza.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnVissza.FlatAppearance.BorderSize = 0;
            this.btnVissza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVissza.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnVissza.ForeColor = System.Drawing.Color.White;
            this.btnVissza.Location = new System.Drawing.Point(670, 12);
            this.btnVissza.Size = new System.Drawing.Size(110, 34);
            this.btnVissza.Text = "Vissza";
            this.btnVissza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVissza.Click += new System.EventHandler(this.btnVissza_Click);

            // ── lblUzenet ──────────────────────────────────────────────
            this.lblUzenet.AutoSize = false;
            this.lblUzenet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblUzenet.Location = new System.Drawing.Point(12, 150);
            this.lblUzenet.Size = new System.Drawing.Size(796, 22);
            this.lblUzenet.Text = "";
            this.lblUzenet.Visible = false;

            // ── dgvEredmeny ────────────────────────────────────────────
            this.dgvEredmeny.AllowUserToAddRows = false;
            this.dgvEredmeny.AllowUserToDeleteRows = false;
            this.dgvEredmeny.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dgvEredmeny.Location = new System.Drawing.Point(12, 176);
            this.dgvEredmeny.ReadOnly = true;
            this.dgvEredmeny.RowHeadersVisible = false;
            this.dgvEredmeny.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEredmeny.Size = new System.Drawing.Size(796, 340);
            this.dgvEredmeny.GridColor = System.Drawing.Color.FromArgb(189, 195, 199);

            // Oszlopok
            this.colBetegNev.HeaderText = "Beteg neve";
            this.colBetegNev.Name = "colBetegNev";
            this.colBetegNev.FillWeight = 14;

            this.colTaj.HeaderText = "TAJ szám";
            this.colTaj.Name = "colTaj";
            this.colTaj.FillWeight = 10;

            this.colOrvosNev.HeaderText = "Orvos neve";
            this.colOrvosNev.Name = "colOrvosNev";
            this.colOrvosNev.FillWeight = 14;

            this.colSzakterulet.HeaderText = "Szakterület";
            this.colSzakterulet.Name = "colSzakterulet";
            this.colSzakterulet.FillWeight = 12;

            this.colDatum.HeaderText = "Időpont";
            this.colDatum.Name = "colDatum";
            this.colDatum.FillWeight = 13;

            this.colStatusz.HeaderText = "Státusz";
            this.colStatusz.Name = "colStatusz";
            this.colStatusz.FillWeight = 10;

            this.colMegjegyzes.HeaderText = "Megjegyzés";
            this.colMegjegyzes.Name = "colMegjegyzes";
            this.colMegjegyzes.FillWeight = 27;

            this.dgvEredmeny.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colBetegNev,
                this.colTaj,
                this.colOrvosNev,
                this.colSzakterulet,
                this.colDatum,
                this.colStatusz,
                this.colMegjegyzes
            });

            // ── Form2 ──────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.ClientSize = new System.Drawing.Size(820, 530);
            this.Controls.Add(this.pnlFejlec);
            this.Controls.Add(this.pnlKereses);
            this.Controls.Add(this.lblUzenet);
            this.Controls.Add(this.dgvEredmeny);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orvosi Rendelő – Beteg keresése";

            this.pnlFejlec.ResumeLayout(false);
            this.pnlKereses.ResumeLayout(false);
            this.pnlKereses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEredmeny)).EndInit();
            this.ResumeLayout(false);
        }
    }
}