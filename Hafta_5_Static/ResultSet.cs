using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_5_Static
{
    public static class ResultSet
    {
        public static Result Action01()
        {
            return new Successed();
        }

        public static Result Action02(string message)
        {
            return new Successed(message);
        }

        public static Result Action03()
        {
            return new Failed();
        }

        public static Result Action04(string message)
        {
            return new Failed(message);
        }
    }
}
