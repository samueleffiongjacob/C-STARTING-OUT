using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("what your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            /* we started out with the defining string function and number 
                - string name = "samuel";
                - int age = 20;
                */

            Console.WriteLine("Hello World!" + name);
            Console.WriteLine("am learing c# at age :" + age);
            age += 1;
            Console.WriteLine("c is awesome" + age);
            Console.Write("lets build something great \n");
            Console.Write("what do you think?");
            Console.ReadLine();

        }
    }


    // number 
}
// GFGJSHJSJHJHDVHJDS

