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
using System.Data.OleDb;
using System.Data.Common;


namespace cashierApplication
{

    public partial class magaza_ciro : Form
    {
        public object DataSource { get; set; }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-253USIG\\SQLEXPRESS;Initial Catalog=YKM_DATABASE;Integrated Security=True");
        public magaza_ciro()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public void SelectedRowTotal()
        {
            double sum =0;
            

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);


                
            }
            label5.Text = sum.ToString()  + "₺";
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection da = new SqlConnection("Data Source=DESKTOP-253USIG\\SQLEXPRESS;Initial Catalog=YKM_DATABASE;Integrated Security=True");
            DataTable dt = new DataTable(); 
            da.Open();
            string sql = "SELECT * FROM fatura WHERE fatura_tarih between @date1 and @date2 and magaza_ad= @magaza";
            SqlDataAdapter adapter = new SqlDataAdapter(sql ,da);
            adapter.SelectCommand.Parameters.AddWithValue("@date1", dateTimePicker1.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@date2", dateTimePicker2.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@magaza", label3.Text);
            adapter.Fill(dt);
            da.Close();
            dataGridView1.DataSource = dt;
            


           

        }



        private void magaza_ciro_Load(object sender, EventArgs e)
        {
           
            DatagridviewSetting(dataGridView1);
            dataGridView1.RowTemplate.Height = 30;




        }
        public void DatagridviewSetting(DataGridView datagridview)
        {
           datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            magaza_yonetici_login magaza_Yonetici_Login = new magaza_yonetici_login();
            magaza_Yonetici_Login.label1magaza.Text = label3.Text;
            
            magaza_Yonetici_Login.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelectedRowTotal();
        }
    }
}
