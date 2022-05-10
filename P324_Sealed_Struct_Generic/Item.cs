using System;
using System.Collections.Generic;
using System.Text;

namespace P324_Sealed_Struct_Generic
{
    class Item<T>
    {
        //public byte Quality;
        //public string _Quality;
        //public char _quality;

        //public Item(byte quality)
        //{
        //    Quality = quality;
        //}

        //public Item(string quality)
        //{
        //    _Quality = quality;
        //}

        //public Item(char quality)
        //{
        //    _quality = quality;
        //}

        public T Quality;

        public Item(T quality)
        {
            Quality = quality;
        }
    }
}
