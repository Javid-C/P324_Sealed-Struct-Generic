using System;
using System.Collections.Generic;
using System.Text;

namespace P324_Sealed_Struct_Generic
{
    class StringList
    {
        private string[] arr;

        public int Count { get => arr.Length; }

        public StringList()
        {
            arr = new string[0];
        }

        public string[] getArr()
        {
            return arr;
        }

        public void Add(string word)
        {
            Array.Resize(ref arr, arr.Length + 1);

            arr[arr.Length - 1] = word;
        }
    }
}
