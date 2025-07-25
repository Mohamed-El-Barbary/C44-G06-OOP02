﻿using System;
using Demo.Encapsulation;
namespace Demo
{
    internal class Program
    {
        // Entry point of the program
        static void Main(string[] args)
        {

            #region Struct
            // Point p1;
            /// Declare for Object Of type Point
            /// CLR (Common Language Runtime) will allocate 8 UnInitialized bytes in stac

            ///p1 = new Point();
            /// new ==> is just for constructor Selection that will intialize the struct object Attributes
            /// this Constructor does not take any paraneters, it called the parameterless constructor
            /// parameterless constructor is generated by the compiler if not defined, initializes the struct's Attributes to their default values


            // p1 = new Point(1, 2);
            /// new Point(1, 2) ==> is calling the constructor of the struct Point with parameters 1 and 2
            // Console.WriteLine(p1);
            /// The ToString() method is called implicitly when the object is passed to Console.WriteLine.
            /// Boxing *may* happen here if `Point` is a struct and doesn't override ToString(), 
            /// because the struct will be boxed to call `object.ToString()`.
            /// If `Point` overrides ToString(), then **no boxing occurs**.

            //Console.WriteLine(p1.ToString());
            /// Explicitly calling ToString() method on the struct instance.
            /// No boxing happens here, even if ToString() is not overridden,
            /// because the method is called directly on the value type without converting it to object. 
            #endregion

            #region Encapsulation

            Employee employee = new Employee(1, "John Doe", 50000, 22);

            /// employee.id = 2;
            /// This line will cause a compile-time error because 'id' is private
            /// you must use a public method or property to modify it

            /// Ussing Getters & Setters Old Approach
            /// employee.SetId(5000);
            /// Console.WriteLine(employee.GetId());

            /// Using Properties New Approach
            /// employee.Name = "Mohamed Elbarbary";
            Console.WriteLine(employee.Name); 

            #endregion

        }
    }
}
