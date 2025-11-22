using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USPG_PII_TareaEstructuras.Core
{
    internal class LinkedStack<T>
    {
        private Node<T>? _top;
        public int Count { get; private set; }
        public bool IsEmpty => _top == null;

        public void Push(T item)
        {
            var node = new Node<T>(item);
            node.Next = _top;
            _top = node;
            Count++;
        }

        public T Pop()
        {
            if (IsEmpty) throw new InvalidOperationException("Pila vacía");
            var data = _top!.Data;
            _top = _top.Next;
            Count--;
            return data;
        }

        public T Peek()
        {
            if (IsEmpty) throw new InvalidOperationException("Pila vacía");
            return _top!.Data;
        }
    }
}
