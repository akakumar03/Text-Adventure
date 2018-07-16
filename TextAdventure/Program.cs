using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            GameTitle();
            
        }
        public static void GameTitle()
        {
            Console.WriteLine("This is my First Title");
            Console.WriteLine("Press 'Enter' to begin");
            Console.ReadLine(); //Pause the programme
            Console.Clear(); //Clear the screen.       
            First(); //Calling the First function
        }
        public static void First()
        {
            String Choice;
            Console.WriteLine("You Wake up");
            Console.WriteLine("What did you do?");
            Console.WriteLine("1 : Punch");
            Console.WriteLine("2 :Cry");
            Console.WriteLine("3 :Pee");
            Console.Write("Choice :");
            Choice = Console.ReadLine().ToLower(); //ToLower makes everything in lowercase.
            Console.Clear();

            switch (Choice)
            {                             //You can have multiple case scenarios in one case
                case "1":
                case "punch":
                    {
                        Console.WriteLine("your fist");
                        Console.WriteLine("All the other chear");
                        Console.WriteLine("Mrs.Storm hears the commotion");
                        Console.WriteLine("Sees her Husband");
                        Console.WriteLine("Please press 'Enter' to continue");
                        Console.ReadLine();
                        GameOver();
                        break;


                    }

                case "2":
                case "cry":
                    {
                        Console.WriteLine("Dont");
                        Console.WriteLine("Cry");
                        Console.WriteLine("Please");
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        Second();
                        break;
                    }
                case "3":
                case "pee":
                    {
                        Console.WriteLine("You");
                        Console.WriteLine("Would");
                        Console.WriteLine("Cry");
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        Second();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("I don't understand");
                        Console.WriteLine("Please Understand");
                        Console.WriteLine("Press Enter to try again");
                        Console.ReadLine();
                        First();
                        break;
                       }
            }
        }
        public static void Second()
        {
            Random rnd = new Random();  //Random is used to take out random index from an array. Pick out a random word everytime.

            string[] setOperation = { "So what the hell are waiting for?",
                "In the hallway lies the balony.",
            "Please, Stop it."};
            int RandomNumber = rnd.Next(0, 3); 
            string SecText = setOperation[RandomNumber];

            string setChoice;
            Console.WriteLine(SecText); //We want the console to print the random generation.
            Console.WriteLine("please do it fast.");
            Console.WriteLine("Have you finished yet?");
            Console.WriteLine("Choice :");
           setChoice= Console.ReadLine().ToLower();

            if (setChoice == "Yes" || setChoice == "y")
            {
                Third();
            }
            else if (setChoice == "No" || setChoice == "n")
            {
                Console.WriteLine("ShutUp");
                Console.WriteLine("Press  'Enter' to continue");
                Console.ReadLine();
                GameOver();
            }
            else
            {
                Console.WriteLine("I dont understand the command");
                Console.WriteLine("Press 'Enter' to continue");
                Console.ReadLine();
                Second();
            }

        }
        public static void Third()
        {
            int age;

            Console.WriteLine("You burst into the bathroom");
            Console.WriteLine("You are shite");
            Console.Write("Age :");
            int.TryParse(Console.ReadLine(), out age); //parsing is done when you are putting a string into a number.

            while (age < 100)
            {
                Console.WriteLine("You look old");
                Console.WriteLine("Fuck");
                Console.Write("Age :");
                int.TryParse(Console.ReadLine(), out age);
                
            }
            Console.WriteLine("Wow! You're really old");
            Youwin();
            
        }
        public static void GameOver()
        {
            Console.Clear();
            Console.WriteLine("Yes, You are");
            Console.WriteLine("Why not you");
            Console.WriteLine("press 'Enter' to continue");
            Console.ReadLine();
            Console.Clear();
            GameTitle();
        }
        public static void Youwin()
        {
            Console.Clear();
            Console.WriteLine("Yes, You are");
            Console.WriteLine("Why not you");
            Console.WriteLine("press 'Enter' to continue");
            Console.ReadLine();
            Console.Clear();
            GameTitle();
        }
    }
}
