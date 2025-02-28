using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3
{
    class Book
    {
        // Properties
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        // Default Constructor
        public Book()
        {
            Title = "Unknown Title";
            Author = "Unknown Author";
            ISBN = "N/A";
        }

        // Constructor with Title and Author
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            ISBN = "N/A"; // Default ISBN if not provided
        }

        // Constructor with Title, Author, and ISBN
        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }

        // Method to Display Book Info
        public void DisplayBookInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}");
        }
    }

    //class Program3
    //{
    //    static void Main()
    //    {
    //        // Using Default Constructor
    //        Book book1 = new Book();
    //        Console.WriteLine("Book 1 Details:");
    //        book1.DisplayBookInfo();

    //        // Using Constructor with Title and Author
    //        Console.WriteLine("\nEnter Title and Author:");
    //        Console.Write("Title: ");
    //        string title = Console.ReadLine();
    //        Console.Write("Author: ");
    //        string author = Console.ReadLine();
    //        Book book2 = new Book(title, author);
    //        Console.WriteLine("\nBook 2 Details:");
    //        book2.DisplayBookInfo();

    //        // Using Constructor with Title, Author, and ISBN
    //        Console.WriteLine("\nEnter Title, Author, and ISBN:");
    //        Console.Write("Title: ");
    //        string title3 = Console.ReadLine();
    //        Console.Write("Author: ");
    //        string author3 = Console.ReadLine();
    //        Console.Write("ISBN: ");
    //        string isbn3 = Console.ReadLine();
    //        Book book3 = new Book(title3, author3, isbn3);
    //        Console.WriteLine("\nBook 3 Details:");
    //        book3.DisplayBookInfo();
    //    }
    //}
}
