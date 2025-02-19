using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    internal class Program
    {
        static List<Product>products = new List<Product>();
        static void Main(string[] args)
        {
            int option = Menu();
            while(option!=5)
            {
                switch(option)
                {
                    case 1:
                        addproduct();
                        break;
                    case 2:
                        searchbytitle();
                        break;
                    case 3:
                        searchbyisbn();
                        break;
                    case 4:
                        update();
                        break;
                }
                option = Menu();
            }
        }
        static int Menu()
        {
            Console.WriteLine("1.Add a book.");
            Console.WriteLine("2.Search a book by its title.");
            Console.WriteLine("3.search by its ISBN.");
            Console.WriteLine("4.Update number of copies.");
            Console.WriteLine("5.Exit");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        static void addproduct()
        {
            Console.WriteLine("Enter the title of book.");
            string title = Console.ReadLine();
            Console.WriteLine("Enter the name of author.");
            string author = Console.ReadLine();
            Console.WriteLine("Enter the name of publisher.");
            string publisher = Console.ReadLine();
            Console.WriteLine("Enter the ISBN number.");
            int isbn = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of copies.");
            int copies = int.Parse(Console.ReadLine());
            Product book = new Product( title, author, publisher, isbn, copies);
            products.Add( book );
        }
        static void searchbytitle()
        {
            Console.WriteLine("Enter the title of the book you wanna search.");
            string title = Console.ReadLine();
            foreach(Product book in products)
            {
                if( book.Title == title )
                {
                    Console.WriteLine($"Title of the book is:{title}");
                    Console.WriteLine($"The name of the author is: {book.Author}");
                    Console.WriteLine($"The name of the publisher is:{book.Publisher}");
                    Console.WriteLine($"The ISBN of {title} is {book.ISBN}");
                    Console.WriteLine($"The number of copies of that book is:{book.Copies}");
                }
            }
        }
        static void searchbyisbn()
        {
            Console.WriteLine("Enter the title of the book you wanna search.");
            int isbn = int.Parse(Console.ReadLine());
            foreach (Product book in products)
            {
                if (book.ISBN == isbn)
                {
                    Console.WriteLine($"Title of the book is:{book.Title}");
                    Console.WriteLine($"The name of the author is: {book.Author}");
                    Console.WriteLine($"The name of the publisher is:{book.Publisher}");
                    Console.WriteLine($"The ISBN of {book.Title} is {isbn}");
                    Console.WriteLine($"The number of copies of that book is:{book.Copies}");
                }
            }
        }
        static void update()
        {
            Console.WriteLine("Enter the title of the book(you want to update): ");
            string title = Console.ReadLine() ;
            Console.WriteLine("Enter the new name of the book.");
            string name = Console.ReadLine() ;
            Console.WriteLine("Enter th isbn of the book: ");
            int isbn = int.Parse(Console.ReadLine());
            Console.WriteLine("Reenter the name of the author");
            string author = Console.ReadLine() ;
            Console.WriteLine("Renter thename of the publisher: ");
            string publisher = Console.ReadLine() ;
            Console.WriteLine("Reenter the new number of copies: ");
            int copie = int.Parse(Console.ReadLine()) ;
            foreach(Product book in products)
            {
                if(book.ISBN == isbn && book.Title == title)
                {
                    book.Title = name;
                    book.Author = author;
                    book.Publisher = publisher;
                    book.Copies = copie;
                }
            }
        }
    }
}
