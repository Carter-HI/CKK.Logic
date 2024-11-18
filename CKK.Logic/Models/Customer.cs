using CKK.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Customer : Entity
    {
        public Customer(int id, string name)  { }
        private string _address = "";

        string Address { get; set; }

    }
}
