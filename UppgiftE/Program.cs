using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppgiftE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv in några ord, skriv AVSLUTA när du är klar");

            string s = string.Empty;
            string ny;
            

            do
            {
                ny = Console.ReadLine();
                s += ny + ' ';
                //if (ny == "AVSLUTA") kom inte på hur jag skulle exkludera AVSLUTA.
                    
                    
                    
                
                    
                     
                    
            } while (ny != "AVSLUTA");
           
                
                Console.WriteLine(s);
            



        }
    }
}
