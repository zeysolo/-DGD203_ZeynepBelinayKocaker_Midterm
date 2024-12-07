using System;

namespace foxproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string namePlayer;

            int foxPoint = 0;

            Console.WriteLine("Please tell us your name :");

            namePlayer = Console.ReadLine();

            Console.WriteLine("Have you ever wondered which fox are you?");

            Console.WriteLine("First Fox :");
            Console.WriteLine("Where would you go on your free time?");
            Console.WriteLine("1 - to snowy mountains ");
            Console.WriteLine("2 - to a forest with lushed green");
            Console.WriteLine("3 - to a quiet mountain where no one can reach you");
            Console.WriteLine("4 - a desert destination");
            string firstAnswer = Console.ReadLine();
            if (firstAnswer == "1")
            {
                foxPoint += 10;
            }
            else if (firstAnswer == "2")
            {
                foxPoint += 20;
            }
            else if (firstAnswer == "3")
            {
                foxPoint += 30;
            }
            else if (firstAnswer == "4")
            {
                foxPoint += 40;
            }

            Console.WriteLine("Second Fox :");
            Console.WriteLine("How would you react when you are under stress? ?");
            Console.WriteLine("1 - quiet and retiring, slowly problem solver ");
            Console.WriteLine("2 - quick solver, maybe a little bit faulty");
            Console.WriteLine("3 - firstly, we got to think on it");
            Console.WriteLine("4 - motivate others so someone can solve it on my behalf");
            string secondAnswer = Console.ReadLine();
            if (secondAnswer == "1")
            {
                foxPoint += 10;
            }
            else if (secondAnswer == "2")
            {
                foxPoint += 20;
            }
            else if (secondAnswer == "3")
            {
                foxPoint += 30;
            }
            else if (secondAnswer == "4")
            {
                foxPoint += 40;
            }

            Console.WriteLine("Third Fox :");
            Console.WriteLine("What would you enjoy you on a free day?");
            Console.WriteLine("1 - movie and chill on a cold day ");
            Console.WriteLine("2 - diving into a new thing (whatever it is)");
            Console.WriteLine("3 - alone time");
            Console.WriteLine("4 - fun time with people");
            string thirdAnswer = Console.ReadLine();
            if (thirdAnswer == "1")
            {
                foxPoint += 10;
            }
            else if (thirdAnswer == "2")
            {
                foxPoint += 20;
            }
            else if (thirdAnswer == "3")
            {
                foxPoint += 30;
            }
            else if (thirdAnswer == "4")
            {
                foxPoint += 40;
            }
            Console.WriteLine("Fourth Fox :");
            Console.WriteLine("What would people say about you?");
            Console.WriteLine("1 - dependable ");
            Console.WriteLine("2 - resourceful");
            Console.WriteLine("3 - thoughtful");
            Console.WriteLine("4 - energetic");
            string fourthAnswer = Console.ReadLine();
            if (fourthAnswer == "1")
            {
                foxPoint += 10;

            }
            else if (fourthAnswer == "2")
            {
                foxPoint += 20;

            }
            else if (fourthAnswer == "3")
            {
                foxPoint += 30;

            }
            else if (fourthAnswer == "4")
            {
                foxPoint += 40;
            }

            if (foxPoint >= 30 && foxPoint < 49)
            {
                Console.WriteLine("vulpes lagopus (arctic fox)");
                Console.WriteLine("You are calm and adaptable. Everyone would rely on you, even if they shouldn’t.");
            }
            else if (foxPoint >= 60 && foxPoint < 69)
            {
                Console.WriteLine("vulpes vulpes (red fox)");
                Console.WriteLine("You are resourceful and versatile as hell. Probably everyone wants you around, but no one really likes you. Sorry.");
            }
            else if (foxPoint >= 70 && foxPoint < 89)
            {
                Console.WriteLine("vulpes ferrilata (tibetan fox)");
                Console.WriteLine("You are thoughtful and strategic. You are alone by your choice or others’ choice. It doesn’t matter. You are alone.");
            }
            else if (foxPoint >= 90)
            {
                Console.WriteLine("vulpes zerda (fennec fox)");
                Console.WriteLine("You are energetic and charming, you can light up any room except your inner room.");
            }

            Console.ReadLine();
        }
    }
}