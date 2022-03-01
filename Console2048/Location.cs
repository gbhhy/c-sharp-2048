using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2048
{
    internal struct Location
    {
        public int RowIndex { get; set; }
        public int ColumnIndex { get; set; }
        public Location(int rowIndex,int columnIndex):this()
        {
            this.RowIndex = rowIndex;
            this.ColumnIndex = columnIndex;
        }
    }
}
