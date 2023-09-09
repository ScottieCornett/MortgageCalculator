using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageCalculator
{
    public class ConsoleReader
    {
        public static double ReadNumber(string prompt, double min, double max)
        {
            double value;

            while (true)
            {

                Console.Write(prompt);
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Please enter a valid value");
                    continue;
                }

                bool parsed = double.TryParse(input, out value);

                if (parsed && value > min && value <= max)
                    break;

                Console.WriteLine("Please enter a number between " + min + " and " + max);

            }
            return value;
        }


    }
}
