
namespace prjChess
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnChessboard = new System.Windows.Forms.Panel();
            this.btnNextStep = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.rdQueen = new System.Windows.Forms.RadioButton();
            this.rdKnight = new System.Windows.Forms.RadioButton();
            this.choiceQueen = new System.Windows.Forms.PictureBox();
            this.choiceKnight = new System.Windows.Forms.PictureBox();
            this.trbSpeed = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTacGia = new System.Windows.Forms.Button();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.pnConfig = new System.Windows.Forms.Panel();
            this.btnResetState = new System.Windows.Forms.Button();
            this.btnRunAlgo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStartPosition = new System.Windows.Forms.Label();
            this.pnChooseChess = new System.Windows.Forms.Panel();
            this.lblQueen = new System.Windows.Forms.Label();
            this.lblKnight = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picArrow = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnUnderChessBoard = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.choiceQueen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choiceKnight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSpeed)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnConfig.SuspendLayout();
            this.pnChooseChess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).BeginInit();
            this.pnUnderChessBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnChessboard
            // 
            this.pnChessboard.BackColor = System.Drawing.Color.Transparent;
            this.pnChessboard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnChessboard.Location = new System.Drawing.Point(50, 50);
            this.pnChessboard.Name = "pnChessboard";
            this.pnChessboard.Size = new System.Drawing.Size(937, 705);
            this.pnChessboard.TabIndex = 0;
            this.pnChessboard.Visible = false;
            this.pnChessboard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnChessboard_MouseClick);
            // 
            // btnNextStep
            // 
            this.btnNextStep.Location = new System.Drawing.Point(198, 227);
            this.btnNextStep.Name = "btnNextStep";
            this.btnNextStep.Size = new System.Drawing.Size(101, 38);
            this.btnNextStep.TabIndex = 3;
            this.btnNextStep.Text = "Bước kế tiếp";
            this.btnNextStep.UseVisualStyleBackColor = true;
            this.btnNextStep.Click += new System.EventHandler(this.btnNextStep_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(4, 227);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(86, 38);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "Tạm dừng";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(96, 227);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(96, 38);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Tiếp tục";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // rdQueen
            // 
            this.rdQueen.AutoSize = true;
            this.rdQueen.Location = new System.Drawing.Point(239, 20);
            this.rdQueen.Name = "rdQueen";
            this.rdQueen.Size = new System.Drawing.Size(72, 17);
            this.rdQueen.TabIndex = 5;
            this.rdQueen.TabStop = true;
            this.rdQueen.Text = "Quân hậu";
            this.rdQueen.UseVisualStyleBackColor = true;
            this.rdQueen.Visible = false;
            // 
            // rdKnight
            // 
            this.rdKnight.AutoSize = true;
            this.rdKnight.Location = new System.Drawing.Point(164, 20);
            this.rdKnight.Name = "rdKnight";
            this.rdKnight.Size = new System.Drawing.Size(69, 17);
            this.rdKnight.TabIndex = 6;
            this.rdKnight.TabStop = true;
            this.rdKnight.Text = "Quân Mã";
            this.rdKnight.UseVisualStyleBackColor = true;
            this.rdKnight.Visible = false;
            // 
            // choiceQueen
            // 
            this.choiceQueen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.choiceQueen.Image = ((System.Drawing.Image)(resources.GetObject("choiceQueen.Image")));
            this.choiceQueen.Location = new System.Drawing.Point(168, 67);
            this.choiceQueen.Name = "choiceQueen";
            this.choiceQueen.Size = new System.Drawing.Size(116, 85);
            this.choiceQueen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.choiceQueen.TabIndex = 7;
            this.choiceQueen.TabStop = false;
            this.choiceQueen.Click += new System.EventHandler(this.choiceQueen_Click);
            // 
            // choiceKnight
            // 
            this.choiceKnight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.choiceKnight.Image = ((System.Drawing.Image)(resources.GetObject("choiceKnight.Image")));
            this.choiceKnight.Location = new System.Drawing.Point(20, 67);
            this.choiceKnight.Name = "choiceKnight";
            this.choiceKnight.Size = new System.Drawing.Size(109, 85);
            this.choiceKnight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.choiceKnight.TabIndex = 8;
            this.choiceKnight.TabStop = false;
            this.choiceKnight.Click += new System.EventHandler(this.choiceKnight_Click);
            // 
            // trbSpeed
            // 
            this.trbSpeed.LargeChange = 50;
            this.trbSpeed.Location = new System.Drawing.Point(14, 150);
            this.trbSpeed.Maximum = 450;
            this.trbSpeed.Name = "trbSpeed";
            this.trbSpeed.Size = new System.Drawing.Size(283, 50);
            this.trbSpeed.TabIndex = 11;
            this.trbSpeed.TickFrequency = 50;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnTacGia);
            this.panel1.Controls.Add(this.btnCloseApp);
            this.panel1.Controls.Add(this.pnConfig);
            this.panel1.Controls.Add(this.lblStartPosition);
            this.panel1.Controls.Add(this.pnChooseChess);
            this.panel1.Location = new System.Drawing.Point(1386, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 729);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnTacGia
            // 
            this.btnTacGia.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnTacGia.FlatAppearance.BorderSize = 0;
            this.btnTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTacGia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTacGia.Location = new System.Drawing.Point(-1, 676);
            this.btnTacGia.Name = "btnTacGia";
            this.btnTacGia.Size = new System.Drawing.Size(402, 52);
            this.btnTacGia.TabIndex = 15;
            this.btnTacGia.Text = "Thông tin tác giả";
            this.btnTacGia.UseVisualStyleBackColor = false;
            this.btnTacGia.Click += new System.EventHandler(this.btnTacGia_Click);
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.BackColor = System.Drawing.Color.LightCoral;
            this.btnCloseApp.FlatAppearance.BorderSize = 0;
            this.btnCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseApp.Font = new System.Drawing.Font("Arial Narrow", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseApp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCloseApp.Location = new System.Drawing.Point(346, -1);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(55, 41);
            this.btnCloseApp.TabIndex = 14;
            this.btnCloseApp.Text = "x";
            this.btnCloseApp.UseVisualStyleBackColor = false;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // pnConfig
            // 
            this.pnConfig.Controls.Add(this.btnResetState);
            this.pnConfig.Controls.Add(this.btnRunAlgo);
            this.pnConfig.Controls.Add(this.btnStart);
            this.pnConfig.Controls.Add(this.label1);
            this.pnConfig.Controls.Add(this.btnStop);
            this.pnConfig.Controls.Add(this.trbSpeed);
            this.pnConfig.Controls.Add(this.btnNextStep);
            this.pnConfig.Location = new System.Drawing.Point(37, 244);
            this.pnConfig.Name = "pnConfig";
            this.pnConfig.Size = new System.Drawing.Size(311, 386);
            this.pnConfig.TabIndex = 13;
            // 
            // btnResetState
            // 
            this.btnResetState.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetState.Location = new System.Drawing.Point(45, 309);
            this.btnResetState.Name = "btnResetState";
            this.btnResetState.Size = new System.Drawing.Size(221, 49);
            this.btnResetState.TabIndex = 14;
            this.btnResetState.Text = "Khởi tạo lại";
            this.btnResetState.UseVisualStyleBackColor = true;
            this.btnResetState.Click += new System.EventHandler(this.btnResetState_Click);
            // 
            // btnRunAlgo
            // 
            this.btnRunAlgo.Font = new System.Drawing.Font("Consolas", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunAlgo.Location = new System.Drawing.Point(16, 25);
            this.btnRunAlgo.Name = "btnRunAlgo";
            this.btnRunAlgo.Size = new System.Drawing.Size(283, 52);
            this.btnRunAlgo.TabIndex = 13;
            this.btnRunAlgo.Text = "Chạy thuật toán";
            this.btnRunAlgo.UseVisualStyleBackColor = true;
            this.btnRunAlgo.Click += new System.EventHandler(this.btnRunAlgo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Điều chỉnh tốc độ";
            // 
            // lblStartPosition
            // 
            this.lblStartPosition.AutoSize = true;
            this.lblStartPosition.BackColor = System.Drawing.Color.Transparent;
            this.lblStartPosition.Font = new System.Drawing.Font("Consolas", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartPosition.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblStartPosition.Location = new System.Drawing.Point(20, 244);
            this.lblStartPosition.Name = "lblStartPosition";
            this.lblStartPosition.Size = new System.Drawing.Size(360, 22);
            this.lblStartPosition.TabIndex = 13;
            this.lblStartPosition.Text = "Hãy đặt quân mã đầu tiên vào bàn cờ";
            // 
            // pnChooseChess
            // 
            this.pnChooseChess.Controls.Add(this.lblQueen);
            this.pnChooseChess.Controls.Add(this.lblKnight);
            this.pnChooseChess.Controls.Add(this.choiceKnight);
            this.pnChooseChess.Controls.Add(this.label3);
            this.pnChooseChess.Controls.Add(this.rdKnight);
            this.pnChooseChess.Controls.Add(this.choiceQueen);
            this.pnChooseChess.Controls.Add(this.rdQueen);
            this.pnChooseChess.Location = new System.Drawing.Point(31, 46);
            this.pnChooseChess.Name = "pnChooseChess";
            this.pnChooseChess.Size = new System.Drawing.Size(312, 191);
            this.pnChooseChess.TabIndex = 13;
            // 
            // lblQueen
            // 
            this.lblQueen.AutoSize = true;
            this.lblQueen.Font = new System.Drawing.Font("Consolas", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueen.Location = new System.Drawing.Point(173, 159);
            this.lblQueen.Name = "lblQueen";
            this.lblQueen.Size = new System.Drawing.Size(99, 19);
            this.lblQueen.TabIndex = 15;
            this.lblQueen.Text = "N quân hậu";
            // 
            // lblKnight
            // 
            this.lblKnight.AutoSize = true;
            this.lblKnight.Font = new System.Drawing.Font("Consolas", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKnight.Location = new System.Drawing.Point(23, 159);
            this.lblKnight.Name = "lblKnight";
            this.lblKnight.Size = new System.Drawing.Size(99, 19);
            this.lblKnight.TabIndex = 14;
            this.lblKnight.Text = "Mã đi tuần";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label3.Location = new System.Drawing.Point(8, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Chọn bài toán:";
            // 
            // picArrow
            // 
            this.picArrow.BackColor = System.Drawing.Color.Transparent;
            this.picArrow.Image = ((System.Drawing.Image)(resources.GetObject("picArrow.Image")));
            this.picArrow.Location = new System.Drawing.Point(1234, 314);
            this.picArrow.Name = "picArrow";
            this.picArrow.Size = new System.Drawing.Size(146, 110);
            this.picArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picArrow.TabIndex = 14;
            this.picArrow.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(1525, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Thanh công cụ";
            // 
            // pnUnderChessBoard
            // 
            this.pnUnderChessBoard.BackColor = System.Drawing.Color.Transparent;
            this.pnUnderChessBoard.Controls.Add(this.pnChessboard);
            this.pnUnderChessBoard.Location = new System.Drawing.Point(130, 58);
            this.pnUnderChessBoard.Name = "pnUnderChessBoard";
            this.pnUnderChessBoard.Size = new System.Drawing.Size(1007, 771);
            this.pnUnderChessBoard.TabIndex = 16;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 863);
            this.Controls.Add(this.pnUnderChessBoard);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picArrow);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Main";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.Main_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.choiceQueen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choiceKnight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSpeed)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnConfig.ResumeLayout(false);
            this.pnConfig.PerformLayout();
            this.pnChooseChess.ResumeLayout(false);
            this.pnChooseChess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).EndInit();
            this.pnUnderChessBoard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnChessboard;
        private System.Windows.Forms.Button btnNextStep;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RadioButton rdQueen;
        private System.Windows.Forms.RadioButton rdKnight;
        private System.Windows.Forms.PictureBox choiceQueen;
        private System.Windows.Forms.PictureBox choiceKnight;
        private System.Windows.Forms.TrackBar trbSpeed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRunAlgo;
        private System.Windows.Forms.Panel pnChooseChess;
        private System.Windows.Forms.Panel pnConfig;
        private System.Windows.Forms.Label lblStartPosition;
        private System.Windows.Forms.PictureBox picArrow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblQueen;
        private System.Windows.Forms.Label lblKnight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnResetState;
        private System.Windows.Forms.Panel pnUnderChessBoard;
        private System.Windows.Forms.Button btnCloseApp;
        private System.Windows.Forms.Button btnTacGia;
    }
}

