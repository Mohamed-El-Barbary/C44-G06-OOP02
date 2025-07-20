using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    struct Point
    {
        #region Fields
        // Attributes
        private int x;
        private int y;

        #endregion

        #region Constructor
        /// Constructor => is a special method that is called when an instance of the struct is created
        ///             . Named alawys with the same name of its class or struct
        ///             . Has no return type
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            // this refers to the object that the constructor is being called on
        }

        /// Parameterless Constructor
        /// in sruct , Compile Always generates a parameterless constructor if not defined
        /// this Constructor will initializes each and every attribute of the struct to its default value

        public Point()
        {
            x = default; // default value for int
            y = default; // default value for int
        }
        #endregion

        #region Methods

        ///public override string ToString()
        ///{
        ///    // return base.ToString();
        ///    // base refers to the parent class ValueType 
        ///    // calling ToString() method of the parent class ValueType [base]
        ///    return $"Point: ({x}, {y})";
        ///}

        #endregion

    }
}
