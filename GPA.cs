using System;

namespace MyFirstApp
{
    class GPA
    {
        public static void Run()
        {
            Console.WriteLine("Enter the number of subjects:");
            int numSubjects = int.Parse(Console.ReadLine());

            double totalGradePoints = 0;
            int totalCreditHours = 0;

            for (int i = 0; i < numSubjects; i++)
            {
                Console.WriteLine($"Enter the grade for subject {i + 1} (in points, e.g., 4 for A, 3 for B, etc.):");
                double grade = double.Parse(Console.ReadLine());

                Console.WriteLine($"Enter the credit hours for subject {i + 1}:");
                int creditHours = int.Parse(Console.ReadLine());

                totalGradePoints += grade * creditHours;
                totalCreditHours += creditHours;
            }

            double gpa = totalGradePoints / totalCreditHours;

            Console.WriteLine($"Your GPA is: {gpa:F2}");
        }
    }
}
