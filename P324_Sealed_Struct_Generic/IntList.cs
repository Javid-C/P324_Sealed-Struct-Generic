using System;
using System.Collections.Generic;
using System.Text;

namespace P324_Sealed_Struct_Generic
{
    class IntList
    {
        private int[] arr;

        public int Count { get => arr.Length;}

        public IntList()
        {
            arr = new int[0];
        }

        public int[] getArr()
        {
            return arr;
        }

        public void Add(int num)
        {
            Array.Resize(ref arr, arr.Length + 1);

            arr[arr.Length - 1] = num;
        }
    }
}
