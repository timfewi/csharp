using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Book.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public Contact(int id, string name, string phoneNumber, string address, string email)
        {
            Id = id;
            Name = name;
            PhoneNumber = phoneNumber;
            Address = address;
            Email = email;
        }


        public override string ToString()
        {
            return $"Name: {Name}\nPhone Number: {PhoneNumber}\nAddress: {Address}\nEmail: {Email}";
        }

        public string ToFileString()
        {
            return $"{Name},{PhoneNumber},{Address},{Email}";
        }


        public static Contact FromFileString(string fileString)
        {
            string[] contactProperties = fileString.Split(',');
            return new Contact(0, contactProperties[0], contactProperties[1], contactProperties[2], contactProperties[3]);
        }
    }
}
