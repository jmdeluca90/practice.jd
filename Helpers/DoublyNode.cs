using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.jd.Helpers
{
    public class DoublyNode
    {
        public int Data;
        public DoublyNode Next;
        public DoublyNode Prev;

        public DoublyNode(int data)
        {
            Data = data;
            Next = null;
            Prev = null;
        }

    }
}
