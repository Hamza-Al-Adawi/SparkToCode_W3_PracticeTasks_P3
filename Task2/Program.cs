namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter a number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());


            double sss = Math.Sqrt(firstNumber);
            double ppp = Math.Pow(firstNumber,   2);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("-- Squre Root of the number (" +firstNumber+ ") is : " + sss );
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("-- The power of number (" + firstNumber + ") is : " + ppp );
            Console.WriteLine("");
            Console.WriteLine("");
            //
          
        }
    }
}
