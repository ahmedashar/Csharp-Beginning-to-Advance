using System;

namespace Inheritance
{
    // parent class (Base Class)
    class Vehicle
    {
        public string brand = "xyzBrand";

        public void vBrand()
        {
            Console.WriteLine("Vehicle Brand Name is: {0}", brand);
        }
    }

    // child class (Derived class)
    class Car : Vehicle
    {
        public int model = 2010;
        public string color = "red";

        public void carInfo()
        {
            vBrand();
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Model No: " + model);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //single inheritance
            Car c1 = new Car();
            c1.carInfo();
            c1.vBrand();
            Console.WriteLine(c1.brand);
            // single inheritance


        }
    }
}
// In C#, it is possible to inherit fields and methods from one class to another.
// We group the "inheritance concept" into two categories:
//Derived Class(child) -the class that inherits from another class
//Base Class(parent) - the class being inherited from
//To inherit from a class, use the : symbol.

// Types of Inheritance
// 1. Single Inheritance -> one base class and one drived class
// 2. Multiple Inheritence -> one base class and more than one derived class 
// 3. Multi-level inheritence -> Base, Intermediate, Derived (Grand Parents, Parents and Child)



// Access Modifier

//Applicable to
// | Applicable to Application | Current Class | Derived Class | Outside the namespace/assembly | Outsite the namespace but in derived class

//1) public: 








