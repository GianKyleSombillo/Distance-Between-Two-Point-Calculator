using System;

class Program
{
    static void Main(string[] args)
    {
        // Introduction
        Console.WriteLine("Welcome to the Distance Between Two Points Calculator!");

        // Get coordinates of the first point (x1, y1)
        Console.Write("Enter the x-coordinate of the first point: ");
        double x1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the y-coordinate of the first point: ");
        double y1 = Convert.ToDouble(Console.ReadLine());

        // Get coordinates of the second point (x2, y2)
        Console.Write("Enter the x-coordinate of the second point: ");
        double x2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the y-coordinate of the second point: ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        // Calculate the distance using the distance formula
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        // Display the result
        Console.WriteLine($"\nThe distance between the two points ({x1}, {y1}) and ({x2}, {y2}) is: {distance:F2}");

        // End program
        Console.WriteLine("\nThank you for using the Distance Calculator.");
    }
}
