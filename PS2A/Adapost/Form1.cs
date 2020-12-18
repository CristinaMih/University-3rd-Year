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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAfisareAnimale_Click(object sender, EventArgs e)
        {
            Animale f1 = new Animale();
            f1.Show();
            this.Visible = false;
        }

        private void btnPersoane_Click(object sender, EventArgs e)
        {
            Persoane f2 = new Persoane();
            f2.Show();
            this.Visible = false;
        }

        private void btnAdoptie_Click(object sender, EventArgs e)
        {

        }

        private void buttonNecesități_Click(object sender, EventArgs e)
        {
            Necesitati_Tratament f4 = new Necesitati_Tratament();
            f4.Show();
            this.Visible = false;
        }
    }
}
