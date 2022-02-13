using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private void TsmiKereses_Click(object sender, EventArgs e)
            => new FrmSzerzoLista(this).ShowDialog();
        private void TbId_TextChanged(object sender, EventArgs e)
            => tsmiTorles.Enabled = !string.IsNullOrEmpty(tbId.Text);

        private void TsmiMentes_Click(object sender, EventArgs e)
        {
            string errorMsg = "";
            if (string.IsNullOrEmpty(tbNev.Text))
                errorMsg += "A név mező kitöltése kötelező!\n";

            if (!string.IsNullOrWhiteSpace(errorMsg))
            {
                MessageBox.Show(
                    caption: "HIBA",
                    text: $"{errorMsg}",
                    icon: MessageBoxIcon.Error,
                    buttons: MessageBoxButtons.OK);
            }
            else
            {
                using (var conn = new SqlConnection(Program.ConnectionString))
                {
                    conn.Open();
                    new SqlCommand(
                        "INSERT INTO szerzo VALUES " +
                       $"((SELECT MAX(szerzoID) + 1 FROM szerzo), '{tbNev.Text}');",
                        conn).ExecuteNonQuery();

                    var r = new SqlCommand(
                        "SELECT MAX(szerzoID) FROM szerzo;",
                        conn).ExecuteReader();
                    r.Read();
                    tbId.Text = r[0].ToString();
                }
                MessageBox.Show("Az új szerző sikeresen rögzítve lett!");
            }
        }

        private void UresUrlap()
        {
            tbId.Text = null;
            tbNev.Text = null;
        }

        private void TsmiTorles_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                caption: "FIGYELMEZTETÉS",
                text: "Biztosan törölni akarja a szerzőt?",
                icon: MessageBoxIcon.Warning,
                buttons: MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var conn = new SqlConnection(Program.ConnectionString))
                {
                    conn.Open();
                    new SqlCommand(
                        $"DELETE FROM szerzo WHERE szerzoID = {tbId.Text};",
                        conn).ExecuteNonQuery();
                }
                MessageBox.Show("A szerző sikeresen törölve lett!");
                UresUrlap();
            }
        }

        private void TsmiUresUrlap_Click(object sender, EventArgs e)
            => UresUrlap();
    }
}
