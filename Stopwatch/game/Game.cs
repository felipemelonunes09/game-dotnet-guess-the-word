using System;
using System.Threading;

namespace Stopwatch.game
{
    public class Game
    {

        private bool isEasy = true;
        private Guess[] guessHand = new Guess[5];

        public Game(bool isEasy = true) {
            this.isEasy = isEasy;
            for (int i = 0; i < 1; i++) {
                guessHand[i] = new Guess
                ( 
                    (  this.isEasy ) ? Word.GetEasyWord() : Word.GetHardWord()
                );
            }
        }

        public void start() {
            for (int i = 0; i < 1; i++) {

                string word = this.guessHand[i].getWord();
                int size = word.Length;
                int current = 0;

                while(current < size){

                    Console.Clear();
                    Console.WriteLine( word[current] );
                    Thread.Sleep(1000);
                    current++;
                }

                this.guessHand[i].guess = Console.ReadLine();
                Console.Write( this.guessHand[i].check() );
                Thread.Sleep(5000);
            }
        }
    
    }
}