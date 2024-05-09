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

namespace cashierApplication
{
    public partial class kart_basvuru_ekran : Form
    {
        SqlConnection kart_bilgi = new SqlConnection("Data Source=DESKTOP-253USIG\\SQLEXPRESS;Initial Catalog=YKM_DATABASE;Integrated Security=True");
        public kart_basvuru_ekran()
        {
            InitializeComponent();
        }

        private void kart_basvuru_ekran_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_k_ad_soyad.Text != "" || txt_k_cep_no.Text != "")
            {
                if (txt_k_cep_no.Text.Length == 10)
                {
                    kart_bilgi.Open();
                    SqlCommand cmd = new SqlCommand("insert into KART_BASVURU (cep_no,ad_soyad) values (@p1,@p2)", kart_bilgi);
                    cmd.Parameters.AddWithValue("@p1", txt_k_cep_no.Text);
                    cmd.Parameters.AddWithValue("@p2", txt_k_ad_soyad.Text);
                    cmd.ExecuteNonQuery();
                    kart_bilgi.Close();
                    MessageBox.Show("     KAYIT EDİLDİ     ");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("CEP TELEFONU HATALI");
                }
            }
            else
            {
                MessageBox.Show("BOŞLUKLARI DOLDURUN");
            }




        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            

        }
    }
}
