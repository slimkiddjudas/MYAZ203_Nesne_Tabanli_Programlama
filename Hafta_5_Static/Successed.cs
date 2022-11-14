using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_5_Static
{
    public class Successed : Result
    {
        public Successed(string message) : base(true, message)
        {
            
        }

        public Successed() : base(true,"Successed.")
        {
            
        }
    }
}
