namespace Assignment_7._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word: ");
            string word1 = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Please enter another word: ");
            string word2 = Console.ReadLine();

            string mergedResult = MergeWords(word1, word2);
            Console.WriteLine();
            Console.WriteLine("Merged result: " + mergedResult);
        }

        public static string MergeWords(string word1, string word2)
        {
            int len1 = word1.Length;
            int len2 = word2.Length;
            int merge = len1 + len2;
            char[] merged = new char[merge];

            for (int i = 0, j = 0, k = 0; i < len1 || j < len2;)  // i is index for word1, j is for word2, k is for merged word
            {
                if (i < len1)
                {
                    merged[k++] = word1[i++]; // puts letter from word1 to merged word
                }
                if (j < len2)
                {
                    merged[k++] = word2[j++]; // puts letter from word2 to merged word
                }
            }

            return new string(merged);
        }
    }
}
