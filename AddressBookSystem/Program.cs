using System;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome To Computation Of Address Book System Problem");

            AddressBookManager manager = new();
            Person person = new();

            string input;
            do
            {
                UserMenu();
                input = Console.ReadLine();
                switch (input)
                {
                    case "A":
                        Console.WriteLine("\nEnter Details to Add New Contact-");
                        person.InputContact();
                        manager.AddPerson(person);
                        break;
                    case "D":
                        Console.Write("\nEnter Name of the person to delete: ");
                        string name = Console.ReadLine();
                        manager.DeleteContact(name);
                        break;
                    case "E":
                        Console.Write("\nEnter Name of the person to edit: ");
                        name = Console.ReadLine();
                        manager.EditContact(name);
                        break;
                    case "P":
                        manager.DisplayContactList();
                        break;
                    case "X":
                        Console.WriteLine("\nProgram Exited Successfully.");
                        break;
                    default:
                        Console.WriteLine("\nInvalid Input.\n");
                        break;
                }
            }
            while (input != "X");
        }

        public static void UserMenu()
        {
            Console.WriteLine("Enter 'A' to add new contact.");
            Console.WriteLine("Enter 'D' to delete an existing contact.");
            Console.WriteLine("Enter 'E' to edit an existing contact.");
            Console.WriteLine("Enter 'P' to display all address book contacts");
            Console.WriteLine("Enter 'X' to exit.");
            Console.Write("Input: ");
        }
    }
}
