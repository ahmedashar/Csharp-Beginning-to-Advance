using System;

namespace typeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //// types conversion 
            //// implicit type conversion.

            //byte d = 12; // 00000000
            //int e = d;  // 00000000 00000000 00000000 00000000 

            //Console.WriteLine(e);

            //// explicit type conversion.
            //int f = 300;
            //byte g = (byte)f; //explicitly converted (unexpted value, data will lost)
            //Console.WriteLine(g);

            //// Convert class method

            //string numString = "1234";
            //int num1 = Convert.ToInt32(numString);

            //// Parse method

            //int num2 = int.Parse(numString);


            //Console.WriteLine(num1);
            //Console.WriteLine(num2);

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



            try
            {
                string str = "xyz";
                int num = int.Parse(str);
                Console.WriteLine(num);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: Invalid format for string.");
                //or
                Console.WriteLine("Error: " + ex.Message);

            }
            var nums = 20;
            if (nums<30 && nums>15)
            {
                Console.WriteLine("okay");
            }
        }
    }
}
