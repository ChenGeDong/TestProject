using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListSample
{
    /// <summary>
    /// 链表的泛型实现
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedList<T>:IEnumerable<T>
    {
        public LinkedListNode<T> First { get; private set; }
        public LinkedListNode<T> Last { get;private set; }


        public LinkedListNode<T> Addlist(T node)
        {
            var newNode = new LinkedListNode<T>(node);
            if(First ==null)
            {
                First = newNode;
                Last = First;
            }
            else
            {
                LinkedListNode<T> previous = Last;
                Last.Next = newNode;
                Last = newNode;
            }
            return newNode;
        }

        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> current = First;
            while(current!= null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }



        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        //IEnumerator IEnumerable.GetEnumerator() => Getenumerator();
    }
}
