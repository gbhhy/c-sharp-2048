using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day08
{
    /// <summary>
    /// 二维数组助手类
    /// </summary>
    static class DoubleArrayHelper
    {
        /// <summary>
        /// 获取二维数组元素
        /// </summary>
        /// <param name="arr">二维数组</param>
        /// <param name="rowIndex">行索引</param>
        /// <param name="columnIndex">列索引</param>
        /// <param name="dir">方向</param>
        /// <param name="count">希望查找的数量</param>
        /// <returns>所有满足条件的元素</returns>
        public static int[] GetElements(int[,] arr, int rowIndex, int columnIndex, Direction dir, int count)
        {
            List<int> result = new List<int>(count);
            for (int i = 0; i < count; i++)
            {
                rowIndex += dir.RowIndex;
                columnIndex += dir.ColumnIndex;
                if (rowIndex >= 0 && rowIndex < arr.GetLength(0) && columnIndex >= 0 && columnIndex < arr.GetLength(1))
                    result.Add(arr[rowIndex, columnIndex]);
            }
            return result.ToArray();
        }
    }
}
