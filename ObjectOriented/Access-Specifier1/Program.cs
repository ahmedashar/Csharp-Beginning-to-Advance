using System;

namespace Access_Specifier1
{
   public class Parent
    {
        public int number = 200;

        public void getPData()
        {
            Console.WriteLine(number);
        }    
    }
   public class Child:Parent
    {
        public int cNum = 100;
        public void getCData()
        {
            Console.WriteLine("Child numebr {0}, Parent number {1}",cNum,number);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Child c1 = new Child();
            c1.getCData();

        }
    }
}

// Access Modifier

//Applicable to
// | Applicable to Application | Current Class | Derived Class | Outside the namespace/assembly | Outsite the namespace but in derived class
//1) public:
//  |          yes             |      yes      |      yes      |              yes               |     yes
//2) private
//  |          NO              |      yes      |      NO       |              NO                |     NO
//3) protected
//  |          NO              |      yes      |      yes      |              NO                |     yes



// mew Keyword
// This allow you to redefine the inherited methods or variable in the derived class.
//  redefining the base class memebers in the derived class result in base class members being hidden.
