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

namespace MTP_L4_P5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("books.xml");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("books.xml");
            XmlNodeList bookNodes = xmlDoc.SelectNodes("/catalog/book/price");
            foreach (XmlNode bookNode in bookNodes)
            {
                string pret = bookNode.InnerText;
                float price = float.Parse(pret);
                bookNode.InnerText = (price + 0.1 * price).ToString();
            }
            xmlDoc.Save("books.xml");

        }
    }
}
