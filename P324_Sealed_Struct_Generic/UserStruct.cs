using System;
using System.Collections.Generic;
using System.Text;

namespace P324_Sealed_Struct_Generic
{
    struct UserStruct : IUser
    {

        public int X;
        public string Y;
        public string Id { get; set; }
        public  string Username{ get; set; }

        public Test UserStructed { get; set; }
        //public UserStruct(string id = "okay",string username = "username")
        //{
        //    Id = id;
        //    Username = username;
        //    X = 5;
        //}
    }

    struct Test
    {

    }
}
