using System;

public class Customer
{
    private int AccountID;

    private string Name;
    public string name   // property
    {
        get { return Name; }   
        set { Name = value; }  
    }
    private string Address;
    public string address   // property
    {
        get { return Address; }
        set { Address = value; }
    }
    private string EmailAddress;
    public string email   // property
    {
        get { return EmailAddress; }
        set { EmailAddress = value; }
    }
    private string contactNo;
    public string contact   // property
    {
        get { return contactNo; }
        set { contactNo = value; }
    }

    public Customer(int aid, string n, string addr, string email, string contact)
	{
        this.AccountID = aid;
        this.Name = n;
        this.Address = addr;
        this.EmailAddress = email;
        this.contactNo = contact;
	}



}
