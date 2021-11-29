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
    public void InstanceCountAfterFirst()
    {
        // ..Arrange
        Customer customer = new Customer();
        Customer.InstanceCount++;
        Customer customer2 = new Customer();
        Customer.InstanceCount++;
        int expected = 2;

        // ..Act
        int actual = Customer.InstanceCount;

        // ..Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ValidateInvalidData()
    {
        // .. Arrange
        Customer customer = new Customer();
        bool expected = false;
        // .. Acts
        bool actual = customer.ValidateData();
        // .. Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ValidateValidData()
    {
        // .. Arrange
        Customer customer = new Customer
        {
            LastName = "Adegoke",
            FirstName = "Temitope"
        };
        bool expected = true;

        // ..Act
        bool actual = customer.ValidateData();

        // ..Assert
        Assert.AreEqual(expected, actual);
    }
}