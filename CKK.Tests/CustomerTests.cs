using CKK.Logic.Models;
using Xunit;
using Xunit.Sdk;
namespace CKK.Tests
{
    public class CustomerTests
    {
        [Fact]
        public void GetSetId_ShouldSetAndReturnCorrectId()
        {
            try
            {
                //Assemble
                Customer customer = new Customer();
                int expected = 12345;
                //Act
                customer.SetId(expected);
                int actual = customer.GetId();
                //Assert
                Assert.Equal(expected, actual);
            }
            catch
            {
                throw new XunitException("The correct Id was not given.");
            }
        }
    }
}