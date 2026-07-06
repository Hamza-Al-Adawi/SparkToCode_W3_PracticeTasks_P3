namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a name: ");
            string name = Console.ReadLine();

            Console.Write("Please enter same name: ");
            string name2 = Console.ReadLine();

            string n1 = name.Trim();
            string n2 = name2.Trim();

            bool nlnu = name.ToUpper() == name2.ToUpper();
            bool nlnu2 = name.ToLower() == name2.ToLower();

            if (name == name2 || n1 == n2 || nlnu || nlnu2)
            {
                Console.WriteLine(" Match ");
            }
            //
            else
            {
                Console.WriteLine(" Not Match ");
            }

            Console.WriteLine("---------------------------------------");
            Console.Write("do you want to open program again (y/n)? -- ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("---------------------------------------");
            string answer = Console.ReadLine();

            if (answer == "y")
            {
                Console.WriteLine("Ok !");
                Console.WriteLine("--");
                Console.WriteLine("--");
                Main(args);
            }
            else if (answer == "n")
            {
                Console.Write("Thanks For Using This Program !");
                Console.WriteLine("--");
                Console.WriteLine("--");
            }
            else
            {
                Console.Write("Invalid Input !");
                Console.WriteLine("--");
                Console.WriteLine("--");
            }
        }
    }
}
