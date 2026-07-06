namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter Your full name: ");
            String name = Console.ReadLine();

            string Up = name.ToUpper(); 
            string Low = name.ToLower();
            int count = name.Length;
            
            Console.WriteLine(Up);
            Console.WriteLine(Low);
            Console.WriteLine("Total number of characters in your name is: " + count);

        }
    }//
}
