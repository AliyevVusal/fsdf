using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace HomeWorkDelegate.Models 
{
    class Book
    {
        

        private int _code = 0;

        public string Code;

        public string Name { get; set; }

        public string AuthorName { get; set; }


        public int PageCount;
  

        public Book(string name,string authorName,int pageCount)
        {
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
            Code = $"{Name[0..2]}{_code}";
        }

        public override string ToString()
        {
            return $"Kitabin Adi : {Name}\nKitabin Muellifi : {AuthorName}\nKitabin Seife Sayi : {PageCount}\nKitabin Kodu : {Code}";
        }






    }
}
