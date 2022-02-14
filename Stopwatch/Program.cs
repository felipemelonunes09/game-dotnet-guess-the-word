using System;
using System.Threading;
using Stopwatch.game;

namespace Stopwatch
{
    class Program
    {

        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu() {

            Console.Clear();
            Console.WriteLine("[ ==> WELLCOME TO GUESS THE NAME <==]");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Choose the display option");
            Console.WriteLine("easy => < 5 letras");
            Console.WriteLine("hard => > 5 letras");
            Console.WriteLine("0 => Sair");
            Console.WriteLine("----------------------------------------");

            string data = Console.ReadLine().ToLower();
            Game game = null;

            Console.WriteLine(data);

            switch(data) {
                case "easy" : 
                    Console.Write("Easy Mode");
                    game = new Game(true);
                break;
                case "hard" :
                    Console.Write("Hard Mode");
                    game = new Game(false);
                break;
                case "0" : 
                    Console.Write("Goodbyee");
                    Thread.Sleep(3000);
                    System.Environment.Exit(0);
                break;
                default : 
                    Console.Write("Hard Mode");
                    game = new Game(false);

                break;
            }

            game.start();
            Menu();
        }

        static void Start (int time) {
            int currentTime = 0;

            while (currentTime != time) {
                Console.Clear();
                Console.WriteLine(currentTime + "s");                
                currentTime++;
                Thread.Sleep(1000);
            }
        }        
    }
}
