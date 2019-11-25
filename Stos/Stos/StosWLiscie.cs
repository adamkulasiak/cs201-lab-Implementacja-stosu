using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stos
{
    public class StosWLiscie<T> : IStos<T>
    {
        private Node<T> first;
        private Node<T> last;

        private class Node<T>
        {
            private T element;
            private Node<T> next;
            private Node<T> previous;

            public Node(T element)
            {
                this.element = element;
            }
        }
        public T this[int index] => throw new NotImplementedException();

        public T Peek => throw new NotImplementedException();

        public int Count => throw new NotImplementedException();

        public bool IsEmpty => throw new NotImplementedException();

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public T Pop()
        {
            throw new NotImplementedException();
        }

        public void Push(T value)
        {
            throw new NotImplementedException();
        }

        public T[] ToArray()
        {
            throw new NotImplementedException();
        }

        public void TrimExcess()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
