using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection.Emit;

namespace cashierApplication
{
    public partial class genel_yonetici_ekran : Form
    {
        public genel_yonetici_ekran()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-253USIG\\SQLEXPRESS;Initial Catalog=YKM_DATABASE;Integrated Security=True");

        void temizle()
        {
            txtid.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
            txttc.Text = "";
            cmbmagaza.Text = "";
            txtmaas.Text = "";
            txtdepartman.Text = "";
            txtcep.Text = "";
        }

        private void genel_yonetici_ekran_Load(object sender, EventArgs e)
        {

            dataGridView1.RowTemplate.Height = 50;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.personel_tablosuTableAdapter1.Fill(this.yKM_DATABASEDataSet6.personel_tablosu);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtad.Text == "" || txtsoyad.Text == "" || txttc.Text == "" || txtcep.Text == "" || txtmaas.Text == "" || cmbmagaza.Text == "" || txtdepartman.Text == "")
            {
                MessageBox.Show("KAYIT BİLGİSİ EKSİK LÜTFEN HEPSİNİ GİRİN");
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into personel_tablosu (perad,persoyad,pertc,percep,permaas,perdepartman,magaza_ad) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtad.Text);
                komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
                komut.Parameters.AddWithValue("@p3", txttc.Text);
                komut.Parameters.AddWithValue("@p4", txtcep.Text);
                komut.Parameters.AddWithValue("@p5", txtmaas.Text);
                komut.Parameters.AddWithValue("@p6", txtdepartman.Text);
                komut.Parameters.AddWithValue("@p7", cmbmagaza.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("       EKLEME  BAŞARILI        ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.personel_tablosuTableAdapter1.Fill(this.yKM_DATABASEDataSet6.personel_tablosu);
            
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand güncelleme = new SqlCommand("Update personel_tablosu Set perad =@p1,persoyad =@p2,pertc =@p3,percep=@p4,permaas =@p5,perdepartman=@p6,magaza_ad=@p7 where perid = @p8", baglanti);
            güncelleme.Parameters.AddWithValue("@p1", txtad.Text);
            güncelleme.Parameters.AddWithValue("@p2", txtsoyad.Text);
            güncelleme.Parameters.AddWithValue("@p3", txttc.Text);
            güncelleme.Parameters.AddWithValue("@p4", txtcep.Text);
            güncelleme.Parameters.AddWithValue("@p5", txtmaas.Text);
            güncelleme.Parameters.AddWithValue("@p6", txtdepartman.Text);
            güncelleme.Parameters.AddWithValue("@p7", cmbmagaza.Text);
            güncelleme.Parameters.AddWithValue("@p8",txtid.Text);
            güncelleme.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("       GÜNCELLEME BAŞARILI     ");
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            if (txtad.Text == "" || txtsoyad.Text == "" || txttc.Text == "" || txtcep.Text == "" || txtmaas.Text == "" || cmbmagaza.Text == "" || txtdepartman.Text == "")
            {
                MessageBox.Show("SİLİNECEK KİŞİNİN BİLGİLERİNİ SEÇİN");

                
            }
            else
            {
                DialogResult secenek = MessageBox.Show("Kaydı veritabanından silmek istiyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                DialogResult secene2 = MessageBox.Show("Kayıt silinecek onaylıyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (secenek == DialogResult.Yes)
                {
                    if (secene2 == DialogResult.Yes)
                    {

                        baglanti.Open();
                        SqlCommand sil = new SqlCommand("Delete from personel_tablosu where perid = @p1", baglanti);
                        sil.Parameters.AddWithValue("@p1", txtid.Text);
                        sil.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("        KAYIT SİLİNDİ       ");
                    }
                }
                else if (secenek == DialogResult.No)
                {

                }

            }
            

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-253USIG\\SQLEXPRESS;Initial Catalog=YKM_DATABASE;Integrated Security=True");
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select * from personel_tablosu where magaza_ad = @magaza ", baglanti);
            cmd.Parameters.AddWithValue("magaza", cmbmagaza.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secim = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secim].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            txttc.Text = dataGridView1.Rows[secim].Cells[3].Value.ToString();
            txtcep.Text = dataGridView1.Rows[secim].Cells[4].Value.ToString();
            txtmaas.Text = dataGridView1.Rows[secim].Cells[5].Value.ToString();
            txtdepartman.Text = dataGridView1.Rows[secim].Cells[6].Value.ToString();
            cmbmagaza.Text = dataGridView1.Rows[secim].Cells[7].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ana_ekran ana_Ekran = new ana_ekran();
            ana_Ekran.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            genelciro genelciro = new genelciro();
            genelciro.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
