using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppgiftF
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int randnum = r.Next(1, 21);
            Console.WriteLine("Gissa på ett nummer mellan 1 - 21");
            int n = int.Parse(Console.ReadLine());
            

            while(n != randnum)
            {
                Console.WriteLine("Gissa på ett nummer mellan 1 - 21");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Grattis, du gissade rätt!");




        }
    }
}
