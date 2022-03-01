using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day08
{
    internal class Student:Person
    {
        //prop+tab+tab
        public int Score { get; set; }
        //实例成员：属于对象   静态成员static：属于类
        //每个对象都存储一份
        public int InstanceCount;
        //仅仅存储一份 所有对象共享
        //实例构造函数：提供创建对象的方式，初始化类的实例数据成员
        public static int StaticCount;
        public Student()
        {
            InstanceCount++;
            StaticCount++;
        }
        //静态构造函数不能用访问级别
        //静态构造函数作用：初始化类的静态数据成员
        //执行时机：类加载时调用一次
        static Student()
        {
            //静态代码块，只能访问静态成员
        }
        //静态方法通过类名调用，没有具体对象，不能访问实例成员

        //静态类不能被继承
    }
}
