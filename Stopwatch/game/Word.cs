using System.Collections.Generic;

namespace Stopwatch.game
{
    public class Word
    {
        
        public static string GetEasyWord () {
            var words = new List<string>();
            return "hdnc";
        }

        public static string GetHardWord() {
            return "dsfjkdsfjsdhdsfhdsusk";
        }

        // need to implement a randomize to get randomized words 
        // Now the word are default
        private static string randomize(int stress) {
            throw new KeyNotFoundException();
        }
    }
}