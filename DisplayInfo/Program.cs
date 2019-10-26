using System;

namespace DisplayInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get first and last name from user input
            Console.WriteLine("Please enter your first name.");
            string Firstname = Console.ReadLine();
            Console.WriteLine("Please enter your last name.");
            string Lastname = Console.ReadLine();

            // Get their favorite number
            Console.WriteLine($"Hello {Firstname} {Lastname}, please enter your favorite number.");
            string Favenum = Console.ReadLine();
            int FavenumValue = Convert.ToInt32(Favenum);

            // Get their favorite animal
            Console.WriteLine("Please enter your favorite animal.");
            string FaveAnimal = Console.ReadLine();


            // Once you have gotten all their info and stored it,
            // display it back to them.

            // If their favorite number is greater than 10, display it in green.
            // If their favorite number is less than 5, display it in red.
            Console.ReadLine();
        }
    }
}
