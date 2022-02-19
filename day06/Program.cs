using System;
using System.Text;

namespace day06
{
    internal class Program
    {
        //交错数组
        static void Main1(string[] args)
        {
            //交错数组 参数数组 数据类型
            //交错数组 每个元素都是新的一维数组 数组组 “不规则的表格”
            int[][] arr=new int[4][];
            arr[0]=new int[5];
            arr[1]=new int[6];
            arr[0][3] = 3;
            //交错数组要用两次foreach，因为数组是元素
            //arr.length 交错数组元素数 可以理解为行数
        }
        //类型确定，个数不确定，用数组

        //params：参数数组对于方法内部，就是不同数组；
        //对于方法外面，可以传递数组，也可以传递一组数据类型相同的变量集合，甚至可以不传参
        //作用：简化调用者调用方法

        //F5跳到下一个断点
        //F12查看定义
        /*数值类型：值类型：结构，枚举；结构包含数值类型，bool，char
         * 引用类型：接口，类；类包含string，Array，委托
         */
        /// <summary>
        ///值类型与引用类型的应用
        /// </summary>
        static void Main2()//参数数组
        {
            //方法在栈中
            /*所以在方法中声明的变量都在栈中
             * 值类型直接存储数据，所以数据存储在栈中
             * 引用类型存储地址，数据存储在堆中
             */
            //面试题
            int a = 1;
            int b = a;
            a = 2;
            Console.WriteLine(b);

            int[] arr = {1};
            int[] arr2 = arr;
            arr[0] = 2;//修改堆中数据
            Console.WriteLine(arr2);

            int[] arr3 = { 1 };
            int[] arr4 = arr3;
            arr3 =new int[]{ 3,4};//修改栈中引用
            Console.WriteLine(arr4);

            string s1 = "男";
            string s2 = s1;
            s1 = "女";//s1[0]='女'不行，堆中的文字不能修改
            Console.WriteLine(s2);

            //object引用类型
            object o1 = 1;
            object o2 = o1;
            o1 = 2;
            Console.WriteLine(o2);
        }
        //值参数
        private static void fun(ref int a)
        {
            a = 2;
        }
        //引用参数 ref
        //输出参数 out 按引用传递：传递实参变量自身的内存地址
        //区别1：方法内部必须赋值
        //区别2：输出参数传递之前可以不赋值
        //out作用：返回多个结果
        //ref作用：修改数据
        //值参数作用：传递信息

        private static void Swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        private static void GetGirthAndSquare(int length,int width,out int square,out int girth)
        {
            square = length*width;
            girth = (length+width)*2;
        }
        static void Main3()
        {
            int a = 1,b=2;
            Swap(ref a,ref b);
            int square,girth;
            GetGirthAndSquare(a,b,out square,out girth);
            Console.WriteLine(square);
            //TryParse返回两个结果
            int result;
            bool re = int.TryParse("233--", out result);
        }
        static void Main4()
        {
            //字符串池：提高内存利用率
            //字符串的不可变性

            //可变字符串StringBuilder 一次开辟能容纳10个字符大小的空间
            //优点：避免产生垃圾；
            //可以在原有空间修改字符串
            //适用性：频繁对字符串操作
            StringBuilder builder = new StringBuilder(10);
            for (int i = 0; i < 10; i++)
            {
                builder.Append(i);
            }
            string result = builder.ToString();
        }
        //单词反转
        private static string ReverseWord(string str)
        {
            string[]rev=str.Split(' ');
            string newStr = "";
            for (int i = rev.Length-1;i>=0;i--)
            {
                newStr+=rev[i];
                if (i > 0)
                    newStr += " ";
            }
            return newStr;
        }
        //字符反转
        private static string ReverseCha(string )
        static void Main()
        {
            string str = "How are you";
            string result=ReverseWord(str);
            Console.WriteLine(result);
        }
    }
}
//GCgarbage collection