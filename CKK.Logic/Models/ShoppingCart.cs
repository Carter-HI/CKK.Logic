using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class ShoppingCart
    {
        private Customer _customer;
        private List<ShoppingCartItem> items = new List<ShoppingCartItem>();

        public ShoppingCart(Customer cust)
        {
            _customer = cust;
        }
        public int GetCustomerId()
        {
                return _customer.GetId();
            
        }
        public ShoppingCartItem AddProduct(Product prod, int quantity)
        {
            ShoppingCartItem foundItem = GetProductById(prod.GetId());
            if (foundItem != null)
            {
                foundItem.SetQuantity(foundItem.GetQuantity() + quantity);
            }
            else
            {
                items.Add(new ShoppingCartItem(prod, quantity));
            }
        }
        public ShoppingCartItem RemoveProduct(Product prod, int quantity)
        {
            ShoppingCartItem foundItem = GetProductById(prod.GetId());
            if (foundItem != null)
            {
                foundItem.SetQuantity(foundItem.GetQuantity() - quantity);
            }
            else if (quantity <= 0)
            {
                items.Remove(foundItem);
            }
        }
        public ShoppingCartItem GetProductById(int id)
        {
            return items.Where(x => x.GetProduct().GetId() == id).FirstOrDefault();
        }
        public decimal GetTotal()
        {
            var grandtotal = 0m;

            return grandtotal;
        }
        public ShoppingCartItem GetProduct()
        {

        }
    }
}
