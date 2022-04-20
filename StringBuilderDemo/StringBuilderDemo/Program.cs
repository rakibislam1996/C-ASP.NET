using System;
using System.Text;
using System.Speech.Synthesis;
namespace StringBuilderDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("abcde fghij");

            ShowMaxCapacity(sb);


            for (int i = 0; i<sb.Length; i++)
                Console.Write(sb[i]);
            Console.WriteLine();

            Console.WriteLine(sb.MaxCapacity);
            
            sb[2] = 'x';
            Console.WriteLine(sb);
            sb[2] = '\0';
            Console.WriteLine(sb);
            
            CovertToSTring(sb);

            AppendDemo(sb);

            InsertDemo(sb);

            DeletingMethods(sb);
        }

        private static void ShowMaxCapacity(StringBuilder sb)
        {
            Console.WriteLine(sb.MaxCapacity);
        }

        private static void CovertToSTring(StringBuilder sb)
        {
            string str = sb.ToString();
            Console.WriteLine(str);
        }

        private static void DeletingMethods(StringBuilder sb)
        {
            sb.Replace('R', 'A');  // Removes 10 characters starting from index 5 
            Console.WriteLine(sb);
            sb.Remove(5, 10);  // Removes 10 characters starting from index 5 
            Console.WriteLine(sb);
            sb.Clear();
        }

        private static void InsertDemo(StringBuilder sb)
        {
            sb.Insert(5, '$');  // inserts any type of data at position mentioned in 1st param
            Console.WriteLine(sb);
            sb.Insert(5, 67);
            Console.WriteLine(sb);
            sb.Insert(5, 12.3);
            Console.WriteLine(sb);
            sb.Insert(5, "RRR");
            Console.WriteLine(sb);
        }

        private static void AppendDemo(StringBuilder sb)
        {
            sb.Append('k');
            Console.WriteLine(sb);
            sb.Append("lmn");
            Console.WriteLine(sb);
            sb.Append("op" + 'q');
            Console.WriteLine(sb);
            sb.AppendLine("r");  // appends r at the end , also a new line
            Console.WriteLine(sb);
            //sb.AppendLine(); // appends a newline
        }
    }
}
