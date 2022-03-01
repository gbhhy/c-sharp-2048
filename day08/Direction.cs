using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day08
{
    internal struct Direction//值类型
    {
        private int rowIndex;//除非是static或const字段，否则不能赋值
        public int RowIndex
        {
            get { return rowIndex; }
            set { rowIndex = value; }
        }
        public int ColumnIndex { get; set; }
        //public Direction()
        //{

        //}
        //结构体不能包含无参数构造函数，因为结构体自带无参数构造函数
        public Direction(int rowIndex,int columnIndex):this()//先调用无参构造函数，为自动属性的字段赋值，结构中最好不写自动属性
        {
            this.RowIndex = rowIndex;
            this.ColumnIndex = columnIndex;
        }
        public static Direction Up
        {
            get { return new Direction(-1,0); }
        }
        public static Direction Down
        {
            get { return new Direction(1, 0); }
        }
        public static Direction Left
        {
            get { return new Direction(0, -1); }
        }
        public static Direction Right
        {
            get { return new Direction(0, 1); }
        }
    }
}
