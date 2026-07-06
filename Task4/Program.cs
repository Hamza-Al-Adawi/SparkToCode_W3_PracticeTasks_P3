namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thanks For Subscription! ");

            DateTime alyoom = DateTime.Today;
            DateTime nextMonth = alyoom.AddDays(30);

            Console.WriteLine("Your subscription will expire on: " + nextMonth );
        }
    }
}
