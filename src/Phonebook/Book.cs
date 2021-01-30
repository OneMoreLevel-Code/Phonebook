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
            PhoneMap.Add(name, phonenumber);
        }

        public void printNumbers()
        {
            foreach (var name in PhoneMap)
            {
                System.Console.WriteLine(name);
            }
        }
        public string toString()
        {
            string returnString = "";
            foreach (var name in PhoneMap)
            {
                returnString += name;
            }
            return returnString;
        }
    }
}
