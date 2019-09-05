using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufzaelung
{
    class Program
    {

        static void Main(string[] args)
        {
            foreach (var item in Enum.GetValues(typeof(Farben)))
            {
                Console.WriteLine(item);

            }
            foreach (int item in Enum.GetValues(typeof(Farben)))
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

     

     
    }

        enum Farben
        {
            Rot = 1,
            Gelb = 2,
            Gruen = 3,
            Blau = 4
        }
}
