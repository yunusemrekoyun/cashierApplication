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
    public partial class genelciro : Form
    {
        public genelciro()
        {
            InitializeComponent();
        }


        private void genelciro_Load(object sender, EventArgs e)
        {
            DatagridviewSetting(dataGridView1);
            dataGridView1.RowTemplate.Height = 35;
        }
        public void DatagridviewSetting(DataGridView datagridview)
        {
            datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
        public void SelectedRowTotal()
        {
            double sum = 0;
            


            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);



            }
            




            label4.Text = sum.ToString() + "₺";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection da = new SqlConnection("Data Source=DESKTOP-253USIG\\SQLEXPRESS;Initial Catalog=YKM_DATABASE;Integrated Security=True");
            DataTable dt = new DataTable();
            da.Open();
            string sql = "SELECT * FROM fatura WHERE fatura_tarih between @date1 and @date2 ";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, da);
            adapter.SelectCommand.Parameters.AddWithValue("@date1", dateTimePicker1.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@date2", dateTimePicker2.Text);
            adapter.Fill(dt);
            da.Close();
            dataGridView1.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelectedRowTotal();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
