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
                            Console.WriteLine("{0}, {1}", list[i].Name, list[i].PhoneNumber);
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("Press any key to exit.");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine();
                        menu();
                        break;
                }
                selection = menu();
            } while (selection != 3);        
        }

        public static int menu()
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Add a contact.");
            Console.WriteLine("2. Show contact list.");
            Console.WriteLine("3. Exit.");
            string enter = Console.ReadLine();
            int input = Int32.Parse(enter);
            return input;
        }
    }
}
