using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace tokoton22_02
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

            var nsmgr = new XmlNamespaceManager(dom.NameTable);
            nsmgr.AddNamespace("ex", "http://www.piedey.co.jp/example/linqtoxml201003");

            var nodes = dom.SelectNodes("//ex:name[starts-with(@id,'M')]", nsmgr);
            foreach(XmlElement node in nodes)
            {
                Console.WriteLine(node.InnerText);
            }

            Console.ReadLine();

        }
    }
}
