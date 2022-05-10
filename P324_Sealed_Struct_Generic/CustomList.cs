using System;
using System.Collections.Generic;
using System.Text;

namespace P324_Sealed_Struct_Generic
{
    class CustomList<T> where T: class,IUser
    {

        private T[] arr;

        public int Count { get => arr.Length; }

        public CustomList()
        {
            arr = new T[0];
        }

        public T[] getArr()
        {
            return arr;
        }

        public void Add(T item)
        {
            Array.Resize(ref arr, arr.Length + 1);

            arr[arr.Length - 1] = item;
        }
    }
}
