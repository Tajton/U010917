using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U010917
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mening här:");

            String svar = Console.ReadLine();

            String[] s = svar.Split(' ');

            Console.WriteLine(s.Length);

            
            foreach (var word in s)
            {
                Console.WriteLine(word +' ' + word.Length);

            }

           
            

        }
    }
}
