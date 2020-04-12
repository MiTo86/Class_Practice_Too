using System;

namespace Class_Practice_Too
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Book book1 = new Book();
            book1.Title = "Forward the Foundation";
            book1.Author = "Isaac Asimov";
            book1.Pages = 434;

            Book book2 = new Book();
            book2.Title = "The Last Emperox";
            book2.Author = "John Scalzi";
            book2.Pages = 387;*/

            //With a constructor
            Book book1 = new Book("Forward the Foundation", "Isaac Asimov", 434, "teen");
            Console.WriteLine(Book.bookCount); //the static attribute counts the number of books created.

            Book book2 = new Book("The Last Emperox", "John Scalzi", 387, "what");
            Console.WriteLine(Book.bookCount); //the static attribute counts the number of books created.
            Book book3 = new Book();

            book2.Title = "The Consuming Fire";

            Console.WriteLine(book1.Title);
            Console.WriteLine(book1.Author);
            
            Console.WriteLine(book2.Title);
            Console.WriteLine(book2.Author);
           

            //Added the getter and setter for rating of the book
            //Checking if getter and setter work
            Console.WriteLine(book1.Rating);
            Console.WriteLine(book2.Rating);

            //Added an object method to determine if book is over 400 pages.
            Console.WriteLine(book1.HasRightPages());
            Console.WriteLine(book2.HasRightPages());

            

            Console.ReadLine();
        }
    }
}
