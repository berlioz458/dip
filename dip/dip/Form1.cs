using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace dip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string pathXML = @"C:\dip\dip\dip\dip\data.xml";
            
            if (File.Exists(pathXML))
            {
                XmlDocument XmlDoc = new XmlDocument();
                XmlDoc.Load(pathXML);
                XmlElement root = XmlDoc.DocumentElement;

                foreach (XmlNode i in root)
                {
                    
                }
            }
        }
    }
}
