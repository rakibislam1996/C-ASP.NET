using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutput
{
    class PrintProblems
    {
        public void printingProbs()
        {
            string str = "\"This is a string\"";
            Console.WriteLine(str);

            str = @"""This is a string""";
            Console.WriteLine(str);

            str = "\\";
            Console.WriteLine(str);

            str = "Lets \\ learn \\ C#"; // need to use \ twice 
            Console.WriteLine(str);

            str = @"This \ is \ a \ string"; // using @ will allow \ to be printed 
            Console.WriteLine(str);
        }
        
    }
}
