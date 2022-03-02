using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkDelegate.Models
{
    public delegate bool Search(string search);

    class Library
    {
        List<Book> Books = new List<Book>();
        

        public void AddBooks(string name, string authorName, int pageCount)
        {
            Books.Add(new Book(name, authorName, pageCount)
            {
                Name = name,
                AuthorName = authorName,
                PageCount = pageCount
            }); ;


        }

        public void FindAllBookByName(string searchName)
        {
            foreach (Book book in Books)
            {
                if (book.Name == searchName)
                {
                    Console.WriteLine(book);
                }
            }
        }

        public void RemoveAllBookByName(string removeBookName)
        {
            foreach (Book book in Books)
            {
                if (book.Name == removeBookName)
                {
                    Books.Remove(book);
                    return;
                }


                //if (TrueOrFalse(removeBookName))
                //{
                //    Books.Remove(book);
                //}
                //else
                //{
                //    Console.WriteLine("Kitab Movcut deyil");
                //}


            }
            Console.WriteLine("xxxxxxx");
        }

        public void SearchBooks(string bookName)
        {
            foreach (Book item in Books)
            {
                if (item.Name == bookName)
                {
                    Console.WriteLine(item.ToString()); 
                }

            }

        }

        public void RemoveByNo(string no)
        {
            foreach (Book book in Books)
            {
                if (true)
                {
                    Books.Remove(book);
                }

            }

        }

        public bool TrueOrFalse(string name)
        {
            foreach (Book book in Books)
            {
                if (book.Name == name)
                {
                    return true;
                }                
            }

            return false;
        }

    }



}
