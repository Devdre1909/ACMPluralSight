using System.Collections.Generic;

namespace ACM.BL;
public class Customer
{
    public Customer() { }
    public Customer(int customerId)
    {
        this.CustomerId = customerId;
    }
    public int CustomerId { get; private set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? EmailAddress { get; set; }
    public string FullName
    {
        get
        {
            if (string.IsNullOrEmpty(FirstName) && string.IsNullOrEmpty(LastName)) return "";
            if (string.IsNullOrEmpty(LastName) && !string.IsNullOrEmpty(FirstName)) return FirstName;
            if (string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName)) return LastName;
            return $"{LastName}, {FirstName}";
        }
    }

    public static int InstanceCount { get; set; }

    public bool ValidateData()
    {
        if (string.IsNullOrWhiteSpace(LastName)) return false;
        if (string.IsNullOrWhiteSpace(FirstName)) return false;
        return true;
    }

    public Customer RetrieveById(int customerId)
    {
        return new Customer();
    }

    public List<Customer> RetrieveAll()
    {
        return new List<Customer>();
    }

}
