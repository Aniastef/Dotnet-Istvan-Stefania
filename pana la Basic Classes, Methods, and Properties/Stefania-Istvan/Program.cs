using System;

namespace Stefania_Istvan
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Stefania";
            person.LastName = "Istvan";

            Console.WriteLine(person.FullName);

            Console.WriteLine(" What do you think the name is?");
            string FullNameGuess = Console.ReadLine();

            Console.WriteLine("Second guess?");
            string FullNameGuess2 = Console.ReadLine();

            if (person.FullName == FullNameGuess)
            {
                Console.WriteLine("You got the name! You win! ");
            }
            else if(person.FullName== FullNameGuess2)
            {
                Console.WriteLine("You got the name! You get 1/2 points");
            }

            else
            {
                Console.Write("You're a dissapointment (but that's okay)");
            }


        }
        
        
    }
}
//namespace-> classes -> members -> method -> statements

