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
            if (jsonContent.Length > 0)
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
            Console.WriteLine("The Contact Details Available in Address Book are:\n");
            foreach (Person p in ContactList)
                Console.WriteLine(p.DisplayContact());
        }
    }
}
