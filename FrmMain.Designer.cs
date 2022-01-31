
namespace Idezetgyujtemeny
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiSzerkesztes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSzerzo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTema = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiForras = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIdezet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKereses = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvTemaSzerint = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSzerzoSzerint = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNapidezete = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblIdezetSzam = new System.Windows.Forms.Label();
            this.tlp = new System.Windows.Forms.TableLayoutPanel();
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemaSzerint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSzerzoSzerint)).BeginInit();
            this.tlp.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "A nap idézete:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Az idézetek száma témák szerint:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(284, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Az idézetek száma szerzők szerint:";
            // 
            // msMain
            // 
            this.msMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.msMain.AutoSize = false;
            this.msMain.Dock = System.Windows.Forms.DockStyle.None;
            this.msMain.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSzerkesztes,
            this.tsmiKereses});
            this.msMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.msMain.Location = new System.Drawing.Point(599, 208);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(126, 226);
            this.msMain.TabIndex = 3;
            this.msMain.Text = "menuStrip1";
            // 
            // tsmiSzerkesztes
            // 
            this.tsmiSzerkesztes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSzerzo,
            this.tsmiTema,
            this.tsmiForras,
            this.tsmiIdezet});
            this.tsmiSzerkesztes.Image = global::Idezetgyujtemeny.Properties.Resources.edit;
            this.tsmiSzerkesztes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSzerkesztes.Name = "tsmiSzerkesztes";
            this.tsmiSzerkesztes.Padding = new System.Windows.Forms.Padding(4, 20, 4, 0);
            this.tsmiSzerkesztes.Size = new System.Drawing.Size(119, 107);
            this.tsmiSzerkesztes.Text = "Szerkesztés";
            this.tsmiSzerkesztes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiSzerzo
            // 
            this.tsmiSzerzo.Name = "tsmiSzerzo";
            this.tsmiSzerzo.Size = new System.Drawing.Size(180, 24);
            this.tsmiSzerzo.Text = "Szerző";
            this.tsmiSzerzo.Click += new System.EventHandler(this.TsmiSzerzo_Click);
            // 
            // tsmiTema
            // 
            this.tsmiTema.Name = "tsmiTema";
            this.tsmiTema.Size = new System.Drawing.Size(180, 24);
            this.tsmiTema.Text = "Téma";
            // 
            // tsmiForras
            // 
            this.tsmiForras.Name = "tsmiForras";
            this.tsmiForras.Size = new System.Drawing.Size(180, 24);
            this.tsmiForras.Text = "Forrás";
            // 
            // tsmiIdezet
            // 
            this.tsmiIdezet.Name = "tsmiIdezet";
            this.tsmiIdezet.Size = new System.Drawing.Size(180, 24);
            this.tsmiIdezet.Text = "Idézet";
            // 
            // tsmiKereses
            // 
            this.tsmiKereses.Image = global::Idezetgyujtemeny.Properties.Resources.search;
            this.tsmiKereses.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiKereses.Name = "tsmiKereses";
            this.tsmiKereses.Size = new System.Drawing.Size(119, 87);
            this.tsmiKereses.Text = "Keresés";
            this.tsmiKereses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // dgvTemaSzerint
            // 
            this.dgvTemaSzerint.AllowUserToAddRows = false;
            this.dgvTemaSzerint.AllowUserToDeleteRows = false;
            this.dgvTemaSzerint.AllowUserToResizeColumns = false;
            this.dgvTemaSzerint.AllowUserToResizeRows = false;
            this.dgvTemaSzerint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTemaSzerint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTemaSzerint.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTemaSzerint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemaSzerint.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvTemaSzerint.Location = new System.Drawing.Point(3, 33);
            this.dgvTemaSzerint.Name = "dgvTemaSzerint";
            this.dgvTemaSzerint.RowHeadersVisible = false;
            this.dgvTemaSzerint.Size = new System.Drawing.Size(275, 319);
            this.dgvTemaSzerint.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Téma";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 60F;
            this.Column2.HeaderText = "Idézetek száma";
            this.Column2.Name = "Column2";
            // 
            // dgvSzerzoSzerint
            // 
            this.dgvSzerzoSzerint.AllowUserToAddRows = false;
            this.dgvSzerzoSzerint.AllowUserToDeleteRows = false;
            this.dgvSzerzoSzerint.AllowUserToResizeColumns = false;
            this.dgvSzerzoSzerint.AllowUserToResizeRows = false;
            this.dgvSzerzoSzerint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSzerzoSzerint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSzerzoSzerint.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSzerzoSzerint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSzerzoSzerint.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4});
            this.dgvSzerzoSzerint.Location = new System.Drawing.Point(284, 33);
            this.dgvSzerzoSzerint.Name = "dgvSzerzoSzerint";
            this.dgvSzerzoSzerint.RowHeadersVisible = false;
            this.dgvSzerzoSzerint.Size = new System.Drawing.Size(275, 319);
            this.dgvSzerzoSzerint.TabIndex = 5;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Szerző";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.FillWeight = 60F;
            this.Column4.HeaderText = "Idézetek száma";
            this.Column4.Name = "Column4";
            // 
            // lblNapidezete
            // 
            this.lblNapidezete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNapidezete.BackColor = System.Drawing.Color.White;
            this.lblNapidezete.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNapidezete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNapidezete.Location = new System.Drawing.Point(26, 57);
            this.lblNapidezete.Name = "lblNapidezete";
            this.lblNapidezete.Size = new System.Drawing.Size(553, 53);
            this.lblNapidezete.TabIndex = 6;
            this.lblNapidezete.Text = "label4";
            this.lblNapidezete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDatum
            // 
            this.lblDatum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDatum.Location = new System.Drawing.Point(595, 20);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(86, 19);
            this.lblDatum.TabIndex = 7;
            this.lblDatum.Text = "###Date###";
            this.lblDatum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIdezetSzam
            // 
            this.lblIdezetSzam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdezetSzam.AutoSize = true;
            this.lblIdezetSzam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIdezetSzam.Location = new System.Drawing.Point(595, 74);
            this.lblIdezetSzam.Name = "lblIdezetSzam";
            this.lblIdezetSzam.Size = new System.Drawing.Size(127, 19);
            this.lblIdezetSzam.TabIndex = 8;
            this.lblIdezetSzam.Text = "###IdezetSzam###";
            this.lblIdezetSzam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlp
            // 
            this.tlp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp.AutoSize = true;
            this.tlp.ColumnCount = 2;
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp.Controls.Add(this.label2, 0, 0);
            this.tlp.Controls.Add(this.label3, 1, 0);
            this.tlp.Controls.Add(this.dgvTemaSzerint, 0, 1);
            this.tlp.Controls.Add(this.dgvSzerzoSzerint, 1, 1);
            this.tlp.Location = new System.Drawing.Point(17, 140);
            this.tlp.Name = "tlp";
            this.tlp.RowCount = 2;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp.Size = new System.Drawing.Size(562, 355);
            this.tlp.TabIndex = 9;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 538);
            this.Controls.Add(this.tlp);
            this.Controls.Add(this.lblIdezetSzam);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblNapidezete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.msMain;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemaSzerint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSzerzoSzerint)).EndInit();
            this.tlp.ResumeLayout(false);
            this.tlp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.DataGridView dgvTemaSzerint;
        private System.Windows.Forms.DataGridView dgvSzerzoSzerint;
        private System.Windows.Forms.ToolStripMenuItem tsmiSzerkesztes;
        private System.Windows.Forms.ToolStripMenuItem tsmiSzerzo;
        private System.Windows.Forms.ToolStripMenuItem tsmiTema;
        private System.Windows.Forms.ToolStripMenuItem tsmiForras;
        private System.Windows.Forms.ToolStripMenuItem tsmiIdezet;
        private System.Windows.Forms.ToolStripMenuItem tsmiKereses;
        private System.Windows.Forms.Label lblNapidezete;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblIdezetSzam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TableLayoutPanel tlp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

