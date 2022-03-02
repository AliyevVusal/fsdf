using System;
using HomeWorkDelegate.Models;
using System.Collections;
using System.Collections.Generic;
using HomeWorkDelegate.Extensions;

namespace HomeWorkDelegate
{
    class Program
    {
        static Library library = new Library();

        static void Main(string[] args)
        {
            
            
            do
            {
                Console.WriteLine("Ali ve Ninoya Xos Geldiniz");
                Console.WriteLine("1 - Kitab Elave Ed");
                Console.WriteLine("2 - Kitab Silin");
                Console.WriteLine("3 - Kitab Silmek");
                Console.WriteLine("4 - ");
                Console.WriteLine("5 - Kitab Haqqinda Melumat");

                string choiseStr = Console.ReadLine();
                int choise;
                int.TryParse(choiseStr, out choise);
                while (!int.TryParse(choiseStr, out choise))
                {
                    choiseStr = Console.ReadLine();
                }

                switch (choise)
                {
                    case 1:
                        Console.Clear();
                        AddBook(library);
                        break;

                    case 2:
                        Console.Clear();
                        FindAllBookByName(library);
                        break;

                    case 3:
                        Console.Clear();
                        RemoveAllBookByName(library);
                        break;

                    case 4:
                        Console.Clear();
                        RemoveByNo(library);
                        break;

                    case 5:
                        Console.Clear();
                        SearchBooks(library);
                        break;
                    case 6:
                        Console.WriteLine("Programi istifade etdiyiniz ucun teshekurler 5 ulduz verersiniz!");
                        return;
                        
                }

            } while (true);

            
            


        }

        public static void AddBook(Library library)
        {
            Console.WriteLine("Kitabin Adin Daxil Edin");
            string name = Console.ReadLine();
            name.ChekTrueString();

            Console.WriteLine("Muelifin Adin Daxil Edin");
            string authorName = Console.ReadLine();
            authorName.ChekTrueString();

            Console.WriteLine("Kitabda Seife Sayin daxil edin");
            string pageCountStr = Console.ReadLine();
            int pageCount;
            int.TryParse(pageCountStr, out pageCount);
            while (!int.TryParse(pageCountStr, out pageCount) )
            {
                pageCountStr = Console.ReadLine();
            }

            library.AddBooks(name,authorName,pageCount);
            Console.WriteLine("Kitab Ugurla Elave Edildi!");
        }

        public static void FindAllBookByName(Library library)
        {
            Console.WriteLine("Axtardiginiz Kitab Adin Daxil Edin");
            string searchBookName = Console.ReadLine();
            searchBookName.ChekTrueString();
            library.FindAllBookByName(searchBookName);
        }

        public static void RemoveAllBookByName(Library library)
        {
            string removeBookName = Console.ReadLine();
            removeBookName.ChekTrueString();
            library.RemoveAllBookByName(removeBookName);
        }

        public static void RemoveByNo(Library library)
        {
            string no = Console.ReadLine();
            no.ChekTrueString();
            library.RemoveByNo(no);
        }

        public static void SearchBooks(Library library)
        {
            string bookName = Console.ReadLine();
            bookName.ChekTrueString();
            library.SearchBooks(bookName);

        }
    }
    
}
