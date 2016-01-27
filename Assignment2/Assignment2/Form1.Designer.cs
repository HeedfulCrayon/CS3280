namespace Assignment2
{
    partial class Form1
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
            this.startRoll = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInvalid = new System.Windows.Forms.Label();
            this.lblDiceNum = new System.Windows.Forms.Label();
            this.lblDice1 = new System.Windows.Forms.Label();
            this.lblDice2 = new System.Windows.Forms.Label();
            this.lblDice3 = new System.Windows.Forms.Label();
            this.lblDice6 = new System.Windows.Forms.Label();
            this.lblDice5 = new System.Windows.Forms.Label();
            this.lblDice4 = new System.Windows.Forms.Label();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.lblFreq6 = new System.Windows.Forms.Label();
            this.lblFreq5 = new System.Windows.Forms.Label();
            this.lblFreq4 = new System.Windows.Forms.Label();
            this.lblFreq3 = new System.Windows.Forms.Label();
            this.lblFreq2 = new System.Windows.Forms.Label();
            this.lblFreq1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // startRoll
            // 
            this.startRoll.Location = new System.Drawing.Point(322, 141);
            this.startRoll.Name = "startRoll";
            this.startRoll.Size = new System.Drawing.Size(101, 27);
            this.startRoll.TabIndex = 0;
            this.startRoll.Text = "Roll";
            this.startRoll.UseVisualStyleBackColor = true;
            this.startRoll.Click += new System.EventHandler(this.startRoll_Click);
            // 
            // pbImage
            // 
            this.pbImage.ImageLocation = "die1.gif";
            this.pbImage.Location = new System.Drawing.Point(322, 23);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(101, 89);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 1;
            this.pbImage.TabStop = false;
            // 
            // txtGuess
            // 
            this.txtGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuess.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtGuess.Location = new System.Drawing.Point(167, 19);
            this.txtGuess.MaxLength = 1;
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(23, 26);
            this.txtGuess.TabIndex = 2;
            this.txtGuess.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtGuess_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter your guess:";
            // 
            // lblInvalid
            // 
            this.lblInvalid.AutoSize = true;
            this.lblInvalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalid.ForeColor = System.Drawing.Color.Red;
            this.lblInvalid.Location = new System.Drawing.Point(197, 23);
            this.lblInvalid.Name = "lblInvalid";
            this.lblInvalid.Size = new System.Drawing.Size(84, 17);
            this.lblInvalid.TabIndex = 4;
            this.lblInvalid.Text = "Invalid entry";
            this.lblInvalid.Visible = false;
            // 
            // lblDiceNum
            // 
            this.lblDiceNum.AutoSize = true;
            this.lblDiceNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiceNum.Location = new System.Drawing.Point(12, 184);
            this.lblDiceNum.Name = "lblDiceNum";
            this.lblDiceNum.Size = new System.Drawing.Size(65, 20);
            this.lblDiceNum.TabIndex = 5;
            this.lblDiceNum.Text = "Number";
            // 
            // lblDice1
            // 
            this.lblDice1.AutoSize = true;
            this.lblDice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDice1.Location = new System.Drawing.Point(32, 204);
            this.lblDice1.Name = "lblDice1";
            this.lblDice1.Size = new System.Drawing.Size(18, 20);
            this.lblDice1.TabIndex = 6;
            this.lblDice1.Text = "1";
            // 
            // lblDice2
            // 
            this.lblDice2.AutoSize = true;
            this.lblDice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDice2.Location = new System.Drawing.Point(32, 227);
            this.lblDice2.Name = "lblDice2";
            this.lblDice2.Size = new System.Drawing.Size(18, 20);
            this.lblDice2.TabIndex = 7;
            this.lblDice2.Text = "2";
            // 
            // lblDice3
            // 
            this.lblDice3.AutoSize = true;
            this.lblDice3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDice3.Location = new System.Drawing.Point(32, 250);
            this.lblDice3.Name = "lblDice3";
            this.lblDice3.Size = new System.Drawing.Size(18, 20);
            this.lblDice3.TabIndex = 8;
            this.lblDice3.Text = "3";
            // 
            // lblDice6
            // 
            this.lblDice6.AutoSize = true;
            this.lblDice6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDice6.Location = new System.Drawing.Point(32, 319);
            this.lblDice6.Name = "lblDice6";
            this.lblDice6.Size = new System.Drawing.Size(18, 20);
            this.lblDice6.TabIndex = 11;
            this.lblDice6.Text = "6";
            // 
            // lblDice5
            // 
            this.lblDice5.AutoSize = true;
            this.lblDice5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDice5.Location = new System.Drawing.Point(32, 296);
            this.lblDice5.Name = "lblDice5";
            this.lblDice5.Size = new System.Drawing.Size(18, 20);
            this.lblDice5.TabIndex = 10;
            this.lblDice5.Text = "5";
            // 
            // lblDice4
            // 
            this.lblDice4.AutoSize = true;
            this.lblDice4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDice4.Location = new System.Drawing.Point(32, 273);
            this.lblDice4.Name = "lblDice4";
            this.lblDice4.Size = new System.Drawing.Size(18, 20);
            this.lblDice4.TabIndex = 9;
            this.lblDice4.Text = "4";
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrequency.Location = new System.Drawing.Point(125, 184);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(84, 20);
            this.lblFrequency.TabIndex = 12;
            this.lblFrequency.Text = "Frequency";
            // 
            // lblFreq6
            // 
            this.lblFreq6.AutoSize = true;
            this.lblFreq6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFreq6.Location = new System.Drawing.Point(154, 319);
            this.lblFreq6.Name = "lblFreq6";
            this.lblFreq6.Size = new System.Drawing.Size(18, 20);
            this.lblFreq6.TabIndex = 18;
            this.lblFreq6.Text = "0";
            // 
            // lblFreq5
            // 
            this.lblFreq5.AutoSize = true;
            this.lblFreq5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFreq5.Location = new System.Drawing.Point(154, 296);
            this.lblFreq5.Name = "lblFreq5";
            this.lblFreq5.Size = new System.Drawing.Size(18, 20);
            this.lblFreq5.TabIndex = 17;
            this.lblFreq5.Text = "0";
            // 
            // lblFreq4
            // 
            this.lblFreq4.AutoSize = true;
            this.lblFreq4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFreq4.Location = new System.Drawing.Point(154, 273);
            this.lblFreq4.Name = "lblFreq4";
            this.lblFreq4.Size = new System.Drawing.Size(18, 20);
            this.lblFreq4.TabIndex = 16;
            this.lblFreq4.Text = "0";
            // 
            // lblFreq3
            // 
            this.lblFreq3.AutoSize = true;
            this.lblFreq3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFreq3.Location = new System.Drawing.Point(154, 250);
            this.lblFreq3.Name = "lblFreq3";
            this.lblFreq3.Size = new System.Drawing.Size(18, 20);
            this.lblFreq3.TabIndex = 15;
            this.lblFreq3.Text = "0";
            // 
            // lblFreq2
            // 
            this.lblFreq2.AutoSize = true;
            this.lblFreq2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFreq2.Location = new System.Drawing.Point(154, 227);
            this.lblFreq2.Name = "lblFreq2";
            this.lblFreq2.Size = new System.Drawing.Size(18, 20);
            this.lblFreq2.TabIndex = 14;
            this.lblFreq2.Text = "0";
            // 
            // lblFreq1
            // 
            this.lblFreq1.AutoSize = true;
            this.lblFreq1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFreq1.Location = new System.Drawing.Point(154, 204);
            this.lblFreq1.Name = "lblFreq1";
            this.lblFreq1.Size = new System.Drawing.Size(18, 20);
            this.lblFreq1.TabIndex = 13;
            this.lblFreq1.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 440);
            this.Controls.Add(this.lblFreq6);
            this.Controls.Add(this.lblFreq5);
            this.Controls.Add(this.lblFreq4);
            this.Controls.Add(this.lblFreq3);
            this.Controls.Add(this.lblFreq2);
            this.Controls.Add(this.lblFreq1);
            this.Controls.Add(this.lblFrequency);
            this.Controls.Add(this.lblDice6);
            this.Controls.Add(this.lblDice5);
            this.Controls.Add(this.lblDice4);
            this.Controls.Add(this.lblDice3);
            this.Controls.Add(this.lblDice2);
            this.Controls.Add(this.lblDice1);
            this.Controls.Add(this.lblDiceNum);
            this.Controls.Add(this.lblInvalid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.startRoll);
            this.Name = "Form1";
            this.Text = "Roll the Dice!";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startRoll;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInvalid;
        private System.Windows.Forms.Label lblDiceNum;
        private System.Windows.Forms.Label lblDice1;
        private System.Windows.Forms.Label lblDice2;
        private System.Windows.Forms.Label lblDice3;
        private System.Windows.Forms.Label lblDice6;
        private System.Windows.Forms.Label lblDice5;
        private System.Windows.Forms.Label lblDice4;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.Label lblFreq6;
        private System.Windows.Forms.Label lblFreq5;
        private System.Windows.Forms.Label lblFreq4;
        private System.Windows.Forms.Label lblFreq3;
        private System.Windows.Forms.Label lblFreq2;
        private System.Windows.Forms.Label lblFreq1;
    }
}

