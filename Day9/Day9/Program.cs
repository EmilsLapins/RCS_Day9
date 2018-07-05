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
                Console.WriteLine("Izveleties uzdevumu- 1: RaditMasivu 2: Printet vertibas 3: Izdzest vertibas (0: Iziet!)");

                Choice = Convert.ToInt16(Console.ReadLine());

                switch (Choice)
                {
                    case 0:

                        break;

                    case 1:
                        task1.Ievade();

                        
                        break;
                    case 2:
                        task1.Print();

                        break;
                      
                    case 3:
                        task1.Izdzest();

                        break;



                    default:
                        Console.WriteLine("Nepareiza ievade!");
                        break;
                }
            }

        }
    }
}
