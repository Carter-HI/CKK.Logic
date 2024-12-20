﻿using CKK.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Interfaces;
using CKK.Logic.Exceptions;

namespace CKK.Logic.Models
{
    public class Store : Entity , IStore
    {


        private List<StoreItem> items = new List<StoreItem>();
        




       public StoreItem AddStoreItem(Product prod, int quantity)
        {
            if (quantity < 0)
            {
                throw new InventoryItemStockTooLowException();
            }
            if (quantity <= 0)
            {
                return null;
            }
            StoreItem foundItem = FindStoreItemById(prod.Id);
            if(foundItem != null)
            {
                foundItem.SetQuantity(foundItem.GetQuantity() + quantity);
                return foundItem;
            }
            else
            {
                StoreItem temp = new StoreItem(prod, quantity); 
                items.Add(temp); 
                return temp;
            }
        }
        public StoreItem RemoveStoreItem(int id, int quantity)
        {
            StoreItem foundItem = FindStoreItemById(id);
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
        public List<StoreItem> GetStoreItems()
        {
            return items;
        }
        public StoreItem FindStoreItemById(int id)
        {
            if (id < 0)
            {
                throw new InvalidIdException();
            }
            return items.Where(x => x.GetProduct().Id == id).FirstOrDefault();
        }
    }
}
