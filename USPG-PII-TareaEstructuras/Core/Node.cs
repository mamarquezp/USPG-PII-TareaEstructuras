using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USPG_PII_TareaEstructuras.Core
{
    internal class Node<T>
    {
        public T Data { get; set; }
        public Node<T>? Next { get; set; }
        public Node<T>? Prev { get; set; } // Usado solo en Deque

        public Node(T data)
        {
            Data = data;
        }
    }
}
