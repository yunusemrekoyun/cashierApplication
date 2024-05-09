using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cashierApplication
{

    public partial class intro : Form
    {
        int start = 0;  

        public intro()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            start += 1;
            if (start == 40)
            {
                this.Hide();
                ana_ekran ana_ekran = new ana_ekran();
                ana_ekran.ShowDialog();
                this.timer1.Stop();
                


            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void intro_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }
    }
}
