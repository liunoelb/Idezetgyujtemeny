
namespace Idezetgyujtemeny
{
    partial class FrmSzerzo
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
            this.msSzerzo = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKereses = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMentes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTorles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUresUrlap = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.msSzerzo.SuspendLayout();
            this.SuspendLayout();
            // 
            // msSzerzo
            // 
            this.msSzerzo.Dock = System.Windows.Forms.DockStyle.None;
            this.msSzerzo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.tsmiKereses,
            this.tsmiMentes,
            this.tsmiTorles,
            this.tsmiUresUrlap});
            this.msSzerzo.Location = new System.Drawing.Point(60, 152);
            this.msSzerzo.Name = "msSzerzo";
            this.msSzerzo.Size = new System.Drawing.Size(257, 59);
            this.msSzerzo.TabIndex = 0;
            this.msSzerzo.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 55);
            // 
            // tsmiKereses
            // 
            this.tsmiKereses.Image = global::Idezetgyujtemeny.Properties.Resources.keres;
            this.tsmiKereses.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiKereses.Name = "tsmiKereses";
            this.tsmiKereses.Size = new System.Drawing.Size(58, 55);
            this.tsmiKereses.Text = "Keresés";
            this.tsmiKereses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiKereses.Click += new System.EventHandler(this.TsmiKereses_Click);
            // 
            // tsmiMentes
            // 
            this.tsmiMentes.Image = global::Idezetgyujtemeny.Properties.Resources.save;
            this.tsmiMentes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiMentes.Name = "tsmiMentes";
            this.tsmiMentes.Size = new System.Drawing.Size(58, 55);
            this.tsmiMentes.Text = "Mentés";
            this.tsmiMentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiMentes.Click += new System.EventHandler(this.TsmiMentes_Click);
            // 
            // tsmiTorles
            // 
            this.tsmiTorles.Enabled = false;
            this.tsmiTorles.Image = global::Idezetgyujtemeny.Properties.Resources.delete;
            this.tsmiTorles.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiTorles.Name = "tsmiTorles";
            this.tsmiTorles.Size = new System.Drawing.Size(49, 55);
            this.tsmiTorles.Text = "Törlés";
            this.tsmiTorles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiTorles.Click += new System.EventHandler(this.TsmiTorles_Click);
            // 
            // tsmiUresUrlap
            // 
            this.tsmiUresUrlap.Image = global::Idezetgyujtemeny.Properties.Resources.ures_urlap;
            this.tsmiUresUrlap.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiUresUrlap.Name = "tsmiUresUrlap";
            this.tsmiUresUrlap.Size = new System.Drawing.Size(72, 55);
            this.tsmiUresUrlap.Text = "Üres űrlap";
            this.tsmiUresUrlap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiUresUrlap.Click += new System.EventHandler(this.TsmiUresUrlap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Azonosító:";
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(102, 54);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(80, 26);
            this.tbId.TabIndex = 2;
            this.tbId.TextChanged += new System.EventHandler(this.TbId_TextChanged);
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(102, 97);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(208, 26);
            this.tbNev.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Név:";
            // 
            // FrmSzerzo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 246);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msSzerzo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msSzerzo;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmSzerzo";
            this.Text = "Szerző";
            this.msSzerzo.ResumeLayout(false);
            this.msSzerzo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msSzerzo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiKereses;
        private System.Windows.Forms.ToolStripMenuItem tsmiMentes;
        private System.Windows.Forms.ToolStripMenuItem tsmiTorles;
        private System.Windows.Forms.ToolStripMenuItem tsmiUresUrlap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox tbId;
        internal System.Windows.Forms.TextBox tbNev;
    }
}