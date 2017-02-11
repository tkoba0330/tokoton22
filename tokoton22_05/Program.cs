using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace tokoton22_05
{
    class Program
    {
        static void Main(string[] args)
        {
            XNamespace ex = "http://www.piedey.co.jp/example/linqtoxml201003";

            XElement names = new XElement(ex + "names",
                new XAttribute("id","M0001"),
                new XElement(ex + "name","一郎")
                );

            Console.WriteLine(names.ToString());

            Console.ReadLine();
        }
    }
}
