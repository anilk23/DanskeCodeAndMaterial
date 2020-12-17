using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
   public class DuplicateKeyException : ApplicationException
    {
        public DuplicateKeyException(string msg) :base(msg)
        {
           
        }
    }
}
