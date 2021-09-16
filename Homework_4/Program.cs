using System;
using System.Collections.Generic;

namespace Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int, string> novels = new MyList<int, string>();

            novels.Add(1, "Tutunamayanlar");
            novels.Add(2, "Ince Mehmed");



            foreach (var novel in novels.Values)
            {
                Console.WriteLine(novel);

            }

            foreach (var novel in novels.Keys)
            {
                Console.WriteLine(novel);
            }
        }
    
    }
        class MyList<Tkey, Tvalue>
        {
            Tkey[] keys;
            Tvalue[] values;
            public MyList() 
            {
                keys = new Tkey[0];
                values = new Tvalue[0];
            }

            public void Add (Tkey key , Tvalue value)
            {
                Tkey[] tempKey = keys;
                keys = new Tkey[keys.Length + 1];
                for (int i = 0; i < tempKey.Length; i++)
                {
                    keys[i] = tempKey[i];
                }
                keys[keys.Length - 1] = key;

                Tvalue[] tempValues = values;
                values = new Tvalue[values.Length + 1];

                for (int i = 0; i < tempValues.Length; i++)
                {
                    values[i] = tempValues[i];
                }
                values[values.Length - 1] = value;
            }

            public int Length
            {
                get { return keys.Length; }
            }

            public Tkey[] Keys
            {
                get { return keys; }
            }

            public Tvalue[] Values
            {
                get { return values; }
            }
        }

        
    

}
