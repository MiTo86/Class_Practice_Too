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
        private string rating;

        //Adding a constructor - a special method that is put inside a class that is called whenever an object of the class is created.
        public Book(string aTitle, string aAuthor, int aPages, string aRating) // The constructor with parameters.
        {
            Title = aTitle;
            Author = aAuthor;
            Pages = aPages;
            Rating = aRating; //added for getter and setter demo (called the setter
        }

        //Can also have a constructor without parameters
        public Book()
        {

        }

        //Adding a getter and setter
        public string Rating
        {
            get { return rating; }
            set 
            { 
            if (value =="children" || value == "teen" || value == "mature")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }

        //Adding an object method
        public bool HasRightPages()
        {
            if (Pages >= 400)
            {
                return true;
            }
            return false;
        }
    }
}
