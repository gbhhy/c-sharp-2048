using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day07
{
    internal class User
    {
        //字段
        private string loginID;
        //属性
        public string LoginID
        {
            get { return this.loginID; }
            set { this.loginID = value; }
        }
        //自动属性：包含一个字段两个方法
        public string Password { get; set; }
        //构造函数
        public User()
        {
        }
        public User(string loginID,string Password)
        {
            this.loginID = loginID;
            this.Password = Password;
        }
        //方法
        public void PrintUser()
        {
            Console.WriteLine("账号为{0}，密码为{1}",LoginID,Password);
        }
    }
}
