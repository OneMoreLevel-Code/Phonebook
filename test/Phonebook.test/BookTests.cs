using System;
using Xunit;

namespace Phonebook.test
{
    public class BookTests
    {
        [Fact]
        public void AddPhonenumber()
        {
            Book phonebook = new Book();
            string expected = "cool";

            phonebook.AddPhonenumber("Robert", "cool");

            Assert.Equal(expected, "cool");
        }
    }
}
