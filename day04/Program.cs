using System;
namespace day04
{
    internal class Program
    {
        //重载
        static void Main1(string[] args)
        {
            Console.WriteLine("{0}", GetSecond(2, 1, 1));
            //方法重载：方法名称相同，参数列表不同
            //作用：在不同条件下，解决同一类问题，让调用者仅仅记忆1个方法
        }
        private static int GetSecond(int minute)
        {
            return minute * 60;
        }
        private static int GetSecond(int minute, int hour)
        {
            return GetSecond(minute + hour * 60);
        }
        private static int GetSecond(int minute, int hour, int day)
        {
            return GetSecond(minute, hour + day * 24);
        }
        //递归优势：复杂问题简单化
        //劣势：性能差
        //注意：堆栈溢出
        private static int GetFactorial(int num)
        {
            if (num == 1) return 1;
            return GetFactorial(num - 1);
        }
        private static int GetNum(int num)
        {
            if (num == 1) return 1;
            else if (num % 2 == 0)
            {
                return num * (-1) + GetNum(num - 1);
            }
            else return num + GetNum(num - 1);
        }
        static float[] CreateArray()
        {
            Console.WriteLine("请输入学生人数");
            int count = int.Parse(Console.ReadLine());
            float[] array = new float[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("请输入第{0}个学生成绩", i + 1);
                array[i] = float.Parse(Console.ReadLine());
                while (array[i] < 0 || array[i] > 100)
                {
                    Console.WriteLine("数据有误，请再次输入");
                    array[i] = float.Parse(Console.ReadLine());
                }
            }
            return array;
        }
        private static float GetMax(float[] array)
        {
            float max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
        }
        static void Main2()
        {
            //声明
            int[] b;
            //初始化new 数据类型[容量]
            b = new int[3];
            int[] hhy = new int[6];
            float[] a = CreateArray();
            float max = GetMax(a);
            Console.WriteLine(max);
        }
        static int GetDays(int year, int month, int day)
        {
            int[] DaysOfMonth = { 31, LeapYearOrNot(year) ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int days = day;
            for (int i = 0; i < month - 1; i++)
            {
                days += DaysOfMonth[i];
            }
            return days;
        }
        /// <summary>
        /// 根据年份判断闰年还是平年的方法
        /// </summary>
        /// <param name="year">年份</param>
        /// <returns></returns>
        private static bool LeapYearOrNot(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                return true;
            }
            else
                return false;
        }
        static void Main3()
        {
            //初始化+赋值
            string[] array1;
            array1 = new string[] { "hhy", "is", "god" };
            //声明+初始化+赋值
            bool[] array2 = { true, false };
            float max = GetMax(new float[] { 3, 5, 7 });
            int days = GetDays(2022, 3, 5);
            Console.WriteLine(days);
        }
        static void Main4()
        {
            int[] array1 = { 2, 3, 5, 6 };
            /*
             foreach(元素类型 变量名 in 数组名称）
            {
                 变量名 即  数组每个元素
            }
            从头到尾 依次 读取(只能读) 数组元素
            不能修改，只能读全部
             */
            //优点：使用简单
            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }
            //var 推断类型，根据所赋数据，推断出类型
            //适用性：数据类型名称较长 缺点：代码可读性差
            var v1 = 1;
            var v2 = "33";

            //声明父类类型 赋值 子类对象
            Array arr01 = new int[2];
            Array arr02 = new float[2];
            //object万类之祖
            //声明object类型，赋值任意类型
            object o1 = 1;
            object o2 = 4.4;
        }
        //彩票生成器
        //红球：1-33  6个  不能重复
        //蓝球：1-16  1个
        /*1.在控制台中购买彩票的方法
         * “请输入第一个红球号码”
         * “号码不能超过1-33”
         * 2.随机产生一注彩票的方法int[7]
         * static Random random=new Random();本行语句放在方法外，类内
         * random.Next(1,34)
         * 红球号码不能重复，且按照从小到大排序
         * 3.两注彩票比较的方法，返回中奖等级
         * 先计算红球，蓝球中奖数量
         * 在Main中测试
         */
        //购买彩票的方法
        private static int[] BuyLottery()
        {
            int[] lottery = new int[7];
            for(int i=0;i<6;i++)
            {
                Console.WriteLine("请输入第{0}个红球号码，号码数字在1-33之间",i+1);
                int temp=int.Parse(Console.ReadLine());
                while(temp<=0||temp>33)
                {
                    Console.WriteLine("号码不能超过1-33，请重新输入");
                    temp=int.Parse(Console.ReadLine());
                }
                while(Array.IndexOf(lottery,temp)>=0)
                {
                    Console.WriteLine("当前号码已经存在，请重新输入");
                    temp= int.Parse(Console.ReadLine());
                }
                lottery[i] = temp;
            }
            Console.WriteLine("请输入第一个蓝球号码，号码数字在1-16之间");
            int blue = int.Parse(Console.ReadLine());
            while (blue <= 0 || blue > 16)
            {
                Console.WriteLine("号码不能超过1-16，请重新输入");
                blue = int.Parse(Console.ReadLine());
            }
            lottery[lottery.Length-1] = blue;
            return lottery;
        }
        static Random random = new Random();
        //生成彩票的方法
        private static int[] CreateLottery()
        {
            int[] lottery=new int[7];
            for(int i=0;i<6; i++)
            {
                int temp=random.Next(1,34);
                while(Array.IndexOf(lottery, temp) >= 0)
                {
                    temp = random.Next(1, 34);
                }
                lottery[i]=temp;
            }
            Array.Sort(lottery,0,6);
            lottery[lottery.Length - 1] = random.Next(1, 17);
            return lottery;
        }
        /// <summary>
        /// 比较两注彩票的方法
        /// </summary>
        /// <param name="buy">购买的彩票</param>
        /// <param name="create">生成的彩票</param>
        /// <returns></returns>
        private static int AwardLevel(int[] buy, int[] create)
        {
            bool blue = buy[buy.Length - 1] == create[create.Length - 1];
            int CountRed = 0;
            int award = 0;
            int[] RedNum = new int[6];
            Array.Copy(create, RedNum, 6);
            for (int i = 0; i < buy.Length - 1; i++)
            {
                if (Array.IndexOf(RedNum, buy[i]) >= 0)
                    CountRed++;
            }
            if(blue==true)
            {
                switch(CountRed)
                {
                    case 6:
                        award = 1;
                        break;
                        case 5:
                        award = 3;
                        break;
                    case 4:
                        award = 4;
                        break;
                        case 3:
                        award = 5;
                        break;
                    default:
                        award = 6;
                        break;
                }
            }
            else
            {
                switch(CountRed)
                {
                    case 6:
                        award=2;
                        break;
                    case 5:
                        award = 4;
                        break;
                        case 4 :
                        award = 5;
                        break;
                }
            }
            return award;
        }
        static void Main()
        {
            int[] buy = BuyLottery();
            int[] create = CreateLottery();
            int award=AwardLevel (buy,create);
            Console.WriteLine("恭喜你获得了{0}等奖", award);
        }
        //不写i++
    }
}