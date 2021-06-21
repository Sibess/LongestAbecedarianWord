using System;

namespace LongestAbecedarianWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestAbecedarian(new string[] { "forty", "choppy", "ghost" }));
        }

        public static string LongestAbecedarian(string[] arr)
        {
            string longestAabecedarian = "";
            int letterCount = 0;

            foreach (string word in arr)
            {
                if (word.Length > letterCount && IsAbecedarian(word))
                {
                    letterCount = word.Length;
                    longestAabecedarian = word;
                }
            }
            return longestAabecedarian;
        }

        public static bool IsAbecedarian(string word)
        {
            for (int letter = 1; letter < word.Length; letter++)
            {
                if ((word[letter]) < (word[letter - 1]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
