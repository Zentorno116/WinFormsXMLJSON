using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace WinFormsXMLJSON
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            var xmlDoc = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("Transport"));

            foreach (var item in Transport.GetTransports())
            {
                xmlDoc.Root.Add(new XElement("Transport", new XAttribute("Name", item.Name)),
                    new XElement("Transport", new XAttribute("route", item.route)),
                    new XElement("Transport", new XAttribute("Capacity", item.Capacity)),
                    new XElement("Transport", new XAttribute("Speed", item.Speed)),
                    new XElement("Transport", new XAttribute("Cost", item.Cost)));

            }
            xmlDoc.Save(Path.Combine(Environment.CurrentDirectory, "xmlDoc.xml"));

            List<Transport> transportList = new List<Transport>();

            foreach (var item in Transport.GetTransports())
            {
                transportList.Add(item);
            }
            string jsonData = JsonConvert.SerializeObject(transportList);

            File.WriteAllText("Transport.json", jsonData);

            Console.Read();
        }
    }
}


















            /*public partial class MainForm : Form
        {
            public MainForm()
            {
                InitializeComponent();
                LoadData();
            }

            private void LoadData() 
            {

            }
        }
            */
