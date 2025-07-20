using System;


namespace Demo.Encapsulation
{

    struct Employee
    {
        // Encapsulation ==> Separates Data definition[Attributes | Fields] from its Use [Getters & Setters]
        // Hiding the implementation details of a class or struct from the outside world,

        #region Attribute

        private int id;
        private string? name;
        private decimal salary;
        // private decimal deduction; // Derived Attribute, not stored in memory, calculated on the fly

        #endregion

        #region 1.Applying Encapsulation thorugh Getters & Setters [Old Approach]

        public int GetId()
        {
            return this.id;
        }

        public void SetId(int value)
        {
            id = value > 1000 && value < 10_000 ? value : 9999; // Data Validation
        }
        #endregion

        #region Properties
        // Applying Encapsulation through Properties [New Approach] Recommended

        /// 2.1 Full Properties
        /// Called Full because you create both Fields and Properties
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value > 1000 && value < 10_000 ? value : 9999; // Data Validation
            }
        }

        public string? Name
        {
            get
            {
                return name;
            }
            set
            {
                name = ValidateName(value);
            }
            /// init
            /// {
            /// 
            ///     // init is used to allow setting the property only during object initialization
            ///     // init make you Initialize in Object Initializer 
            ///     // init is Used instead of set 
            ///     // and not allow to change the value after object creation
            /// 
            /// }
        }

        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = ValidateSalary(value); // Data Validation
            }
        }

        // Read-Only Property
        public decimal Deduction
        {
            get
            {
                return salary * .2M;
            }
        }

        // 2.2 Automatic Properties
        // Compiler will Generate Backing Fields 'Hidden Private Attributes'

        private int Age { get; set; } // Auto-implemented property, no backing field
                                      // int <age>_backingField; // Compiler generates this field automatically

        #endregion
       
        #region Code Snippet For Properties
        // propfull: is a Code Snippet for [Full Property]

        private string? address;
        public string? Address
        {
            get { return address; }
            set { address = value; }

        }

        // prop: is a Code Snippet for [Automatic Property]

        public int MyProperty { get; set; }

        #endregion

        #region Constructors

        public Employee(int id, string? name, decimal salary, int age)
        {
            this.id = id;
            this.name = ValidateName(name);
            this.salary = ValidateSalary(salary);
            this.Age = age; // Using Property Setter
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return $"Id : {this.id}\nName : {this.name}\nSalary : {this.salary}";
        }

        private string? ValidateName(string? name)
        {
            return name is null ? null : name?.Length < 20 ? name : name?.Substring(0, 10);
        }

        private decimal ValidateSalary(decimal salary)
        {
            return salary > 5000 ? salary : 5000; // Data Validation
        }

        #endregion

        #region Notes
        //  If You Make Validation in the Setters of the Properties You Must Nake This Validatoin in Constructors
        // You can Make Private Method To Validate the Data and Call it in the Properties Setters and in the Constructors 
        #endregion

    }

}
