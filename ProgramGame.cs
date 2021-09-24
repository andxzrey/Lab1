using System;

namespace Game
{
    class Game
    {
        public void Source()
        {
            Random rnd = new Random();
            int rndNum = rnd.Next(0,100);
            int num = 0;
            while (num != rndNum)
            {
                Console.Write("Enter a num: ");
                num = int.Parse(Console.ReadLine());
                if (num < rndNum) { Console.WriteLine("Please enter a number greater."); }
                if (num > rndNum) { Console.WriteLine("Please enter a number less than what you entered."); }
            }
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Congratulations! You did it.");
            Console.ResetColor();
        }
    }
    class ProgramGame
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Source();
        }
    }
}
