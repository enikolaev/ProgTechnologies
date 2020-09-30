using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5
{

    enum Publishers
    {
        Кванта, Сигма, НаучЛит, ФизМатЛит
    }

    class Book
    {
        public Book(string pName, string pFN, string pSN, string pSu,
            int pP, float pPrice, Publishers pPub)
        {
            Name = pName; AuthorFName = pFN; AuthorSName = pSN;
            AuthorSurName = pSu; Pages = pP; Price = pPrice; pub = pPub;
        }

        public string GetCard()
        {
            string card = "********************************************\n" +
                $"Title: {Name} : by author {AuthorFullName} \n" +
                $"Pages: {Pages}; {AuthorShortlName}; Price: {Price}. \n" +
                $"Publisher: {pub} \n" +
                "********************************************\n";

            return card;
        }

        public string Card { get {
                return GetCard();
            } }

        public string AuthorFullName {
            get 
            {
                return AuthorSurName + " " + AuthorFName + " " + AuthorSName; 
            } 
        }

        public string AuthorShortlName
        {
            get
            {
                return AuthorSurName + " " 
                    + AuthorFName[0] + ". " + AuthorSName[0] + ".";
            }
        }

        public static void PrintBook(Book b)
        {
            Console.WriteLine(b.Card);
        }

        private string Name;
        private string AuthorFName, AuthorSName, AuthorSurName;
        private int Pages;
        private float Price;
        private Publishers pub;
    }
}
