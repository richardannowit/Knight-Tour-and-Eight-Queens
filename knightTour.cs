using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjChess
{
    class KnightTour : ChessAlgorithms
    {
        private int[] di = new int[8] { -2, -2, -1, -1, 1, 1, 2, 2 };
        private int[] dj = new int[8] { 1, -1, 2, -2, 2, -2, 1, -1 };
        int boardSize;
        bool isStop;
        int[,] tmpBoardDetail;
        int[,] boardResult;
        private bool _runSuccessful;

        struct nuocDi
        {
            public int n, x, y;
        }
        public KnightTour() : base()
        {
            // Ham sinh nuoc di -> Private void 
            // Ham next nuoc -> Dung ham tren de tao next nuoc -> Tuple<int,int>
            boardSize = base.boardDetail.kBoardSize;
            tmpBoardDetail = new int[boardSize, boardSize];
            boardResult = new int[boardSize, boardSize];
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    boardResult[i, j] = -1;
                    tmpBoardDetail[i, j] = -1;
                }

            }
            _runSuccessful = false;
            isStop = false;
        }

        public KnightTour(int _boardSize) : base(_boardSize)
        {
            // Ham sinh nuoc di -> Private void
            // Ham next nuoc -> Dung ham tren de tao next nuoc -> Tuple<int,int>
            boardSize = _boardSize;
            tmpBoardDetail = new int[boardSize, boardSize];
            boardResult = new int[boardSize, boardSize];
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    boardResult[i, j] = -1;
                    tmpBoardDetail[i, j] = -1;
                }
            }
            _runSuccessful = false;
            isStop = false;
        }

        private void resetState(int boardSize)
        {
            boardSize = base.boardDetail.getBoardSize();
            tmpBoardDetail = new int[boardSize, boardSize];
            boardResult = new int[boardSize, boardSize];
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    boardResult[i, j] = -1;
                    tmpBoardDetail[i, j] = -1;
                }
            }
            _runSuccessful = false;
            isStop = false;
        }

        private int getDegree(int x, int y)
        {
            int cnt = 0;
            for (int k = 0; k < 8; k++)
            {
                int u = x + di[k];
                int v = y + dj[k];
                if (u >= 0 && u < boardSize && v >= 0 && v < boardSize && tmpBoardDetail[u, v] == -1)
                {
                    cnt++;

                }
            }
            return cnt;
        }

        private void backtracking(int x, int y, int value)
        {
            //if (isStop) return;

            if (value == boardSize * boardSize)
            {
                _runSuccessful = true;
                updateResult();

            }

            if (value > boardSize * boardSize)
            {
                return;
            }

            nuocDi[] possibleSteps = new nuocDi[10];

            int cnt = 0;

            //for (int i = 0; i < 8; i++) possibleSteps[i].n = -1;

            for (int k = 0; k < 8; k++)
            {
                int u = x + di[k];
                int v = y + dj[k];
                if (u >= 0 && u < boardSize && v >= 0 && v < boardSize && tmpBoardDetail[u, v] == -1)
                {
                    nuocDi tmp;
                    tmp.n = getDegree(u, v);
                    tmp.x = u;
                    tmp.y = v;
                    possibleSteps[cnt++] = tmp;

                }
            }

            if (cnt > 0)
            {
                //Sort 
                for (int i = 0; i < cnt - 1; i++)
                {
                    for (int j = i + 1; j < cnt; j++)
                    {
                        if (possibleSteps[i].n > possibleSteps[j].n)
                        {
                            nuocDi tmp = possibleSteps[i];
                            possibleSteps[i] = possibleSteps[j];
                            possibleSteps[j] = tmp;
                        }
                    }
                }

                for (int i = 0; i < cnt && !_runSuccessful; i++)
                {
                    tmpBoardDetail[possibleSteps[i].x, possibleSteps[i].y] = value + 1;
                    backtracking(possibleSteps[i].x, possibleSteps[i].y, value + 1);
                    tmpBoardDetail[possibleSteps[i].x, possibleSteps[i].y] = -1;
                }
            }

        }
        public override bool runAlgorithm()
        {

            resetState(boardSize);
            Tuple<int, int> startPosition = base.getStartPosition();
            tmpBoardDetail[startPosition.Item1, startPosition.Item2] = 1;
            backtracking(startPosition.Item1, startPosition.Item2, 1);
            //printSolution();
            return _runSuccessful;
        }

        public void updateResult()
        {
            _runSuccessful = true;

            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    boardResult[i, j] = tmpBoardDetail[i, j];
                }
            }
        }

        public override Tuple<int, int> nextStep(int currentValue)
        {

            if (currentValue == boardSize * boardSize)
            {
                return Tuple.Create(-1, -1);
            }
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {

                    if (boardResult[i, j] == currentValue + 1)
                    {
                        return Tuple.Create(i, j);
                    }
                }
            }
            return Tuple.Create(-1, -1);
        }


        // DEBUG
        public override void printSolution()
        {
            //_runSuccessful = true;
            string kq = string.Empty;

            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    //boardResult[i, j] = tmpBoardDetail[i, j];
                    kq += (boardResult[i, j] + "\t");
                }
                kq += "\n";
            }
            System.IO.File.WriteAllText("test.txt", kq);
            System.Diagnostics.Process.Start("test.txt");
        }
    }
}
