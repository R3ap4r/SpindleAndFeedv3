using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SpindleAndFeedv3
{
    class Program
    {
        private static void Main()
        {
            ISpindleAndFeedCalculator berekening = Factory.SpindleAndFeed();

            
            double diameter = Scherm("Geef de diameter in : ");


            double vsnelheid = Scherm("\nGeef de v snelheid in : ");


            double spindleSnelheid = berekening.Spindle(diameter, vsnelheid);

            
            Console.WriteLine($"\n\nSpindle snelheid is {spindleSnelheid:F2}");

            double tanden = Scherm("\nGeef het aantal tanden in: ");
            double voedingTand = Scherm("\nGeef de voeding per tand in: ");

            int feedSnelheid = Convert.ToInt32(berekening.Feed(spindleSnelheid, tanden, voedingTand));

            Console.WriteLine($"\nFeed snelheid is {feedSnelheid:F2}");

            Console.ReadLine();
        }

        public static double Scherm (string tekst)
        {
            Console.Write($"{tekst}");
            string inputbegin = Console.ReadLine();
            double output = Controleer(inputbegin);
            return output;
            
        }

        public static double Controleer (string controle)
        {
            double waarde = 0;
            string tekstControleBijna = Regex.Replace(controle, "[^0-9.,]", "");
            string tekstControle = Regex.Replace(tekstControleBijna, "[.]",",");
            bool dubbel = double.TryParse(tekstControle,out _);

            

            if (dubbel && (tekstControle.Length > 0))
            {
                waarde = Convert.ToDouble(tekstControle);
                
                
            }
            else
            {
                Console.WriteLine("Geen/foutieve waarde ingegeven, einde programma");

                Console.ReadLine();

                Environment.Exit(0);
            }

            return waarde;
            
            
        }
    }

   


}
