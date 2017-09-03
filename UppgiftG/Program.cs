using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppgiftG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en mening här: ");

            string s = Console.ReadLine();

            s = s.Replace('a', '@').Replace("b","|3").Replace("elit", "1337")
                .Replace('l','1').Replace("o", "()").Replace('e','3')
                .Replace('c','<');

            Console.WriteLine("Din mening i leet speak: \n" + s);
        }
    }
}
