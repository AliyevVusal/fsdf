using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkDelegate.Extensions
{
    static class Extension
    {
        public static string ChekTrueString(this string strings)
        {
            while (string.IsNullOrWhiteSpace(strings))
            {
                Console.WriteLine("Deyeri Duzgun Daxil Edin!!!");
                strings = Console.ReadLine();
            }

            return strings;
        }


    }
}
