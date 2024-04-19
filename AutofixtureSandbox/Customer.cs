namespace AutofixtureSandbox;

public class Customer
{
    public string Name { get; set; }
    public DateTime Birthdate { get; set; }
    public List<Email> Emails { get; set; }
    public Address HomeAddress { get; set; }
    public string Phone { get; set; }

    public Customer(string name, DateTime birthdate, List<Email> emails, Address homeAddress, string phone)
    {
        Name = name;
        Birthdate = birthdate;
        Emails = emails;
        HomeAddress = homeAddress;
        Phone = phone;
    }
}