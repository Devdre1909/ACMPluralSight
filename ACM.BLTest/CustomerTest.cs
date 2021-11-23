using ACM.BL;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest;

[TestClass]
public class CustomerTest
{
    [TestMethod]
    public void FullNameTestValid()
    {
        // ..Arrange
        Customer customer = new Customer
        {
            FirstName = "Temitope",
            LastName = "Adegoke"
        };
        string expected = "Adegoke, Temitope";

        // .. Acts
        string actual = customer.FullName;

        // .. Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void FullNameFirstNameEmpty()
    {
        // ..Arrange
        Customer customer = new Customer
        {
            LastName = "Adegoke"
        };
        string expected = "Adegoke";

        // ..Act
        string actual = customer.FullName;

        // ..Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void FullNameLastNameEmpty()
    {
        // ..Arrange
        Customer customer = new Customer
        {
            FirstName = "Temitope"
        };
        string expected = "Temitope";

        // ..Act
        string actual = customer.FullName;

        // ..Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void InstanceCountValid()
    {
        // ..Arrange
        Customer customer = new Customer();
        Customer.InstanceCount += 1;
        int expected = 1;

        // ..Act
        int actual = Customer.InstanceCount;

        // ..Assert
        Assert.AreEqual(expected, actual);
    }


}