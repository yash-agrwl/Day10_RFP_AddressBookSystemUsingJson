using System;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome To Computation Of Address Book System Problem\n");

            AddressBookManager manager = new();
            Person person = new();
            UserMenu();
            switch (Console.ReadLine())
            {
                case "A":
                    Console.WriteLine("\nEnter Details to Add New Contact-");
                    person.InputContact();
                    manager.AddPerson(person);
                    break;
                case "E":
                    Console.Write("\nEnter Name of the person to edit: ");
                    string name = Console.ReadLine();
                    manager.EditContactList(name);
                    break;
                default :
                    Console.WriteLine("\nInvalid Input.");
                    break;
            }
            
        }

        public static void UserMenu()
        {
            Console.WriteLine("Enter 'A' to add new contact.");
            Console.WriteLine("Enter 'E' to edit existing contact.");
            Console.Write("Input: ");
        }
    }
}
