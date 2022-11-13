using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageCalculator
{
    public class MortgageReport
    {
        private static MortgageCalculator? calculator;

        public static void PrintMortgage(int principal, float annualInterest, byte years)
        {
            calculator = new MortgageCalculator(principal, annualInterest, years);
            double mortgage = calculator.CalculateMortgage();
            string mortgageFormatted = mortgage.ToString("C");
            Console.WriteLine();
            Console.WriteLine("MORTGAGE");
            Console.WriteLine("--------");
            Console.WriteLine("MORTGAGE PAYMENT: " + mortgageFormatted);
        }

        public static void PrintPaymentSchedule()
        {

            Console.WriteLine();
            Console.WriteLine("PAYMENT SCHEDULE");
            Console.WriteLine("----------------");

            for (short month = 1; month <= calculator.GetNumberOfPayments(); month++)
            {

                double balance = calculator.CalculateBalance(month);
                var displayBalance = balance.ToString("C");
                Console.WriteLine(displayBalance + " " + "Payment number: " + month);
            }

        }

    }
}
