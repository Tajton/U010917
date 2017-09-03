using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppgiftB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mening här:");

            string svar = Console.ReadLine();

            String[] s = svar.Split(' ');

            Array.Sort(s, (x, y) => x.Length.CompareTo(y.Length));

            foreach (String str in s)
                Console.WriteLine(str);

            Console.WriteLine("\n");

            Array.Reverse(s);

            foreach (String str in s)
                Console.WriteLine(str);
        }
    }
}
