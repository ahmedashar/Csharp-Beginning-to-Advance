using System;

namespace ObjectOriented
{
    //creating class
    public class Person{
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }
        }
    //Constructor
    public class Student
    {
        public string Name;
        public Student(string name)
        {
            this.Name = name;
            Console.WriteLine("get Name Through Constructor==> {0}",Name);
        }
    }

    // Constructor Overloading 
    public class ConOverloading
    {
        int Id;
        string Name;
        public ConOverloading()
        {
            Console.WriteLine("Constructor Overloading: Default Constructor");
        }
        public ConOverloading(int id)
        {
            this.Id = id;
            Console.WriteLine("Constructor Overloading: Your id is "+Id);
        }public ConOverloading(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            Console.WriteLine("Constructor Overloading: Your id is {0} and Name is {1}",Id,Name);


        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            // make object, instence of class.
            var p1 = new Person();
            p1.Name = "Ashar";
            p1.Introduce("Ahmed");
            //

            // constructor of Student
            var s1 = new Student("Ashar");

            // Constructor Overloading
            var c1 = new ConOverloading();
            var c2 = new ConOverloading(2);
            var c3 = new ConOverloading(5,"Ashar");

            Console.WriteLine(c1+ "\n" + c2 + "\n" + c3);
        }
    }
}
