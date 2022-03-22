using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBookManager
    {

        public List<Person> ContactList;

        public AddressBookManager()
        {
            string jsonContent = File.ReadAllText(@"C:\Users\AGARWAL-PC\source\repos\Day10_RFP_AddressBookSystem\AddressBookSystem\AddressBook.json");
            if (jsonContent.Length > 2)
            {
                ContactList = JsonConvert.DeserializeObject<List<Person>>(jsonContent);
                this.DisplayContactList();
            }

            else
            {
                ContactList = new List<Person>();
                Console.WriteLine("The Address Book is Empty.\n");
            }
        }

        public void AddPerson(Person p)
        {
            ContactList.Add(p);
            string jsonContent = JsonConvert.SerializeObject(ContactList);
            File.WriteAllText(@"C:\Users\AGARWAL-PC\source\repos\Day10_RFP_AddressBookSystem\AddressBookSystem\AddressBook.json", jsonContent);
        }

        public void DisplayContactList()
        {
            Console.WriteLine("\nThe Contact Details Available in Address Book are:\n");
            foreach (Person p in ContactList)
                Console.WriteLine(p.DisplayContact());
        }

        public void EditContact(string name)
        {
            bool check = false;

            for (int i = 0; i < ContactList.Count; i++)
            {
                if(ContactList[i].FirstName == name)
                {
                    check = true;
                    Console.WriteLine("\nEnter new details-");
                    Console.Write("Enter First-Name: ");
                    ContactList[i].FirstName = Console.ReadLine();
                    Console.Write("Enter Last-Name: ");
                    ContactList[i].LastName = Console.ReadLine();
                    Console.Write("Enter Address: ");
                    ContactList[i].Address = Console.ReadLine();
                    Console.Write("Enter City: ");
                    ContactList[i].City = Console.ReadLine();
                    Console.Write("Enter State: ");
                    ContactList[i].State = Console.ReadLine();
                    Console.Write("Enter Zip-Code: ");
                    ContactList[i].ZipCode = int.Parse(Console.ReadLine());
                    Console.Write("Enter ContactNumber: ");
                    ContactList[i].PhoneNumber = long.Parse(Console.ReadLine());
                    Console.Write("Enter Email-Id: ");
                    ContactList[i].EmailId = Console.ReadLine();
                }
            }

            if (check)
                Console.WriteLine("\nContact Edited Successfully.\n");
            else
                Console.WriteLine("\nContact with the entered name does not exist.\n");

            string jsonContent = JsonConvert.SerializeObject(ContactList);
            File.WriteAllText(@"C:\Users\AGARWAL-PC\source\repos\Day10_RFP_AddressBookSystem\AddressBookSystem\AddressBook.json", jsonContent);
        }

        public void DeleteContact(string name)
        {
            bool check = false;

            for (int i = 0; i < ContactList.Count; i++)
            {
                if (ContactList[i].FirstName == name)
                {
                    check = true;
                    ContactList.Remove(ContactList[i]);
                }
            }

            if (check)
                Console.WriteLine("\nContact Deleted Successfully.\n");
            else
                Console.WriteLine("\nContact with the entered name does not exist.\n");

            string jsonContent = JsonConvert.SerializeObject(ContactList);
            File.WriteAllText(@"C:\Users\AGARWAL-PC\source\repos\Day10_RFP_AddressBookSystem\AddressBookSystem\AddressBook.json", jsonContent);
        }
    }
}
