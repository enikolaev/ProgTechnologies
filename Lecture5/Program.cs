using System;
using System.Collections.Generic;
using System.Diagnostics;
using static System.Console;

namespace Lecture5
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b;
            b = new Book("Hello book", "John", "Jerry", "Luis", 120, 23.89f,
                Publishers.Кванта);

            Library lib = new Library();
            lib.AddBook(b);
            lib.AddBook(
                new Book("Second book", "Mark", "Sou", "Woo", 540, 154.45f,
                Publishers.НаучЛит)
                );
            lib.AddBook(
                new Book("Wing of Liberty", "MaBirk", "Sou", "Woo", 12, 154.45f,
                Publishers.НаучЛит)
                );
            lib.AddBook(
                new Book("No name book", "Mark", "Sou", "Woo", 540, 154.45f,
                Publishers.Сигма)
                );
            lib.AddBook(
                new Book("Math in University", "Lisa", "Boil", "Jeromy", 540, 154.45f,
                Publishers.НаучЛит)
                );

            WriteLine(lib.GetAllBooks());

            string FileToSave = "mylib.txt";
            Storage store = new Storage(FileToSave);
            store.SaveLibrary(lib);

            Process.Start(FileToSave);


            ReadKey();
        }
    }
}