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
    public partial class kart_sorgu_ekran : Form
    {
        SqlConnection kart_sorgulama = new SqlConnection("Data Source=DESKTOP-253USIG\\SQLEXPRESS;Initial Catalog=YKM_DATABASE;Integrated Security=True");


        public string sayi1 = "";
        public double sayi2 = 0;
        public double sayi3 = 0;
        
        public kart_sorgu_ekran()
        {
            InitializeComponent();
        }

        private void kart_sorgu_ekran_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            sehir.Visible = false;
            label3.Text = sayi1;

        }

       
        private void button1_Click(object sender, EventArgs e)
        {
           
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-253USIG\\SQLEXPRESS;Initial Catalog=YKM_DATABASE;Integrated Security=True");
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select * from KART_BASVURU where cep_no = @cep ", baglanti);
            cmd.Parameters.AddWithValue("cep", txt_kart_sorgulama.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;



            

            label2.Text = dataGridView1.Rows[0].Cells[1].Value?.ToString();
            if(label2.Text == "")
            {
                MessageBox.Show("   KULLANICI BULUNAMADI !      ");
                
            }
            if(label2.Text != "")
            {
                

                bool sonuc = double.TryParse(sayi1, out sayi2);
                if (sonuc)
                {
                    sayi3 = sayi2 * 95 / 100;
                    bitir_ekran bitir = new bitir_ekran();
                    bitir.label5.Text = sehir.Text;
                    bitir.label4.Text = sayi3.ToString();
                    bitir.ShowDialog();
                    
                    
                }


                



            }
            this.Hide();







            baglanti.Close();

           

        }

        private void button2_Click(object sender, EventArgs e)
        {   bitir_ekran bitir_Ekran = new bitir_ekran();
            bitir_Ekran.label5.Text = sehir.Text;
            bitir_Ekran.label1bitir.Text = sayi1;
            this.Hide();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sehir_Click(object sender, EventArgs e)
        {

        }
    }
}
