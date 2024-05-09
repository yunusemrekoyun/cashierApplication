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
    public partial class bitir_ekran : Form
    {
        public string veri = "";
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-253USIG\\SQLEXPRESS;Initial Catalog=YKM_DATABASE;Integrated Security=True");

        public bitir_ekran()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into fatura (fatura_tarih,satis_toplam,odeme_tipi,magaza_ad) values (@p1,@p2,@p3,@p4)", baglanti);
            if (comboBox1.Text != "")
            {
                baglanti.Open();
                
                if (label1bitir.Text == "")
                {
                    
                    komut.Parameters.AddWithValue("@p2", Convert.ToDouble(label4.Text));
                    komut.Parameters.AddWithValue("@p1", label6.Text);
                    komut.Parameters.AddWithValue("@p3", comboBox1.Text);
                    komut.Parameters.AddWithValue("@p4", label5.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    


                }
                
                else
                {
                    
                    komut.Parameters.AddWithValue("@p2", Convert.ToDouble(label1bitir.Text));
                    komut.Parameters.AddWithValue("@p1", label6.Text);
                    komut.Parameters.AddWithValue("@p3", comboBox1.Text);
                    komut.Parameters.AddWithValue("@p4", label5.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                }
                
                printPreviewDialog1.Document = printDocument1;
                this.Hide();
                printPreviewDialog1.ShowDialog();
                

            }
            else
            {
                MessageBox.Show("ÖDEME ŞEKLİ SEÇİN");
            }

            




            



            


        }

        private void button4_Click(object sender, EventArgs e)
        {
            kart_sorgu_ekran kart_sorgu = new kart_sorgu_ekran();
            kart_sorgu.sehir.Text = label5.Text;
            kart_sorgu.sayi1 = label1bitir.Text;
            

            kart_sorgu.ShowDialog();
            
            

        }

        private void bitir_ekran_Load(object sender, EventArgs e)
        {
            
            dataGridView1.Visible = false;
            
            label1bitir.Text = veri;
            label6.Text = DateTime.Today.ToString("dd.MM.yyyy");

            label5.Visible=false;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToLongDateString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("     HAYUBE SOFT       ", new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(180));
            e.Graphics.DrawString(label6.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(550,1000));
            if (label4.Text == "")
            {
                e.Graphics.DrawString("Fatura Tutarı :"+label1bitir.Text + " ₺ ", new Font("Arial", 15, FontStyle.Regular), Brushes.Blue, new Point(100,70));
            }
            else
            {
                e.Graphics.DrawString("Fatura Tutarı :" + label4.Text + " ₺ ", new Font("Arial", 15, FontStyle.Regular), Brushes.Red, new Point(100, 70));
            }
            e.Graphics.DrawString("Ödeme Şekli :" + comboBox1.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Blue, new Point(100, 150));


        }


        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
