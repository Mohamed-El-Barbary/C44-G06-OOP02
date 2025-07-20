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

        }
    }
}
