using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day07
{
    internal class TeacherList
    {
        //字段
        private User[] data;
        private int currentIndex;
        //属性
        public int Count
        {
            get { return currentIndex; }
        }
        //构造函数
        public TeacherList(int capacity)
        {
            data = new User[capacity];
        }
        public TeacherList() : this(8) { }
        //方法
        public void Add(User value)
        {
            CheckCapacity();
            data[currentIndex++] = value;
        }
        public User GetElement(int index)
        {
            return data[index];
        }
        //ctrl+r+m 提取方法
        private void CheckCapacity()
        {
            if (currentIndex >= data.Length)
            {
                User[] newData = new User[data.Length * 2];
                data.CopyTo(newData, 0);
                data = newData;
            }
        }
    }
}
