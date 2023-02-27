using System;

namespace Session05
{   
    class Car
    {
        public string carName;
        public int modelNo;

        //parameterize container
        public Car(string name, int model) {
            this.carName = name;
            this.modelNo = model;
        }
        // get methods
        public string getName()
        {
            return this.carName;
        }
        public int getModel()
        {
            return this.modelNo;
        }

        // Destructor --> de-allocate memory of object that are no longer required 
        ~Car()
        {
            Console.WriteLine("Destructor has been invoked");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car c1 = new Car("Civic", 2022);
            Console.WriteLine(c1.getName());
            Console.WriteLine(c1.getModel());

            //Car c2 = new Car("Civic", 2022);
            //Console.WriteLine(c2.getName());
            //Console.WriteLine(c2.getModel());
        }
    }
}
