using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTP_Lab6_P2_v2
{
    public partial class Form2 : Form
    {
        public string marca
        {
            set
            {
                tbMarca.Text = value;
            }
            get
            {
                return tbMarca.Text;
            }
        }

        public string nume
        {
            set
            {
                tbNume.Text = value;
            }
            get
            {
                return tbNume.Text;
            }
        }

        public string an_studiu
        {
            set
            {
                tbAnStudiu.Text = value;
            }
            get
            {
                return tbAnStudiu.Text;
            }
        }
        
        public string specializare
        {
            set
            {
                comboBox1.Text = value;
            }
            get
            {
                return comboBox1.Text;
            }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnRenunta_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
