using System;

namespace day08
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            //继承 static 结构体 2048核心类
            //子类可以使用父类成员 父类只能使用父类成员

            //父类型的引用可以指向子类的对象
            //但只能使用父类成员
            Person person01 = new Student();
            //如果需要访问子类成员，需要强转
            Student student01 = (Student)person01;
            //转换失败不会发生异常
            Teacher teacher01 = person01 as Teacher;
        }
        static void Main2()
        {
            Student student01 = new Student();
            Student student02=new Student();
            Student student03=new Student();
            //通过引用调用
            Console.WriteLine(student03.InstanceCount);
            //通过类名调用
            Console.WriteLine(Student.StaticCount);
        }
        static void Main()
        {
            
        }
    }
}
