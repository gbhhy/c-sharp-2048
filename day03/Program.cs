using System;

namespace day03
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            //短路逻辑
            int n1 = 1, n2 = 2;
            bool re1 = n1 > n2 && n1++ > 1;
            Console.WriteLine(n1);//1

            bool re2 = n1 < n2 || n2++ < 1;
            Console.WriteLine(n2);//2
        }

        static void Main2()
        {
            //loop
            //作用域：从声明开始，到}结束
            //continue；结束本次循环，直接进入下次循环
            //do while后面有分号

            //创建一个随机数工具
            Random rnd = new Random();
            //产生一个随机数
            rnd.Next(1, 101);
        }

        static void Main3()
        {
            Random rand = new Random();
            int randNum = rand.Next(1, 101);
            int inputNumber = 101;
            int count = 0;
            Console.WriteLine("请输入一到一百之间的随机数");
            do
            {
                inputNumber = int.Parse(Console.ReadLine());
                count++;
                if (inputNumber == randNum)
                {
                    Console.WriteLine("恭喜你猜对了！");
                }
                else if (inputNumber > randNum)
                {
                    Console.WriteLine("大了");
                }
                else
                {
                    Console.WriteLine("小了");
                }
            } while (inputNumber != randNum);//可以用break;
            //while(true)break;
            Console.WriteLine("你猜了{0}次！", count);
        }

        static void Main4()
        {
            string str = "whhy";
            string str1 = "wshhy1";
            string s = str.Remove(1, 2);
            s = str.Replace('s', 'y');
            bool d = str.StartsWith(str1);
            bool d2 = str1.Contains(str);
            Console.WriteLine(d2);
        }
        /*[访问修饰符][可选修饰符] 返回类型 方法名称（参数列表）
         * {
         *
         * 方法体
         * return 结果；
         * }
         * 调用方法：方法名称（参数）;
         * 注意c#中方法名称首字母必须大写*/
        private static void Fun1()//定义方法 void没有返回值
        {
            Console.WriteLine("Fun1执行了");
        }
        private static int Fun2()//定义方法 void没有返回值
        {
            Console.WriteLine("Fun2执行了");
            return 0;//返回数据，退出方法，没有返回值的方法也能写return，但不能带数据
        }

        static void Main()
        {
            Calendar(2022);
        }
        /*
         * 1.在控制台中显示年历
         * 2.在控制台中显示月历
         * -显示表头/t空格
         * -计算当月1日星期数，输出空格console.write()不换行
         * -计算当月天数，输入1\t
         * -每逢周六换行
         * 3.根据年月日，计算今天星期几
         * 4.计算指定月份的天数
         * 5.判断闰年平年区别，被4整除但不能被100整除，能被400整除
        */


        /// <summary>
        /// 根据年份，显示年历的方法
        /// </summary>
        /// <param name="year">年份</param>
        private static void Calendar(int year)
        {
            for(int i = 1; i <= 12; i++)
            {
                MonthlyCalendar(year,i);
            }
        }


        /// <summary>
        /// 在控制台显示月历的方法
        /// </summary>
        /// <param name="year">年份</param>
        private static void MonthlyCalendar(int year,int month)
        {
            Console .WriteLine("{0}年{1}月",year,month);
            Console.WriteLine("日\t一\t二\t三\t四\t五\t六");
            int cnt=0;
            //根据1日星期几显示空白
            for(int i=0;i< GetDayOfWeek(year, month, 1);i++)
            {
                Console.Write("\t");
                cnt++;
            }
            for(int i=1; i<=GetDayOfMonth(year, month);i++)
            {
                Console.Write("{0}\t",i);
                cnt++;
                if (cnt%7==0)
                {
                    Console.Write("\n");
                }
            }
            Console.Write("\n");
        }


        /// <summary>
        /// 计算指定月份的天数
        /// </summary>
        /// <param name="year">年份</param>
        /// <param name="month">月份</param>
        /// <returns></returns>
        private static int GetDayOfMonth(int year,int month)
        {
            int result = 0;
            if(LeapYearOrNot (year)&&month==2)
            {
                result = 29;
            }
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    result = 31;
                    break;
                case 2:
                    result = 28;
                    break;
                default:
                    result = 30;
                    break;
            }
            return result;
        }


        /// <summary>
        /// 根据年月日，计算星期几的方法
        /// </summary>
        /// <param name="year">年份</param>
        /// <param name="month">月份</param>
        /// <param name="day">天</param>
        /// <returns>星期几</returns>
        private static int GetDayOfWeek(int year, int month, int day)
        {
            DateTime dt = new DateTime(year, month, day);
            return (int)dt.DayOfWeek;
        }


        /// <summary>
        /// 根据年份判断闰年还是平年的方法
        /// </summary>
        /// <param name="year">年份</param>
        /// <returns></returns>
        private static bool LeapYearOrNot(int year)
        {
            if((year%4==0&&year%100!=0)||year%400==0)
            {
                return true;
            }
            else
                return false;
        }
    }
}