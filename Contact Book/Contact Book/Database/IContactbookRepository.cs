using Contact_Book.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Book.Database
{
    public interface IContactbookRepository
    {
        void AddContact(Contact contact);
        void RemoveContact(Contact contact);
        void RemoveContactWithName(string name);
        void UpdateContact(Contact contact);
        Contact GetOneContact(string name);
        IEnumerable<Contact> GetAllContacts(); 

        void SaveChanges();

    }
}
