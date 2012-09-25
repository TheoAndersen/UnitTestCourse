using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___AnnoyingDependencies
{
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
