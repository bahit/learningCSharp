using System;

namespace testConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // First we initial variable to be used in while loop and switch
            // switch statement.
            int menuLevel = 0;
            bool x = true;

            // Use the x variable (which equates to true) to be used as our 
            // "on-off" switch, so that we can exit the while loop.
            while (x)
            {
                switch (menuLevel) // check for user input, goes to cases
                {
                    case 0:
                        Console.WriteLine("Welcome to my app.");
                        Console.WriteLine("Select number from 1 to 3:");
                        Console.WriteLine("1) Go to section 1");
                        Console.WriteLine("2) Go to section 2");
                        Console.WriteLine("3) To quit");
                        // This line below converts user input, which when using
                        // Console.ReadLine() would return a string value,
                        // thus need to be converted to a int using Int32.Parse()
                        menuLevel = Int32.Parse(Console.ReadLine());
                        Console.Clear(); // This command clears the console
                        break;
                    case 1:
                        Console.WriteLine("You are in section 1");
                        Console.WriteLine("Type 0 to return.");
                        Console.WriteLine("Type 3 to quit.");
                        menuLevel = Int32.Parse(Console.ReadLine());
                        break;
                        Console.Clear();
                    case 2:
                        Console.WriteLine("You are in section 2");
                        Console.WriteLine("Type 0 to return.");
                        Console.WriteLine("Type 3 to quit.");
                        menuLevel = Int32.Parse(Console.ReadLine());
                        break;
                        Console.Clear();
                    case 3: // This would exit the loop as x is being check in while loop
                        x = false;
                        break;
                }
            }
            Console.WriteLine("Good bye."); // The app finally stops by showing this
        }
    }
}
