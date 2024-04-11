using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    internal class StoreItem
    {
        private Product Product;
        private int Quantity;

        public StoreItem(Product product, int quantity)
        {
            this.Product = product;
            this.Quantity = quantity;
        }

        public int GetQuantity()
        {
            return this.Quantity;
        }

        public void SetQuantity(int quantity)
        {
            this.Quantity = quantity;
        }

        public Product GetProduct()
        {
            return this.Product;
        }
        public void SetProduct(Product product)
        {
            this.Product = product;
        }
    }
}
