


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
            //After 10 years I will have 1961

            Console.WriteLine("How much money will I have in each year? Here is the answer:");
            d.ShowProgress(years);

            //How much money will I have in each year? Here is the answer:
            //1000,1070,1144,1224,1309,1400,1498,1602,1714,1833,1961

        }
    }

}