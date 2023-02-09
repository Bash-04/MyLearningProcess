using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVoorbeeld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int getal1 = HaalGetalOp();
            int getal2 = HaalGetalOp();

            int uitkomst = BerekenSom(getal1, getal2);

            Console.WriteLine("De uitkomst is: " + BerekenSom(getal1, getal2));

            if (System.Diagnostics.Debugger.IsAttached) Console.ReadLine();
        }

        public static int HaalGetalOp()
        {
            Console.WriteLine("Geef een getal");
            int getal = Convert.ToInt32(Console.ReadLine());
            return getal;
        }

        public static int BerekenSom(int getal1, int getal2)
        {
            return getal1 + getal2;
        }
    }
}
