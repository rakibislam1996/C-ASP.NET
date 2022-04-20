using System;

namespace TupleDemo
{
    internal class Program
    {
        
        public static Tuple<int,string,int> Fun(Tuple<int, string, int> person)
        {
            return Tuple.Create(person.Item1,person.Item2,person.Item3);

        }
        static void Main(string[] args)
        {
            Tuple<int, string, int> person = Tuple.Create(1, "Steve", 25);
            Console.WriteLine(person.Item1 +" " + person.Item2 + " " + person.Item3);
            Fun(person);
            
            var numbers = Tuple.Create(1, 2, 3, 4, 5, 6, 7, 8);  // Can not add more than 8 members
            Console.WriteLine(numbers.Rest);
            var nested = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13));

            Console.WriteLine(nested.Rest.Item1);
            Console.WriteLine(nested.Rest.Item1.Item1);
            Console.WriteLine(nested.Rest.Item1.Item2);

        }
    }
}
