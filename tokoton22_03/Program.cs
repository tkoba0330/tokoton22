using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace tokoton22_03
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
            var doc = XElement.Parse(xmldoc);
            XNamespace ex = "http://www.piedey.co.jp/ecxample/linqtoxml201003";

            var q = doc.Descendants(ex + "name").Where(x => x.Attribute("id").Value.StartsWith("M"));

            foreach(var element in q)
            {
                Console.WriteLine(element.Value);
            }

            Console.ReadLine();

        }
    }
}
