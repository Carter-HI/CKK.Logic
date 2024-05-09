using CKK.Logic.Models;
using Xunit;
using Xunit.Sdk;

namespace CKK.Tests
{
    public class ShoppingCartTests
    {
        [Fact]
        public void AddingProduct()
        {
            try
            {
                //Assemble
                Product product = new Product();
                int expected1 = 101;
                string expected2 = "Apple";
                decimal expected3 = 1;
                //Act
                product.SetId(expected1);
                product.SetName(expected2);
                product.SetPrice(expected3);
                int actual1 = product.GetId();
                string actual2 = product.GetName();
                decimal actual3 = product.GetPrice();
                //Assert
                Assert.Equal(expected1, actual1);
                Assert.Equal(expected2, actual2);
                Assert.Equal(expected3, actual3);
            }
            catch
            {
                throw new XunitException("The product was not added.");
            }
        }
        [Fact]
        public void RemovingProduct()
        {
            try 
            {
                Product product = new Product();
                int expected1 = 0;
                string expected2 = null;
                decimal expected3 = 0;
                //Act
                product.SetId(expected1);
                product.SetName(expected2);
                product.SetPrice(expected3);
                int actual1 = product.GetId();
                string actual2 = product.GetName();
                decimal actual3 = product.GetPrice();
                //Assert
                Assert.Equal(expected1, actual1);
                Assert.Equal(expected2, actual2);
                Assert.Equal(expected3, actual3);
            }
            catch
            {
                throw new XunitException("A product was not removed.");
            }
        }
        [Fact]
        public void GettingTotal()
        {
            try { }
            catch
            {
                throw new XunitException("Total is not accurate to the value that was entered.");
            }
        }
    }
}
