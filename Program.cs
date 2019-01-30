using System;

namespace ConsoleApp1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("charity");
            Console.Write("2019");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine("visionn2030");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("world investment");
            Console.Title = "financial risk";
            Console.Clear();
            Console.WriteLine("enter your name");

            string name = Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine("password");
            string password = Console.ReadLine();
            Console.WriteLine(password);
            Console.Clear();
            Console.WriteLine(name);
            Console.WriteLine(password);
            Console.ReadKey();
         }
        
    }
    
}
