using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Exceptions
{
    public class InvalidIdException : Exception
    {
        public InvalidIdException() : base("No numbers 0 or lower.")
        {

        }
        public InvalidIdException(string messageValue) : base(messageValue)
        {

        }
        public InvalidIdException(string messageValue, Exception inner) : base(messageValue, inner)
        {

        }
    }
}
