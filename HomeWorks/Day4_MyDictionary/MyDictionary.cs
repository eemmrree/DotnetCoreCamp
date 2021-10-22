using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_MyDictionary
{
    class MyDictionary<TKey , TValue>
    {
        TKey[] keys;
        TValue[] values;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            TKey[] tempKeys = keys;
            TValue[] tempValues = values;
            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];
            for (int i = 0; i < keys.Length - 1; i++)
            {
                keys[i] = tempKeys[i];
            }
            keys[keys.Length - 1] = key;


            for (int i = 0; i < values.Length - 1; i++)
            {
                values[i] = tempValues[i];
            }
            values[values.Length - 1] = value;
        }
        public int Length
        {
            get { return keys.Length; }

        }
        public TValue[] Items
        {
            get { return values; }
        }
    }
}
