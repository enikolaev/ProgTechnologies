using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5
{
    class Library
    {
        private List<Book> Books;


        public int BookCount
        {
            get { return Books.Count; }
        }

        public void AddBook(Book b)
        {
            Books.Add(b);
        }
        
        public Library()
        {
            Books = new List<Book>();
        }

        public string GetAllBooks()
        {
            string res = "";

            for (int i = 0; i < Books.Count; i++)
            {
                res += Books[i].Card;
            }

            return res;
        }        
    }
}
