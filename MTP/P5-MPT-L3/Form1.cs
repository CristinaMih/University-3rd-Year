using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_MPT_L3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }  

        private void button1_Click(object sender, EventArgs e)
        {
            string text = tbInsert.Text;
            System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();
            lbl.Text = text;
            if (Int32.TryParse(tb1.Text, out int x) && Int32.TryParse(tb1.Text, out int y)) //tratare caz introducere de caractere
                lbl.Location = new System.Drawing.Point(x, y);
            else
                MessageBox.Show("Introduceti coordonate valide!", "Atentie");
            
            lbl.Size = new System.Drawing.Size(65, 15);
            this.Controls.Add(lbl);
        }
    }    
}
