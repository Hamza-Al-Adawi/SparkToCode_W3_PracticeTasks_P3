namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            Console.Write("please enter a password: ");
            string password = Console.ReadLine();

            int length = password.Length;

            bool isLengthValid = length >= 8;
            bool isForbiddenWord = password.ToLower().Contains("password");
            bool containsTolower = password.Any(char.IsLower);
            bool containsUpper = password.Any(char.IsUpper);

            if (isLengthValid && !isForbiddenWord && containsTolower && containsUpper)
            {
                Console.WriteLine("Strong: Password is valid.");
            }
            else
            {
                Console.WriteLine("Weak: ");
                if (length < 8)
                {
                    Console.WriteLine("- Password is too short. Please choose a password with at least 8 characters.");
                }
                if (isForbiddenWord)
                {
                    Console.WriteLine("- Password is too common. Please choose a different password.");
                }
                if (!containsTolower || !containsUpper)
                {
                    Console.WriteLine("- Password must contain both uppercase and lowercase letters.");
                }
            }
        }
    }
}
