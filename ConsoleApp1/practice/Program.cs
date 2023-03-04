using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {

            //int totalMarks = 100;
            //int obtainedMarks =0;

            //try
            //{
            //    obtainedMarks = Convert.ToInt32(Console.ReadLine());
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("inValid Value: " + e.Message);
            //}

            //    if (obtainedMarks == totalMarks)
            //{
            //    Console.WriteLine("Topper");
            //}

            ////initialization of array
            //int[] marks = { 25, 55, 67, 33 };
            //// return lenght of aray
            //Console.WriteLine(marks.Length);
            //// for loop
            //for(int i=0; i < marks.Length; i++)
            //{
            //Console.WriteLine(marks[i]);
            //}

            //// while loop
            //int j = 0; 
            //while( j < marks.Length){

            //Console.WriteLine(marks[j]);
            //    j++;
            //}

            //int z = 0;
            //do
            //{
            //    Console.WriteLine(marks[z]);
            //    z++;
            //} while (z < marks.Length);
            //

            //byte num1 = 255;
            //byte num2 = 1;
            //byte result = 0;

            //try { 
            //checked { 
            //result = (byte) (num1 + num2);
            //}

            //Console.WriteLine(result);

            //}catch(OverflowException ex)
            //{
            //    Console.WriteLine("ERROR: "+ ex.Message);
            //}


            //string x = Console.ReadLine().ToUpper();
            //Console.WriteLine(x);


            //int i = 0;
            //int j;
            //while (i <= 5)
            //{
            //    j = 0;
            //    while (j <= i)
            //    {
            //        Console.Write("*");
            //        j++;
            //    }
            //    Console.WriteLine();
            //    i++;
            //}

            //array 


            //3rd way

            //2nd way
            //int[] ids = { 6, 8, 9, 10 };

            //Console.WriteLine("id1-before: " + ids[0]);

            //int[] ids2 = ids;
            //ids[0] = 99;

            //Console.WriteLine("id2: "+ids2[0]);
            //Console.WriteLine("id1-after: " + ids[0]);

            //1st way
            //string[] stdName = new string[10];
            //stdName[9] = "Ashar";
            //Console.WriteLine("std_Name " + stdName.Length);

            // multi-dimensional array
            //int[,] numbers =
            //{
            //    {1,2,3 },
            //    {4,5,6 }
            //};
            //int[,] numbers2 = new int[2, 4] { { 1,2,3,4},{5,6,7,8} };

            //for(int i=0; i<numbers.GetLength(0); i++)
            //{
            //    for(int j=0; j<numbers.GetLength(1); j++)
            //    {
            //        Console.Write(numbers[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            int[ ][ ] num = new int[3][];
            num[0] = new int[3];
            num[1] = new int[4];
            num[2] = new int[1];

            num[0][0] = 1;
            num[0][1] = 3;
            num[0][2] = 7;

            num[1][0] = 0;
            num[1][1] = 2;
            num[1][2] = 4;
            num[1][3] = 6;

            num[2][0] = 9;

            //for(int i =0; i<num.Length; i++)
            //{
            //    for (int j = 0; j < num[i].Length; j++)
            //    {
            //        Console.Write(num[i][j]);
            //    }
            //    Console.WriteLine();
            //}

            foreach (var n in num)
            {
                foreach (var subn in n)
                {
                    Console.Write(subn);
                }
                Console.WriteLine();
            }

        }
    }
}
