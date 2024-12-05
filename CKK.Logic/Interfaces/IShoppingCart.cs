﻿using CKK.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Interfaces
{
    internal interface IShoppingCart
    {

        public int GetCustomerId()
        {
            return _customer.Id;

        }
        public ShoppingCartItem AddProduct(Product prod, int quantity)
        {
            if (quantity <= 0)
            {
                return null;
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
            if (quantity <= 0)
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
        public decimal GetTotal()
        {
            var grandtotal = 0m;
            foreach (var item in items)
            {
                grandtotal += item.GetTotal();
            }

            return grandtotal;
        }
        public ShoppingCartItem GetProductById(int id)
        {

            return items.Where(x => x.GetProduct().Id == id).FirstOrDefault();
        }
        public List<ShoppingCartItem> GetProducts()
        {
            
        }

    }
}
