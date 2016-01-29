using System;


namespace AddressBook
{
    public class Contact
    {
        private string name { get; set; }                // First name.
        private long phoneNumber { get; set; }            // Phone number.
        
        public Contact()
        {
            this.name = "John Doe";
            this.phoneNumber = 9999999999;
        }

        public Contact(string a, long b)
        {
            name = a;
            phoneNumber = b;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public long PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
    }
}