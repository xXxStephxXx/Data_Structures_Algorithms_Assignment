using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures_algorithms_library
{
    public class Dbl_LinkedListNode<T>
    {
        public Dbl_LinkedListNode (T value)
        {
            Value = value;
        }

        public T Value { get; set; }
        public Dbl_LinkedListNode<T> Next { get; set; }
        public Dbl_LinkedListNode<T> Previous { get; set; }
    }
}
