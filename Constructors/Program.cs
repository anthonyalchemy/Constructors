using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //classes and ojects allow you to create custom data types
            //classes model real world  entities 
            /* Go to solution explorer 
             * Click on program 
             * add class 
             * rename 
             */

            //object will be created here which is an instance of a class 

            Book book1 = new Book("Harry Potter", "J.K.Rowling", 400); //book object (BOOK) is calling the constructor method 
          
            Book book2 = new Book("Lord of the rings", "Tolkein", 700); //book object

            book2.title = "The Hobbit"; //changing the value of an attribute

            Console.WriteLine(book2.title);
            Console.ReadLine();

        }
    }
}