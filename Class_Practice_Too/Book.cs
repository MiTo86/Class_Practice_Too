using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Practice_Too
{
    class Book
    {
        public string Title;
        public string Author;
        public int Pages;

        //Adding a constructor - a special method that is put inside a class that is called whenever an object of the class is created.
        public Book(string aTitle, string aAuthor, int aPages) // The constructor with parameters.
        {
            Title = aTitle;
            Author = aAuthor;
            Pages = aPages;
        }

        //Can also have a constructor without parameters
        public Book()
        {

        }
    }
}
