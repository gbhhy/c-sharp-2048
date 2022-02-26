using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day07
{
    internal class UserList
    {
        //字段
        private User[] data;
        //属性
        //构造函数
        public UserList() : this(8) { }
        public UserList(int capacity)
        {
            data=new User[capacity];
        }
        //方法
        public void Add(User value)
        {
            int count = 0;//计算循环执行次数，若执行满则说明数组已满
            for(int i = 0; i < data.Length; i++)
            {
                if(data[i] == null)
                {
                    data[i] = value;
                    break;
                }
                count++;
            }
            if(count==data.Length)
            {
                User[] temp=new User[data.Length+1];
                for(int i = 0; i < data.Length; i++)
                {
                    temp[i] = data[i];
                }
                temp[data.Length] = value;
                data = temp;
            }
        }
        public void Insert(User value,int index)
        {
            if(index < 0 || index >= data.Length)
            {
                throw new ArgumentOutOfRangeException("index");
            }
            User temp=new User();
            int count=0;
            for(int i = 0; i < data.Length; i++)
            {
                if(data[i]==null)
                {
                    temp = data[i - 1];
                    break;
                }
                count++;
            }
            if(temp==null)
            {
                temp=data[data.Length-1];
            }
            this.Add(temp);
            for(;count>index;count--)
            {
                data[count] = data[count-1];
            }
            data[index] = value;
        }
        public void Delete(int index)
        {
            for(int i=index;i<data.Length-1;i++)
            {
                data[i]=data[i+1];
            }
            int count=0;
            for(int i=0;i<data.Length;i++)
            {
                if(data[i]==null)
                {
                    data[i-1]=null;
                    break;
                }
                count++;
            }
            if(count==data.Length)
            {
                data[data.Length-1] = null;
            }
        }
        public void PrintList()
        {
            for(int i = 0; i < data.Length; i++)
            {
                data[i].PrintUser();
            }
        }
        public User GetElement(int index)
        {
            return data[index];
        }
    }
}
