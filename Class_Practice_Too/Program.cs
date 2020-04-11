using System;

namespace Class_Practice_Too
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Title = "Forward the Foundation";
            book1.Author = "Isaac Asimov";
            book1.Pages = 434;

            Book book2 = new Book();
            book2.Title = "The Last Emperox";
            book2.Author = "John Scalzi";
            book2.Pages = 387;

            Console.WriteLine(book1.Title);
            Console.WriteLine(book1.Author);

            Console.WriteLine(book2.Title);
            Console.WriteLine(book2.Author);
            Console.ReadLine();
        }
    }
}
