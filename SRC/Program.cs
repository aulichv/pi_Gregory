using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semestralka_konsole
{
    class Program
    {
        /// <summary>
        /// Metoda, která pomocí řady Jamese Gregoryho
        /// stanový hodnotu Ludolfova čísla.
        /// </summary>
        /// <param name="n">Počet iterací (členů řady)</param>
        /// <returns>Hodnota pi datového typu decimal</returns>
        public static decimal VypocitejPi(uint n)
        {
            decimal soucet = 0;
            decimal pomocna = 0;
            for (int i = 0; i < n; i++)
            {

                pomocna = 4m / (1 + (2 * i));
                //Pro sudé koeficienty
                if (i % 2 == 0)
                    soucet += pomocna;
                //Pro liché koeficienty
                else
                    soucet -= pomocna;
            }
            return soucet;
        }
        static void Main(string[] args)
        {
            bool pokracovat = true;
            uint n = 0;
            do
            {
                Console.WriteLine("Zadejte počet iterací:");
                try
                {
                    n = uint.Parse(Console.ReadLine());
                    //Stanovení podmínky počtu opakování
                    if (n > 1000)
                    {
                        //Upozorní uživatele na špatný vstup
                        Console.WriteLine("Zadejte prosím celé kladné číslo menší než 1 000");
                    }
                    else
                        //Správná hodnota n, ukončí smyčku a vypočte pi
                        pokracovat = false;
                }

                catch (Exception e)
                {
                    Console.WriteLine("Zadejte prosím celé kladné číslo menší než 1 000");
                }
            }
            while (pokracovat);
            //Provedení funkce pro uživatelem zadaný počet iterací
            Console.WriteLine("Hodnota Ludolfova čísla pro {0} iterací je {1}", n, VypocitejPi(n));
            Console.ReadKey();
        }
    }
}
