using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoundScreenCorner
{
    public partial class Option : Form
    {
        public Option()
        {
            InitializeComponent();
        }

        private void Option_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Screen.AllScreens.Count(); i++)
            {
                CheckBox cb = new CheckBox();
                cb.Text = $"Monitor {i}";
                panel5.Controls.Add(cb);
                cb.Dock = DockStyle.Top;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
