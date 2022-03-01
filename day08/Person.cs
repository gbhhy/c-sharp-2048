using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day08
{
    internal class Person
    {
        private int id;//孩子不能用
        protected int family;//仅仅本“家族”使用
        public string Name { get; set; }
    }
}
