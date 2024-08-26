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

       public void AddStoreItem(Product prod, int quantity)
        {
            StoreItem foundItem = FindStoreItemById(prod.GetId());
            if(foundItem != null)
            {
                foundItem.SetQuantity(foundItem.GetQuantity() + quantity);
            }
            else
            {
                items.Add(new StoreItem(prod, quantity));
            }
        }
        public void RemoveStoreItem(Product prod, int quantity)
        {
            StoreItem foundItem = FindStoreItemById(prod.GetId());
            if (foundItem != null)
            {
                foundItem.SetQuantity(foundItem.GetQuantity() - quantity);
            }
            else if (quantity < 0)
            {
                 quantity = 0;
            }
        }
        public List<StoreItem> GetStoreItem()
        {
            
        }
        public StoreItem FindStoreItemById(int id)
        {
            return items.Where(x => x.GetProduct().GetId() == id).FirstOrDefault();
        }
    }
}
