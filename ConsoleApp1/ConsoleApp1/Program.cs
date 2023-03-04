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

                char stName = Convert.ToChar( Console.Read());
                Console.WriteLine("value: " + stName);

                float zzz = 1.44f;
                Console.WriteLine(float.MinValue + " ," + float.MaxValue);
                Console.WriteLine(int.MinValue + " ," + int.MaxValue);


             

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

            string days = "Monday";

            switch (days)
            {
                case "Monday":
                    Console.WriteLine("Day one");
                    break;
                case "Tuesday":
                    Console.WriteLine("Day two");
                    break;
                case "Wednesday":
                    Console.WriteLine("Day three");
                    break;
                default:
                    Console.WriteLine("Others");
                    break;
            }

            }
        }
    }
