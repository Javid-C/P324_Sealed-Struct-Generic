using System;
using System.Collections.Generic;
using System.Text;

namespace P324_Sealed_Struct_Generic
{
    class User:IUser
    {
        public string Id { get; set; }
        public string Username { get; set; }

        public User UserTest { get; set; }

        public User()
        {
            
        }
    }
}
