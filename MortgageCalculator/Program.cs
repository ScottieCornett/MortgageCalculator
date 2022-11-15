namespace MortgageCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Menu.GreetUser();
            while (true)
            {

                int principal = (int)ConsoleReader.ReadNumber("Principal: ", 1000, 5000000);
                float annualInterest = (float)ConsoleReader.ReadNumber("Annual Interest Rate: ", 0, 30);
                byte years = (byte)ConsoleReader.ReadNumber("Period (Years): ", 0, 100);


                MortgageReport.PrintMortgage(principal, annualInterest, years);
                State.Compare();
                Console.WriteLine();
                MortgageReport.PrintPaymentSchedule();
                Console.WriteLine("Would you like to calculate another loan? Press 1 to continue or enter to exit \n");
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                    break;
                else if (input == "1")
                    continue;
                else
                    Console.WriteLine("Please enter a valid input");

            }

        }
    }
}