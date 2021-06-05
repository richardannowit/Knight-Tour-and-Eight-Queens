using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjChess
{
    class ChessAlgorithms
    {
        private Tuple<int, int> _startPosition;
        public BoardDetail boardDetail;
        public ChessAlgorithms()
        {
            boardDetail = new BoardDetail();
        }
        public ChessAlgorithms(int boardSize)
        {
            boardDetail = new BoardDetail(boardSize);
        }

        public virtual Tuple<int,int> nextStep(int currentValue)
        {
            return new Tuple<int, int>(0, 0);
        }

        public virtual bool runAlgorithm()
        {
            return false;
        }

        public virtual void printSolution()
        {

        }

        public Tuple<int,int> getStartPosition()
        {
            //return _startPosition;
            return new Tuple<int, int>(_startPosition.Item1, _startPosition.Item2);
        }

        public void setStartPosition(Tuple<int, int> newPosition)
        {
            this._startPosition = new Tuple<int, int>(newPosition.Item1, newPosition.Item2);
        }

    }
}
