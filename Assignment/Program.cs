using System;
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment
{


    #region Q01

    // 1.Define a struct "Person" with properties "Name" and "Age".
    // Create an array of three "Person" objects and populate it with data.Then,
    // write a C# program to display the details of all the persons in the array.

    struct Person
    {

        public int Age { get; set; }
        public string? Name { get; set; }

        public Person(int age, string? name)
        {
            this.Age = age;
            this.Name = name;
        }

        public override string ToString()
        {

            return $"Name: {Name}, Age: {Age}";
        }

    }

    #endregion

    #region Q02
    // Create a struct called "Point" to represent a 2D point with properties "X" and "Y".
    // Write a C# program that takes two points as input from the user and calculates the distance between them.

    struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double DistanceBetweenPoints(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        }

    }

    #endregion

    class Program
    {
        static void Main(string[] args)
        {

            #region Q01
            // 1.Define a struct "Person" with properties "Name" and "Age".
            // Create an array of three "Person" objects and populate it with data.Then,
            // write a C# program to display the details of all the persons in the array.

           Person[] persons = new Person[3];
           
           Console.WriteLine("Enter details for 3 persons:");
           
           for (int i = 0; i < persons.Length; i++)
           {
               Console.WriteLine($"Enter details for person {i + 1}:");
               for (int j = 0; j <= 1;)
               {
                   Console.Write("Name: ");
                   string? name = Console.ReadLine();
           
                   Console.Write("Age: ");
                   bool isAgeValid = int.TryParse(Console.ReadLine(), out int age);
           
                   if (isAgeValid && name?.Length > 0)
                   {
                       persons[i] = new Person(age, name);
                       j++;
                   }
                   else
                   {
                       Console.WriteLine($"Invalid input. Please enter a valid name and age For Person {i + 1} again.");
                   }
               }
           
            }

            Console.Clear();
            
            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine($"Person {i + 1}\nName: {persons[i].Name} , Age: {persons[i].Age}");
            }

            #endregion

            #region Q02
            // Create a struct called "Point" to represent a 2D point with properties "X" and "Y".
            // Write a C# program that takes two points as input from the user and calculates the distance between them.
            Point point = new Point();

            Console.WriteLine("\nEnter X1 :");
            bool isValidInputX01 = double.TryParse(Console.ReadLine(), out double x1);

            Console.WriteLine("Enter Y1 :");
            bool isValidInputY01 = double.TryParse(Console.ReadLine(), out double y1);

            Console.WriteLine("Enter X2 :");
            bool isValidInputX02 = double.TryParse(Console.ReadLine(), out double x2);

            Console.WriteLine("Enter Y2 :");
            bool isValidInputY02 = double.TryParse(Console.ReadLine(), out double y2);

            if (isValidInputX01 && isValidInputY01 && isValidInputX02 && isValidInputY02)
            {
                Point p1 = new Point(x1, y1);
                Point p2 = new Point(x2, y2);
                double distance = point.DistanceBetweenPoints(p1, p2);
                Console.WriteLine($"The distance between the points ({p1.X}, {p1.Y}) and ({p2.X}, {p2.Y}) is: {distance}");
            }
            else
            {
                Console.WriteLine("Invalid input. Enter Valid Inputs.");
            }

            #endregion

        }
    }
}
