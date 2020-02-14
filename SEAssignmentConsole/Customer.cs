using System;

public class Customer
{
    private int AccountID;
    private string Name;
    private string Address;
    private string EmailAddress;
    private string contactNo;
    
	public Customer(int aid, string n, string addr, string email, string contact)
	{
        this.AccountID = aid;
        this.Name = n;
        this.Address = addr;
        this.EmailAddress = email;
        this.contactNo = contact;
	}
}
