using Contact_Book.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Book.Models
{
    internal class Contactbook : IContactbookRepository
    {
    

        private List<Contact> contacts = new List<Contact>();

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }

        public void RemoveContact(Contact contact)
        {
            contacts.Remove(contact);
        }


        public Contact GetOneContact(string name)
        {
            try
            {
                return contacts.Single(c => c.Name == name);
            }
            catch (InvalidOperationException)
            {
                return null;
            }
        }

        public IEnumerable<Contact> GetAllContacts()
        {
            return contacts;
        }


        public void RemoveContactWithName(string name)
        {
            var contact = GetOneContact(name);
            if (contact != null)
            {
                RemoveContact(contact);
            }
        }


        public void UpdateContact(Contact contact)
        {
            var oldContact = GetOneContact(contact.Name);
            if (oldContact != null)
            {
                RemoveContact(oldContact);
                AddContact(contact);
            }
        }

        public void SaveChanges()
        {
            // Do nothing
        }
    }
}
