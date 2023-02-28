using System;

namespace Polymorphism
{
    class Program
    {
        // 01 simple example of polymorphism
        // method does not take any parameter 
        public void greet()
        {
            Console.WriteLine("Hello");
        } 
        // method takes one string parameter
        public void greet(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        static void Main(string[] args)
        {
            // 01 Simple Example of Polmorphism
            Program p1 = new Program();
            p1.greet();
            p1.greet("Ashar");
        }
    }
}

//Notes

// Polymorphism is one of the features provided by Object Oriented Programming.
// Polymorphism simply means occurring in more than one form.


//Types of Polymorphism
//After getting the basic idea of polymorphism, let's learn the types of polymorphism in C#.

//There are two types of polymorphism:
//01-Compile Time Polymorphism / Static Polymorphism
//02-Run-Time Polymorphism / Dynamic Polymorphism


//01- In compile time polymorphism, the compiler identifies which method is being called at the compile time.
//In C#, we achieve compile time polymorphism through 2 ways:

// 1) Method overloading: In a C# class, we can create methods with the same name in a class if they have:
//i  different numbers of parameter
//ii types of parameter

// 2) Operator overloading: 
//i  operator is overloaded to perform numeric addition as well as string concatenation and


//02- In runtime polymorphism, the method that is called is determined at the runtime not at compile time.

//The runtime polymorphism is achieved by
//Method Overriding.

//During inheritance in C#, if the same method is present in both the superclass and the subclass. 
//Then, the method in the subclass overrides the same method in the superclass. This is called method overriding.

//In this case, the same method will perform one operation in the superclass and another operation in the subclass.

//We can use virtual and override keywords to achieve method overriding.

//eg codes
//https://www.programiz.com/csharp-programming/polymorphism