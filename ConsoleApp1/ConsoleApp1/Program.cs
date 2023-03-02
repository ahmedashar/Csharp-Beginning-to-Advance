
    /*
     * 
     * 
     * fgfdg
     * dfgdfg
     */
    /// <summary>
    /// asdasdsdfsdfdsfdfsdfsdf
    /// </summary>
    // asdfsfsdf
  
            using System;

namespace consoleApp
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");
                //datatype variableName = value;

                // byte , short, int, long, float, double

                byte USnum = 100; //range 0 to 255    unsigned 8-bit
                sbyte Snum = -100; //range -128 to 127   signed 8-bit
                Console.WriteLine("byte value: " + Snum);
                Console.WriteLine("sbyte value: " + USnum);


                float result1 = 10 / 3f;
                Console.WriteLine("float value: " + result1);

                char ch = 'A';
                string name = "Ashar";
                bool user = true;
                char br = '\n';
                Console.WriteLine("char :{1} {0} name:{2} ", br, ch, name);

                // single line comment

                /* 
                 multi lines comment
                 */

                //const int z = 500;

                int stName = Console.Read();
                Console.WriteLine("value: " + stName);

                float zzz = 1.44f;
                Console.WriteLine(float.MinValue + " ," + float.MaxValue);
                Console.WriteLine(int.MinValue + " ," + int.MaxValue);


                // types conversion 
                // implicit type conversion and explicit type conversion.

                byte d = 12;
                int e = d;
                Console.WriteLine(e);

                // explicit 
                int f = 300;
                byte g = (byte)f; //explicitly converted (unexpted value, data will lost)
                Console.WriteLine(g);

                try
                {
                    // Non compatible types
                    string nameC = "1222";
                    //int numberC = (int) nameC; 
                    byte numC = Convert.ToByte(nameC);
                    Console.WriteLine(numC);

                }
                catch (Exception)
                {
                    Console.WriteLine("bytes maximum range 255");
                }

                bool active = true;
                if (active)
                    Console.WriteLine("Active");
                else
                    Console.WriteLine("Offline");

                string result = (active) ? "Active" : "Offline";
                Console.WriteLine("Ternary Operator: " + result);

                int marks = 80;
                if (marks >= 80)
                {
                    Console.WriteLine("Passed: Grade A+");
                }
                else if (marks >= 60 && marks <= 79)
                {
                    Console.WriteLine("Passed: Grade A");
                }
                else
                    Console.WriteLine("Failed");
                {

                }


                int day = 4;
                switch (day)
                {
                    case 6:
                        Console.WriteLine("Today is Saturday.");
                        break;
                    case 7:
                        Console.WriteLine("Today is Sunday.");
                        break;
                    default:
                        Console.WriteLine("Looking forward to the Weekend.");
                        break;
                }
                // Outputs "Looking forward to the Weekend."

            }
        }
    }
