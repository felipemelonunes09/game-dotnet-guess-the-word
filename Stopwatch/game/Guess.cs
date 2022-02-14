namespace Stopwatch.game
{
    public class Guess : IGuess
    {

        private string word = "not implemented word";
        public string guess = "";
        
        public Guess (string word = "guess") {
            this.word = word;
        }

        public bool check() {
            return this.word.Equals( this.guess );
        }

        public string getWord() {
            return this.word;
        }
    }
}