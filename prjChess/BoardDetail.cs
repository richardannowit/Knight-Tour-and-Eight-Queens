using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjChess
{
    class BoardDetail
    {
        private int _cellSize;
        private int _boardSize;
        public int kCellSize = 90; // Default 50
        public int kBoardSize = 8; // Default 8


        private int[,] _board;

        public BoardDetail()
        {
            _cellSize = kCellSize;
            _boardSize = kBoardSize;
            _board = new int[_boardSize, _boardSize];
        }
        public BoardDetail(int boardSize)
        {
            if (boardSize <= 14)
            {
                _cellSize = 90;
            }
            else
            {
                _cellSize = kCellSize;
            }
            
            _boardSize = boardSize;
            _board = new int[_boardSize, _boardSize];
        }
        public BoardDetail(int boardSize, int cellSize)
        {
            _cellSize = cellSize;
            _boardSize = boardSize;
            _board = new int[_boardSize, _boardSize];
        }
        

        public void resetBoard()
        {
            for(int i=0; i<getBoardSize(); i++)
            {
                for (int j = 0; j < getBoardSize(); j++) 
                    _board[i, j] = -1;
            }
        }

        public int[,] getBoard()
        {
            int[,] newBoard = _board.Clone() as int[,];
            return newBoard;
        }
        public void setBoard(int[,] newBoard)
        {
            _board = newBoard.Clone() as int[,];
        }
        
        public int getCellSize()
        {
            return _cellSize;
        }

        public void setCellSize(int cellSize)
        {
            _cellSize = cellSize;
        }

        public int getBoardSize()
        {
            return _boardSize;
        }

        

        public Tuple<int, int> getCenterPosition(int row, int col)
        {
            // TODO: xử lý row col lớn hơn boardsize;
            int x = col * this.getCellSize() + this.getCellSize() / 5;
            int y = row * this.getCellSize() + this.getCellSize() / 5;
            return Tuple.Create(x, y);
        }


        //Chuyển toạ độ mảng sang toạ độ graphic
        public Tuple<int, int> getPosition(int row, int col)
        {
            // TODO: xử lý row col lớn hơn boardsize;
            int x = col * this.getCellSize();
            int y = row * this.getCellSize();
            return Tuple.Create(x, y);
        }

        //Chuyển từ vị trí graphic sang toạ độ mảng
        public Tuple<int, int> getDimensionFromPosition(int x, int y)
        {
            // TODO: xử lý row col lớn hơn boardsize;
            // x chia thanh nhieu phan thi se ra toa do cot
            int row = (int)Math.Ceiling(((double)y / this.getCellSize()))-1;
            int col = (int)Math.Ceiling((double)x / this.getCellSize())-1;
            return Tuple.Create(row, col);
        }


       

    }
}
