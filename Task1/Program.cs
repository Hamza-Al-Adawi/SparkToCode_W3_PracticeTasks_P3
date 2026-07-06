namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter the first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("please enter the second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            
            int xzx = Math.Abs(secondNumber - firstNumber);     
            
            
            //this will print the final result as a positive integer                            
            
            
            
            //math.abs() method is used to get the absolute value of the difference between the two numbers

            Console.Write("final result as a positive integer is :" +xzx);
        }
        //
    }
}
