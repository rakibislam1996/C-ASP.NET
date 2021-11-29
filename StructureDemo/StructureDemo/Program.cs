// See https://aka.ms/new-console-template for more information

struct Book
{
    public string Name { get; set; }
    public string Author { get; set; }
    public int Price { get; set; }

}
class Program
{
    static void Main()
    {
        Book book = new Book();
        book.Name = "ANSI C";
        book.Author = "Balagurusamy";
        book.Price = 1000;
        Console.WriteLine(book.Name);
        Console.WriteLine(book.Author);
        Console.WriteLine(book.Price);
    }
}

