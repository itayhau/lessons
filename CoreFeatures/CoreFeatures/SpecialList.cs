using System;
using System.Collections.Generic;
using System.Text;

namespace CoreFeatures
{
    /// <summary>
    /// List without dup
    /// List always sorted
    /// Pop first item
    /// Pop last item
    /// Push item
    /// </summary>
    public class MySpecialList
    {
        private List<int> m_numbers = new List<int>();
        private readonly int m_max;

        public int Max
        {
            get { return m_max; }
        }
        public int Count
        {
            get
            {
                return m_numbers.Count;
            }
        }
        public MySpecialList(int max)
        {
            if (max <= 0)
            {
                throw new ArgumentException("Container must have at least 1 item.");
            }
            m_max = max;
        }

        public bool Push(int item)
        {
            if (m_numbers.Contains(item))
                return false;
            if (m_numbers.Count >= Max)
            {
                throw new TooManyItemsException($"cannot insert {item} since list exceeds {Max} items.");
            }
            m_numbers.Add(item);
            m_numbers.Sort();
            return true;
        }

        public int PopFirst()
        {
            if (m_numbers.Count == 0)
                throw new EmptyCollectionException("Collection is empty.");
            int item0 = m_numbers[0];
            m_numbers.RemoveAt(0);
            return item0;
        }
        public int PopLast()
        {
            if (m_numbers.Count == 0)
                throw new EmptyCollectionException("Collection is empty.");
            int item_last = m_numbers[m_numbers.Count - 1];
            m_numbers.RemoveAt(m_numbers.Count - 1);
            return item_last;
        }
        public void Clear()
        {
            m_numbers.Clear();
        }
    }

}
