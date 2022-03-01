using System;
using System.Collections.Generic;

namespace day07
{
    internal class Program
    {
        /*条件：
         * 1.任意多个枚举值做按位或（|）运算的 结果不能与其他枚举值相同（值以2的n方递增）
         * 2.定义枚举时，用[Flags]修饰
         * 
         * 判断标致枚举是否包含指定枚举值
         * 运算符&（按位与）：两个对应的二进制位中都为1，结果位为1
         */
        private static void PrintPersonStyle(PersonStyle style)//选择多个枚举值 运算符|（按位 或）两个
        {
            if((style&PersonStyle.tall)== PersonStyle.tall)
            {
                Console.WriteLine("高");
            }
            if((style & PersonStyle.rich) == PersonStyle.rich)
            {
                Console.WriteLine("富");
            }
            if((style&PersonStyle.handsome) == PersonStyle.handsome)
            {
                Console.WriteLine("帅");
            }
            if((style&PersonStyle.beautiful )!=0)
            {
                Console.WriteLine("美");
            }
            if((style&PersonStyle.white)!=0)
            {
                Console.WriteLine("白");
            }
        }
        static void Main1(string[] args)
        {
            PrintPersonStyle(PersonStyle.tall|PersonStyle.rich);
            //int==>Enum
            //数据类型转换：显式转换
            PrintPersonStyle((PersonStyle)2);
            //string==>Enum
            PersonStyle sty2=(PersonStyle) Enum.Parse(typeof(PersonStyle), "beautiful");
            PrintPersonStyle(sty2);
            //Enum==>string Tostring
        }
        static void Main2()//类和对象
        {
            Wife wife01=new Wife();
            wife01.SetName("悦悦");
            wife01.SetAge(20);
            wife01.Name = "悦";
            Console.WriteLine(wife01.Name);
        }
        static void Main3()
        {
            Wife[] wifeArray=new Wife[5];
            wifeArray[0]=new Wife("01",12);
            wifeArray[1] = new Wife("02", 28);
            wifeArray[2] = new Wife("03", 23);
            wifeArray[3] = new Wife("04", 17);
            wifeArray[4] = new Wife("05", 21);
            int age = FindYoungWife(wifeArray).Age;
            Console.WriteLine(age);
        }
        static void Main4()
        {
            UserList school=new UserList(5);
            school.Add(new User("ggg", "ddd"));
            school.Insert(new User("sss", "sss"), 0);
            school.Insert(new User("sss", "sss"), 0);
            school.Insert(new User("sss", "sss"), 0);
            school.Insert(new User("jss", "sss"), 0);
            school.Delete(2);
            school.PrintList();
        }
        static void Main()
        {
            //c#泛型集合 List<数据类型>
            //User[]              new User[]
            List<User>list=new List<User>();
            list.Add(new User());
            //Remove
            //RemoveAt
            //Insert
            //Count

            //字典集合  根据？查找？
            //键值对集合
            Dictionary<string, User> map=new Dictionary<string, User>();
            map.Add("hhy", new User());
            User hhy = map["hhy"];
        }
        private static Wife FindYoungWife(Wife[] array)
        {
            Wife youngestWife=new Wife("",100);
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i].Age<youngestWife.Age)
                {
                    youngestWife=array[i];
                }
            }
            return youngestWife;
        }
    }
}
