using CKK.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Interfaces
{
    internal interface IStore 
    {

        public StoreItem AddStoreItem(Product prod, int quantity)
        {
            if (quantity <= 0)
            {
                return null;
            }
            StoreItem foundItem = FindStoreItemById(prod.Id);
            if (foundItem != null)
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
            if (quantity <= 0)
            {
                return null;
            }
            StoreItem foundItem = FindStoreItemById(id);
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
        public StoreItem FindStoreItemById(int id)
        {

            return items.Where(x => x.GetProduct().Id == id).FirstOrDefault();
        }
        public List<StoreItem> GetStoreItems()
        {

        }
    }
}
