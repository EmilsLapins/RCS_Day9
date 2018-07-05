using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    class Piemeri
    {
        public void Klase()
        {
            // Telpa, 12 vietas. 
            // Ievadi vai attiecigais sols ir tukss vai nav tukss?  Tuksa vieta - 0, vai vards []
            // Jaizvada
            // Izvada visus vardus, ieskaitot nulles,
            // ekstra - izvada tikai pilnas vietas.

            string[] Vietas = new string[12];

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("Pilns (Raksti vardu) vai tukss (raksti: 0)?");
                Vietas[i] = Console.ReadLine();
                
            }

            for (int i = 11; i >= 0; i--)
            {
                if (Vietas[i] != "0")
                {
                    Console.WriteLine("Seit atroad: " + Vietas[i]);
                }
                
            }


                Console.WriteLine("Debug: End");

        }
    }
}
