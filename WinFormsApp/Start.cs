using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }
        int n = 10;
        private void cdTimer_Tick(object sender, EventArgs e)
        {
            n--;
            if (n == 0)
            {
                cdTimer.Stop();
                practise f = new practise(tName.Text);
                f.Show();
                this.Hide();

            }

            lStart.Text = n.ToString();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            cdTimer.Start();
        }
    }
}
