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
        /// Metoda, ktera pomoci rady Jamese Gregoryho
        /// stanovy hodnotu Ludolfova cisla.
        /// </summary>
        /// <param name="n">Pocet iteraci (clenů rady)</param>
        /// <returns>Hodnota pi datoveho typu decimal</returns>
        public static decimal VypocitejPi(uint n)
        {
            decimal soucet = 0;
            decimal pomocna = 0;
            for (int i = 0; i < n; i++)
            {

                pomocna = 4m / (1 + (2 * i));
                //Pro sude koeficienty
                if (i % 2 == 0)
                    soucet += pomocna;
                //Pro liche koeficienty
                else
                    soucet -= pomocna;
            }
            return soucet;
        }
        static void Main(string[] args)
        {
            bool pokracovat = true;
            uint n = 0;
            decimal pi = 0;
            do
            {
                Console.WriteLine("Zadejte počet iterací:");
                try
                {
                    n = uint.Parse(Console.ReadLine());
                    //Stanovení podminky počtu opakovani
                    if (n > 10000000)
                    {
                        //Upozorni uzivatele na spatny vstup
                        Console.WriteLine("Zadejte prosím celé kladné číslo menší než 10 000 000");
                    }
                    else
                        //Spravna hodnota n, ukonci smycku a vypocte pi
                        pokracovat = false;
                }

                catch (Exception e)
                {
                    Console.WriteLine("Zadejte prosím celé kladné číslo menší než 10 000 000");
                }
            }
            while (pokracovat);
            //Provedeni funkce pro uzivatelem zadany pocet iteraci a zaokrouhleni na 8 desetinnych mist
            pi = Math.Round(VypocitejPi(n), 8);
            Console.WriteLine("Hodnota Ludolfova čísla pro {0} iterací je {1}", n, pi);
            Console.WriteLine("Pro ukončení programu stiskněte libovolnou klávesu.");
            Console.ReadKey();
        }
    }
}
