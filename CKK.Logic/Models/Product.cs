using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Product : Entity
    {
        public Product(int id, string name) : base(id, name)
        private decimal _price;


        public void SetId(int id)
        {
            _id = id;
        }

        public int GetId()
        {
            return _id;
        }
        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            _name = name;
        }

        public decimal GetPrice()
        {
            return _price;
        }

        public void SetPrice(decimal price)
        {
            _price = price;
        }
    }
}
