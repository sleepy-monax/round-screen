using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoundScreenCorner
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        //[STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            foreach (var i in Screen.AllScreens)
            {
                Form frm = new Form1();
                frm.Show();
                frm.Location = i.WorkingArea.Location;
                frm.WindowState = FormWindowState.Maximized;
            }

            NotifyIcon ni = new NotifyIcon();
            ni.Visible = true;
            ni.Icon = Application.OpenForms[0].Icon;
            ni.Text = $"Round corners on {Application.OpenForms.Count} screens.";
            ni.Click += Ni_Click;

            Application.Run();
        }

        private static void Ni_Click(object sender, EventArgs e)
        {
            new Option().Show();
        }
    }
}
