using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace L2_MTP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnTrimite_Click(object sender, EventArgs e)
        {
            if((NumeTF.Text=="")||(VarstaTF.Text==""))
            {
                MessageBox.Show("Introduceti numele si varsta!");
                NumeTF.Focus();
            }
            else
            {
                if (!Regex.Match(NumeTF.Text,"^[A-Z][a-zA-Z]*$").Success)
                {
                    MessageBox.Show("Numele este invalid!","Mesaj eroare nume", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    NumeTF.Text = "";
                    NumeTF.Focus();
                }
                string nume = NumeTF.Text;
                string varsta = VarstaTF.Text;

                string judet = listBox1.SelectedItem.ToString();
                
                string gen = "";

                if (radioButton1.Checked)
                    gen = radioButton1.Text;
                else if (radioButton2.Checked)
                    gen = radioButton2.Text;
                else
                    MessageBox.Show("Selecteaza genul!");

                string lp="";
                if (checkBC.Checked)
                    lp = lp + checkBC.Text;
                if (checkBCp.Checked)
                    lp = lp + checkBCp;
                if (checkBJ.Checked)
                    lp = lp + checkBJ;

                string linie = nume + " " + varsta + " " + judet + " " + gen + " " + lp;

                listBox2.Items.Add(linie);
            }
        }

        private void VarstaTF_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(VarstaTF.Text, @"^[0-9]*$"))
            {
                MessageBox.Show("Scrieti o varsta valida");
                VarstaTF.Text = VarstaTF.Text.Remove(VarstaTF.Text.Length - 1);
            }

        }
    }
}
