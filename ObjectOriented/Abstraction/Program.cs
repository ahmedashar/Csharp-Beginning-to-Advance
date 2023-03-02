using System;

namespace Abstraction
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int get()
            {

                return 2;
            }
            Console.WriteLine(get());

            Console.WriteLine("Hello World!");
        }
    }
}

//Abstraction is an important part of object oriented programming.
//*It means that only the required information is visible to the user and the rest of the information is hidden.
//*Abstraction can be implemented using abstract classes in C#.
//*Abstract classes are base classes with partial implementation.
//*In C#, we cannot create objects of an abstract class