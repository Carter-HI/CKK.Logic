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
                return foundItem;
            }
            else
            {
                ShoppingCartItem temp = new ShoppingCartItem(prod, quantity);
                items.Add(temp);
                return temp;
            }
            return null;
        }
        public ShoppingCartItem RemoveProduct(int id, int quantity)
        {
            if (quantity <=0 )
            {
                return null;
            }
            ShoppingCartItem foundItem = GetProductById(id);
            if (foundItem != null)
            {
                if (foundItem.GetQuantity() - quantity <= 0)
                {
                    items.Remove(foundItem);
                    foundItem.SetQuantity(0);
                    return foundItem;
                }
                else
                {
                    foundItem.SetQuantity(foundItem.GetQuantity() - quantity);
                    return foundItem;
                }
            }
                return null;
        }
        public ShoppingCartItem GetProductById(int id)
        {
            
            return items.Where(x => x.GetProduct().GetId() == id).FirstOrDefault();
        }
        public decimal GetTotal()
        {
            var grandtotal = 0m;
            foreach(var item in items)
            {
                grandtotal += item.GetTotal();
            }

            return grandtotal;
        }
        public List<ShoppingCartItem> GetProducts()
        {
            return items;
        }
    }
}
