using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    class Program
    {
        static void Main(string[] args)
        {
            Piemeri task1 = new Piemeri();

            int Choice = 1;
            while (Choice != 0)
            {
                Console.WriteLine("Izveleties uzdevumu- 1: (0: Iziet!)");

                Choice = Convert.ToInt16(Console.ReadLine());

                switch (Choice)
                {
                    case 0:

                        break;

                    case 1:
                        task1.Klase();

                        
                        break;
                    case 2:


                        break;
                  

                    default:
                        Console.WriteLine("Nepareiza ievade!");
                        break;
                }
            }

        }
    }
}
