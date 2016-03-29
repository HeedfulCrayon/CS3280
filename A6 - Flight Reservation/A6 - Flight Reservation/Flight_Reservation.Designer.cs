namespace A6___Flight_Reservation
{
    partial class Flight_Reservation
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
            this.cbFlight = new System.Windows.Forms.ComboBox();
            this.cbPassenger = new System.Windows.Forms.ComboBox();
            this.gbPassengerInfo = new System.Windows.Forms.GroupBox();
            this.lblPassSeat = new System.Windows.Forms.Label();
            this.lblPassengerSeatNum = new System.Windows.Forms.Label();
            this.lblChoosePass = new System.Windows.Forms.Label();
            this.lblChooseFlight = new System.Windows.Forms.Label();
            this.plFlight412 = new System.Windows.Forms.Panel();
            this.lblSeat1 = new System.Windows.Forms.Label();
            this.lblFlightNum = new System.Windows.Forms.Label();
            this.lblSeat2 = new System.Windows.Forms.Label();
            this.lblSeat3 = new System.Windows.Forms.Label();
            this.lblSeat4 = new System.Windows.Forms.Label();
            this.lblSeat5 = new System.Windows.Forms.Label();
            this.lblSeat6 = new System.Windows.Forms.Label();
            this.lblSeat7 = new System.Windows.Forms.Label();
            this.lblSeat8 = new System.Windows.Forms.Label();
            this.lblSeat9 = new System.Windows.Forms.Label();
            this.lblSeat10 = new System.Windows.Forms.Label();
            this.lblSeat11 = new System.Windows.Forms.Label();
            this.lblSeat12 = new System.Windows.Forms.Label();
            this.lblSeat13 = new System.Windows.Forms.Label();
            this.lblSeat14 = new System.Windows.Forms.Label();
            this.lblSeat15 = new System.Windows.Forms.Label();
            this.lblSeat16 = new System.Windows.Forms.Label();
            this.lblSeat24 = new System.Windows.Forms.Label();
            this.lblSeat23 = new System.Windows.Forms.Label();
            this.lblSeat22 = new System.Windows.Forms.Label();
            this.lblSeat21 = new System.Windows.Forms.Label();
            this.lblSeat20 = new System.Windows.Forms.Label();
            this.lblSeat19 = new System.Windows.Forms.Label();
            this.lblSeat18 = new System.Windows.Forms.Label();
            this.lblSeat17 = new System.Windows.Forms.Label();
            this.lblDivider = new System.Windows.Forms.Label();
            this.gbPassengerInfo.SuspendLayout();
            this.plFlight412.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbFlight
            // 
            this.cbFlight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFlight.FormattingEnabled = true;
            this.cbFlight.Location = new System.Drawing.Point(160, 28);
            this.cbFlight.Name = "cbFlight";
            this.cbFlight.Size = new System.Drawing.Size(140, 24);
            this.cbFlight.TabIndex = 0;
            this.cbFlight.SelectedIndexChanged += new System.EventHandler(this.cbFlight_SelectedIndexChanged);
            // 
            // cbPassenger
            // 
            this.cbPassenger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPassenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPassenger.FormattingEnabled = true;
            this.cbPassenger.Location = new System.Drawing.Point(160, 65);
            this.cbPassenger.Name = "cbPassenger";
            this.cbPassenger.Size = new System.Drawing.Size(140, 24);
            this.cbPassenger.TabIndex = 1;
            this.cbPassenger.SelectedIndexChanged += new System.EventHandler(this.cbPassenger_SelectedIndexChanged);
            // 
            // gbPassengerInfo
            // 
            this.gbPassengerInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPassengerInfo.Controls.Add(this.lblPassSeat);
            this.gbPassengerInfo.Controls.Add(this.lblPassengerSeatNum);
            this.gbPassengerInfo.Controls.Add(this.lblChoosePass);
            this.gbPassengerInfo.Controls.Add(this.lblChooseFlight);
            this.gbPassengerInfo.Controls.Add(this.cbFlight);
            this.gbPassengerInfo.Controls.Add(this.cbPassenger);
            this.gbPassengerInfo.Location = new System.Drawing.Point(357, 12);
            this.gbPassengerInfo.Name = "gbPassengerInfo";
            this.gbPassengerInfo.Size = new System.Drawing.Size(306, 137);
            this.gbPassengerInfo.TabIndex = 2;
            this.gbPassengerInfo.TabStop = false;
            this.gbPassengerInfo.Text = "Passenger Information";
            // 
            // lblPassSeat
            // 
            this.lblPassSeat.AutoSize = true;
            this.lblPassSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassSeat.Location = new System.Drawing.Point(16, 102);
            this.lblPassSeat.Name = "lblPassSeat";
            this.lblPassSeat.Size = new System.Drawing.Size(138, 20);
            this.lblPassSeat.TabIndex = 5;
            this.lblPassSeat.Text = "Passenger\'s Seat:";
            // 
            // lblPassengerSeatNum
            // 
            this.lblPassengerSeatNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPassengerSeatNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerSeatNum.Location = new System.Drawing.Point(160, 102);
            this.lblPassengerSeatNum.Name = "lblPassengerSeatNum";
            this.lblPassengerSeatNum.Size = new System.Drawing.Size(29, 22);
            this.lblPassengerSeatNum.TabIndex = 4;
            this.lblPassengerSeatNum.Text = "   ";
            this.lblPassengerSeatNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChoosePass
            // 
            this.lblChoosePass.AutoSize = true;
            this.lblChoosePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoosePass.Location = new System.Drawing.Point(6, 67);
            this.lblChoosePass.Name = "lblChoosePass";
            this.lblChoosePass.Size = new System.Drawing.Size(148, 20);
            this.lblChoosePass.TabIndex = 3;
            this.lblChoosePass.Text = "Choose Passenger:";
            this.lblChoosePass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblChooseFlight
            // 
            this.lblChooseFlight.AutoSize = true;
            this.lblChooseFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseFlight.Location = new System.Drawing.Point(43, 30);
            this.lblChooseFlight.Name = "lblChooseFlight";
            this.lblChooseFlight.Size = new System.Drawing.Size(111, 20);
            this.lblChooseFlight.TabIndex = 2;
            this.lblChooseFlight.Text = "Choose Flight:";
            this.lblChooseFlight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // plFlight412
            // 
            this.plFlight412.Controls.Add(this.lblDivider);
            this.plFlight412.Controls.Add(this.lblSeat24);
            this.plFlight412.Controls.Add(this.lblSeat23);
            this.plFlight412.Controls.Add(this.lblSeat22);
            this.plFlight412.Controls.Add(this.lblSeat21);
            this.plFlight412.Controls.Add(this.lblSeat20);
            this.plFlight412.Controls.Add(this.lblSeat19);
            this.plFlight412.Controls.Add(this.lblSeat18);
            this.plFlight412.Controls.Add(this.lblSeat17);
            this.plFlight412.Controls.Add(this.lblSeat16);
            this.plFlight412.Controls.Add(this.lblSeat15);
            this.plFlight412.Controls.Add(this.lblSeat14);
            this.plFlight412.Controls.Add(this.lblSeat13);
            this.plFlight412.Controls.Add(this.lblSeat12);
            this.plFlight412.Controls.Add(this.lblSeat11);
            this.plFlight412.Controls.Add(this.lblSeat10);
            this.plFlight412.Controls.Add(this.lblSeat9);
            this.plFlight412.Controls.Add(this.lblSeat8);
            this.plFlight412.Controls.Add(this.lblSeat7);
            this.plFlight412.Controls.Add(this.lblSeat6);
            this.plFlight412.Controls.Add(this.lblSeat5);
            this.plFlight412.Controls.Add(this.lblSeat4);
            this.plFlight412.Controls.Add(this.lblSeat3);
            this.plFlight412.Controls.Add(this.lblSeat2);
            this.plFlight412.Controls.Add(this.lblSeat1);
            this.plFlight412.Controls.Add(this.lblFlightNum);
            this.plFlight412.Location = new System.Drawing.Point(30, 12);
            this.plFlight412.Name = "plFlight412";
            this.plFlight412.Size = new System.Drawing.Size(291, 299);
            this.plFlight412.TabIndex = 3;
            // 
            // lblSeat1
            // 
            this.lblSeat1.BackColor = System.Drawing.Color.Blue;
            this.lblSeat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat1.ForeColor = System.Drawing.Color.White;
            this.lblSeat1.Location = new System.Drawing.Point(24, 47);
            this.lblSeat1.Name = "lblSeat1";
            this.lblSeat1.Size = new System.Drawing.Size(33, 29);
            this.lblSeat1.TabIndex = 1;
            this.lblSeat1.Text = "1";
            this.lblSeat1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFlightNum
            // 
            this.lblFlightNum.AutoSize = true;
            this.lblFlightNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightNum.Location = new System.Drawing.Point(121, 17);
            this.lblFlightNum.Name = "lblFlightNum";
            this.lblFlightNum.Size = new System.Drawing.Size(39, 20);
            this.lblFlightNum.TabIndex = 0;
            this.lblFlightNum.Text = "767";
            // 
            // lblSeat2
            // 
            this.lblSeat2.BackColor = System.Drawing.Color.Blue;
            this.lblSeat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat2.ForeColor = System.Drawing.Color.White;
            this.lblSeat2.Location = new System.Drawing.Point(77, 47);
            this.lblSeat2.Name = "lblSeat2";
            this.lblSeat2.Size = new System.Drawing.Size(33, 29);
            this.lblSeat2.TabIndex = 2;
            this.lblSeat2.Text = "2";
            this.lblSeat2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat3
            // 
            this.lblSeat3.BackColor = System.Drawing.Color.Blue;
            this.lblSeat3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat3.ForeColor = System.Drawing.Color.White;
            this.lblSeat3.Location = new System.Drawing.Point(166, 47);
            this.lblSeat3.Name = "lblSeat3";
            this.lblSeat3.Size = new System.Drawing.Size(33, 29);
            this.lblSeat3.TabIndex = 3;
            this.lblSeat3.Text = "3";
            this.lblSeat3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat4
            // 
            this.lblSeat4.BackColor = System.Drawing.Color.Blue;
            this.lblSeat4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat4.ForeColor = System.Drawing.Color.White;
            this.lblSeat4.Location = new System.Drawing.Point(217, 47);
            this.lblSeat4.Name = "lblSeat4";
            this.lblSeat4.Size = new System.Drawing.Size(33, 29);
            this.lblSeat4.TabIndex = 4;
            this.lblSeat4.Text = "4";
            this.lblSeat4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat5
            // 
            this.lblSeat5.BackColor = System.Drawing.Color.Blue;
            this.lblSeat5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat5.ForeColor = System.Drawing.Color.White;
            this.lblSeat5.Location = new System.Drawing.Point(24, 98);
            this.lblSeat5.Name = "lblSeat5";
            this.lblSeat5.Size = new System.Drawing.Size(33, 29);
            this.lblSeat5.TabIndex = 5;
            this.lblSeat5.Text = "5";
            this.lblSeat5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat6
            // 
            this.lblSeat6.BackColor = System.Drawing.Color.Blue;
            this.lblSeat6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat6.ForeColor = System.Drawing.Color.White;
            this.lblSeat6.Location = new System.Drawing.Point(77, 98);
            this.lblSeat6.Name = "lblSeat6";
            this.lblSeat6.Size = new System.Drawing.Size(33, 29);
            this.lblSeat6.TabIndex = 6;
            this.lblSeat6.Text = "6";
            this.lblSeat6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat7
            // 
            this.lblSeat7.BackColor = System.Drawing.Color.Blue;
            this.lblSeat7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat7.ForeColor = System.Drawing.Color.White;
            this.lblSeat7.Location = new System.Drawing.Point(166, 98);
            this.lblSeat7.Name = "lblSeat7";
            this.lblSeat7.Size = new System.Drawing.Size(33, 29);
            this.lblSeat7.TabIndex = 7;
            this.lblSeat7.Text = "7";
            this.lblSeat7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat8
            // 
            this.lblSeat8.BackColor = System.Drawing.Color.Blue;
            this.lblSeat8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat8.ForeColor = System.Drawing.Color.White;
            this.lblSeat8.Location = new System.Drawing.Point(217, 98);
            this.lblSeat8.Name = "lblSeat8";
            this.lblSeat8.Size = new System.Drawing.Size(33, 29);
            this.lblSeat8.TabIndex = 8;
            this.lblSeat8.Text = "8";
            this.lblSeat8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat9
            // 
            this.lblSeat9.BackColor = System.Drawing.Color.Blue;
            this.lblSeat9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat9.ForeColor = System.Drawing.Color.White;
            this.lblSeat9.Location = new System.Drawing.Point(24, 136);
            this.lblSeat9.Name = "lblSeat9";
            this.lblSeat9.Size = new System.Drawing.Size(33, 29);
            this.lblSeat9.TabIndex = 9;
            this.lblSeat9.Text = "9";
            this.lblSeat9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat10
            // 
            this.lblSeat10.BackColor = System.Drawing.Color.Blue;
            this.lblSeat10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat10.ForeColor = System.Drawing.Color.White;
            this.lblSeat10.Location = new System.Drawing.Point(77, 136);
            this.lblSeat10.Name = "lblSeat10";
            this.lblSeat10.Size = new System.Drawing.Size(33, 29);
            this.lblSeat10.TabIndex = 10;
            this.lblSeat10.Text = "10";
            this.lblSeat10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat11
            // 
            this.lblSeat11.BackColor = System.Drawing.Color.Blue;
            this.lblSeat11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat11.ForeColor = System.Drawing.Color.White;
            this.lblSeat11.Location = new System.Drawing.Point(166, 136);
            this.lblSeat11.Name = "lblSeat11";
            this.lblSeat11.Size = new System.Drawing.Size(33, 29);
            this.lblSeat11.TabIndex = 11;
            this.lblSeat11.Text = "11";
            this.lblSeat11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat12
            // 
            this.lblSeat12.BackColor = System.Drawing.Color.Blue;
            this.lblSeat12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat12.ForeColor = System.Drawing.Color.White;
            this.lblSeat12.Location = new System.Drawing.Point(217, 136);
            this.lblSeat12.Name = "lblSeat12";
            this.lblSeat12.Size = new System.Drawing.Size(33, 29);
            this.lblSeat12.TabIndex = 12;
            this.lblSeat12.Text = "12";
            this.lblSeat12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat13
            // 
            this.lblSeat13.BackColor = System.Drawing.Color.Blue;
            this.lblSeat13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat13.ForeColor = System.Drawing.Color.White;
            this.lblSeat13.Location = new System.Drawing.Point(24, 174);
            this.lblSeat13.Name = "lblSeat13";
            this.lblSeat13.Size = new System.Drawing.Size(33, 29);
            this.lblSeat13.TabIndex = 13;
            this.lblSeat13.Text = "13";
            this.lblSeat13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat14
            // 
            this.lblSeat14.BackColor = System.Drawing.Color.Blue;
            this.lblSeat14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat14.ForeColor = System.Drawing.Color.White;
            this.lblSeat14.Location = new System.Drawing.Point(77, 174);
            this.lblSeat14.Name = "lblSeat14";
            this.lblSeat14.Size = new System.Drawing.Size(33, 29);
            this.lblSeat14.TabIndex = 14;
            this.lblSeat14.Text = "14";
            this.lblSeat14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat15
            // 
            this.lblSeat15.BackColor = System.Drawing.Color.Blue;
            this.lblSeat15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat15.ForeColor = System.Drawing.Color.White;
            this.lblSeat15.Location = new System.Drawing.Point(166, 174);
            this.lblSeat15.Name = "lblSeat15";
            this.lblSeat15.Size = new System.Drawing.Size(33, 29);
            this.lblSeat15.TabIndex = 15;
            this.lblSeat15.Text = "15";
            this.lblSeat15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat16
            // 
            this.lblSeat16.BackColor = System.Drawing.Color.Blue;
            this.lblSeat16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat16.ForeColor = System.Drawing.Color.White;
            this.lblSeat16.Location = new System.Drawing.Point(217, 174);
            this.lblSeat16.Name = "lblSeat16";
            this.lblSeat16.Size = new System.Drawing.Size(33, 29);
            this.lblSeat16.TabIndex = 16;
            this.lblSeat16.Text = "16";
            this.lblSeat16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat24
            // 
            this.lblSeat24.BackColor = System.Drawing.Color.Blue;
            this.lblSeat24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat24.ForeColor = System.Drawing.Color.White;
            this.lblSeat24.Location = new System.Drawing.Point(217, 250);
            this.lblSeat24.Name = "lblSeat24";
            this.lblSeat24.Size = new System.Drawing.Size(33, 29);
            this.lblSeat24.TabIndex = 24;
            this.lblSeat24.Text = "24";
            this.lblSeat24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat23
            // 
            this.lblSeat23.BackColor = System.Drawing.Color.Blue;
            this.lblSeat23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat23.ForeColor = System.Drawing.Color.White;
            this.lblSeat23.Location = new System.Drawing.Point(166, 250);
            this.lblSeat23.Name = "lblSeat23";
            this.lblSeat23.Size = new System.Drawing.Size(33, 29);
            this.lblSeat23.TabIndex = 23;
            this.lblSeat23.Text = "23";
            this.lblSeat23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat22
            // 
            this.lblSeat22.BackColor = System.Drawing.Color.Blue;
            this.lblSeat22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat22.ForeColor = System.Drawing.Color.White;
            this.lblSeat22.Location = new System.Drawing.Point(77, 250);
            this.lblSeat22.Name = "lblSeat22";
            this.lblSeat22.Size = new System.Drawing.Size(33, 29);
            this.lblSeat22.TabIndex = 22;
            this.lblSeat22.Text = "22";
            this.lblSeat22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat21
            // 
            this.lblSeat21.BackColor = System.Drawing.Color.Blue;
            this.lblSeat21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat21.ForeColor = System.Drawing.Color.White;
            this.lblSeat21.Location = new System.Drawing.Point(24, 250);
            this.lblSeat21.Name = "lblSeat21";
            this.lblSeat21.Size = new System.Drawing.Size(33, 29);
            this.lblSeat21.TabIndex = 21;
            this.lblSeat21.Text = "21";
            this.lblSeat21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat20
            // 
            this.lblSeat20.BackColor = System.Drawing.Color.Blue;
            this.lblSeat20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat20.ForeColor = System.Drawing.Color.White;
            this.lblSeat20.Location = new System.Drawing.Point(217, 212);
            this.lblSeat20.Name = "lblSeat20";
            this.lblSeat20.Size = new System.Drawing.Size(33, 29);
            this.lblSeat20.TabIndex = 20;
            this.lblSeat20.Text = "20";
            this.lblSeat20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat19
            // 
            this.lblSeat19.BackColor = System.Drawing.Color.Blue;
            this.lblSeat19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat19.ForeColor = System.Drawing.Color.White;
            this.lblSeat19.Location = new System.Drawing.Point(166, 212);
            this.lblSeat19.Name = "lblSeat19";
            this.lblSeat19.Size = new System.Drawing.Size(33, 29);
            this.lblSeat19.TabIndex = 19;
            this.lblSeat19.Text = "19";
            this.lblSeat19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat18
            // 
            this.lblSeat18.BackColor = System.Drawing.Color.Blue;
            this.lblSeat18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat18.ForeColor = System.Drawing.Color.White;
            this.lblSeat18.Location = new System.Drawing.Point(77, 212);
            this.lblSeat18.Name = "lblSeat18";
            this.lblSeat18.Size = new System.Drawing.Size(33, 29);
            this.lblSeat18.TabIndex = 18;
            this.lblSeat18.Text = "18";
            this.lblSeat18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeat17
            // 
            this.lblSeat17.BackColor = System.Drawing.Color.Blue;
            this.lblSeat17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat17.ForeColor = System.Drawing.Color.White;
            this.lblSeat17.Location = new System.Drawing.Point(24, 212);
            this.lblSeat17.Name = "lblSeat17";
            this.lblSeat17.Size = new System.Drawing.Size(33, 29);
            this.lblSeat17.TabIndex = 17;
            this.lblSeat17.Text = "17";
            this.lblSeat17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDivider
            // 
            this.lblDivider.BackColor = System.Drawing.Color.Black;
            this.lblDivider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDivider.Location = new System.Drawing.Point(24, 81);
            this.lblDivider.Name = "lblDivider";
            this.lblDivider.Size = new System.Drawing.Size(226, 10);
            this.lblDivider.TabIndex = 25;
            // 
            // Flight_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 323);
            this.Controls.Add(this.plFlight412);
            this.Controls.Add(this.gbPassengerInfo);
            this.Name = "Flight_Reservation";
            this.Text = "Flight Reservation System";
            this.gbPassengerInfo.ResumeLayout(false);
            this.gbPassengerInfo.PerformLayout();
            this.plFlight412.ResumeLayout(false);
            this.plFlight412.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFlight;
        private System.Windows.Forms.ComboBox cbPassenger;
        private System.Windows.Forms.GroupBox gbPassengerInfo;
        private System.Windows.Forms.Label lblPassSeat;
        private System.Windows.Forms.Label lblPassengerSeatNum;
        private System.Windows.Forms.Label lblChoosePass;
        private System.Windows.Forms.Label lblChooseFlight;
        private System.Windows.Forms.Panel plFlight412;
        private System.Windows.Forms.Label lblFlightNum;
        private System.Windows.Forms.Label lblSeat1;
        private System.Windows.Forms.Label lblSeat16;
        private System.Windows.Forms.Label lblSeat15;
        private System.Windows.Forms.Label lblSeat14;
        private System.Windows.Forms.Label lblSeat13;
        private System.Windows.Forms.Label lblSeat12;
        private System.Windows.Forms.Label lblSeat11;
        private System.Windows.Forms.Label lblSeat10;
        private System.Windows.Forms.Label lblSeat9;
        private System.Windows.Forms.Label lblSeat8;
        private System.Windows.Forms.Label lblSeat7;
        private System.Windows.Forms.Label lblSeat6;
        private System.Windows.Forms.Label lblSeat5;
        private System.Windows.Forms.Label lblSeat4;
        private System.Windows.Forms.Label lblSeat3;
        private System.Windows.Forms.Label lblSeat2;
        private System.Windows.Forms.Label lblDivider;
        private System.Windows.Forms.Label lblSeat24;
        private System.Windows.Forms.Label lblSeat23;
        private System.Windows.Forms.Label lblSeat22;
        private System.Windows.Forms.Label lblSeat21;
        private System.Windows.Forms.Label lblSeat20;
        private System.Windows.Forms.Label lblSeat19;
        private System.Windows.Forms.Label lblSeat18;
        private System.Windows.Forms.Label lblSeat17;
    }
}

