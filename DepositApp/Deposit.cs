using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositApp
{
    class Deposit
    {
        //the amount of money in the deposit on its start
        private int InitialAmount;

        //annual revenue in %
        //Example: Revenue = 7 stands for 7% revenue in a year
        private int AnnualRevenue;

        public Deposit()
        {
            InitialAmount = 1000;
            AnnualRevenue = 7;
        }

        public Deposit(int amount, int revenue)
        {
            InitialAmount = amount;
            AnnualRevenue = revenue;
        }

        public int getDepositAfter(int years)
        {
            int total = InitialAmount;
            do
            {
                total = total + total * AnnualRevenue / 100;
                years--;
            } while (years > 0);

                return total;
        }

        public void ShowProgress(int years)
        {
            int total = InitialAmount;
            Console.Write(total);

            do
            {
                total = total + total * AnnualRevenue / 100;
                years--;
                Console.Write(","+total);
            } while (years > 0);

            Console.WriteLine("\n");
        }  

    }
}
