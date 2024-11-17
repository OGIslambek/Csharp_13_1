using System.Diagnostics;

namespace Csharp_13_1
{
    internal class Program
    {
        public static List<string> usualList = new List<string>();
        public static LinkedList<string> linkedList = new LinkedList<string>();

        static void Main(string[] args)
        {
            string text = File.ReadAllText("C:\\Desktop\\Text.txt");

            char[] delimiters = new char[] { ' ', '\r', '\n', '.', ',', ';', ':', '!', '?', '"' };

            var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            Stopwatch stopWatch1 = new Stopwatch();

            stopWatch1.Start();

            for (int i = 0; i < words.Length; i++)
            {
                linkedList.AddLast(words[i]);
            }

            stopWatch1.Stop();

            Console.WriteLine($"Время добавления текста в связанный список: {stopWatch1.Elapsed.TotalMilliseconds} мс");


            Stopwatch stopWatch2 = new Stopwatch();
            stopWatch2.Start();

            for (int i = 0; i < words.Length; i++)
            {
                usualList.Add(words[i]);
            }

            stopWatch2.Stop();

            Console.WriteLine($"Время добавления текста в список: {stopWatch2.Elapsed.TotalMilliseconds} мс");
        }
    }
}
