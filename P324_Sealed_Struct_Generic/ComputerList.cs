using System;
using System.Collections.Generic;
using System.Text;

namespace P324_Sealed_Struct_Generic
{
    class ComputerList
    {

        private Computer[] arr;

        public int Count { get => arr.Length; }

        public ComputerList()
        {
            arr = new Computer[0];
        }

        public Computer[] getArr()
        {
            return arr;
        }

        public void Add(Computer comp)
        {
            Array.Resize(ref arr, arr.Length + 1);

            arr[arr.Length - 1] = comp;
        }
    }
}
