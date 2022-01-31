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
    public partial class FrmSzerzoLista : Form
    {
        public FrmSzerzo FrmSzerzo { get; set; } = null;
        public FrmSzerzoLista()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.author;
        }

        private void FrmSzerzoLista_Load(object sender, EventArgs e)
        {
            FillDGV();
        }

        private void FillDGV()
        {
            dgvSzerzok.Rows.Clear();
            using (var conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                var reader = new SqlCommand(
                    "SELECT szerzoID, nev " +
                    "FROM szerzo " +
                   $"WHERE nev LIKE '{tbSzures.Text}%';",
                    conn).ExecuteReader();
                while (reader.Read())
                {
                    dgvSzerzok.Rows.Add(reader.GetInt32(0), reader[1]);
                }
            }
        }

        private void TbSzures_TextChanged(object sender, EventArgs e)
        {
            FillDGV();
        }

        private void DgvSzerzok_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FrmSzerzo.
        }
    }
}
