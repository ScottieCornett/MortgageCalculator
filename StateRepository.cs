using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageCalculator
{
    public class StateRepository
    {
        public IEnumerable<State> GetStates()
        {
            return new List<State>
            {
                new State { Name = "Alabama", MonthlyPayment = 974 },
                new State { Name = "Alaska", MonthlyPayment = 1652 },
                new State { Name = "Arizona", MonthlyPayment = 2128 },
                new State { Name = "Arkansas", MonthlyPayment = 852 },
                new State { Name = "California", MonthlyPayment = 3906 },
                new State { Name = "Colorado", MonthlyPayment = 2880 },
                new State { Name = "Connecticut", MonthlyPayment = 1842 },
                new State { Name = "Delaware", MonthlyPayment = 1704 },
                new State { Name = "Florida", MonthlyPayment = 1872 },
                new State { Name = "Georgia", MonthlyPayment = 1483 },
                new State { Name = "Hawaii", MonthlyPayment = 4901 },
                new State { Name = "Idaho", MonthlyPayment = 2262 },
                new State { Name = "Illinois", MonthlyPayment = 1296 },
                new State { Name = "Indiana", MonthlyPayment = 1061 },
                new State { Name = "Iowa", MonthlyPayment = 936 },
                new State { Name = "Kansas", MonthlyPayment = 1007 },
                new State { Name = "Kentucky", MonthlyPayment = 952 },
                new State { Name = "Louisiana", MonthlyPayment = 1045 },
                new State { Name = "Maine", MonthlyPayment = 1727 },
                new State { Name = "Maryland", MonthlyPayment = 2031 },
                new State { Name = "Massachusetts", MonthlyPayment = 2913 },
                new State { Name = "Michigan", MonthlyPayment = 1126 },
                new State { Name = "Minnesota", MonthlyPayment = 1661 },
                new State { Name = "Mississippi", MonthlyPayment = 792 },
                new State { Name = "Missouri", MonthlyPayment = 1104 },
                new State { Name = "Montana", MonthlyPayment = 2133 },
                new State { Name = "Nebraska", MonthlyPayment = 1166 },
                new State { Name = "Nevada", MonthlyPayment = 2249 },
                new State { Name = "New Hampshire", MonthlyPayment = 2151 },
                new State { Name = "New Jersey", MonthlyPayment = 2297 },
                new State { Name = "New Mexico", MonthlyPayment = 1404 },
                new State { Name = "New York", MonthlyPayment = 1789 },
                new State { Name = "North Carolina", MonthlyPayment = 1490 },
                new State { Name = "North Dakota", MonthlyPayment = 1381 },
                new State { Name = "Ohio", MonthlyPayment = 1019 },
                new State { Name = "Oklahoma", MonthlyPayment = 865 },
                new State { Name = "Oregon", MonthlyPayment = 2565 },
                new State { Name = "Pennsylvania", MonthlyPayment = 1295 },
                new State { Name = "Rhode Island", MonthlyPayment = 2128 },
                new State { Name = "South Carolina", MonthlyPayment = 1361 },
                new State { Name = "South Dakota", MonthlyPayment = 1399 },
                new State { Name = "Tennessee", MonthlyPayment = 1376 },
                new State { Name = "Texas", MonthlyPayment = 1460 },
                new State { Name = "Utah", MonthlyPayment = 2784 },
                new State { Name = "Vermont", MonthlyPayment = 1721 },
                new State { Name = "Virginia", MonthlyPayment = 1839 },
                new State { Name = "Washington", MonthlyPayment = 3052 },
                new State { Name = "West Virginia", MonthlyPayment = 648 },
                new State { Name = "Wisconsin", MonthlyPayment = 1285 },
                new State { Name = "Wyoming", MonthlyPayment = 1551}
            };
            
         }
    }
}
