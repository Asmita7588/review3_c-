using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review3
{
    internal class InsufficientFundException : Exception
    {
        public InsufficientFundException(string msg ) :base(msg) { }
    }
}
