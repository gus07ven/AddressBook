using System;

public class Contact
{
    String name;                // First name.
    String phoneNumber;            // Phone number.

	public Contact()
	{
	}

    public Contact(String name, String phoneNumber)
    {
        this.name = name;
        this.phoneNumber = phoneNumber;
    }

    public String getFirstName()
    {
        return firstName;
    }

    public void setName(String name)
    {
        this.name = name;
    }

    public String getPhoneNumber()
    {
        return phoneNumber;
    }

    public void setPhoneNumber(String phoneNumber)
    {
        this.phoneNumber = phoneNumber;
    }

}
