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


namespace Adapost
{
    public partial class Animale : Form
    {

        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=0305awolnation;database=adapost;sslMode=none");
        MySqlDataAdapter da;
        MySqlCommand cmd;
        DataTable dt;
        string sql;

        private void retrieveData(string sql, DataGridView dtg)
        {
            try
            {
                con.Open();

                cmd = new MySqlCommand();
                da = new MySqlDataAdapter();
                dt = new DataTable();

                cmd.Connection = con;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);

                dtg.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                da.Dispose();
            }
        }
        public Animale()
        {
            InitializeComponent();
            sql = "SELECT * FROM `animale`";
            retrieveData(sql, dataGridView1);
        }

        private void btnAfisare_Click(object sender, EventArgs e)
        {
            sql = "SELECT animale.cod_animal, animale.nume, animale.adoptat, animale.greutate, animale.talie, animale.tip_hrana, animale.rasa, animale.culoare, ta.tip_animal FROM animale INNER JOIN tipuri_animale ta on animale.id_tip = ta.id  WHERE tip_animal= '" + tbCautare.Text + "';";
            retrieveData(sql, dataGridView1);
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Visible = false;
        }

        private void btnCautare_Click(object sender, EventArgs e)
        {

            DateTime dateToday = dateTimePicker1.Value;

            string strDate = dateToday.ToString("yyyy-MM-dd");

            //sql = "SELECT * FROM `animale` WHERE Date(`data_consultatie`) <= '" + strDate + "'";
            sql = "SELECT animale.nume, c.tratament, c.tip_tratament FROM animale INNER JOIN consultatie c on animale.id_consultatie = c.id WHERE Date(`data_consultatie`) <= '" + strDate + "' AND adoptat=0;";
            retrieveData(sql, dataGridView1);
        }
    }
}
