using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SI
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("What's your age?");
             int age = Int32.Parse(Console.ReadLine());

             Console.WriteLine("What's the pass?");
             string password = Console.ReadLine();

             if (!(age <= 12) || password == "miaumiau")
             {
                 Console.WriteLine("Welcome! You're atleast a teenager");

             }*/




            /* bool correct = true;
             int points;
             if(correct)
             { points = 10;
             }
             else
             { points = 0; 
             }
             Console.WriteLine(points); */




            /*int i = 0;
               do
           { Console.WriteLine(i);
               i++;
           } while (false); */



            /* for (int i = 9; i >= 0; i--)
             { 
                     for (int k = i; k >= 0; k--)
                     {
                     Console.Write(k + " ");
                     }
                     Console.WriteLine();
              } */


            /* for(int i=9;i>=0;i--)
             { 
                 if(i==3) //pe scurt imi da skip la 3
                 {
                     continue;
                 }
                 Console.WriteLine(i); 
                 } */


            //ARRAYS//

            /* int[] grades = new int[10];
            grades[0] = 900;
            Console.WriteLine(grades[0]);
            */





            /*
             int size = Convert.ToInt32(Console.In.ReadLine());

             int[] grades = new int[size];



             for (int i = 0; i < grades.Length; i++)
             {
                 grades[i] = Convert.ToInt32(Console.In.ReadLine());
             }

             for (int i = 0; i < grades.Length; i++)
             {
                 Console.Write(grades[i] + " ");

             } */


            /* int[] grades = { 30, 430, 23, 10 }; */

            /*
             * bool found = false;
             * for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] == 30)
                {
                    Console.Write("Found it");
                    found = true;
                    break;
                }
            }
            if (!found)
                Console.Write("not found");*/

            /*Console.WriteLine(Array.IndexOf(grades, 23));

            Array.Sort(grades);
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(grades[i]);
            }
            */


            /* int[] grades1 = { 30, 430, 23, 10 };
             int[] grades2 = { 30, 430, 23, 10 };
             if (Enumerable.SequenceEqual(grades1, grades2))
                 Console.Write("Equal"); 
            -> mi-au trebuit using system.collections si using system.linq pt "enumerable"
            */



            //2d arrays//

            /*int[,] grades = new int[3, 4]
            {
                {5,4,7,3 },
                {7,3,2,6 },
                {5,3,7,3 }


            };

            Console.WriteLine(grades[0, 2]); */





            /*int[,] grades =
            {
                {5,4,7,3 },
                {7,3,2,6},
                {5,3,7,3 }
            };*/




            /*Console.WriteLine(grades[1][6]);
            Console.WriteLine(grades.Length);
            Console.WriteLine(grades[1].Length);*/

            /*Console.WriteLine(grades.GetLength(0)); //rows
            Console.WriteLine(grades.GetLength(1)); //columns
            ->astea pt 2d array

            for (int i = 0; i < grades.GetLength(0); i++)
            {
                for(int k=0;k<grades.GetLength(1);k++)
                {
                    Console.Write(grades[i,k] + " ");
                }
                Console.WriteLine();
            }*/




            //LISTS//

            List<int> grades = new List<int>();
            grades.Add(5);
            grades.Add(10);











        }
    }
}
