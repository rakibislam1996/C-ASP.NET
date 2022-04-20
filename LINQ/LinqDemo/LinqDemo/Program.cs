using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqDemo
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
                    PublishDate=new DateTime(2012,9,30),Price = 8900 },
                new Book{ Name="Ethics in IT Outsourcing",Author="Tandy Gold",
                    PublishDate=new DateTime(2012,5,24),Price = 7500 }
            };

            var findBooks = books.Where(book => book.Price >= 7000 && book.PublishDate > new DateTime(2010, 1, 1)); // Lamba
            foreach (var item in findBooks)
                Console.WriteLine(item.Name);
            Console.WriteLine();

            var findBooks2 = from book in books   // Query
                             where book.Price >= 7000 && book.PublishDate >= new DateTime(2010, 1, 1)
                             select book;
            foreach (var item in findBooks2)
                Console.WriteLine(item.Name);
            Console.WriteLine();

            var selectBook = books.FindAll(book => book.PublishDate > new DateTime(1995, 10, 10)); // Lamba
            foreach (var item in selectBook)
                Console.WriteLine(item.Name);
            Console.WriteLine();

            var selectBook2 = from book in books    // Query
                              where book.PublishDate > new DateTime(1995, 10, 10)
                              select book;
            foreach (var item in selectBook2)
                Console.WriteLine(item.Name);
            Console.WriteLine();

            List<string> names = new List<string>() { "Rakib", "Sakib", "Rafi" };

            var findName = names.FindAll(name => name.StartsWith("R"));  // Lamba
            foreach (var item in findName)
                Console.Write(item + " ");
            Console.WriteLine("\n");

            var findName2 = from name in names    // Query
                            where name.StartsWith("R")
                            select name;
            foreach (var item in findName2)
                Console.Write(item + " ");
            Console.WriteLine("\n");

            List<int> numbers = new List<int>() { 10, 12, 56, 23 };
            var findNum = numbers.FindAll(number => number >= 20);  // Lamba
            foreach (var item in findNum)
                Console.Write(item + " ");
            Console.WriteLine("\n");

            var findNum2 = from number in numbers   // Query
                           where number >= 20
                           select number;
            foreach (var item in findNum2)
                Console.Write(item + " ");
            Console.WriteLine("\n");
        }
    }
}
