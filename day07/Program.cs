using System;

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
        static void Main(string[] args)
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
    }
}
