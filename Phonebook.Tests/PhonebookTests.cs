using System;
using Xunit;

namespace Phonebook.Tests
{
    public class PhonebookTests
    {
        [Fact]
        public void AnExpectedContactIsFound()
        {
            var phonebook = new Phonebook();

            Contact contact1 = new Contact("user1", "234567898");
            Contact contact2 = new Contact("user2", "333333333");
            Contact contactToBeFound = new Contact("user3", "666666666");
            Contact contact4 = new Contact("user4", "888888888");

            phonebook.AddContact(contact1.Name, contact1.PhoneNumber);
            phonebook.AddContact(contact2.Name, contact2.PhoneNumber);
            phonebook.AddContact(contactToBeFound.Name, contactToBeFound.PhoneNumber);
            phonebook.AddContact(contact4.Name, contact4.PhoneNumber);

            var FoundContact = phonebook.FindContact(contactToBeFound.Name);

            Assert.Equal("user3", FoundContact.Name);
            Assert.Equal("666666666", FoundContact.PhoneNumber);

        }

        [Fact]
        public void ANonExistingContactIsNotFound()
        {
            var phonebook = new Phonebook();

            var unknowContactName = "user";

            Contact contact1 = new Contact("user1", "234567898");
            Contact contact2 = new Contact("user2", "333333333");
            Contact contact3 = new Contact("user3", "666666666");

            phonebook.AddContact(contact1.Name, contact1.PhoneNumber);
            phonebook.AddContact(contact2.Name, contact2.PhoneNumber);
            phonebook.AddContact(contact3.Name, contact3.PhoneNumber);

            var FoundContact = phonebook.FindContact(unknowContactName);

            Assert.Null(FoundContact);
        }

        [Fact]
        public void ANewContactCanBeAddedIfItDoesntExist()
        {
            var phonebook = new Phonebook();

            Contact contact = new Contact("user1", "234567898");

            var FoundContact = phonebook.FindContact(contact.Name);

            Assert.Null(FoundContact);

            phonebook.AddContact(contact.Name, contact.PhoneNumber);

            FoundContact = phonebook.FindContact(contact.Name);

            Assert.Equal("user1", FoundContact.Name);
            Assert.Equal("234567898", FoundContact.PhoneNumber);
        }

        [Fact]
        public void AnExistingContactIsDeletedCorrectly()
        {
            var phonebook = new Phonebook();

            Contact contact = new Contact("user1", "234567898");
            phonebook.AddContact(contact.Name, contact.PhoneNumber);
            var FoundContact = phonebook.FindContact(contact.Name);

            Assert.NotNull(FoundContact);

            phonebook.DeleteContact(contact.Name);

            FoundContact = phonebook.FindContact(contact.Name);
            Assert.Null(FoundContact);
        }
    }
}
