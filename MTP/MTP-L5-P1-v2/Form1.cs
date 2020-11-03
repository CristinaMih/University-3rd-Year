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
using HtmlAgilityPack;
using System.Net;

namespace MTP_L5_P1_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string URL = "https://okian.ro/bestsellers.html";
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(URL);
            string[] linkcarti = new string[99999];
            string[] denumirecarte = new string[99999];
            int nr_carti = 20; // apar 20 de carti pe pagina by default

            //parcurgem link-urile paginilor si preluam link-urile cartilor
            int j = 0;

            for (int i = 1; i <= 69; i++) //69 este numarul ultimei pagini
                //ATENTIE! lista de bestsellers se tot actualizeaza si numarul de pagini creste 
                //este posibil sa nu fie la fel de la o zi la alta
            {
                string URL2 = URL + "?p=" + i;
                HtmlWeb web2 = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc2 = web2.Load(URL2);

                //nr carti pe pagina
                if (i == 69)
                    nr_carti = 19; //pe pagina 69 sunt 19 carti
                //ultima accesare a siteului: 27.10, ora 22

                for (int ii = 1; ii < nr_carti; ii++)
                {
                    try
                    {
                        // preluare link-uri carti
                        // /html/body/div[3]/main/div[2]/div/div[5]/div[2]/ul/li[1]/div/div/div[2]/h3/a
                        // /html/body/div[3]/main/div[2]/div/div[5]/div[2]/ul/li[2]/div/div/div[2]/h3/a


                        linkcarti[j] = doc2.DocumentNode.SelectNodes("/html/body/div[3]/main/div[2]/div/div[5]/div[2]/ul/li[" + ii + "]/div/div/div[2]/h3/a")[0].Attributes["href"].Value;
                        textBox1.Text = linkcarti[j];
                        denumirecarte[j] = doc2.DocumentNode.SelectNodes("/html/body/div[3]/main/div[2]/div/div[5]/div[2]/ul/li[" + ii + "]/div/div/div[2]/h3/a")[0].InnerText;

                        j++;

                    }

                    catch
                    {

                    }
                    //break;
                }
                break;
            }            
            // extragere in XML
            // variabila in care vom numara cate carti avem in fisierul XML pe care il vom crea
            int nrTotalCarti = 0;
            XmlTextWriter scriereXML = new XmlTextWriter("OkianBestsellers.xml", Encoding.UTF8);
            scriereXML.Formatting = Formatting.Indented;
            // scriem nodul radacina in XML ca fiind Bestsellers
            scriereXML.WriteStartElement("Bestsellers");

            //instantiem descrierea cartii 
            string descriereCarte = "";
            //preluam toate linkurile de carti extrase mai sus
            for (int k = 0; k <= j; k++)
            {
                try
                {
                    var path = linkcarti[k];
                    var doc2 = new HtmlWeb
                    {
                        OverrideEncoding = Encoding.GetEncoding("UTF-8")
                    };
                    var doc3 = doc2.Load(path);
                    scriereXML.WriteStartElement("NumeCarte");
                    string numeCarte = doc3.DocumentNode.SelectNodes("//span[contains(@class, 'base')]")[0].InnerText;
                    scriereXML.WriteString(numeCarte); // numele cartii
                    scriereXML.WriteEndElement(); // inchidem tag-ul de nume carte

                    
                    scriereXML.WriteStartElement("NumeAutor");
                    string autor = doc3.DocumentNode.SelectNodes("//div[contains (@class, 'stock unavailable space')]")[0].InnerText;
                    scriereXML.WriteString(autor);
                    scriereXML.WriteEndElement();
                    
                    //luam sectiunile
                    var htmlNodes = doc3.DocumentNode.SelectNodes("//a[contains(@class, 'data switch')]");
                    int nrNoduri = htmlNodes.Count;

                    //pentru fiecare nod cu tag <a>, nume "data switch"
                    //pentru ca acolo se afla numele de sectiuni pe care vrem sa le afisam
                    scriereXML.WriteStartElement("sectiuni");
                    for (int i = 0; i < nrNoduri; i++)
                    {
                        var node = htmlNodes[i];
                        string numeSectiune;
                        numeSectiune = htmlNodes[i].SelectNodes("//a[contains(@class, 'data switch')]")[i].InnerText;
                        //string numeSectiuneD = System.Net.WebUtility.HtmlDecode(numeSectiune); //decodam pentru limbi straine
                        if (numeSectiune == "Recenzii")
                            descriereCarte = "Nu există recenzii";
 
                        scriereXML.WriteStartElement("sectiune");
                        scriereXML.WriteAttributeString("nume", numeSectiune.ToString());
                   
                        var valoare = htmlNodes[i].SelectNodes("//div[contains(@class, 'value')]");                
                        descriereCarte = valoare[i].InnerText;

                        //am observat ca imi pune continutul de la CITESTE MAI MULT la Detalii, asa ca am luat pe fiecare in parte
                        if(numeSectiune == "CITESTE MAI MULT")
                        {
                            var valoareCiteste = htmlNodes[i].SelectNodes("/html/body/div[3]/main/div[3]/div/div[1]/div/div/div/div/div/div[2]/div/div[2]/div[2]/div/div/div[2]/div/div");
                            descriereCarte = valoareCiteste[i].InnerText;
                        }

                        if(numeSectiune == "Detalii")
                        {
                            //am incercat sa iau toate detaliile din tabelul de detalii, insa imi ia doar primul row
                            var tabelDetalii = htmlNodes[i].SelectNodes("//tbody");
                            foreach (var row in tabelDetalii)
                            {
                                var valoareTH = row.SelectSingleNode("//th[contains(@class, 'col label')]");
                                var valoareTD = row.SelectSingleNode("//td[contains(@class, 'col data')]");
                                descriereCarte = valoareTH.InnerText + valoareTD.InnerText;
                                
                            }
                        }
                        //continut sectiune
                        scriereXML.WriteString(descriereCarte);
                        scriereXML.WriteEndElement();
                        descriereCarte = "";

                    }
                    //inchidem tagul sectiuni
                    scriereXML.WriteEndElement();
                    nrTotalCarti++;
                    //! codul nu afiseaza numarul total de carti in textBox
                    //break;
                }
                catch
                {
                }
            }
           //inchidem tag-ul Bestsellers
            scriereXML.WriteEndElement();
            scriereXML.Close();
            textBox1.Text = nrTotalCarti.ToString();

        }
    }
}
