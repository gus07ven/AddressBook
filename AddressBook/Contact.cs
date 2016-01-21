using System;

public class Contact
{
    String name;                // First name.
    int phoneNumber;            // Phone number.
    private string phone;

    public Contact()
	{
	}

    public Contact(String a, int b)
    {
        this.name = a;
        this.phoneNumber = b;
    }

    public Contact(string name, string phone)
    {
        this.name = name;
        this.phone = phone;
    }

    public String getFirstName()
    {
        return firstName;
    }

    public void setName(String name)
    {
        this.name = name;
    }

    public long getPhoneNumber()
    {
        return phoneNumber;
    }

    public void setPhoneNumber(int phoneNumber)
    {
        this.phoneNumber = phoneNumber;
    }

}
