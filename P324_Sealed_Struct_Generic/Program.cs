using System;

namespace P324_Sealed_Struct_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Worker worker = new Worker();

            //worker.Info();

            //Assign();

            //Nullable();

            //Item item = new Item(90);
            //Item item1 = new Item("Awesome");
            //Item item2 = new Item('A');

            //Console.WriteLine(item2._quality);

            //Item<string> item = new Item<string>("Awesome");
            //Item<byte> item1 = new Item<byte>(95);
            //Item<double> item2 = new Item<double>(95.4d);

            //Console.WriteLine(item.Quality);


            //Generics

            //IntList intList = new IntList();

            //intList.Add(5);
            //intList.Add(15);
            //intList.Add(25);
            //Console.WriteLine("Numbers");
            //foreach (int item in intList.getArr())
            //{
            //    Console.WriteLine(item);
            //}

            //StringList stringList = new StringList();

            //stringList.Add("Chingiz");
            //stringList.Add("Jamal");
            //stringList.Add("Fakhrin");

            //Console.WriteLine("Count: " + stringList.Count);

            //foreach (string word in stringList.getArr())
            //{
            //    Console.WriteLine(word);
            //}

            //Console.WriteLine("Computer section\n");

            Computer computer = new Computer("Lenova",2000.2d,"16GB");
            Computer computer1 = new Computer("HP",1500.2d,"8GB");
            Computer computer2 = new Computer("ASUS",3000.2d,"32GB");

            //ComputerList computerList = new ComputerList();

            //computerList.Add(computer);
            //computerList.Add(computer1);
            //computerList.Add(computer2);

            //Console.WriteLine("Computers count: " + computerList.Count);

            //foreach (Computer comp in computerList.getArr())
            //{
            //    Console.WriteLine(comp);
            //}


            //CustomList<string> customStringList = new CustomList<string>();

            //customStringList.Add("Milk");
            //customStringList.Add("Coffee");
            //customStringList.Add("Tea");

            //foreach (string item in customStringList.getArr())
            //{
            //    Console.WriteLine(item);
            //}

            //CustomList<Computer> customComputerList = new CustomList<Computer>();

            //customComputerList.Add(computer);
            //customComputerList.Add(computer1);
            //customComputerList.Add(computer2);

            //foreach (Computer comp in customComputerList.getArr())
            //{
            //    Console.WriteLine(comp);
            //}


            //CustomList<int> customIntList = new CustomList<int>();

            //customIntList.Add(30);
            //customIntList.Add(90);
            //customIntList.Add(100);

            //foreach (int num in customIntList.getArr())
            //{
            //    Console.WriteLine(num);
            //}

            CustomList<User> customUserList = new CustomList<User>();

            customUserList.Add(new User
            {
                Id = "1cca"
            }) ;

            foreach (User user in customUserList.getArr())
            {
                Console.WriteLine(user);
            }





        }

        public static void Assign()
        {
            User user = new User();
            user.Id = "1cca-bcas";
            User user1 = user;
            user1.Id = "class type test";

            UserStruct userStruct = new UserStruct();

            userStruct.Id = "4jjg-ikba";

            UserStruct userStruct1 = userStruct;

            userStruct1.Id = "struct test";



            Console.WriteLine(user.Id);
            Console.WriteLine("\n" + userStruct.Id);

            Implementation();

        }


        public static void Nullable()
        {
            //User user = null;

            //user.Id = "11cc";

            //Console.WriteLine(user.Id);

            //UserStruct userStruct = default;
            //userStruct.Id = default;

            //UserStruct userStruct = new UserStruct();
            //Console.WriteLine(userStruct.Id);


            User user;

            

            //user.Id = "1cca";

            UserStruct userStruct1;
            userStruct1.X = 4;
            userStruct1.Y = "okay";

            //Console.WriteLine(userStruct1.Id);

        }


        public static void Implementation()
        {
            IUser user = new UserStruct();
            user.Id = "1cca";
            IUser user2 = user;
            user2.Id = "test";

            Console.WriteLine(user.Id);
           
        }
    }
}
