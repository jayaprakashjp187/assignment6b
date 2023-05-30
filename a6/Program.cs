namespace a6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.MonthleyPaymentProgram\n2.squareroot program\n3.");
            Console.WriteLine("choose what program u want");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    Console.WriteLine("welcome to the MonthleyPaymentProgram");
                    Console.WriteLine("Enter theyears ");
                    int a = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the loan amount: ");
                    int b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the percent interest ");
                    int c = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("The Monthly Payment  is:" + MonthleyPayment.CalculateMonthlyPayment(a, b, c));


                    break;
                  case 2:
                    Console.WriteLine("welcome to the square root program");
            
                    double k = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Square root: " + SquareRoot.FindingSqrt(k));
                  
                    Console.WriteLine();
                    break;
                  case 3:
                    Console.WriteLine("welcome to the binary program");
                    Console.Write("Enter a decimal number (To Convert it into Binary): ");
                    int i = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Binary representation of the given decimal number: " + ToBinaryConversion.ToBinary(i));
                   
                    break;
            }
        }
    }
}