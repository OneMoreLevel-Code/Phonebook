using System;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book phonebook = new Book();
            phonebook.AddPhonenumber("test", "0000000000");
            phonebook.printNumbers();
        }
    }
}
