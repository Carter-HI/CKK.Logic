using CKK.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Product : Entity
    {
        public Product(int id, string name)  { }
        private decimal _price;

       public decimal Price { get; set; }

    }
}
