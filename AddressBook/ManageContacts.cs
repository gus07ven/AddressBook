using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class ManageContacts
    {
        static void Main()
        {
            List<Contact> list = new List<Contact>();

            int selection = menu();

            do
            {
                switch (selection)
                {
                    case 1:
                        Console.WriteLine("Please enter a name:");
                        string nameIn = Console.ReadLine();
                        Console.WriteLine("Please enter a phone number:");
                        string numIn = Console.ReadLine();
                        long phoneIn = Int64.Parse(numIn);
                        list.Add(new Contact(nameIn, phoneIn));
                        Console.WriteLine("The contact has been added");
                        Console.WriteLine();
                        break;
                    case 2:
                        for (int i = 0; i < list.Count; i++)
                            Console.WriteLine("{0}. {1}, {2}", i + 1, list[i].name, list[i].phoneNumber);
                        Console.WriteLine();
                        break;
                    case 3:
                        // Show all contacts in list.
                        for (int i = 0; i < list.Count; i++)
                            Console.WriteLine("{0}. {1}, {2} ", i + 1, list[i].name, list[i].phoneNumber);

                        // Select the contact to update.
                        Console.WriteLine("Please select the number of the contact you would like to update.");
                        string contactSel = Console.ReadLine();
                        int choice = Int32.Parse(contactSel) - 1;

                        // Check if contact exists.
                        if ((list.ElementAtOrDefault(choice) != null))

                            // If contact exist pull contact and ask which field to update.
                            Console.WriteLine("{0}. {1}, {2} ", choice + 1, list[choice].name, list[choice].phoneNumber);
                        Console.WriteLine("To update name press 1, to update phone number press 2.");
                        string selection2 = Console.ReadLine();
                        int choice2 = Int32.Parse(selection2);

                        // Update new name.
                        if (choice2 == 1)
                        {
                            Console.WriteLine("Please enter the new name:");
                            list[choice].name = Console.ReadLine();
                            Console.WriteLine("The name {0} has been updated.", list[choice].name);
                            Console.WriteLine("{0}. {1}, {2} ", choice + 1, list[choice].name, list[choice].phoneNumber);

                        }
                        // Update new phone number.
                        else {
                            Console.WriteLine("Please enter the new phone number:");
                            string newPhone = Console.ReadLine();
                            long newPhone2 = long.Parse(newPhone);
                            list[choice].phoneNumber = newPhone2;
                            Console.WriteLine("The new phone number {0} has been updated.", list[choice].phoneNumber);
                            Console.WriteLine("{0}. {1}, {2} ", choice + 1, list[choice].name, list[choice].phoneNumber);

                        }
                        break;
                    case 4:
                        // Show all contacts in list.
                        for (int i = 0; i < list.Count; i++)
                            Console.WriteLine("{0}. {1}, {2} ", i + 1, list[i].name, list[i].phoneNumber);

                        // Select the contact to update.
                        Console.WriteLine("Please select the number of the contact you would like to delete.");
                        string contactSel2 = Console.ReadLine();
                        int choice3 = Int32.Parse(contactSel2) - 1;

                        // Delete contact.
                        list.Remove(list[choice3]);
                        Console.WriteLine("The contacts in the list are:");
                        for (int i = 0; i < list.Count; i++)
                            Console.WriteLine("{0}. {1}, {2} ", i + 1, list[i].name, list[i].phoneNumber);
                        Console.WriteLine();
                        break;
                    default:
                        break;
                }
                selection = menu();
            } while (selection != 5);
        }

        public static int menu()
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Add a contact.");
            Console.WriteLine("2. Show contact list.");
            Console.WriteLine("3. Update contact information.");
            Console.WriteLine("4. Delete contact.");
            Console.WriteLine("5. Exit.");
            string enter = Console.ReadLine();
            int input = Int32.Parse(enter);
            return input;
        }
    }
}
