using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___AnnoyingDependencies
{
    /*
     * Øvelse 2 - Irriterende afhængigheder
     * 
     * Dette lille program tager en dato som argument, og svarer med antal dage der er gået siden da.
     * 
     * Følgende skal unit testes
     * 1. At AgeCalculator regner antal dage siden den pågældende dag korrekt
     * 2. At de to kald til log4net bliver kaldt med den rigtige tekst (ikke integrationstest, så test at AgeCalculatoren logger de to linjer er godt nok)
     * 
     * For at gøre dette er det nødvendigt at ændre designet sådan at det er muligt at unit teste dette.
     * Dette kræver afkobling af DateTime.now samt Logningen
     */
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("The first parameter should be a date in the format 'dd/mm/yyyy'");
                return;
            }

            AgeCalculator.CalculateAgeInDays(args[0]);

            Console.ReadKey();
        }
    }
}
