namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your raw score: ");
            double rawScore = Convert.ToDouble(Console.ReadLine());

            double roundedscore = Math.Round(rawScore);

            if (roundedscore < 50 )
            {
                Console.WriteLine("Your grade is F");
                Console.WriteLine("You Failed!");
            }
            else if (roundedscore >= 50 && roundedscore <= 69)
            {
                Console.WriteLine("Your grade is D");
                Console.WriteLine("You Passed!");
            }
            else if (roundedscore >= 70 && roundedscore <= 79)
            {
                Console.WriteLine("Your grade is C");
                Console.WriteLine("You Passed!");
            }
            else if (roundedscore >= 80 && roundedscore <= 89)
            {
                Console.WriteLine("Your grade is B");
                Console.WriteLine("You Passed!");
            }
            else if (roundedscore >= 90 && roundedscore <= 100)
            {
                Console.WriteLine("Your grade is A");
                Console.WriteLine("You Passed!");
            }
            else
            {
                Console.WriteLine("Invalid score entered.");
            }
            //
        }
    }
}
