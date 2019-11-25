using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stos
{
    public class StosWTablicy<T> : IStos<T>
    {
        private T[] tab;
        int szczyt = -1;

        public StosWTablicy(int size = 10)
        {
            tab = new T[size];
            szczyt = -1;
        }

        public T this[int index] => tab[index];

        public T Peek
        {
            get
            {
                if (IsEmpty)
                    throw new StosEmptyException();
                return tab[szczyt];
            }
        }

        public int Count
        {
            get
            {
                return szczyt + 1;
            }
        }

        public bool IsEmpty => szczyt == -1;

        public void Clear()
        {
            szczyt = -1;
        }

        public T Pop()
        {
            if (IsEmpty)
                throw new StosEmptyException();
            szczyt--;
            return tab[szczyt + 1];
        }

        public void Push(T value)
        {
            if (szczyt == tab.Length - 1)
            {
                Array.Resize<T>(ref tab, tab.Length * 2);
            }

            szczyt++;
            tab[szczyt] = value;
        }

        public T[] ToArray()
        {
            //return tab;//bardzo źle - reguły hermetyzacji
            T[] temp = new T[szczyt + 1];
            for (int i = 0; i < temp.Length; i++)
                temp[i] = tab[i];
            return temp;
        }

        public System.Collections.ObjectModel.ReadOnlyCollection<T> ToArrayReadOnly() => Array.AsReadOnly(tab);

        public void TrimExcess()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
                yield return this[i];
        }

        //klasa prywatna enumerator 
        //public IEnumerator<T> GetEnumerator() => new Enumerator(this);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public IEnumerable<T> TopToBottom
        {
            get
            {
                for (int i = Count - 1; i >= 0; i--)
                    yield return this[i];
            }
        }
        

        private class Enumerator : IEnumerator<T>
        {
            private StosWTablicy<T> stos;
            private int position = -1;
            internal Enumerator(StosWTablicy<T> stos) => this.stos = stos;
            public T Current => stos.tab[position];

            object IEnumerator.Current => Current;

            public void Dispose() {}

            public bool MoveNext()
            {
                if (position < stos.Count - 1)
                {
                    position++;
                    return true;
                }
                else return false;
            }

            public void Reset() => position = -1;
        }
    }
}
