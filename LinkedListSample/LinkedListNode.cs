using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListSample
{
    /// <summary>
    /// linkedListNode的泛型版本
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedListNode<T>
    {
        public LinkedListNode(T value)
        {
            Value = value;
        }
        public T Value { get; private set; }

        public LinkedListNode<T> Next { get; internal set; }
        public LinkedListNode<T> Prev { get; internal set; }
    }
}
