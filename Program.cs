using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace orai_munka_2.feladat
{
    internal class Program
    {
        public static void Udvozol()
        {
            int hour = DateTime.Now.Hour;
            if (hour >= 5 && hour < 12)
            {
                Console.WriteLine("Jó reggelt.");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("Jó napot.");
            }
            else if (hour >= 18 && hour < 4)
            {
                Console.WriteLine("Jó estét.");
            }
        }
        public static void Bank()
        {
            Console.Write("Mennyi pénzt tesz be a bankba?: ");
            string pénz = Console.ReadLine();
            Console.Write("Hány évre rakja be?: ");
            string ev = Console.ReadLine();

            Console.WriteLine("A betétel után {0} forint marad.");

        }
        static void Main(string[] args)
        {
            Udvozol();
            Bank();
        }
    }
}
