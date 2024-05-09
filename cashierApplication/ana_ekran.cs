using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cashierApplication
{
    public partial class ana_ekran : Form
    {
            
        public ana_ekran()
        {
            InitializeComponent();
        }

        private void ana_ekran_Load(object sender, EventArgs e)
        {
           
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Personel")
            {
                if (textBox1.Text == "personel" && textBox2.Text == "0606")
                {


                    kasiyer_ekran kasiyer_ekran = new kasiyer_ekran();
                    kasiyer_ekran.label11.Text = "ANKARA/ETLİK1";
                    this.Hide();
                    kasiyer_ekran.ShowDialog();

                }
                if (textBox1.Text == "personel" && textBox2.Text == "1616")
                {


                    kasiyer_ekran kasiyer_ekran = new kasiyer_ekran();
                    kasiyer_ekran.label11.Text = "BURSA/GÖRÜKLE1";
                    this.Hide();
                    kasiyer_ekran.ShowDialog();

                }
                if (textBox1.Text == "personel" && textBox2.Text == "3434")
                {


                    kasiyer_ekran kasiyer_ekran = new kasiyer_ekran();
                    kasiyer_ekran.label11.Text = "İSTANBUL/KADIKÖY1";
                    this.Hide();
                    kasiyer_ekran.ShowDialog();

                }
                if (textBox1.Text == "personel" && textBox2.Text == "4343")
                {


                    kasiyer_ekran kasiyer_ekran = new kasiyer_ekran();
                    kasiyer_ekran.label11.Text = "KÜTAHYA/GEDİZ1";
                    this.Hide();
                    kasiyer_ekran.ShowDialog();

                }
                if (textBox1.Text == "personel" && textBox2.Text == "3535")
                {


                    kasiyer_ekran kasiyer_ekran = new kasiyer_ekran();
                    kasiyer_ekran.label11.Text = "İZMİR/BUCA1";
                    this.Hide();
                    kasiyer_ekran.ShowDialog();

                }

                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış");
                }
            }
            else if (comboBox2.Text == "Mağaza Yöneticisi")
            {

                if (textBox1.Text == "etlik1" && textBox2.Text == "0000")
                {
                    magaza_yonetici_login magaza_yonetici_login = new magaza_yonetici_login();
                    magaza_yonetici_login.label1magaza.Text = "ANKARA/ETLİK1";
                    this.Hide();
                    magaza_yonetici_login.ShowDialog();


                }
                if (textBox1.Text == "kadıköy1" && textBox2.Text == "0000")
                {
                    magaza_yonetici_login magaza_yonetici_login = new magaza_yonetici_login();
                    magaza_yonetici_login.label1magaza.Text = "İSTANBUL/KADIKÖY1";
                    this.Hide();
                    magaza_yonetici_login.ShowDialog();


                }
                if (textBox1.Text == "görükle1" && textBox2.Text == "0000")
                {
                    magaza_yonetici_login magaza_yonetici_login = new magaza_yonetici_login();
                    magaza_yonetici_login.label1magaza.Text = "BURSA/GÖRÜKLE1";
                    this.Hide();
                    magaza_yonetici_login.ShowDialog();

                }
                if (textBox1.Text == "gediz1" && textBox2.Text == "0000")
                {
                    magaza_yonetici_login magaza_yonetici_login = new magaza_yonetici_login();
                    magaza_yonetici_login.label1magaza.Text = "KÜTAHYA/GEDİZ1";
                    this.Hide();
                    magaza_yonetici_login.ShowDialog();

                }
                if (textBox1.Text == "buca1" && textBox2.Text == "0000")
                {
                    magaza_yonetici_login magaza_yonetici_login = new magaza_yonetici_login();
                    magaza_yonetici_login.label1magaza.Text = "İZMİR/BUCA1";
                    this.Hide();
                    magaza_yonetici_login.ShowDialog();

                }

                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış");
                }

            }
            else if (comboBox2.Text == "Genel Yönetici")
            {
                if (textBox1.Text == "admin" && textBox2.Text == "0000")
                {
                    genel_yonetici_ekran genel_yonetici_ekran = new genel_yonetici_ekran();
                    this.Hide();

                    genel_yonetici_ekran.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış");
                }

            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
