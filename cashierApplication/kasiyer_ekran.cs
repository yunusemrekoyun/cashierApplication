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
    public partial class kasiyer_ekran : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-253USIG\\SQLEXPRESS;Initial Catalog=YKM_DATABASE;Integrated Security=True");
        
       private void temizle()
        {
            barkodtext.Text = "";
            urunad.Text = "";
            urunfiyat.Text = "";
            miktar.Text = "";

        }

        private void populate()
        {
            baglanti.Open();
            string query = "select barkod_no,urun_adi,fiyat from urunler";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        public kasiyer_ekran()
        {
            InitializeComponent();
            
            
        }
        public void DatagridviewSetting(DataGridView datagridview)
        {
            
            
            datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        

       
       

        private void button5_Click(object sender, EventArgs e)
        {
            bitir_ekran bitir_Ekran = new bitir_ekran();    
            bitir_Ekran.ShowDialog();
        }

        private void kasiyer_ekran_Load(object sender, EventArgs e)
        {
            dataGridView1.RowTemplate.Height = 50;
            ORDERDGV.RowTemplate.Height = 50;


            label12.Text = label11.Text;
            label5.Visible = false;
            populate();
            DatagridviewSetting(dataGridView1);
            DatagridviewSetting(ORDERDGV);
            label6.Text = "Tarih Ve Saat:   " + DateTime.Today.ToString("dd/MM/yyyy");
             label7.Text = DateTime.Now.ToLongTimeString(); 
            
            timer1.Start();
            label11.Visible = false;
            

            
            



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (barkodtext.Text == "")
            {
                urunad.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                urunfiyat.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                
            }
            else
            {
                urunad.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                urunfiyat.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                
            }
            


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        public double Grdtotal = 0, n=0;
        public double grdtotali = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            

            
            double total;
            
            if (urunad.Text == "" || urunfiyat.Text == "")
            {
                MessageBox.Show("       EKSİK BİLGİ GİRİŞİ     ");
            }
            else
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(ORDERDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = urunad.Text;
                newRow.Cells[2].Value = urunfiyat.Text;

                if (miktar.Text == "")
                {
                    miktar.Text = "1";
                }
                newRow.Cells[3].Value = miktar.Text;
                newRow.Cells[4].Value = Convert.ToDouble(urunfiyat.Text) * Convert.ToDouble(miktar.Text);
                total = Convert.ToDouble(urunfiyat.Text) * Convert.ToDouble(miktar.Text);
                ORDERDGV.Rows.Add(newRow);
                Grdtotal = Grdtotal + total;
                grdtotali = Grdtotal;
                label5.Text = Grdtotal.ToString();
                tl.Text = Grdtotal + " ₺ ";
                n++;

               
                temizle();

            }
            

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnarama_Click(object sender, EventArgs e)
        {
            // BUTON İLE ARAMA YAPMA
            if (barkodtext.Text == "")
            {
                MessageBox.Show("   BARKOD GİRİN    ");
            }
            else
            {


                baglanti.Open();
                SqlCommand cmd = new SqlCommand("select * from urunler where barkod_no = @barkod", baglanti);
                cmd.Parameters.AddWithValue("barkod", int.Parse(barkodtext.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
                
            }


            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void ORDERDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            kasiyer_ekran kasiyer_Ekran = new kasiyer_ekran();
            kasiyer_Ekran.ShowDialog();
            
        }
        
        private void btnbitir_Click(object sender, EventArgs e)
        {
            
            if (label5.Text == "")
            {
                MessageBox.Show("       ÜRÜN GİRİŞİ YAPILMADI      ");
            }

            else
            {

                bitir_ekran bitir = new bitir_ekran();
                bitir.label5.Text = label11.Text;
                bitir.veri = Grdtotal.ToString();
                bitir.ShowDialog();
            }
            
        }

        private void ORDERDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            kart_basvuru_ekran kart = new kart_basvuru_ekran();
            kart.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToLongTimeString();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    cell.Value = "";
                }
                e.Handled = true;
            }
        }
    }
}
