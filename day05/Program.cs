using System;

namespace day05
{
    internal class Program
    {
        //选择排序
        private static void sort(int[] ori)
        {
            for (int i = 0; i < ori.Length - 1; i++)
            {
                for (int j = i; j < ori.Length - 1; j++)
                {
                    if (ori[j] >= ori[j + 1])
                    {
                        int temp = 0;
                        temp = ori[j];
                        ori[j] = ori[j + 1];
                        ori[j + 1] = temp;
                    }
                }
            }
        }
        static void Main1(string[] args)
        {
            //数组分类：一维数组 多维数组 交错数组
            int[,] arr = new int[5, 3];
            //arr.length->15
            //foreach(int item in arr)
            //arr.GetLength(0)行数
            //arr.GetLength(1)列数
        }
        /*2048核心算法
         * 上移
         * 从上到下获取列数据，形成一维数组
         * 
         * 去零：将零元素移至末尾
         * 相邻相同则合并（将后一个元素累加到前一个元素上，后一个元素清零）
         * 去零
         * 
         * 将一维数组元素还原至原列
         * 
         * 下移
         * 
         * 左移
         * 
         * 右移
         * 
         * 1.定义去零方法
         * 2.合并数据方法
         * 3.上移方法
         * ......
         */
        /// <summary>
        /// 去零方法
        /// </summary>
        /// <param name="arr">需要去零的一维数组</param>
        /// <returns></returns>
        private static void putZero(int[] arr)
        {
            int[] newArr= new int[arr.Length];
            int index = 0;
            for(int i=0; i<arr.Length; i++)
            {
                if(arr[i] != 0)
                {
                    newArr[index++] = arr[i];
                }
            }
            newArr.CopyTo(arr,0);
        }
        /// <summary>
        /// 合并数据的方法
        /// </summary>
        /// <param name="arr">需要合并的一维数组</param>
        /// <returns></returns>
        private static void mergeArr(int[] arr)
        {
            for(int i=0;i<arr.Length-1;i++)
            {
                if (arr[i] == 0) continue;//统计合并位置
                if(arr[i]==arr[i+1])
                {
                    arr[i]+=arr[i+1];
                    arr[i + 1] = 0;
                }
            }
        }
        /// <summary>
        /// 去零+处理数据
        /// </summary>
        /// <param name="arr">需要的一维数组</param>
        /// <returns></returns>
        private static int[] processArr(int[] arr)
        {
            putZero(arr);
            mergeArr(arr);
            putZero(arr);
            return arr;
        }
        /// <summary>
        /// 上移方法
        /// </summary>
        /// <param name="matrix">原矩阵</param>
        /// <returns></returns>
        private static void upMove(int[,] matrix)
        {
            for(int i=0;i<matrix.GetLength(1);i++)
            {
                int[] newArr=new int[matrix.GetLength(0)];
                for(int j=0;j<matrix.GetLength(0);j++)
                {
                    newArr[j]=matrix[j,i];
                }
                newArr=processArr(newArr);
                for(int j=0;j<matrix.GetLength(0);j++)
                {
                    matrix[j,i]=newArr[j];
                }
            }
        }
        /// <summary>
        /// 下移方法
        /// </summary>
        /// <param name="matrix">原矩阵</param>
        /// <returns></returns>
        private static int[,] downMove(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                int[] newArr = new int[matrix.GetLength(0)];
                for (int j = matrix.GetLength(0)-1; j >= 0; j--)
                {
                    newArr[matrix.GetLength(0)-j-1] = matrix[j, i];
                }
                newArr = processArr(newArr);
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    matrix[j, i] = newArr[matrix.GetLength(0)-j-1];
                }
            }
            return matrix;
        }
        /// <summary>
        /// 左移方法
        /// </summary>
        /// <param name="matrix">原矩阵</param>
        /// <returns></returns>
        private static int[,] leftMove(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] newArr = new int[matrix.GetLength(1)];
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    newArr[j] = matrix[i, j];
                }
                newArr = processArr(newArr);
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = newArr[j];
                }
            }
            return matrix;
        }
        /// <summary>
        /// 右移方法
        /// </summary>
        /// <param name="matrix">原矩阵</param>
        /// <returns></returns>
        private static void rightMove(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] newArr = new int[matrix.GetLength(1)];
                for (int j = matrix.GetLength(1)-1; j >=0; j--)
                {
                    newArr[matrix.GetLength(1) - 1-j] = matrix[i, j];
                }
                newArr = processArr(newArr);
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = newArr[matrix.GetLength(0) - j - 1];
                }
            }
        }
        private static void Move(int[,] matrix,MoveDirection direction)
        {
            switch(direction)
            {
                case MoveDirection.Up:
                    upMove(matrix);
                    break;
                    case MoveDirection.Down:
                    downMove(matrix);
                    break ;
                    case MoveDirection.Left:
                    leftMove(matrix);
                    break;
                    case MoveDirection.Right:
                    rightMove(matrix);
                    break;
            }
        }
        /// <summary>
        /// 打印二维数组方法
        /// </summary>
        /// <param name="arr">需要打印的二维数组</param>
        private static void printDoubleArr(Array arr)
        {
            for(int i=0;i< arr.GetLength(0);i++)
            {
                for(int j=0;j< arr.GetLength(1);j++)
                {
                    Console.Write(arr.GetValue(i,j)+"\t");
                }
                Console.WriteLine();
            }
        }
        static void Main()
        {
            int[,] map = new int[4, 4]
            {
                {2, 0, 0, 0},
                {2, 4, 4, 4},
                {0, 8, 4, 0},
                {2, 4, 0, 4},
            };
            Move(map,MoveDirection.Up);
            printDoubleArr(map);
        }
    }
}