using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Idezetgyujtemeny
{

    static class Program
    {
        internal static Random RND = new Random();
        internal static string ConnectionString =
            $"Server=(localdb)\\MSSQLLocalDB;" +
             "Database=idezetek;" +
             "Integrated Security=True;";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
