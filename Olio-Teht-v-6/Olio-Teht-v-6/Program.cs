
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_Teht_v_6
{
    /// <summary>
    /// Laskee polttoaineen kulutuksen.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            double kulutus = 7.02;
            double hinta = 1.595;
            Console.Write("Anna matka kilometreinä ");
            string line = Console.ReadLine();
            double matka;
            bool result = Double.TryParse(line, out matka);
            if (result)
            {
                double bensiini = matka / 100 * kulutus;
                double kustannukset = bensiini * hinta;
                Console.WriteLine("Bensiinin kulutus on {0:F2} litraa.", bensiini);
                Console.WriteLine("Kustannukset ovat {0:F2} euroa.", kustannukset);
            }
            else
            {
                Console.WriteLine("Et antanut lukua!");
            }
            Console.ReadLine();
        }
    }
}
