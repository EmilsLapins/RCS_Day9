using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    class Piemeri
    {
        string[] Vietas = new string[12];

        public void Ievade()
        {
            // Telpa, 12 vietas. 
            // Ievadi vai attiecigais sols ir tukss vai nav tukss?  Tuksa vieta - 0, vai vards []
            // Jaizvada
            // Izvada visus vardus, ieskaitot nulles,
            // ekstra - izvada tikai pilnas vietas.
            
        string Empty = (Vietas[0]);


            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("Pilns (Raksti vardu) vai tukss (raksti: 0)?");
                Vietas[i] = Console.ReadLine();

            }
            Console.WriteLine("Debug: End");

        }
        public void Print() { 

            for (int i = 0; i < 12; i++)
            {
                if (Vietas[i] != "0" )
                {
                    
                    Console.WriteLine((i + 1) + ". Seit atrodas: " + Vietas[i]);
                }
                else
                {
                    if (Vietas[i] == "0")
                    {
                        Console.WriteLine("Jaievada vertibas!");
                        break;

                    }
                   /* else
                    {

                        if (Vietas[i] == "")
                        {
                            Console.WriteLine("Jaievada vertibas!");
                            break;
                        }
                    }
                    */

                }
            }
            
                Console.WriteLine("Debug: End");

        }
        public void Izdzest()
        {
            Console.WriteLine("Izdzesam masivu!");
            for (int i = 0; i < 12; i++)
            {
                Vietas[i] = "0";
            }
            //for (int i = 0; i < 12; i++)
            //{
            //    Console.WriteLine((i+1) + ": Seit atrodas: " + Vietas[i]);
            //}
            Console.WriteLine("Debug: End");

        }


    }
}
