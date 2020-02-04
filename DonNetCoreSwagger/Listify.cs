using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


namespace DotNetCoreSwagger
{
    //Listify implements the IList interface to get an IEnmunerable (an unstructured array) to act like a List (a well defined, structured array)
    public class Listify : IList<int>
    {
        public int Start = 10;
        public int End = 20;
        IEnumerable<int> oIEnumerable;

        public Listify()
        {
            oIEnumerable = Enumerable.Range(Start, End).Select(x => x);
        }

        public Listify(int pStart, int pEnd)
        {
            Start = pStart;
            End = pEnd;
            oIEnumerable = Enumerable.Range(Start, End).Select(x => x);
        }

        readonly IList<int> _list = new List<int>();

        public int this[int index] { get => oIEnumerable.ElementAt<int>(index); set => throw new NotImplementedException(); }

        public int Count => Math.Abs(End - Start);

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(int item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(int item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(int[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<int> GetEnumerator()
        {
            return oIEnumerable.GetEnumerator();
        }

        public int IndexOf(int item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, int item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return oIEnumerable.GetEnumerator();
        }
    }
}
