using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Idezetgyujtemeny
{
    public partial class FrmSzerzo : Form
    {
        public FrmSzerzo()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.author;
        }

        private void KeresésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmSzerzoLista(this).ShowDialog();
        }
    }
}
