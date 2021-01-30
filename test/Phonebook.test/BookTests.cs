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
            string expected = "01230123";

            phonebook.AddPhonenumber("Robert", "01230123");

            Assert.Equal(expected, phonebook.PhoneMap["Robert"]);
        }
    }
}
