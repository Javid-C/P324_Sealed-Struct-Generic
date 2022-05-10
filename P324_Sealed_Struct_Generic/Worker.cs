using System;
using System.Collections.Generic;
using System.Text;

namespace P324_Sealed_Struct_Generic
{
    class Worker : Human  /*sealed ola biler*/
    {
        public override void Info()
        {
            Console.WriteLine("Worker Info");
        }

        public override void Salary()
        {
            Console.WriteLine("300$");
        }
    }
}
