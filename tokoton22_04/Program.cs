using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace tokoton22_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string ns = "http://www.piedey.co.jp/example/linqtoxml201003";

            var doc = new XmlDocument();
            var names = doc.CreateElement("names", ns);
            doc.AppendChild(names);
            names.SetAttribute("id", "M0001");

            var name = doc.CreateElement("name", ns);
            name.InnerText = "一郎";
            names.AppendChild(name);

            Console.WriteLine(doc.OuterXml);

            Console.ReadLine();
        }
    }
}
