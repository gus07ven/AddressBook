using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class ManageContacts
    {
        List<Contact> list = new List<Contact>();

        static void Main(string[] args)
        {

            // Ask for user to select an option.
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Add contact");
            Console.WriteLine("2. List contacts");
            Console.WriteLine("3. Exit");
            String input = Console.ReadLine();

            // Loop while user does not select exit.
            do
            {
                switch (input)
                {
                    case "1":
                        AddContact();
                        break;
                    case "2":
                        ListContacts();
                        break;
                    default:
                        
                        break;
                }
            } while (input != "3");
        }


        static String AddContact()
        {
            Console.WriteLine("Please enter the name:");
            String name = Console.ReadLine();
            Console.WriteLine("Please enter the phone number:");
            String phone = Console.ReadLine();
            Contact addPerson = new Contact(name, phone);
            list.Add(addPerson);
            String message = "The name and phone number have been added";
            return message;
        }

        static Contact ListContacts()
        {
            foreach (Contact value in list)
                Console.WriteLine(value);
            return null;
        }

    }

}
