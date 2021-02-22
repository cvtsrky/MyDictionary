using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T1,T2>
    {
        T1[] number;
        T2[] name;
        public MyDictionary()
        {
            number = new T1[0];
            name = new T2[0];
        }
        public void Add(T1 numbers , T2 names)
        {
            T1[] tempNo = number;
            T2[] tempName = name;

            number = new T1[number.Length + 1];
            name = new T2[name.Length + 1];

            for (int i = 0; i < tempNo.Length; i++)
            {
                number[i] = tempNo[i];
            }
            number[number.Length - 1] = numbers;

            for (int i = 0; i < tempName.Length; i++)
            {
                name[i] = tempName[i];
            }
            name[name.Length - 1] = names;

            

        }
        public void ToList()
        {
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i] + ":" + name[i]);
            }
        }
    }
}
