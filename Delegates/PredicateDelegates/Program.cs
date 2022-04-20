using System;

namespace PredicateDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Predicate takes only one input and gives output as boolean
            
            Predicate<string> predicate = IsUpper; // <input>
            Console.WriteLine(predicate("Hello"));
        }

        private static bool IsUpper(string text)
        {
            return text.Equals(text.ToUpper());
        }
    }
}
