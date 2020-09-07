
using System;

namespace Projekt_1C
{
    class Program
    {
        static void Main(string[] args)
        {

            RoomDescription();


            Console.WriteLine("Hello friend! What is your name? :D");

            string name = Console.ReadLine();

            if (name == "Joel")
            {
                Console.WriteLine("Pogbaby");

            }
            else
            {
                Console.WriteLine("Hello " + name);

            }
            Console.ReadLine();

            Console.WriteLine("So, how old are you?");

            // Console.ReadLine();

            string ageS = Console.ReadLine();
            int age = int.Parse(ageS);

            if (age >= 45)
            {
                Console.WriteLine("Damn, you're pretty old. Compared to me at least ");
            }
            else
            {
                Console.WriteLine("Oh, alright then. You are not that old then");
            }
            Console.ReadLine();


            Console.WriteLine("So are you Male or Female?");
            string sex = Console.ReadLine();

            if (sex == "Male" || sex == "Female")
            {
                Console.WriteLine("So you are a Human " + sex);
            }
            else
            {
                Console.WriteLine("I do not know what that is, is it some kind of a third sexual idenfication term?");
            }
            Console.ReadLine();





        }

        static void RoomDescription()
        {
            Console.WriteLine("It is a large, cold, dark and empty room.");
            Console.ReadLine();
            Console.WriteLine("There are no visable openings, doors or windows to this room.");
            Console.ReadLine();
            Console.WriteLine("All surfices of the room looks and feels like smooth marble or metal of some kind.");
            Console.ReadLine();
            Console.WriteLine("You sense somethng moving about in this room, but you are not sure from where...");
            Console.ReadLine();








        }


    }
}
