using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C#");
            var score = 4000000000000;
            Console.WriteLine(score);
            var sentence = "I love you.";
            var howLong = sentence.Length;
            var bool1 = true;
            Console.Write(howLong);
            score = 43;
            score = score + 1;
            score = score * 2;
            score = score / 2;
            score = score - 10;
            Console.WriteLine(score);
            Console.Write("What is your name? ");
            var name = Console.ReadLine();
            // Console.WriteLine("It is a pleasure to meet you, " + name + ".");
            Console.Write("It is a pleasure to meet you, ");
            Console.WriteLine(name);
            //interpolation below
            Console.WriteLine($"It is a pleasure to meet you, {name}.");
            Console.Write("What is your score?");
            var scoreAsString = Console.ReadLine();
            var inputScore = int.Parse(scoreAsString);
            // if you use double.Parse(scoreAsString) then the console can accept decimal input
            var doubledScore = inputScore * 2;
            Console.WriteLine(doubledScore);
            //just playing around fam
            /* apparently I have to speak english or the
            computer yells at me...
            very scary */
        }
    }
}