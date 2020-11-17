using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.ComponentModel.Design.Serialization;

namespace MTP_L7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            string connect = @"datasource = localhost; port = 3306; database = pediatrie; username = root; password = 0305awolnation";
            MySqlConnection con = new MySqlConnection(connect);
            try
            {
                con.Open();
                string dataTable = "select * from pacienti";
                MySqlDataAdapter adapter = new MySqlDataAdapter(dataTable, connect);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "pacienti");
                dataGridView1.DataSource = ds.Tables["pacienti"].DefaultView;
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pediatrieDataSet.pacienti' table. You can move, or remove it, as needed.
            this.pacientiTableAdapter.Fill(this.pediatrieDataSet.pacienti);
            string connect = @"datasource = localhost; port = 3306; database = pediatrie; username = root; password = 0305awolnation";
            MySqlConnection con = new MySqlConnection(connect);
            try
            {
                con.Open();
                string dataTable = "select * from pacienti";
                MySqlDataAdapter adapter = new MySqlDataAdapter(dataTable, connect);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "pacienti");
                dataGridView1.DataSource = ds.Tables["pacienti"].DefaultView;
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }


        }
    }
}
