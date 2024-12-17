using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from Program!");

            // Call the method from AnotherFile
            AnotherFile.Run();
        }
    }
}
