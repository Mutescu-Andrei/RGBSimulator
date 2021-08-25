using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prob3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void refresh()
        {
            et_Rosu.Text = rosu.Value.ToString();
            et_Verde.Text = verde.Value.ToString();
            et_Albastru.Text = albastru.Value.ToString();
            culoare.BackColor = System.Drawing.Color.FromArgb(rosu.Value, verde.Value, albastru.Value);
        }

        private void rosu_Scroll(object sender, ScrollEventArgs e)
        {
            refresh();
        }

        private void verde_Scroll(object sender, ScrollEventArgs e)
        {
            refresh();
        }

        private void albastru_Scroll(object sender, ScrollEventArgs e)
        {
            refresh();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
