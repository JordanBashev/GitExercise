using System;

namespace GitExercise
{
    public class Startup
    {
        public static void Main()
        {
            bool IsAuthorized = true;

            if(!IsAuthorized)
            {
                Console.WriteLine("Access Denied");
                Console.ReadKey(true);
                return;
            }


            Console.WriteLine("Console Calculator App");
            Console.WriteLine(new string('-', 15));

            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            Console.WriteLine("Choose one from the listed options:");
            foreach (string option in OptionsManager.OptionsList)
            {
                Console.WriteLine($"\t{option}");
            }

            Console.Write("Option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "a":
                    OptionsManager.Add(a, b);
                    break;
                case "s":
                    OptionsManager.Subtract(a, b);
                    break;
                case "m":
                    OptionsManager.Multiply(a, b);
                    break;
                case "d":
                    OptionsManager.Divide(a, b);
                    break;
                case "sabs":
                    OptionsManager.SubstracAbs(a, b);
                    break;
            }

            Console.WriteLine("Press any key to close the app...");
            Console.ReadKey(true);
        }

        private static bool CheckCredentials()
        {
            Console.WriteLine("Please Type in password to gain access");
            string pass = Console.ReadLine();
            Console.Clear();


            return  pass == Password;
        }

        private static string Password = "abcd1234";
    }
}
