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

        private decimal _price;

       public decimal Price 
        {
            get { return Price; }
            set { 
                if (Price < 0) { throw new ArgumentOutOfRangeException(); } 
            } }

    }
}
