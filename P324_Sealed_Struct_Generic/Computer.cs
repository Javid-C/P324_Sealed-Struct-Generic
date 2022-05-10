using System;
using System.Collections.Generic;
using System.Text;

namespace P324_Sealed_Struct_Generic
{
    class Computer
    {
        public string Brand;
        public double Price;
        public string Ram;

        public Computer()
        {

        }
        public Computer(string brand, double price,string ram)
        {
            Brand = brand;
            Price = price;
            Ram = ram;
        }

        public override string ToString()
        {
            return $"{Brand}, {Price}, {Ram}";
        }
    }
}
