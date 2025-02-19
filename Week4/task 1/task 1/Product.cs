using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    internal class Product
    {
        public string Title;
        public string Author;
        public string Publisher;
        public int ISBN;
        public int Copies;
        public Product(string title,string author,string publisher,int isbn,int copies )
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            ISBN = isbn;
            Copies = copies;
        }
    }
}
