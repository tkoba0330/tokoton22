using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace tokoton22_01
{
    class Program
    {
        private const string xmldoc =
            @"<?xml version='1.0'?>
<names xmlns='http://www.piedey.co.jp/example/linqtoxml201003'>
    <name id='M0001'>一郎</name>
    <name id='M0001'>次郎</name>
    <name id='F0001'>花子</name>
</names>
";

        static void Main(string[] args)
        {
            var dom = new XmlDocument();
            dom.LoadXml(xmldoc);

            foreach(XmlElement node in dom.GetElementsByTagName("name",
                "http://www.piedey.co.jp/example/linqtoxml201003"))
            {
                if(node.Attributes["id"].Value.StartsWith("M"))
                {
                    Console.WriteLine(node.InnerText);
                }
            }

            Console.ReadLine();

        }
    }
}
