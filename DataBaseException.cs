using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register
{
    internal class DataBaseException : Exception
    {
        public DataBaseException() : base() { }


        public DataBaseException(string message) : base(message) { }
    
    
    }
}
