using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day07
{
    /// <summary>
    /// 定义 老婆 类
    /// </summary>
    internal class Wife
    {
        //数据成员
        //字段field 首字母小写
        private string name;
        private int age;
        //属性 首字母大写 属性是字段的外壳 本质就是两个方法 可以不写
        //实现只读只写，保护字段，通常一个公有属性和一个私有字段
        public string Name
        {
            get
                { return name; }
            set
                { name = value; }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("我不要");
                else
                    this.age = value;
            }
        }
        public int Gender
        {
            get;
            set;
        }//自动属性：包含一个字段两个方法
        //构造函数：提供了创建对象的方式，常常用于初始化类的数据成员
        //本质：方法
        //一个类若没有构造函数，那么编译器会自动提供一个无参数构造函数
        //一个类若有构造函数，编译器则不会提供
        //特点：没有返回值 与类同名 创建对象时自动调用（不能手动调用）
        //不希望在类的外部被创建对象，则将其私有化 private
        public Wife(string name,int age):this(name)//调用无参数构造函数
        {
            this.Name = name;//构造函数如果为字段赋值，属性中的代码块不会执行
            this.Age = age;
        }
        //构造函数重载
        public Wife()
        {
            Console.WriteLine("创建对象就执行");
        }
        public Wife(string name):this()
        {
            this.Name = name;
        }
        //方法成员
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return this.name;
        }
        public void SetAge(int age)
        {
            if (age < 0)
                throw new ArgumentOutOfRangeException("我不要");
            else
            this.age = age;
        }
        public int GetAge()
        {
            return age;
        }
    }
}
