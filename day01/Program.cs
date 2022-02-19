using System;//引入命名空间

namespace day01//定义命名空间:类的住址[对类进行逻辑上的划分,避免重名]
{
    internal class Program//定义类[做工具]
    {
        static void Main(string[] args)//定义方法[做功能]
        {

                //ctrl+k+f 自动对齐
                //ctrl+k+c 注释选中代码
                // ctrl+k+u 取消注释
                Console.Title = "first program";
                Console.WriteLine("请输入枪的名称：");
                string gunName = Console.ReadLine();
                Console.WriteLine("请输入弹匣容量：");
                int magazineCapacity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入当前弹匣内子弹数量");
                int usingBullet = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入剩余子弹数量");
                int residualBullet = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("枪的名称是：" + gunName + ",弹匣容量：" + magazineCapacity + ",当前弹匣内子弹数量：" + usingBullet + ",剩余子弹数量：" + residualBullet);
                //console是类[工具]
                //writeline是方法[动词的功能]
                //title是属性[名词的修饰]
                //类.方法  调用语句:使用功能
                //c#变量在使用前必须赋值
            }
        }

}