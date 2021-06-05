using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjChess
{
    public partial class Main : Form
    {
        Graphics gp;
        BoardDetail boardDetail;
        bool runSuccessful;
        int startPosX, startPosY, step, step1;
        ChessAlgorithms chessAlgo;
        public Main()
        {
            InitializeComponent(); 

            boardDetail = new BoardDetail(8);
            gp = pnChessboard.CreateGraphics();

            // Initialize Timer
            timer1 = new Timer();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 500-trbSpeed.Value;

            //Create background and fullscreen
            this.BackgroundImage = Properties.Resources.background;
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            //Add icon
            this.Icon = Properties.Resources.icon;

        }
        
        


        private void Main_Load(object sender, EventArgs e)
        {
            //initialize();
            initState();
            showBoard();
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            //initState();
            showBoard();
        }
        private void initState()
        {

            //------------------//
            btnRunAlgo.Enabled = false;
            pnChooseChess.Visible = true;
            pnConfig.Visible = false;
            picArrow.Visible = false;
            lblStartPosition.Visible = false;
            trbSpeed.Value = 250;
            //Reset choose Knight and Queens
            choiceQueen.Enabled = true;
            choiceQueen.Visible = true;
            lblQueen.Visible = true;
            choiceKnight.Enabled = true;
            choiceKnight.Visible = true;
            lblKnight.Visible = true;

            // Reset color in choose
            choiceKnight.BorderStyle = BorderStyle.FixedSingle;
            choiceKnight.BackColor = SystemColors.Control;
            choiceQueen.BorderStyle =BorderStyle.FixedSingle;
            choiceQueen.BackColor = SystemColors.Control;
            //resetKnightState(true);


            //Turn on controller
            btnStart.Enabled = true;
            btnStop.Enabled = true;
            btnNextStep.Enabled = true;


            // Hide controller
            label1.Visible = false;
            trbSpeed.Visible = false;
            btnStart.Visible = false;
            btnStop.Visible = false;
            btnNextStep.Visible = false;
            btnResetState.Visible = false;

            picArrow.Image = Properties.Resources.arrow;
            
        }

        private void loadSpeed()
        {
            timer1.Interval = 500 - trbSpeed.Value; 
        }

        public void initialize()
        {
            //gp = pnChessboard.CreateGraphics();

            //chessAlgo = new KnightTour(boardSize);
            //chessAlgo = new EightQueens();
            rdKnight.Checked = true;
            step = 1;
            step1 = 0;
            startPosX = 0;
            startPosY = 0;
            runSuccessful = false;
            timer1.Interval = 500 - trbSpeed.Value;

        }

        private void initBoard()
        {
            initialize();
            pnChessboard.Visible = true;
            pnUnderChessBoard.Visible = true;
            //MessageBox.Show(boardDetail.getBoardSize().ToString());
            pnChessboard.Invalidate();
            pnUnderChessBoard.Invalidate();
            drawTable(7, boardDetail.getCellSize());
            drawTable(8, boardDetail.getCellSize());

            
        }

        public void showBoard()
        {
            
            initBoard();
            //drawTable(boardDetail.getBoardSize()-1, boardDetail.getCellSize()-1);
            drawTable(8, boardDetail.getCellSize());
            btnRunAlgo.Enabled = true;
            pnChooseChess.Visible = true;
            lblQueen.Text = "Tám quân hậu";
        }
        private void btnInitBoard_Click(object sender, EventArgs e)
        {
            initBoard();
            //drawTable(boardDetail.getBoardSize()-1, boardDetail.getCellSize()-1);
            drawTable(8, boardDetail.getCellSize());
            btnRunAlgo.Enabled = true;
            pnChooseChess.Visible = true;

            lblQueen.Text = "Tám quân hậu";
        }
        


        /*
         *  Draw Components
         */

        public void drawCell(Graphics gp, int row, int col)
        {
            int cellSize = boardDetail.getCellSize();
            SolidBrush brGreen = new SolidBrush(Color.MediumSeaGreen);
            SolidBrush brWhite = new SolidBrush(Color.White);

            if ((row + col) % 2 != 0)
            {
                gp.FillRectangle(brGreen, new RectangleF(col * cellSize, row * cellSize, cellSize-5, cellSize-5));
            }
            else
            {
                gp.FillRectangle(brWhite, new RectangleF(col * cellSize, row * cellSize, cellSize-5, cellSize-5));
            }
        }

        public void drawTable(int boardSize, int cellSize)
        {
            Graphics gp = pnChessboard.CreateGraphics();
            pnChessboard.Width = cellSize * boardSize;
            pnChessboard.Height = cellSize * boardSize;

            drawIndex(boardSize);



            for (int row=0; row< boardSize; row++)
            {
                for(int col = 0; col< boardSize; col++)
                {
                    drawCell(gp, row, col);


                }
            }
        }

        public void eraseChess(int row, int col)
        {
            Graphics gp = pnChessboard.CreateGraphics();
            drawCell(gp, row, col);
        }

        public void drawChess(Tuple<int, int> pos)
        {
            Graphics gp = pnChessboard.CreateGraphics();
            int row = pos.Item1;
            int col = pos.Item2;
            drawCell(gp, row, col);

            Image chess;
            if (rdKnight.Checked == true)
            {
                chess = Properties.Resources.ma;
            } else
            {
                chess = Properties.Resources.hau;
            }
            //gp.DrawImage(chess, new RectangleF(row+5, col+5, 50, 47));
            gp.DrawImage(chess, new RectangleF(row + 5, col + 7, 60, 57));

        }

        public void drawIndex(int boardSize)
        {
            Graphics gp = pnUnderChessBoard.CreateGraphics();

            Font drawFont = new Font("Arial", 16, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.MediumSeaGreen);
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;
            for (int row = 0; row<boardSize; row++)
            {
                String drawString = (row+1).ToString();
                

                int x = boardDetail.getCenterPosition(row, 0).Item1;
                int y = boardDetail.getCenterPosition(row, 0).Item2+pnChessboard.Location.Y;

                gp.DrawString(drawString, drawFont, drawBrush, x, y);
            }

            for (int col = 0; col < boardSize; col++)
            {
                String drawString = (col + 1).ToString();

                int x = boardDetail.getCenterPosition(0, col).Item1+pnChessboard.Location.X;
                int y = boardDetail.getCenterPosition(0, col).Item2;

                gp.DrawString(drawString, drawFont, drawBrush, x, y);
            }
        }

        public void drawNumber(int row, int col, int step)
        {
            Graphics gp = pnChessboard.CreateGraphics();

            drawCell(gp, row, col);

            String drawString = step.ToString();

            Font drawFont = new Font("Arial", 20, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Red);

            int x = chessAlgo.boardDetail.getCenterPosition(row, col).Item1;
            int y = chessAlgo.boardDetail.getCenterPosition(row, col).Item2;

            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;

            //gp.DrawString(drawString, drawFont, drawBrush, x, y);
            gp.DrawString(drawString, drawFont, drawBrush, x+3, y+3);
        }



        /*
         * RUN ALGORITHMS
         */


        private void resetKnightState(bool check)
        {
            rdKnight.Checked = check;
            choiceKnight.BorderStyle = check ? BorderStyle.Fixed3D : BorderStyle.FixedSingle;
            choiceKnight.BackColor = check ? Color.MediumSeaGreen : SystemColors.Control;
            rdQueen.Checked = !check;
            choiceQueen.BorderStyle = (!check) ? BorderStyle.Fixed3D : BorderStyle.FixedSingle;
            choiceQueen.BackColor = (!check) ? Color.MediumSeaGreen : SystemColors.Control;

            btnRunAlgo.Text = (check)?"Chạy thuật toán Mã đi tuần": "Chạy thuật toán "+ boardDetail.getBoardSize().ToString() + " quân hậu";

        }


        private void btnRunAlgo_Click(object sender, EventArgs e)
        {
            if (rdKnight.Checked == true)
            {
                chessAlgo = new KnightTour(boardDetail.getBoardSize());
            }
            else
            {
                chessAlgo = new EightQueens(boardDetail.getBoardSize());
                choiceKnight.Enabled = false;
                //choiceKnight.Visible = false;
                //lblKnight.Visible = false;
                choiceQueen.Enabled = false;
            }
            Tuple<int, int> startPosition = Tuple.Create(startPosX, startPosY);
            chessAlgo.setStartPosition(startPosition);
            runSuccessful = chessAlgo.runAlgorithm();
            loadSpeed();
            timer1.Enabled = true;

            btnStart.Enabled = false;
            btnStop.Enabled = true;

            btnRunAlgo.Enabled = false;

            //Show all controller
            label1.Visible = true;
            trbSpeed.Visible = true;
            btnStart.Visible = true;
            btnStop.Visible = true;
            btnNextStep.Visible = true;
            btnNextStep.Enabled = false;
            btnResetState.Visible = true;
            

        }

        private void nextStepQueen()
        {
            Tuple<int, int> currentPosition = chessAlgo.nextStep(step1);
            step1++;
            if (currentPosition.Item1 == -1 && currentPosition.Item2 == -1)
            {
                timer1.Enabled = false;
                if (runSuccessful == true)
                {
                    MessageBox.Show("Đặt hậu thành công", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đặt hậu thất bại", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                btnStart.Enabled = false;
                btnStop.Enabled = false;
                btnNextStep.Enabled = false;

                step1 = 0;
                return;
            }
            // Remove chesses from currentPosition.Item1 to down
            for(int row = currentPosition.Item1; row < chessAlgo.boardDetail.getBoardSize(); row++)
            {
                for(int col = 0; col< chessAlgo.boardDetail.getBoardSize(); col++)
                {
                    eraseChess(row, col);
                }
            }
            drawChess(chessAlgo.boardDetail.getPosition(startPosX, startPosY));
            drawChess(chessAlgo.boardDetail.getPosition(currentPosition.Item1, currentPosition.Item2));
        }

        private void nextStepKnight()
        {
            Tuple<int, int> currentPosition = chessAlgo.nextStep(step);
            Tuple<int, int> previousPosition = chessAlgo.nextStep(step - 1);
            drawNumber(previousPosition.Item1, previousPosition.Item2, step);
            step++;
            if (currentPosition.Item1 == -1 && currentPosition.Item2 == -1)
            {
                timer1.Enabled = false;
                if (runSuccessful == true)
                {
                    MessageBox.Show("Đi tuần thành công", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đi tuần thất bại", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                btnStart.Enabled = false;
                btnStop.Enabled = false;
                btnNextStep.Enabled = false;
                step = 1;
                return;
            }
            drawChess(chessAlgo.boardDetail.getPosition(currentPosition.Item1, currentPosition.Item2));
        }



        /*
         * Handle Graphics
         */

        private void btnNextStep_Click(object sender, EventArgs e)
        {
            if (rdKnight.Checked == true)
            {
                nextStepKnight();
            }
            else
            {
                nextStepQueen();
            }


        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            btnNextStep.Enabled = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            loadSpeed();
            timer1.Enabled = true;
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            btnNextStep.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
        }



        
        private void choiceKnight_Click(object sender, EventArgs e)
        {
            resetKnightState(true);
            picArrow.Visible = true;
            lblStartPosition.Visible = true;
            pnConfig.Visible = false;
            lblStartPosition.Text = "Hãy đặt quân mã đầu tiên vào bàn cờ";
        }


        private void btnResetState_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            //Tắt timer trước khi reset lại
            pnChessboard.Visible = false;
            pnUnderChessBoard.Visible = false;
            initState();
            showBoard();
        }


        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            if (!(MessageBox.Show("Bạn có muốn thoát khỏi chương trình không?",
                       "Thoát ứng dụng",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Error) == DialogResult.No))
            {
                Application.Exit();
            }
            
        }


        private void btnTacGia_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Tác giả: Trần Đăng Khoa\n MSSV: B1805879\n Lớp: DI1896A2\n Ngày hoàn thành: 05/06/2021","Thông tin tác giả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void choiceQueen_Click(object sender, EventArgs e)
        {
            resetKnightState(false);
            picArrow.Visible = true;
            lblStartPosition.Visible = true;
            pnConfig.Visible = false;

            lblStartPosition.Text = "Hãy đặt quân hậu đầu tiên vào bàn cờ";
        }

        


        private void pnChessboard_MouseClick(object sender, MouseEventArgs e)
        {
            drawTable(boardDetail.getBoardSize(), boardDetail.getCellSize());
            Tuple<int, int> a = boardDetail.getDimensionFromPosition(e.X, e.Y);
            drawChess(boardDetail.getPosition(a.Item1, a.Item2));
            //this.Text=a.Item1.ToString()+", "+ a.Item2.ToString();
            startPosX = a.Item1;
            startPosY = a.Item2;
            pnConfig.Visible = true;
            picArrow.Visible = false;
            lblStartPosition.Visible = false;
            // Ẩn button chọn quân hậu
            choiceQueen.Enabled = false;
            //choiceQueen.Visible = false;
            //lblQueen.Visible = false;
            choiceKnight.Enabled = false;
        }



        private void timer1_Tick(object sender, EventArgs e)
        {

            loadSpeed();
            if(rdKnight.Checked == true)
            {
                nextStepKnight();
            }
            else
            {
                nextStepQueen();
            }
        }

    }
}
