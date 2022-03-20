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
            person.InputContact();
            
            manager.AddPerson(person);
        }
    }
}
