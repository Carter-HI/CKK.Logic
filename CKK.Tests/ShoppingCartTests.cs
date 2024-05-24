using CKK.Logic.Models;
using Xunit;
using Xunit.Sdk;

namespace CKK.Tests
{
    public class ShoppingCartTests
    {
        [Fact]
        public void AddingProductTest()
        {
            try
            {
                //Assemble
                ShoppingCart myshoppingCart = new ShoppingCart(new Customer { });
                Product product1 = new Product();
                product1.SetId(123);
                myshoppingCart.AddProduct(product1);
                ShoppingCartItem expectingItem = myshoppingCart.GetProduct(1);
                int expected = 123;
                //Act
                int actual = expectingItem.GetProduct().GetId();
                //Assert
                Assert.Equal(expected, actual);
            }
            catch
            {
                throw new XunitException("The item's id was not added. ");
            }
        }
        [Fact]
        public void RemovingProductTest()
        {
            try
            {
                //Assemble
                ShoppingCart myshoppingCart = new ShoppingCart(new Customer { });
                Product product1 = new Product();
                int quantity = 1;
                product1.SetId(0);
                myshoppingCart.AddProduct(product1);
                myshoppingCart.RemoveProduct(product1, quantity);
                ShoppingCartItem expectingItem = myshoppingCart.GetProduct(1);
                int expected = 0;
                //Act
                int actual = expectingItem.GetQuantity();
                //Assert
                Assert.Equal(expected, actual);

            }
            catch
            {
                throw new XunitException("The item's id was not removed. ");
            }
        }
        [Fact]
        public void GetTotalTest()
        {
            try
            {
                //Assemble
                ShoppingCart myshoppingCart = new ShoppingCart(new Customer { });
                Product product1 = new Product();
                product1.SetId(0);
                product1.SetPrice(123);
                myshoppingCart.AddProduct(product1);
                ShoppingCartItem expectingItem = myshoppingCart.GetProduct(1);
                decimal expected = 123;
                //Act
                decimal actual = expectingItem.GetProduct().GetPrice();
                //Assert
                Assert.Equal(expected, actual);
            }
            catch
            {
                throw new XunitException("The price is incorrect.");
            }
        }
    }
}
