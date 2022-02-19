using System;

namespace day02
{
    internal class Program
    {
        static void Main1(string[] args)//占位符
        {
            string gunName = "AK47";
            string ammoCapacity = "30";
            //占位符{位置的编号}如果编号大于参数列表长度，则异常
            string str = string.Format("枪的名称为：{0}，容量为{1}。", gunName, ammoCapacity);
            //标准数字字符串格式化
            Console.WriteLine("金额：{0:c}", 10);//货币￥10.00
            Console.WriteLine("{0:d2}", 5);//05 不足2位用0填充
            Console.WriteLine("{0:f1}", 1.26);//根据指定精度显示
            Console.WriteLine("0:p1", 0.1);//10%百分数显示
            Console.WriteLine("我爱\"unity\"");//转义符 改变字符原始含义\" \'
            char c1 = '\'';
            char c2 = '\0';
            Console.WriteLine("你好，\r\n我是隔壁老王。");//\r回车\n换行\t tab
            //.Net编译过程
            //源代码（.cs的文本文件）——CLS编译（跨语言）——CIL通用中间语言（exe dll）——CLR编译（优化 跨平台）——机器语言
        }

        //运算符
        static void Main2()
        {
            int n1 = 29, n2 = 2;
            int r1 = n1 / n2;
            int r2 = n1 % n2;
            //%作用：
            //（1）判断一个数字能否被另外一个数字整除
            //n1是否能被2整除
            bool r3=n1%2==0;
            //（2）获取整数的个位
            int r4 = n1 % 10;
            string s1 = "5", s2 = "2";
            string s3 = s1 + s2;
            Console.WriteLine(s3);
            bool r10 = !true;
            //++无论先加后加对下一条指令都是自增后的值，先加，先自增，后返回值，只对当前指令有效
            //三目运算符：数据类型 变量名=条件？满足条件结果：不满足条件结果
            string str = 1 > 2 ? "yes" : "no";
        }

        static void Main3()
        {
            //数据类型转换
            //1.Parse转换：string转换为其他数据类型
            //待转数据必须像该数据类型
            string strNumber = "18";
            int num1=int.Parse(strNumber);
            float f1=float.Parse(strNumber);//18.0

            //2.ToString转换任意类型转化为string
            int number = 10;
            string s =number.ToString();

            //3.隐式转换：自动转换
            byte b3 = 100;
            int i3 = b3;

            //4.显示转换：强制转换
            int i4 = 100;
            byte b4 = (byte)i4;

            //表达式由多种变量参与运算，结果自动向较大的类型提升
            byte q = 1;
            short w = 2;
            short e = (short)(q + w);

            //快捷运算符不做自动类型提升
            byte b = 1;
            b += 7;//b=b+7;报错
            #region 方案  //vs专用
            string test = Console.ReadLine();
            int numInput=int.Parse(test);
            int numOutput = 0;
            for(int i=0; i<4; i++)
            {
                numOutput+=numInput%10;
                numInput=numInput/10;
            }
            Console.WriteLine(numOutput);
            #endregion
        }
        //语句
        static void Main4()
        {
            Console.WriteLine ("请输入第一个数字");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个数字");
            int num2=int.Parse(Console.ReadLine());
            Console.WriteLine("请输入运算符");
            char c=char.Parse(Console.ReadLine());
            if(c=='+')
            {
                Console.WriteLine("{0}", num1 + num2);
            }
            else if(c=='-')
            {
                Console.WriteLine("{0}", num1 - num2);
            }
            else if(c=='*')
            {
                Console.WriteLine ("{0}",num1*num2);
            }
            else if(c=='/')
            {
                Console.WriteLine ("{0}",num1 / num2);
            }
            else
            {
                Console.WriteLine("运算符输入有误");
            }
        }

        static void Main5()//switch(必须是值)default:其余的结果
        {
            char c=char.Parse(Console.ReadLine());
            int result;
            switch(c)
            {
                case '+':
                    result=1;
                    break;
                case '-': 
                    result=2;
                    break;
                default: result=3;
                    break;
            }
        }

        static void Main()
        {
            Console.WriteLine ("请输入月份");
            int month=int.Parse(Console.ReadLine());
            int day;
            if(month>=1&&month<=12)
            {
                switch(month)
                {
                    case 2:
                        day = 28;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        day = 30;
                        break;
                        default : day = 31;break;
                }
            }
            else
            {
                Console.WriteLine("输入有误");
            }
        }
    }
}
