using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    internal class Product
    {
        private int id;
        private string name = "";
        private decimal price;


        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return this.id;
        }
        public string GetName()
        {
            return this.name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }

        public decimal GetPrice()
        {
            return this.price;
        }

        public void SetPrice(decimal price)
        {
            this.price = price;
        }
    }
}
