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
    public partial class magaza_yonetici_ekran : Form
    {    
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-253USIG\\SQLEXPRESS;Initial Catalog=YKM_DATABASE;Integrated Security=True");
       
        public magaza_yonetici_ekran()
        {
            InitializeComponent();
        }
        void temizle()
        {
            txtid_m.Text = "";
            txtad_m.Text = "";
            txtsoyad_m.Text = "";
            txttc_m.Text = "";
            txtcep_m.Text = "";
            txtdepartman_m.Text = "";
            txtmaas_m.Text = "";


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void magaza_yonetici_ekran_Load(object sender, EventArgs e)
        {
            dataGridView1.RowTemplate.Height = 35;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-253USIG\\SQLEXPRESS;Initial Catalog=YKM_DATABASE;Integrated Security=True");
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select * from personel_tablosu where magaza_ad = @magaza ",baglanti);
            magaza_yonetici_login login = new magaza_yonetici_login();
            cmd.Parameters.AddWithValue("magaza", label1.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt; 
        }

        private void btntemizle_m_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnkaydet_m_Click(object sender, EventArgs e)
        {
            if (txtad_m.Text == "" || txtsoyad_m.Text == "" || txttc_m.Text == "" || txtcep_m.Text == "" || txtmaas_m.Text == "" || txtdepartman_m.Text == "")
            {
                MessageBox.Show("KAYIT BİLGİSİ EKSİK LÜTFEN HEPSİNİ GİRİN");
            }
            else
            {
                baglanti.Open();
                SqlCommand kaydet = new SqlCommand("insert into personel_tablosu (perad,persoyad,pertc,percep,permaas,perdepartman,magaza_ad) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
                kaydet.Parameters.AddWithValue("@p1", txtad_m.Text);
                kaydet.Parameters.AddWithValue("@p2", txtsoyad_m.Text);
                kaydet.Parameters.AddWithValue("@p3", txttc_m.Text);
                kaydet.Parameters.AddWithValue("@p4", txtcep_m.Text);
                kaydet.Parameters.AddWithValue("@p5", txtmaas_m.Text);
                kaydet.Parameters.AddWithValue("@p6", txtdepartman_m.Text);
                kaydet.Parameters.AddWithValue("@p7", label1.Text);
                kaydet.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("       EKLEME BAŞARILI");
            }


        }

        private void btnguncelle_m_Click(object sender, EventArgs e)
        {
            if (txtad_m.Text == "" || txtsoyad_m.Text == "" || txttc_m.Text == "" || txtcep_m.Text == "" || txtmaas_m.Text == "" || txtdepartman_m.Text == "")
            {
                MessageBox.Show("KAYIT BİLGİSİ EKSİK LÜTFEN HEPSİNİ GİRİN");
            }
            else
            {


                baglanti.Open();
                SqlCommand güncelleme = new SqlCommand("Update personel_tablosu Set perad =@p1,persoyad =@p2,pertc =@p3,percep=@p4,perdepartman =@p5,magaza_ad=@p6,permaas=@p7 where perid = @p8", baglanti);
                güncelleme.Parameters.AddWithValue("@p1", txtad_m.Text);
                güncelleme.Parameters.AddWithValue("@p2", txtsoyad_m.Text);
                güncelleme.Parameters.AddWithValue("@p3", txttc_m.Text);
                güncelleme.Parameters.AddWithValue("@p4", txtcep_m.Text);
                güncelleme.Parameters.AddWithValue("@p5", txtdepartman_m.Text);
                güncelleme.Parameters.AddWithValue("@p6", label1.Text);
                güncelleme.Parameters.AddWithValue("@p7", txtmaas_m.Text);
                güncelleme.Parameters.AddWithValue("@p8", txtid_m.Text);
                güncelleme.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("       GÜNCELLEME BAŞARILI     ");
            }

        }

        private void btnsil_m_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Kaydı veritabanından silmek istiyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (secenek == DialogResult.Yes)
            {
                DialogResult secenek2 = MessageBox.Show("Kayıt silinecek onaylıyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (secenek2 == DialogResult.Yes)
                {
                    baglanti.Open();
                    SqlCommand sil = new SqlCommand("Delete from personel_tablosu where perid = @p1", baglanti);
                    sil.Parameters.AddWithValue("@p1", txtid_m.Text);
                    sil.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("        KAYIT SİLİNDİ       ");
                }
            }
            else if (secenek == DialogResult.No)
            {
                
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void btnlistele_m_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-253USIG\\SQLEXPRESS;Initial Catalog=YKM_DATABASE;Integrated Security=True");
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select * from personel_tablosu where magaza_ad = @magaza ", baglanti);
            cmd.Parameters.AddWithValue("magaza", label1.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secim = dataGridView1.SelectedCells[0].RowIndex;
            txtid_m.Text = dataGridView1.Rows[secim].Cells[0].Value.ToString();
            txtad_m.Text = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            txtsoyad_m.Text = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            txttc_m.Text = dataGridView1.Rows[secim].Cells[3].Value.ToString();
            txtcep_m.Text = dataGridView1.Rows[secim].Cells[4].Value.ToString();
            txtmaas_m.Text = dataGridView1.Rows[secim].Cells[5].Value.ToString();
            
            txtdepartman_m.Text = dataGridView1.Rows[secim].Cells[6].Value.ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
             
            this.Hide();
            magaza_yonetici_login magaza_Yonetici_Login = new magaza_yonetici_login();
            magaza_Yonetici_Login.label1magaza.Text = label1.Text;
            magaza_Yonetici_Login.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
