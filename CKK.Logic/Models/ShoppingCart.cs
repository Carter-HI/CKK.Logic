﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Exceptions;
using CKK.Logic.Interfaces;

namespace CKK.Logic.Models
{
    public class ShoppingCart : IShoppingCart
    {
        private Customer _customer;
        private List<ShoppingCartItem> items = new List<ShoppingCartItem>();

        public ShoppingCart(Customer cust)
        {
            _customer = cust;
        }
        public int GetCustomerId()
        {
                return _customer.Id;
            
        }
        public ShoppingCartItem AddProduct(Product prod, int quantity)
        {
          if (quantity <= 0)
            {
                throw new InventoryItemStockTooLowException();
            }
          
                ShoppingCartItem foundItem = GetProductById(prod.Id);
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
        } 
        
        public ShoppingCartItem RemoveProduct(int id, int quantity)
        {
            ShoppingCartItem foundItem = GetProductById(id);

            if (foundItem == null)
            {
                throw new ProductDoesNotExistException();
            }
            if (quantity < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (quantity <= 0)
                {
                    return null;
                }
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
            if (id < 0)
            {
                throw new InvalidIdException();
            }
            return items.Where(x => x.GetProduct().Id == id).FirstOrDefault();
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
