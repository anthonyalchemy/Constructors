using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class Book
    {
        public string title; // class attributes 
        public string author;
        public int pages;

        //now we can go to other prgram and create a book 

        public Book(string aTitle, string aAuthor, int aPages) // constructor public then its the name of the class, special method called 
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}
