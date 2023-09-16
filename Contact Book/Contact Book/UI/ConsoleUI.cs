using Contact_Book.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Book.UI
{
    internal class ConsoleUI
    {
        private readonly ContactbookRepository _repository;

        public ConsoleUI(ContactbookRepository contactbookRepository)
        {
            _repository = contactbookRepository;
        }

        public void Run()
        {
            bool continueRunning = true;
            while (continueRunning)
            {
                Console.Clear();
                Console.WriteLine("Wähle eine Option:");
                Console.WriteLine("1. Kontakt hinzufügen");
                Console.WriteLine("2. Kontakt löschen");
                Console.WriteLine("3. Kontakt anzeigen");
                Console.WriteLine("4. Alle Kontakte anzeigen");
                Console.WriteLine("5. Beenden");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddContact();
                        break;
                    case "2":
                        DeleteContact();
                        break;
                    case "3":
                        DisplayContact();
                        break;
                    case "4":
                        DisplayAllContacts();
                        break;
                    case "5":
                        continueRunning = false;
                        break;
                    default:
                        Console.WriteLine("Ungültige Auswahl. Bitte erneut versuchen.");
                        break;
                }
            }
        }

        private void AddContact()
        {
            Console.WriteLine("Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Telefonnummer:");
            string phoneNumber = Console.ReadLine();

            Console.WriteLine("Adresse:");
            string address = Console.ReadLine();

            Console.WriteLine("Email:");
            string email = Console.ReadLine();

            var contact = new Contact_Book.Models.Contact(0, name, phoneNumber, address, email);
            _repository.AddContact(contact);

            Console.WriteLine("Kontakt erfolgreich hinzugefügt.");
            Console.ReadLine(); // Warte auf Benutzereingabe, damit die Konsole nicht direkt geschlossen wird
        }

        private void DeleteContact()
        {
            Console.WriteLine("Kontakt loeschen:");
            Console.WriteLine("Gib den Namen des Kontakts ein:");
            string name = Console.ReadLine();
            if (_repository.GetOneContact(name) != null)
            {
                _repository.RemoveContactWithName(name);
                Console.WriteLine("Kontakt erfolgreich gelöscht.");
            }
            else
            {
                Console.WriteLine("Kontakt nicht gefunden.");
            }
            Console.ReadLine(); // Warte auf Benutzereingabe, damit die Konsole nicht direkt geschlossen wird
        }

        private void DisplayContact()
        {
            Console.WriteLine("Kontakt anzeigen:");
            Console.WriteLine("Gib den Namen des Kontakts ein:");
            string name = Console.ReadLine();
            var contact = _repository.GetOneContact(name);
            if (contact != null)
            {
                Console.WriteLine(contact.ToString());
            }
            else
            {
                Console.WriteLine("Kontakt nicht gefunden.");
            }
            Console.ReadLine(); // Warte auf Benutzereingabe, damit die Konsole nicht direkt geschlossen wird
        }

        private void DisplayAllContacts()
        {
            Console.WriteLine("Alle Kontakte anzeigen:");
            var contacts = _repository.GetAllContacts();
            if (contacts == null || !contacts.Any())
            {
                Console.WriteLine("Leider haben Sie keine Kontakte.");
            }
            else
            {
                foreach (var contact in contacts)
                {
                    Console.WriteLine(contact.ToString());
                    Console.WriteLine("----------------------------");
                }
            }
            Console.ReadLine(); // Warte auf Benutzereingabe
        }
    }
}