using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Maksim";
            string surName = "Makarevic";
            Console.WriteLine(name + ' ' + surName);
            string name1;
            name1 = name;
            name = surName;
            surName = name1;
            Console.WriteLine(name + ' ' + surName);           
        }
    }
}
