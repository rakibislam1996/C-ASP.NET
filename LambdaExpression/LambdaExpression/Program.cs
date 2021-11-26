using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunctionActionLambda
{
    class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
        public DateTime PublishDate { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>()
            {
                new Book{ Name="The Unicorn Project",Author="Gene Kim",
                    PublishDate=new DateTime(2019,5,1),Price = 6700 },
                new Book{ Name="The Tao of Programming",Author="Geoffrey James",
                    PublishDate=new DateTime(1986,11,20),Price = 9600 },
                new Book{ Name="Managing the Unmanageable",Author="Mickey W. Mantle",
                    PublishDate=new DateTime(2012,9,30),Price = 8900 }
            };

            var findBooks = books.Where(book => book.Price >= 7000 && book.PublishDate > new DateTime(2010, 9, 2));
            foreach (var item in findBooks)
                Console.WriteLine(item.Name);
            Console.WriteLine();
            
            var selectBook = books.FindAll(book => book.PublishDate > new DateTime(1995, 10, 10));
            foreach (var item in selectBook)
                Console.WriteLine(item.Author);
            Console.WriteLine();

            List<string> names = new List<string>() { "Rakib", "Sakib", "Rafi" };
            var x = names.FindAll(name => name.StartsWith("R"));
            foreach (var item in x)
                Console.Write(item + " ");
            Console.WriteLine("\n");

            List<int> numbers = new List<int>() { 10, 12, 56, 23 };
            var arr = numbers.FindAll(number => number >= 20);
            foreach (var item in arr)
                Console.Write(item + " ");
            Console.WriteLine("\n");
        }
    }
}
