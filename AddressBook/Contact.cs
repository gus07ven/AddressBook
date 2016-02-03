using System;


namespace AddressBook
{
    public class Contact
    {
        public string name { get; set; }                // First name.
        public long phoneNumber { get; set; }            // Phone number.

        public Contact(string a, long b)
        {
            name = a;
            phoneNumber = b;
        }
    }
}