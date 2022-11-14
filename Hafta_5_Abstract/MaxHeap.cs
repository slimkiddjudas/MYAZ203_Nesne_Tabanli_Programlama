using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_5_Abstract
{
    public class MaxHeap : Heap
    {
        public override int Extract()
        {
            var itemMax = _list.Last();
            _list.Remove(itemMax);
            return itemMax;
        }
    }
}
