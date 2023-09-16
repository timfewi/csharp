using Contact_Book.Models;
using Contact_Book.Database;
using SQLitePCL;
using System;
using Contact_Book.UI;

namespace Contact_Book
{
    class Program
    {

        static void Main(string[] args)
        {
            SQLitePCL.Batteries.Init();

            var context = new ContactbookContext();
            var repository = new ContactbookRepository(context);
        

            var ui = new ConsoleUI(repository);
            ui.Run();
        }
    }
}
