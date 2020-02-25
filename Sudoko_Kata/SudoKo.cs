using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoko_Kata
{
    public class Sudoko
    {
        public static bool ValidateSolution(int[][] board)
        {
            int sumSquare = 0;
            int sumRow = 0;
            int sumCol = 0;
            int squareMinRange = 0;
            int squareMaxRange = 2;
            bool boardState = false;

            for (int i = 0; i < 9; i++)
            {
                for (int row = 0; row < 9; row++)
                {
                    for (int col = 0; col < 9; col++)
                    {
                        sumRow += board[row][col];
                        sumCol += board[col][row];
                    }
                    for (int k = squareMinRange; k <= squareMaxRange; k++)
                        for (int j = squareMinRange; j <= squareMaxRange; j++)
                        {
                            sumSquare += board[k][j];
                        }
                    if (sumRow == sumCol && sumRow == 45 && sumSquare == 45)
                    {
                        boardState = true;
                        sumRow = 0;
                        sumCol = 0;
                        sumSquare = 0;
                        if (squareMaxRange + 3 > 8)
                        {
                            squareMinRange = 0;
                            squareMaxRange = 2;
                        }
                        else
                        {
                            squareMinRange += 3;
                            squareMaxRange += 3;
                        }
                    }
                    else
                    {
                        boardState = false;
                        break;
                    }
                }
            }

            return boardState;
        }
    }
}
