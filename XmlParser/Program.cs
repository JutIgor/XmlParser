using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XmlParser
{
    class Program
    {
        static void Main(string[] args)
        {
            //string result = string.Empty;
            //int cont = 0;
            //using (var reader = XmlReader.Create("Input.xml"))
            //{
            //    while (reader.Read() && cont  < 2)
            //    {
            //        if (reader.Name == "n-document") cont++;
            //    }
            //    XElement el = XNode.ReadFrom(reader) as XElement;
            //}

            string result = string.Empty;
            using (var reader = new StreamReader("Input.xml"))
            {
                int i = 0;
                while (i < 4)
                {
                    result += reader.ReadLine();
                    i++;
                }
            }
            result += "</n-extract-response>";
            var xml = XElement.Parse(result);
            xml.Save("Output.xml");
        }
    }
}
