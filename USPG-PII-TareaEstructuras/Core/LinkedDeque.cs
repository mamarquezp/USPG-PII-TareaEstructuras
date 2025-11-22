using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USPG_PII_TareaEstructuras.Core
{
    internal class LinkedDeque<T>
    {
        private Node<T>? _head;
        private Node<T>? _tail;
        public int Count { get; private set; }
        public bool IsEmpty => _head == null;

        public void InsertFront(T item)
        {
            var node = new Node<T>(item);
            if (IsEmpty) _head = _tail = node;
            else
            {
                node.Next = _head;
                _head!.Prev = node;
                _head = node;
            }
            Count++;
        }

        public void InsertRear(T item)
        {
            var node = new Node<T>(item);
            if (IsEmpty) _head = _tail = node;
            else
            {
                _tail!.Next = node;
                node.Prev = _tail;
                _tail = node;
            }
            Count++;
        }

        public T DeleteFront()
        {
            if (IsEmpty) throw new InvalidOperationException("Deque vacío");
            var data = _head!.Data;
            _head = _head.Next;
            if (_head == null) _tail = null;
            else _head.Prev = null;
            Count--;
            return data;
        }

        public T DeleteRear()
        {
            if (IsEmpty) throw new InvalidOperationException("Deque vacío");
            var data = _tail!.Data;
            _tail = _tail.Prev;
            if (_tail == null) _head = null;
            else _tail.Next = null;
            Count--;
            return data;
        }

        public T PeekFront() => IsEmpty ? throw new Exception("Vacío") : _head!.Data;
        public T PeekRear() => IsEmpty ? throw new Exception("Vacío") : _tail!.Data;
    }
}
