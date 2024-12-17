using System;
using System.Xml.XPath;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the type of input you want to enter (int, double, string, date, displays string):");
            string choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "int":
                    Console.WriteLine("Enter an integer:");
                    int intValue = int.Parse(Console.ReadLine());
                    int result = 3 + 1 * 5 / 2;
                    Console.WriteLine($"You entered: {result} dif {intValue} ");
                    break;

                case "double":
                    Console.WriteLine("Enter a double:");
                    double doubleValue = double.Parse(Console.ReadLine());
                    Console.WriteLine($"You entered: {doubleValue}");
                    break;

                case "string":
                    Console.WriteLine("Enter a string:");
                    string stringValue = Console.ReadLine();
                    Console.WriteLine($"You entered: {stringValue}");
                    break;

                case "date":
                    Console.WriteLine("Enter a date (e.g., 2023-12-31):");
                    DateTime dateValue = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine($"You entered: {dateValue.ToShortDateString()}");
                    break;

                case "format":
                   string firstName = "Bob";
                   string greeting = "Hello";
                 Console.WriteLine(greeting + " " + firstName + "!");
                 break;


                default:
                    Console.WriteLine("Invalid choice. Please select a valid datatype.");
                    break;
            }
            exa2.Run();
            AnotherFile.Run();
        }
    }
}
