using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositApp
{
    public class Deposit
    {
        //the amount of money in the deposit on its start
        private int initialAmount;

        //annual revenue in %
        //Example: annualRevenue = 7 stands for 7% revenue in a year
        private int annualRevenue;

        /*
         * default constructor
         * sets initial deposit to 1000 and annual revenue to 7%
         */
        public Deposit()
        {
            initialAmount = 1000;
            annualRevenue = 7;
        }

        /*
         * constructor
         * gets initial amount and annual revenue and sets them to deposit
         */
        public Deposit(int amount, int revenue)
        {
            initialAmount = amount;
            annualRevenue = revenue;
        }

        /*
         * gets number of years
         * returns a deposit after these years
         * example: getDepositAfter(10) returns how much money will be in the deposit after 10 years
         */
        public int getDepositAfter(int years)
        {
            int total = initialAmount;
            do
            {
                total = total + total * annualRevenue / 100;
                years--;
            } while (years > 0);

            return total;
        }

        /*
         * gets number of years
         * prints ho much money will be in the deposit in each year
         */
        public void ShowProgress(int years)
        {
            int total = initialAmount;
            Console.Write(total);

            do
            {
                total = total + total * annualRevenue / 100;
                years--;
                Console.Write(","+total);
            } while (years > 0);

            Console.WriteLine("\n");
        }  

    }
}
