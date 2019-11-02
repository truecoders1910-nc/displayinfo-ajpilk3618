using System;

namespace DisplayInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get first and last name from user input
            Console.Write("Please enter your first name: ");
            string Firstname = Console.ReadLine();
            Console.Write("Please enter your last name: ");
            string Lastname = Console.ReadLine();


            // Get their favorite number
            Console.Write($"Hello {Firstname} {Lastname}, please enter your favorite number: ");
            string Favenum = Console.ReadLine();
            int FavenumValue = Convert.ToInt32(Favenum);


            // Get their favorite animal
            Console.Write("Please enter your favorite animal: ");
            string FaveAnimal = Console.ReadLine();


            // Once you have gotten all their info and stored it,
            // display it back to them.

            if (FavenumValue > 10)
            {
                Console.ForegroundColor = ConsoleColor.Green;

            }
            else if (FavenumValue < 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

            Console.WriteLine($"Your name is {Firstname} {Lastname}.");
            Console.WriteLine($"Your favorite number is {Favenum}.");
            Console.WriteLine($"Your favorite animal is {FaveAnimal}.");


            // If their favorite number is greater than 10, display it in green.
            // If their favorite number is less than 5, display it in red.

            //if (FavenumValue > 10)
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
               
            //}
            //else if (FavenumValue < 5)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //}
            

            Console.ReadLine();
        }
    }
}
