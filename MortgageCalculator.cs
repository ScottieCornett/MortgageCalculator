using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageCalculator
{
    public class MortgageCalculator
    {
        private int principal;
        private float annualInterest;
        private byte years;
        private const byte MONTHS_IN_YEAR = 12;
        private const byte PERCENT = 100;

        public MortgageCalculator(int principal, float annualInterest, byte years)
        {
            this.principal = principal;
            this.annualInterest = annualInterest;
            this.years = years;
        }

        public double CalculateBalance(short numberOfPaymentsMade)
        {
            var monthlyInterest = GetMonthlyInterest();
            int numberOfPayments = GetNumberOfPayments();

            double balance = principal
                * (Math.Pow(1 + monthlyInterest, numberOfPayments) - Math.Pow(1 + monthlyInterest, numberOfPaymentsMade))
                / (Math.Pow(1 + monthlyInterest, numberOfPayments) - 1);
            return balance;
        }
        public double CalculateMortgage()
        {
            var numberOfPayments = GetNumberOfPayments();
            float monthlyInterest = GetMonthlyInterest();


            double mortgage = principal
                * (monthlyInterest * Math.Pow(1 + monthlyInterest, numberOfPayments))
                / (Math.Pow(1 + monthlyInterest, numberOfPayments) - 1);
            return mortgage;

        }

        public float GetMonthlyInterest()
        {
            float monthlyInterest = annualInterest / PERCENT / MONTHS_IN_YEAR;
            return monthlyInterest;
        }

        public int GetNumberOfPayments()
        {
            int numberOfPayments = years * MONTHS_IN_YEAR;
            return numberOfPayments;
        }


    }
}
