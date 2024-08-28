using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Store
    {


        private int _id;
        private string _name = "";
        private List<StoreItem> items = new List<StoreItem>();
        


        public int GetId()
        {
            return _id;
        }
        public void SetId(int id)
        {
            _id = id;
        }
        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            _name = name;
        }

       public StoreItem AddStoreItem(Product prod, int quantity)
        {
            StoreItem foundItem = FindStoreItemById(prod.GetId());
            if(foundItem != null)
            {
                foundItem.SetQuantity(foundItem.GetQuantity() + quantity);
                return foundItem;
            }
            else
            {
                items.Add(new StoreItem(prod, quantity));
            }
            return null;
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
        public List<StoreItem> GetStoreItems()
        {
            return items;
        }
        public StoreItem FindStoreItemById(int id)
        {
            return items.Where(x => x.GetProduct().GetId() == id).FirstOrDefault();
        }
    }
}
