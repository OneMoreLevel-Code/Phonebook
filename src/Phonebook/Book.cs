using System;
using System.Collections.Generic;

namespace Phonebook
{
    public class Book
    {
        Dictionary<string, string> PhoneMap { get; set; }
        public Book()
        {
           PhoneMap = new Dictionary<string, string>();   
        }

        public void AddPhonenumber(string name, string phonenumber)
        {
            PhoneMap[name] = phonenumber;
        }

        public void printNumbers()
        {
            foreach (var name in PhoneMap)
            {
                System.Console.WriteLine(name);
            }
        }
    }
}
