using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjChess
{
    class EightQueens : ChessAlgorithms
    {
        int boardSize;
        int[,] board;
        bool _runSuccessful;
        public EightQueens() : base()
        {
            // Ham sinh nuoc di -> Private void 
            // Ham next nuoc -> Dung ham tren de tao next nuoc -> Tuple<int,int>
            boardSize = base.boardDetail.kBoardSize;
            board = new int[boardSize, boardSize];

            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    board[i, j] = -1;
                }

            }
            _runSuccessful = false;
        }

        public EightQueens(int boardSize) : base(boardSize)
        {
            // Ham sinh nuoc di -> Private void
            // Ham next nuoc -> Dung ham tren de tao next nuoc -> Tuple<int,int>
            boardSize = base.boardDetail.getBoardSize();
            board = new int[boardSize, boardSize];

            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    board[i, j] = -1;
                }

            }
            _runSuccessful = false;
        }

        private void resetState(int boardSize)
        {
            boardSize = base.boardDetail.getBoardSize();
            board = new int[boardSize, boardSize];

            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    board[i, j] = -1;
                }

            }
            _runSuccessful = false;
        }


        private void inKq()
        {
            string kq = string.Empty;

            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    //boardResult[i, j] = tmpBoardDetail[i, j];
                    kq += (board[i, j] + "\t");
                }
                kq += "\n";
            }
            System.IO.File.WriteAllText("test.txt", kq);
            System.Diagnostics.Process.Start("test.txt");
        }

        private bool isValid(int row, int col)
        {
            for (int i = 0; i < row; i++) //check whether there is queen in the left or not
                if (board[i, col] == 1)
                    return false;
            for (int i = row, j = col; i >= 0 && j >= 0; i--, j--)
                if (board[i, j] == 1) //check whether there is queen in the left upper diagonal or not
                    return false;
            for (int i = col, j = row; j >= 0 && i < boardSize; i++, j--)
                if (board[i, j] == 1) //check whether there is queen in the left lower diagonal or not
                    return false;
            return true;
        }
        private bool n_queens(int row)
        {
            if (row >= boardSize) return true;
            for (int col = 0; col < boardSize; col++)
            {
                if (isValid(row, col))
                {
                    board[row, col] = 1;
                    if (n_queens(row + 1)) return true;
                    board[row, col] = -1;

                }
            }
            return false;
        }
        public override bool runAlgorithm()
        {

            resetState(boardSize);
            Tuple<int, int> startPosition = base.getStartPosition();
            _runSuccessful = n_queens(0);
            if (_runSuccessful == true)
            {
                inKq();
            }
            return _runSuccessful;
        }


    }
}
