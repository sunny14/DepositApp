


namespace DepositApp
{
    class Program
    {
        public static void Main(String[] args)
        {
            Deposit d = new Deposit(1000, 7);

            int years = 10;
            int depositAfterTenYears = d.getDepositAfter(years);
            Console.WriteLine("After "+years+" years I will have "+depositAfterTenYears+"\n");

            Console.WriteLine("How much money will I have in each year? Here is the answer:");
            d.ShowProgress(years);
        }
    }

}