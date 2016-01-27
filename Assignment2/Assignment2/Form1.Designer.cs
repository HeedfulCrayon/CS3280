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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 440);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.startRoll);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startRoll;
        private System.Windows.Forms.PictureBox pbImage;
    }
}

