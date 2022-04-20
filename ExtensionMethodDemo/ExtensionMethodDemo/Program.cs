using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethodDemo
{
    static class NewExtension
    {
        public static string Reverse2(this String s,string str)
        {
            string newStr = null; 
            for (int i = s.Length-1; i >= 0; i--)
                newStr += s[i];
            return newStr;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "To Reverse a string";
            str = str.Reverse2();
            Console.WriteLine(str);
        }
    }
}
