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
        static void Main()
        {
            ISpindleAndFeedCalculator berekening = Factory.SpindleAndFeed();

            
            double diameter = Scherm("Geef de diameter in : ");

            Console.WriteLine(diameter);

            double vsnelheid = Scherm("Geef de v snelheid in : ");

            Console.WriteLine(vsnelheid);
            Console.ReadLine();




            double spindleSnelheid = (berekening.Spindle(diameter, vsnelheid));
            double tanden = 6, voedingTand= 0.12;
            
            Console.WriteLine($"Spindle snelheid is {spindleSnelheid:0:3}");

            int feedSnelheid =Convert.ToInt32(berekening.Feed(spindleSnelheid, tanden, voedingTand));

            Console.WriteLine($"\nFeed snelheid is {feedSnelheid}");

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

            Console.WriteLine(dubbel);

            Console.ReadLine();

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

    public static class Factory
    {
        public static ISpindleAndFeedCalculator SpindleAndFeed()
        {
            return new SpindleAndFeedCalculator();
        }
    }


}
