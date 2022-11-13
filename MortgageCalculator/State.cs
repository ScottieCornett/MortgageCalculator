using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageCalculator
{
    public class State
    {
        public string Name { get; set; }
        public int MonthlyPayment { get; set; }

        public static void Compare()
        {
            Console.WriteLine();
            Console.WriteLine("**************US DATA************ ");
            Console.WriteLine("**FROM CHEAPEST TO MOST EXPENSIVE**");
            Console.WriteLine("*********************************");
            Console.WriteLine();
            var states = new StateRepository().GetStates();
            var statelist = states.OrderBy(s => s.MonthlyPayment);
            foreach (var state in statelist)
                Console.WriteLine(state.Name + " " + state.MonthlyPayment.ToString("C"));
        }
    }

}
