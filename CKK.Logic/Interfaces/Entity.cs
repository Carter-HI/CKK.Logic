using CKK.Logic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Interfaces
{
    public abstract class Entity
    {
        public int Id 
        { get { return Id; } set { if (Id < 0) { throw new InvalidIdException(); }
            } }
        public string name { get; set; }
    }
} 
