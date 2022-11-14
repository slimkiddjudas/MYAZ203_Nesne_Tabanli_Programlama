using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_5_Static
{
    public class Failed : Result
    {
        public Failed(string message) : base(false, message)
        {
            
        }

        public Failed() : base(false,"Failed.")
        {
            
        }
    }
}
