using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    public class CustomExceptions:Exception
    {
        public CustomExceptions() : base() { }
        public CustomExceptions(string str) : base(str) { }

    }
}
