using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cashierApplication
{
    public partial class stok : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-253USIG\\SQLEXPRESS;Initial Catalog=YKM_DATABASE;Integrated Security=True");
        public stok()
        {
            InitializeComponent();
        }

        private void stok_Load(object sender, EventArgs e)
        {
            
            
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select * from stok_bilgi where magaza_ad = @magaza ", baglanti);
            cmd.Parameters.AddWithValue("magaza", label1.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            label1.Visible = false;
            baglanti.Close();
            // urun
            baglanti.Open();
            string query = "select barkod_no,urun_adi,marka from urunler";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            baglanti.Close();

            
            label1.Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("KAYIT BİLGİSİ EKSİK LÜTFEN HEPSİNİ GİRİN");
            }

            else
            {



                baglanti.Open();
                SqlCommand kaydet = new SqlCommand("insert into stok_bilgi (urun_adi,urun_sayisi,magaza_ad) values (@p1,@p2,@p3)", baglanti);
                kaydet.Parameters.AddWithValue("@p1", textBox5.Text);
                kaydet.Parameters.AddWithValue("@p2", textBox3.Text);
                kaydet.Parameters.AddWithValue("@p3", label1.Text);
                kaydet.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("       EKLEME BAŞARILI     ");

                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Select * from stok_bilgi where magaza_ad = @magaza ", baglanti);
                cmd.Parameters.AddWithValue("magaza", label1.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                label1.Visible = false;
                baglanti.Close();

            }

                

            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim = dataGridView2.SelectedCells[0].RowIndex;
            textBox4.Text = dataGridView2.Rows[secim].Cells[0].Value.ToString();// barkod nno
            textBox1.Text = dataGridView2.Rows[secim].Cells[2].Value.ToString(); // marka
            textBox5.Text = dataGridView2.Rows[secim].Cells[1].Value.ToString(); // ürün adı
             
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

            magaza_yonetici_login magaza_Yonetici_Login = new magaza_yonetici_login();
            magaza_Yonetici_Login.label1magaza.Text = label1.Text;

            magaza_Yonetici_Login.ShowDialog();
        }
    }
}
