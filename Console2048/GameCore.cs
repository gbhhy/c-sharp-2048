using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2048
{
    /// <summary>
    /// 游戏核心类，负责处理游戏核心算法，与界面无关
    /// </summary>
    internal class GameCore
    {
        private int[,] matrix;
        private int[] mergeArr;
        private int[] moveZeroArray;
        private int[,] originalMatrix;
        public bool ChangeOrNot;
        public int[,] Matrix
        {
            get { return matrix; }
        }
        public GameCore()
        {
            matrix = new int[4,4];
            mergeArr = new int[4];
            moveZeroArray = new int[4];
            emptyLocationList = new List<Location>(16);
            random=new Random();
            originalMatrix = new int[4,4];
        }
        #region 数据合并
        private void MoveZero()
        {
            Array.Clear(moveZeroArray, 0, 4);
            int index = 0;
            for(int i=0; i<mergeArr.Length; i++)
            {
                if(mergeArr[i]!=0)
                {
                    moveZeroArray[index++] = mergeArr[i];
                }
            }
            moveZeroArray.CopyTo(mergeArr, 0);
        }
        private void Merge()
        {
            MoveZero();
            for(int i=0; i<mergeArr.Length-1; i++)
            {
                if(mergeArr[i]!=0&&mergeArr[i]==mergeArr[i+1])
                {
                    mergeArr[i] += mergeArr[i+1];
                    mergeArr[i+1] = 0;
                }
            }
            MoveZero();
        }
        #endregion
        #region 移动
        private void MoveUp()
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    mergeArr[row] = matrix[row, column];
                }
                Merge();
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, column] = mergeArr[row];
                }
            }
        }
        private void MoveDown()
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                for (int row = matrix.GetLength(0)-1; row >= 0; row--)
                {
                    mergeArr[matrix.GetLength(0)-1-row] = matrix[row, column];
                }
                Merge();
                for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                {
                    matrix[row, column] = mergeArr[matrix.GetLength(0) - 1 - row];
                }
            }
        }
        private void MoveLeft()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    mergeArr[column] = matrix[row,column];
                }
                Merge();
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    matrix[row,column] = mergeArr[column];
                }
            }
        }
        private void MoveRight()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = matrix.GetLength(1)-1; column >=0; column--)
                {
                    mergeArr[matrix.GetLength(1) - 1-column] = matrix[row, column];
                }
                Merge();
                for (int column = matrix.GetLength(1) - 1; column >= 0; column--)
                {
                    matrix[row, column] = mergeArr[matrix.GetLength(1) - 1 - column];
                }
            }
        }
        public void Move(MoveDirection dir)
        {
            Array.Copy(Matrix, originalMatrix, matrix.Length);
            ChangeOrNot = false;
            switch(dir)
            {
                case MoveDirection.Up:
                    MoveUp();
                    break;
                    case MoveDirection.Down:
                    MoveDown();
                    break;
                case MoveDirection.Left:
                    MoveLeft();
                    break;
                case MoveDirection.Right:
                    MoveRight();
                    break;
            }
            for(int row = 0; row < matrix.GetLength(0); row++)
            {
                for(int column = 0; column <matrix.GetLength(1); column++)
                {
                    if(matrix[row, column] != originalMatrix[row,column])
                    {
                        ChangeOrNot = true;
                        return;
                    }
                }
            }
        }
        #endregion
        #region 生成数字
        private List<Location> emptyLocationList;
        private void CalculateEmpty()
        {
            emptyLocationList.Clear();
            for(int row = 0; row < matrix.GetLength(0); row++)
            {
                for(int column=0;column < matrix.GetLength(1); column++)
                {
                    if(matrix[row, column] == 0)
                    {
                        emptyLocationList.Add(new Location(row, column));
                    }
                }
            }
        }
        private Random random;
        public void GenerateNumber()
        {
            CalculateEmpty();
            if (emptyLocationList.Count > 0)
            {
                int randomIndex = random.Next(0, emptyLocationList.Count);
                Location loc = emptyLocationList[randomIndex];
                matrix[loc.RowIndex, loc.ColumnIndex] = random.Next(0, 10) == 0 ? 4 : 2;
            }
        }
        #endregion
    }
}