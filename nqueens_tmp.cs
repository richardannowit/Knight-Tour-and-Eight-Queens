using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjChess
{
    class EightQueens : ChessAlgorithms
    {
        int boardSize;
        int[,] board;
        bool _runSuccessful;
        List<Tuple<int, int>> storeStep;
        public EightQueens() : base()
        {
            // Ham sinh nuoc di -> Private void 
            // Ham next nuoc -> Dung ham tren de tao next nuoc -> Tuple<int,int>
            boardSize = base.boardDetail.kBoardSize;
            board = new int[boardSize, boardSize];
            storeStep = new List<Tuple<int, int>>();

            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    board[i, j] = -1;
                }

            }
            _runSuccessful = false;
        }

        public EightQueens(int _boardSize) : base(_boardSize)
        {
            // Ham sinh nuoc di -> Private void
            // Ham next nuoc -> Dung ham tren de tao next nuoc -> Tuple<int,int>
            boardSize = _boardSize;
            board = new int[boardSize, boardSize];
            storeStep = new List<Tuple<int, int>>();

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
            storeStep = new List<Tuple<int, int>>();

            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    board[i, j] = -1;
                }

            }
            _runSuccessful = false;
        }




        private bool isValid(int row, int col)
        {
            for (int i = 0; i < row; i++) //check whether there is queen in the left or not
                if (board[i, col] == 1)
                    return false;
            for (int i = row, j = col; i >= 0 && j >= 0; i--, j--)
                if (board[i, j] == 1) //check whether there is queen in the left upper diagonal or not
                    return false;
            for (int i = row, j = col; i >= 0 && j < boardSize; i--, j++)
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
                    storeStep.Add(Tuple.Create<int, int>(row, col));
                    if (n_queens(row + 1)) return true;
                    board[row, col] = -1;

                }
                else
                {
                    storeStep.Add(Tuple.Create<int, int>(row, col));
                }
                //storeStep.Add(Tuple.Create<int, int>(row+1, col+1));



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
                //inKq();
            }
            return _runSuccessful;


        }


        public override Tuple<int, int> nextStep(int currentValue)
        {

            if (currentValue == storeStep.Count)
            {
                return Tuple.Create(-1, -1);
            }
            return Tuple.Create(storeStep[currentValue].Item1, storeStep[currentValue].Item2);
        }

        //DEBUG
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
            System.IO.File.WriteAllText("test1.txt", kq);
            System.Diagnostics.Process.Start("test1.txt");
        }
        private void inKq2()
        {
            string kq = string.Empty;

            foreach (Tuple<int, int> x in storeStep)
            {
                kq += (x.Item1 + ", " + x.Item2 + "\n");
            }
            System.IO.File.WriteAllText("test2.txt", kq);
            System.Diagnostics.Process.Start("test2.txt");
        }


    }
}
