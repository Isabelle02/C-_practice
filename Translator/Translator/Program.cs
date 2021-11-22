using System;

namespace Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary words = new Dictionary();

            words.PrintEng();

            bool end = false;
            while (!end) {
                Console.WriteLine("\nChoose a word to translate");
                string word = Console.ReadLine();

                if (words[word] != null)
                {
                    Console.WriteLine($"\n{word} - {words[word]}");
                    end = true;
                } 
                else
                    Console.WriteLine("There is no such word");
            }

            Console.ReadKey();
        }
    }

    class Word
    {
        public string Source { get; set; }
        public string Target { get; set; }
        public Word(string source, string target)
        {
            Source = source;
            Target = target;
        }
    }

    class Dictionary
    {
        Word[] words;
        public Dictionary()
        {
            words = new Word[]
            {
                new Word("red", "красный"),
                new Word("blue", "синий"),
                new Word("green", "зеленый"),
                new Word("gallows", "виселица")
            };
        }

        public string this[string source]
        {
            get
            {
                foreach (var w in words)
                    if (w.Source == source)
                        return w?.Target;
                return null;
            }
            /*
            set
            {
                foreach (var w in words)
                    if (w.Source == source)
                        w.Target = value;
            }
            */
        }

        public void PrintEng()
        {
            foreach (var w in words)
                Console.WriteLine(w.Source);
        }
    }
}
