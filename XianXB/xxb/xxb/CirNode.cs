using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xxb
{
    public class CirNode<T>
    {
        public T Item { get; set; }
        public CirNode<T> Next { get; set; }

        public CirNode()
        {
        }

        public CirNode(T item)
        {
            this.Item = item;
        }
    }
}
