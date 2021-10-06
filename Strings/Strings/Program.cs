using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "My name is \"Rakib\""; // need to use \ before " to print ""
            Console.WriteLine(s);

            s = @"My name is ""Rakib"""; // need to use two " print " if there is @
            Console.WriteLine(s);

            s = "My name is \\Rakib\\"; // need to use another \ to print \
            Console.WriteLine(s);

            s = @"My name is \Rakib\"; // use @ before string to not use another \ to print \
            Console.WriteLine(s);

            char c = '\\';  // using \\ to print single \
            Console.WriteLine(c);

            c = '\'';  // using \ to print '
            Console.WriteLine(c);

            char[] greet = { 'h', 'e', 'l', 'l', 'o' };
            Console.WriteLine(greet);

            string greeting = new string(greet);
            Console.WriteLine(greeting);

            string str = "ABCD";
            str.CopyTo(1,greet,1,3); // CopyTo(start idx of str,destination char[] greet,start of greet,count of characters of str to be replaced
            Console.WriteLine(greet);

            string name = "Rakib", name2 = "Sakib";
            Console.WriteLine("ABCD".ToLower());
            Console.WriteLine("abcd".ToUpper());
            name = "Rakib"; name2 = "Sakib";
            Console.WriteLine(name.CompareTo(name2)); // returns -1 if name comes before name2
            name = "Sakib"; name2 = "Rakib";
            Console.WriteLine(name.CompareTo(name2)); // returns 1 if name comes after name2
            name = "Rakib"; name2 = "Rakib";
            Console.WriteLine(name.CompareTo(name2)); // returns 0 if name == name2
            Console.WriteLine(name.Contains('k'));
            Console.WriteLine(name.Substring(1)); // returns substring from index k
            Console.WriteLine(name.IndexOf('k'));
            Console.WriteLine(name.IndexOf("ki"));
            name = "rakikib";
            Console.WriteLine(name.IndexOf("ki",2));
            name = "  fizz  ";
            Console.WriteLine(name.Trim());
            Console.WriteLine(name2.Remove(2));  // removes characters from index k
        }
    }
}
