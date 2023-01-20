using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register
{
    abstract class Document
    {
        public uint id;
        public DateTime dateSigned;


        abstract public string GetDetailedInfo();
              
        
    }
}
