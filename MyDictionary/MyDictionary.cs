using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyList<K>
    {
        K[] units;


        public MyList()
        {
            units = new K[0];
        }


        public void Add(K unit)
        {
            K[] tempArray = units;
            units = new K[units.Length + 1];


            for (int i = 0; i < tempArray.Length; i++)
            {
                units[i] = tempArray[i];
            }

            units[units.Length - 1] = unit;
        }


        public K[] Units
        {
            get { return units; }
        }
    }
}
