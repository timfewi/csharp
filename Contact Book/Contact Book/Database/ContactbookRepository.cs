using Contact_Book.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Book.Database
{
    internal class ContactbookRepository : IContactbookRepository
    {
        private readonly ContactbookContext _context;

        public ContactbookRepository(ContactbookContext context)
        {
            _context = context;
        }

        public void AddContact(Contact contact)
        {
            
            _context.Contacts.Add(contact);
            SaveChanges();
        }
        public void RemoveContact(Contact contact)
        {
            _context.Contacts.Remove(contact);
            
        }

        public void RemoveContactWithName(string name)
        {
            var contact = GetOneContact(name);
            if (contact != null)
            {
                RemoveContact(contact);
                SaveChanges();
            }
        }

        public void UpdateContact(Contact contact)
        {
            _context.Contacts.Update(contact);
        }

        public Contact GetOneContact(string name)
        {
            try
            {
                return _context.Contacts.Single(c => c.Name == name);
            }
            catch (InvalidOperationException)
            {
                return null;
            }
        }

        public IEnumerable<Contact> GetAllContacts()
        {
            try
            {
                return _context.Contacts.ToList();
            }
            catch (InvalidOperationException)
            {
                return null;
            }
        }


        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
