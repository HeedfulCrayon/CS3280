namespace TicTacToe
{
    partial class frmTicTacToe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.gbGameStats = new System.Windows.Forms.GroupBox();
            this.lblTiesScore = new System.Windows.Forms.Label();
            this.lblPlayer2Score = new System.Windows.Forms.Label();
            this.lblPlayer1Score = new System.Windows.Forms.Label();
            this.lblTies = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.lblGameStatus = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbGameStats.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 254);
            this.panel1.TabIndex = 0;
            // 
            // btn9
            // 
            this.btn9.Enabled = false;
            this.btn9.Location = new System.Drawing.Point(188, 172);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(88, 80);
            this.btn9.TabIndex = 8;
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn8
            // 
            this.btn8.Enabled = false;
            this.btn8.Location = new System.Drawing.Point(94, 172);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(88, 80);
            this.btn8.TabIndex = 7;
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn7
            // 
            this.btn7.Enabled = false;
            this.btn7.Location = new System.Drawing.Point(0, 172);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(88, 80);
            this.btn7.TabIndex = 6;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn6
            // 
            this.btn6.Enabled = false;
            this.btn6.Location = new System.Drawing.Point(188, 86);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(88, 80);
            this.btn6.TabIndex = 5;
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn5
            // 
            this.btn5.Enabled = false;
            this.btn5.Location = new System.Drawing.Point(94, 86);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(88, 80);
            this.btn5.TabIndex = 4;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn4
            // 
            this.btn4.Enabled = false;
            this.btn4.Location = new System.Drawing.Point(0, 86);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(88, 80);
            this.btn4.TabIndex = 3;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn3
            // 
            this.btn3.Enabled = false;
            this.btn3.Location = new System.Drawing.Point(188, 0);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(88, 80);
            this.btn3.TabIndex = 2;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn2
            // 
            this.btn2.Enabled = false;
            this.btn2.Location = new System.Drawing.Point(94, 0);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(88, 80);
            this.btn2.TabIndex = 1;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Gainsboro;
            this.btn1.Enabled = false;
            this.btn1.Location = new System.Drawing.Point(0, 0);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(88, 80);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn_Click);
            // 
            // gbGameStats
            // 
            this.gbGameStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gbGameStats.Controls.Add(this.lblTiesScore);
            this.gbGameStats.Controls.Add(this.lblPlayer2Score);
            this.gbGameStats.Controls.Add(this.lblPlayer1Score);
            this.gbGameStats.Controls.Add(this.lblTies);
            this.gbGameStats.Controls.Add(this.lblPlayer2);
            this.gbGameStats.Controls.Add(this.lblPlayer1);
            this.gbGameStats.Location = new System.Drawing.Point(323, 57);
            this.gbGameStats.Name = "gbGameStats";
            this.gbGameStats.Size = new System.Drawing.Size(200, 100);
            this.gbGameStats.TabIndex = 1;
            this.gbGameStats.TabStop = false;
            this.gbGameStats.Text = "Game Statistics";
            // 
            // lblTiesScore
            // 
            this.lblTiesScore.AutoSize = true;
            this.lblTiesScore.Location = new System.Drawing.Point(111, 67);
            this.lblTiesScore.Name = "lblTiesScore";
            this.lblTiesScore.Size = new System.Drawing.Size(13, 13);
            this.lblTiesScore.TabIndex = 5;
            this.lblTiesScore.Text = "0";
            // 
            // lblPlayer2Score
            // 
            this.lblPlayer2Score.AutoSize = true;
            this.lblPlayer2Score.Location = new System.Drawing.Point(111, 46);
            this.lblPlayer2Score.Name = "lblPlayer2Score";
            this.lblPlayer2Score.Size = new System.Drawing.Size(13, 13);
            this.lblPlayer2Score.TabIndex = 4;
            this.lblPlayer2Score.Text = "0";
            // 
            // lblPlayer1Score
            // 
            this.lblPlayer1Score.AutoSize = true;
            this.lblPlayer1Score.Location = new System.Drawing.Point(112, 20);
            this.lblPlayer1Score.Name = "lblPlayer1Score";
            this.lblPlayer1Score.Size = new System.Drawing.Size(13, 13);
            this.lblPlayer1Score.TabIndex = 3;
            this.lblPlayer1Score.Text = "0";
            // 
            // lblTies
            // 
            this.lblTies.AutoSize = true;
            this.lblTies.Location = new System.Drawing.Point(75, 67);
            this.lblTies.Name = "lblTies";
            this.lblTies.Size = new System.Drawing.Size(30, 13);
            this.lblTies.TabIndex = 2;
            this.lblTies.Text = "Ties:";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Location = new System.Drawing.Point(30, 46);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(75, 13);
            this.lblPlayer2.TabIndex = 1;
            this.lblPlayer2.Text = "Player 2 Wins:";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(30, 20);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(75, 13);
            this.lblPlayer1.TabIndex = 0;
            this.lblPlayer1.Text = "Player 1 Wins:";
            // 
            // gbStatus
            // 
            this.gbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gbStatus.Controls.Add(this.lblGameStatus);
            this.gbStatus.Location = new System.Drawing.Point(323, 163);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(200, 103);
            this.gbStatus.TabIndex = 2;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Game Status";
            // 
            // lblGameStatus
            // 
            this.lblGameStatus.AutoSize = true;
            this.lblGameStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameStatus.Location = new System.Drawing.Point(6, 16);
            this.lblGameStatus.Name = "lblGameStatus";
            this.lblGameStatus.Size = new System.Drawing.Size(95, 17);
            this.lblGameStatus.TabIndex = 0;
            this.lblGameStatus.Text = "Player 1 Wins";
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.Moccasin;
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(342, 12);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(155, 39);
            this.btnStartGame.TabIndex = 3;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.Start_Game_Click);
            // 
            // frmTicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(535, 276);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.gbGameStats);
            this.Controls.Add(this.panel1);
            this.Name = "frmTicTacToe";
            this.Text = "Tic Tac Toe";
            this.panel1.ResumeLayout(false);
            this.gbGameStats.ResumeLayout(false);
            this.gbGameStats.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblTiesScore;
        private System.Windows.Forms.Label lblPlayer2Score;
        private System.Windows.Forms.Label lblPlayer1Score;
        private System.Windows.Forms.Label lblTies;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.Label lblGameStatus;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.GroupBox gbGameStats;
        private System.Windows.Forms.Panel panel1;
    }
}

