using System;

namespace PhoneBookApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to PhoneBookApp!");

            Console.WriteLine("1. Add contact");
            Console.WriteLine("2. Display contact by number");
            Console.WriteLine("3. Display all contacts");
            Console.WriteLine("4. Search contacts");

            var userInput = Console.ReadLine();

            var phoneBook = new PhoneBook();

            switch (userInput)
            {
                case "1":

                    Console.WriteLine("Insert number");
                    var number = Console.ReadLine();
                    Console.WriteLine("Insert name");
                    var name = Console.ReadLine();

                    var newContact = new Contact(name, number);
            
                    phoneBook.AddContact(newContact);

                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }
        }
    }
}