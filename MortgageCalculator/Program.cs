namespace MortgageCalculator
{
    public class Program
    {    
            public static void Main(string[] args)
            {
                Menu.GreetUser();

                int principal = (int)ConsoleReader.ReadNumber("Principal: ", 1000, 5000000);
                float annualInterest = (float)ConsoleReader.ReadNumber("Annual Interest Rate: ", 0, 30);
                byte years = (byte)ConsoleReader.ReadNumber("Period (Years): ", 0, 100);

                
                MortgageReport.PrintMortgage(principal, annualInterest, years);
                State.Compare();
                Console.WriteLine();
                MortgageReport.PrintPaymentSchedule();

            }

        
    }
}