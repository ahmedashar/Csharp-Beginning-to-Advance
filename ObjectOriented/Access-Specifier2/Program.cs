using System;
using Access_Specifier1;
namespace Access_Specifier2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there, Access_Specifier2");
            Child c1 = new Child();
            c1.getCData();
        }
    }
}
