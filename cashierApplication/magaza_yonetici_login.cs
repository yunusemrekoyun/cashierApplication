using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cashierApplication
{
    public partial class magaza_yonetici_login : Form
    {
        

        public magaza_yonetici_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        

        private void magaza_yonetici_login_Load(object sender, EventArgs e)
        {
            label1magaza.Visible = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            magaza_yonetici_ekran ekran = new magaza_yonetici_ekran();
            ekran.label1.Text = label1magaza.Text;
            ekran.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            magaza_ciro ekran = new magaza_ciro();

            ekran.label3.Text = label1magaza.Text;
            this.Hide();
            
            ekran.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            stok ciro = new stok();
            ciro.label1.Text = label1magaza.Text;
            ciro.ShowDialog();
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ana_ekran ana_Ekran = new ana_ekran();

            ana_Ekran.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
