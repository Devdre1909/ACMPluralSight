namespace ACM.BL;
public class Customer
{
    public int CustomerId { get; private set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
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
}
