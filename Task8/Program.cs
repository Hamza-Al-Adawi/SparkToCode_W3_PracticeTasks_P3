namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a today's date (e.g. 2026-01-10) ");
            string inputDate = Console.ReadLine();

            Console.WriteLine("Please enter the number of valid membership days");
            int validDays = int.Parse(Console.ReadLine());

            DateTime startDate = DateTime.Parse(inputDate);
            DateTime endDate = startDate.AddDays(validDays);

            DateTime yyy = DateTime.Today;

            if (endDate >= yyy)
            {
                Console.WriteLine("Acitve will expire in " + endDate);
            }
            else if (endDate <= yyy)
            {
                Console.WriteLine("Expired from " + endDate);
            }
        }
    }
}
