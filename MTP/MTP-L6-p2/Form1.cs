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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void universitateBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.universitateBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.universitateDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universitateDataSet.Studenti' table. You can move, or remove it, as needed.
            this.studentiTableAdapter.Fill(this.universitateDataSet.Studenti);
            // TODO: This line of code loads data into the 'universitateDataSet.Specializari' table. You can move, or remove it, as needed.
            this.specializariTableAdapter.Fill(this.universitateDataSet.Specializari);
            // TODO: This line of code loads data into the 'universitateDataSet.Universitate' table. You can move, or remove it, as needed.
            this.universitateTableAdapter.Fill(this.universitateDataSet.Universitate);

        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.specializare = (string)((DataRowView)specializariBindingSource.Current)["Specializare"];
            if (f.ShowDialog() == DialogResult.OK)
            {
             
                // Adaugarea datelor
                studentiTableAdapter.Insert(Convert.ToByte(f.marca), f.specializare, f.nume, Convert.ToByte(f.an_studiu));
                // Salvarea datelor
                tableAdapterManager.UpdateAll(universitateDataSet);
                // Reincarcarea datelor
                studentiTableAdapter.Fill(universitateDataSet.Studenti);
            }
        }

        private void btnCautare_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            if (f3.ShowDialog() == DialogResult.OK)
            {

                studentiBindingSource.Filter = "Nume like'" + f3.nume_cautat + "%'";
              
            }
        }
    }
}
