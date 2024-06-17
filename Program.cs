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

            for (int i = 0, j = 0, k = 0; i < len1 || j < len2;)
            {
                if (i < len1)
                    merged[k++] = word1[i++];
                if (j < len2)
                    merged[k++] = word2[j++];
            }

            return new string(merged);
        }
    }
}
