using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Testing
    {
      /* static void Main()
        {
            List<Contact> list2 = new List<Contact>();
            list2.Add(new Contact("Mike", 1234));
            list2.Add(new Contact("Ron", 56787));

            // Show all contacts in list.
            for (int i = 0; i < list2.Count; i++)
                Console.WriteLine("{0}. {1}, {2} ", i + 1, list2[i].name, list2[i].phoneNumber);

            // Select the contact to update.
            Console.WriteLine("Please select the number of the contact you would like to delete.");
            string contactSel = Console.ReadLine();
            int choice = Int32.Parse(contactSel) - 1;

            // Delete contact.
            list2.Remove(list2[choice]);
            Console.WriteLine("The contacts in the list are:");
            for(int i = 0; i < list2.Count; i++)
                Console.WriteLine("{0}. {1}, {2} ", i + 1, list2[i].name, list2[i].phoneNumber);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

            /*
            // Show all contacts in list.
            for (int i = 0; i < list2.Count; i++)
                Console.WriteLine("{0}. {1}, {2} ", i + 1, list2[i].name, list2[i].phoneNumber);

            // Select the contact to update.
            Console.WriteLine("Please select the number of the contact you would like to update.");
            string contactSel = Console.ReadLine();
            int choice = Int32.Parse(contactSel) - 1;

            // Check if contact exists.
            if ((list2.ElementAtOrDefault(choice) != null))

                // If contact exist pull contact and ask which field to update.
                Console.WriteLine("{0}. {1}, {2} ", choice + 1, list2[choice].name, list2[choice].phoneNumber);
                Console.WriteLine("To update name press 1, to update phone number press 2.");
                string selection2 = Console.ReadLine();
                int choice2 = Int32.Parse(selection2);

                // Update new name.
                    if (choice2 == 1)
                    {
                Console.WriteLine("Please enter the new name:");
                list2[choice].name = Console.ReadLine();
                Console.WriteLine("The name {0} has been updated.", list2[choice].name);
                Console.WriteLine("{0}. {1}, {2} ", choice + 1, list2[choice].name, list2[choice].phoneNumber);
                Console.ReadKey();
            }
                // Update new phone number.
            else {
                Console.WriteLine("Please enter the new phone number:");
                string newPhone = Console.ReadLine();
                long newPhone2 = long.Parse(newPhone);
                list2[choice].phoneNumber = newPhone2;
                Console.WriteLine("The new phone number {0} has been updated.", list2[choice].phoneNumber);
                Console.WriteLine("{0}. {1}, {2} ", choice + 1, list2[choice].name, list2[choice].phoneNumber);
                Console.ReadKey();
            }
           }  
           */                    
    }
}
