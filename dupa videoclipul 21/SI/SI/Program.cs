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

            /*List<int> grades = new List<int>();
            grades.Add(5);
            grades.Add(10);*/

            /*List<int> grades = new List<int>() { 5, 10 };
            Console.WriteLine(grades[0]);

            grades.Add(30);
            Console.WriteLine(grades[2]);

            grades.Insert(2, 15);

            Console.WriteLine(grades[4]);
            /*grades.Clear();//stergem tot
            grades.Remove(10);
            grades = new List<int>();*///mai bine facem asta decat sa stergem tot */

            //List<int> grades = new List<int>() { 5, 10, 26, 34, 2, 23,26,26,26,26, 200 };//

            /*if (grades.Contains(80))
            {
                Console.WriteLine("found");
            }
            if (grades.IndexOf(24)== -1) //-1 o sa dea true pentru ca nu avem 24 in lista si -1 INSEAMNA SA NU FIE ACOLO ca e negativ
            {
                Console.WriteLine("true");
            }  
            
            if(grades.LastIndexOf(26)==9)//daca avem mai multi de 26 in lista ne ajuta ca ne arata unde apare ultima data
            {
                Console.WriteLine("true");
            }*/

            /*List<int> grades1 = new List<int>() { 5, 10, 26, 34, 2, 23, 26, 26, 26, 26, 200 };
            List<int> grades2 = new List<int>() { 5, 10, 26, 34, 2, 23, 26, 26, 26, 26, 200 };
            //if (grades1.Equals(grades2))//daca ai scrie asa ai compara faptul ca sunt ambele liste (nu compari valorile)
               
            if (grades1.SequenceEqual(grades2)) //aici compari valorile din liste
            {
                Console.Write("equal!");
            }

            List<int> grades = new List<int>() { 5, 10, 26, 34, 2, 23, 26, 26, 26, 26, 200 };

            for(int i=0;i<grades.Count;i++)
            {
                grades[i] *= 2; 
                Console.WriteLine(grades[i]); 
            }
            Console.WriteLine("vreau sa vad ce face foreach-ul");

            foreach(int grade in grades) //foreach e buna pt reading elements not updating them 
            {
                
                Console.WriteLine(grade);
            }


            Console.WriteLine("vreau sa vad ce face foreach-ul");


            foreach (int grade in grades.ToArray())  //e mai cleeean asa cica
            {
                
                Console.WriteLine(grade);
            }*/

            //foreach -> clean -> stie cand sa se opreasca -> safe






            //video 52- liste de liste..//
            /* List<List<int>> studentGrades = new List<List<int>>()
             {
                new List<int> { 5, 10, 26 },
                 new List<int>{ 34,26,26},
                 new List<int>{26,2,23,26,200}
             };

             foreach(List<int> grades in studentGrades.ToArray())
             {
                 foreach(int grade in grades)
                 {
                     Console.Write(grade + "\t");
                 }
                 Console.WriteLine();
             } */




            /* int[][] studentGrades =
             {
                 new int[]{5,10,26},
                 new int[]{34,26,26},
                 new int[]{26,2,23,26,200}
             };

             foreach(int[] grades in studentGrades)
             {
                 foreach(int grade in grades)
                 {
                     Console.Write(grade + "\t");

                 }
             } */




            //converting an array to a list
            /*List<int>stuff =new List<int>< int > (){5};
            int[] myArr = stuff.ToArray();

            int[][] studentGrades =
        {
                new int[]{5,10,26},
                new int[]{34,26,26},
                new int[]{26,2,23,26,200}
            };
            List<int> myList = studentGrades[0].ToList();*/



            //sort,reverse a list//
            List<int> stuff = new List<int>() { 5, 60, 3, 50 };

          
            stuff.Reverse();
            stuff.Sort();
            stuff.Reverse();

            foreach (int s in stuff)
            {
                Console.WriteLine(s);
            }




        }
    }
}
