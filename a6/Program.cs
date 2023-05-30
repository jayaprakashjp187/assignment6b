namespace a6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose what program u want");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    Console.WriteLine("1.MonthleyPaymentProgram");
                    Console.WriteLine("Enter theyears ");
                    int a = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the loan amount: ");
                    int b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the percent interest ");
                    int c = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("The Monthly Payment  is:" + MonthleyPayment.CalculateMonthlyPayment(a, b, c));


                    break;
            }
        }
    }
}