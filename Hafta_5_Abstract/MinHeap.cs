using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_5_Abstract
{
    public class MinHeap : Heap
    {
        public override int Extract()
        {
            var minItem = _list.First();
            _list.Remove(minItem);
            return minItem;
        }
    }
}
