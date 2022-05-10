using System;
using System.Collections.Generic;
using System.Text;

namespace P324_Sealed_Struct_Generic
{
    abstract class Human
    {
        public string Name;
        public string Surname;


        public virtual void Info()
        {
            Console.WriteLine("Human info");
        }

        //public virtual void Salary()
        //{
        //    Console.WriteLine("5000$");
        //}

        public abstract void Salary();
    }
}
