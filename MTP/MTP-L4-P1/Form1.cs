using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MTP_L4_P1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Generare_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("forma.xml");
            XmlNodeList nodes = xmlDoc.SelectNodes("/Forma/textBox");
            
            foreach (XmlNode node in nodes)
            {
                TextBox tbNume = new TextBox();
                TextBox tbPrenume = new TextBox();
                TextBox tbCNP = new TextBox();

                tbNume.Location = new Point(100, 100);
                tbPrenume.Location = new Point(100, 200);
                tbCNP.Location = new Point(100, 300);

                tbNume.Text = tbNume.Text + node.Attributes["nume"].Value;
                tbPrenume.Text = tbPrenume.Text + node.Attributes["nume"].Value;
                //tbCNP.Text = tbCNP.Text + node.Attributes["CNP"].Value;

                this.Controls.Add(tbNume);
                this.Controls.Add(tbPrenume);
                this.Controls.Add(tbCNP);

            }
            string list = "/Forma/listBox";
            XmlNodeList listNodes = list.SelectNodes();

            foreach (XmlNode node3 in listNodes)
            {
                ListBox listbox = new ListBox();

                listbox.Items.Add(node3.InnerText);

                this.Controls.Add(listbox);
            }



        }

    }
}

