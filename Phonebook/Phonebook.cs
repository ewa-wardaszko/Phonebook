using System;
using System.Collections.Generic;
using System.Text;

namespace Phonebook
{
    public class Phonebook
    {
        private List<Contact> contacts;

        public Phonebook()
        {
            contacts = new List<Contact>();
        }

        public Contact FindContact(string name)
        {
            foreach(var contact in contacts)
            {
                if (name == contact.Name)
                {
                    return contact;
                }
            }
            return null;
        }

        public void AddContact(string name, string number)
        {
            
            if (FindContact(name) !=null)
            {
                Console.WriteLine("The contact already exists.");
            }
            else
            {
                Contact contact = new Contact(name, number);
                contacts.Add(contact);
                Console.WriteLine("The contact has been added.");
            }
            
        }

        public void DeleteContact(string name)
        {
            var contactToBeDeleted = FindContact(name);
                if (contactToBeDeleted != null)
                {
                    contacts.Remove(contactToBeDeleted);
                    Console.WriteLine("The contact has been deleted!");
                }
                else
                {
                    Console.WriteLine("The contact doesn't exist already.");
                }
        }

        public void ShowContact(string name)
        {
            
            Contact contact = FindContact(name);
            if (contact != null)
            {
                Console.WriteLine($"Contact name: {contact.Name}");
                Console.WriteLine($"Contact phone number: {contact.PhoneNumber}");
            }
            else
            {
                Console.WriteLine("The contact couldn't be found.");
            }
            
        }
    }
}
