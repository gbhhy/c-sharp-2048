using System;

namespace Console2048
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameCore game = new GameCore();
            game.GenerateNumber();
            game.GenerateNumber();
            PrintDoubleArray(game.Matrix);
            while(true)
            {
                KeyDown(game);
                if (game.ChangeOrNot == true)
                {
                    game.GenerateNumber();
                    PrintDoubleArray(game.Matrix);
                }
            }
        }
        private static void PrintDoubleArray(Array arr)
        {
            Console.Clear();
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int column = 0; column < arr.GetLength(1); column++)
                {
                    Console.Write(arr.GetValue(row, column) + "\t");
                }
                Console.WriteLine();
            }
        }
        private static void KeyDown(GameCore game)
        {
            switch(Console.ReadLine())
            {
                case "w":
                    game.Move(MoveDirection.Up);
                    break;
                case "s":
                    game.Move(MoveDirection.Down);
                    break;
                case "a":
                    game.Move(MoveDirection.Left);
                    break;
                case "d":
                    game.Move(MoveDirection.Right);
                    break;
            }
        }
    }
}
