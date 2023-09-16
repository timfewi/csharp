using Contact_Book.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Book.Database
{
    internal class ContactbookContext : DbContext
    {

    public DbSet<Contact> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        optionsBuilder.UseSqlite("Data Source=C:\\Users\\konta\\source\\repos\\Contact Book\\Contact Book\\contactbook.db");
        }
    }
}
