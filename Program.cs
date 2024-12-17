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
                 
                case "7":
                   string projectName = "ACME";
                   string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
                   Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

                   string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
                   string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
                   Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");
                   break; 

                case "maths":
                maths.tempra();
                maths.indec();
                maths.impl();
                maths.Run();   
                break;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid datatype.");
                    break;
            }
           
        }
    }
}
