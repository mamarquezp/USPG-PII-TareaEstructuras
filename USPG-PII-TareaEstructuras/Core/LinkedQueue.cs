using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USPG_PII_TareaEstructuras.Core
{
    internal class LinkedQueue<T>
    {
        private Node<T>? _head;
        private Node<T>? _tail;
        public int Count { get; private set; }
        public bool IsEmpty => _head == null;

        public void Enqueue(T item)
        {
            var node = new Node<T>(item);
            if (IsEmpty) _head = _tail = node;
            else
            {
                _tail!.Next = node;
                _tail = node;
            }
            Count++;
        }

        public T Dequeue()
        {
            if (IsEmpty) throw new InvalidOperationException("Cola vacía");
            var data = _head!.Data;
            _head = _head.Next;
            if (_head == null) _tail = null;
            Count--;
            return data;
        }

        public T Peek()
        {
            if (IsEmpty) throw new InvalidOperationException("Cola vacía");
            return _head!.Data;
        }
    }
}
