using System;
using System.Text;

namespace ImperiumLibrary.Generate
{
    public static class GenerateMutex
    {
        public static string GenerateRandomMutex()
        {
            StringBuilder RandomMutex = new StringBuilder("IMP_MUTEX_");
            Random r = new Random();

            var CharactersAndNumbers = new[]
            {"q", "w", "e", "r", "t", "y", "u", "i", "o", "p",
            "a", "s", "d", "f", "g", "g", "h", "j", "k", "l",
            "z", "x", "c", "v", "b", "n", "m", "0", "1", "2",
            "3", "4", "5", "6", "7", "8", "9"
            };

            Generate(RandomMutex, r, CharactersAndNumbers);
            return Convert.ToString(RandomMutex);
        }

        private static void Generate(StringBuilder RandomMutex, Random r, string[] CharactersAndNumbers)
        {
            for (int i = 0; i < 18; i++)
            {
                RandomMutex.Append(CharactersAndNumbers[r.Next(0, CharactersAndNumbers.Length)]);
            }
        }
    }
}
