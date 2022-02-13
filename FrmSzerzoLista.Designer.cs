
namespace Idezetgyujtemeny
{
    partial class FrmSzerzoLista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSzures = new System.Windows.Forms.TextBox();
            this.dgvSzerzok = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSzerzok)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSzures);
            this.groupBox1.Location = new System.Drawing.Point(21, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Szűrés";
            // 
            // tbSzures
            // 
            this.tbSzures.Location = new System.Drawing.Point(23, 32);
            this.tbSzures.Name = "tbSzures";
            this.tbSzures.Size = new System.Drawing.Size(267, 26);
            this.tbSzures.TabIndex = 0;
            this.tbSzures.TextChanged += new System.EventHandler(this.TbSzures_TextChanged);
            // 
            // dgvSzerzok
            // 
            this.dgvSzerzok.AllowUserToAddRows = false;
            this.dgvSzerzok.AllowUserToDeleteRows = false;
            this.dgvSzerzok.AllowUserToResizeColumns = false;
            this.dgvSzerzok.AllowUserToResizeRows = false;
            this.dgvSzerzok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSzerzok.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSzerzok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSzerzok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvSzerzok.Location = new System.Drawing.Point(21, 118);
            this.dgvSzerzok.Name = "dgvSzerzok";
            this.dgvSzerzok.Size = new System.Drawing.Size(312, 249);
            this.dgvSzerzok.TabIndex = 1;
            this.dgvSzerzok.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvSzerzok_RowHeaderMouseClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 60F;
            this.Column1.HeaderText = "szerzoID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "nev";
            this.Column2.Name = "Column2";
            // 
            // FrmSzerzoLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 379);
            this.Controls.Add(this.dgvSzerzok);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmSzerzoLista";
            this.Text = "Szerzők";
            this.Load += new System.EventHandler(this.FrmSzerzoLista_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSzerzok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSzures;
        private System.Windows.Forms.DataGridView dgvSzerzok;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}