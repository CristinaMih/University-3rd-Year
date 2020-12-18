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
    public partial class Necesitati_Tratament : Form
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
        public Necesitati_Tratament()
        {
            InitializeComponent();
            sql = "SELECT * FROM `animale`";
            retrieveData(sql, dataGridView1);
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Visible = false;
        }

        private void btnAfisareAnimal_Click_1(object sender, EventArgs e)
        {
            sql = "SELECT animale.cod_animal, animale.nume, c.tratament, c.tip_tratament, c.interventie, c.data_consultatie  FROM animale INNER JOIN consultatie c on animale.id_consultatie = c.id  WHERE nume= '" + tbCautareAnimal.Text + "';";
            retrieveData(sql, dataGridView1);
        }

        private void btnAfisareMedic_Click(object sender, EventArgs e)
        {
           sql = "SELECT medici_veterinari.nume, medici_veterinari.prenume, a.cod_animal, a.nume, c.tratament, c.tip_tratament, c.interventie, c.data_consultatie FROM medici_veterinari INNER JOIN consultatie c on c.id_medic = medici_veterinari.id INNER JOIN animale a on a.id_consultatie = c.id WHERE medici_veterinari.nume= '" + tbMedic.Text + "';";
            retrieveData(sql, dataGridView1);
        }

        private void btnAfisareHrana_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM animale  WHERE tip_hrana = '" + tbHrana.Text + "';";
            retrieveData(sql, dataGridView1);
        }
    }
}
