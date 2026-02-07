using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== C# LEARNING EXAMPLES ===\n");
            
            // User Input Example
            Console.WriteLine("What's your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("What's your age? ");
            int age = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"Hello {name}!");
            Console.WriteLine($"You're learning C# at age: {age}");
            age += 1;
            Console.WriteLine($"Next year you'll be {age}");
            Console.WriteLine("Let's build something great!\n");
            
            // Run organized examples
            Examples.DataTypesExample();
            Examples.ConstantsExample();
            Examples.StringOperationsExample();
            
            Console.WriteLine("\n\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}

