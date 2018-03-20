﻿namespace WireFrame
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
            this.SubmitBooking = new System.Windows.Forms.Button();
            this.CheckBookingsButton = new System.Windows.Forms.Button();
            this.PlatformCombobox = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.TimeBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.NoOfPeopleComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ViewCurrentEquipmentButton = new System.Windows.Forms.Button();
            this.CopyrightInfoButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // SubmitBooking
            // 
            this.SubmitBooking.Location = new System.Drawing.Point(327, 270);
            this.SubmitBooking.Name = "SubmitBooking";
            this.SubmitBooking.Size = new System.Drawing.Size(273, 22);
            this.SubmitBooking.TabIndex = 7;
            this.SubmitBooking.Text = "Make booking";
            this.SubmitBooking.UseVisualStyleBackColor = true;
            this.SubmitBooking.Click += new System.EventHandler(this.SubmitBooking_Click);
            // 
            // CheckBookingsButton
            // 
            this.CheckBookingsButton.Location = new System.Drawing.Point(327, 365);
            this.CheckBookingsButton.Name = "CheckBookingsButton";
            this.CheckBookingsButton.Size = new System.Drawing.Size(273, 55);
            this.CheckBookingsButton.TabIndex = 8;
            this.CheckBookingsButton.Text = "Check Bookings";
            this.CheckBookingsButton.UseVisualStyleBackColor = true;
            this.CheckBookingsButton.Click += new System.EventHandler(this.CheckBookingsButton_Click);
            // 
            // PlatformCombobox
            // 
            this.PlatformCombobox.FormattingEnabled = true;
            this.PlatformCombobox.Items.AddRange(new object[] {
            "PC",
            "XBONE",
            "PS4"});
            this.PlatformCombobox.Location = new System.Drawing.Point(479, 102);
            this.PlatformCombobox.Name = "PlatformCombobox";
            this.PlatformCombobox.Size = new System.Drawing.Size(121, 21);
            this.PlatformCombobox.TabIndex = 12;
            this.PlatformCombobox.Text = "Please Choose";
            this.PlatformCombobox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1 Hour",
            "2 Hours",
            "5 Hours"});
            this.comboBox2.Location = new System.Drawing.Point(479, 136);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.Text = "Please Choose";
            // 
            // TimeBox
            // 
            this.TimeBox.FormattingEnabled = true;
            this.TimeBox.Items.AddRange(new object[] {
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "01:00",
            "02:00",
            "03:00",
            "04:00"});
            this.TimeBox.Location = new System.Drawing.Point(479, 173);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(121, 21);
            this.TimeBox.TabIndex = 15;
            this.TimeBox.Text = "Please Choose";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Platform";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Booking Length";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Start Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Software";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Grand Theft Auto",
            "Mortal Kombat",
            "Call of Duty",
            "League of Legends",
            "Counter Strike",
            "Crash Bandicoot"});
            this.comboBox3.Location = new System.Drawing.Point(479, 208);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 20;
            this.comboBox3.Text = "Please Choose";
            // 
            // NoOfPeopleComboBox
            // 
            this.NoOfPeopleComboBox.FormattingEnabled = true;
            this.NoOfPeopleComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.NoOfPeopleComboBox.Location = new System.Drawing.Point(479, 243);
            this.NoOfPeopleComboBox.Name = "NoOfPeopleComboBox";
            this.NoOfPeopleComboBox.Size = new System.Drawing.Size(121, 21);
            this.NoOfPeopleComboBox.TabIndex = 22;
            this.NoOfPeopleComboBox.Text = "Please Choose";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(324, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Number of People";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(499, 25);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(112, 54);
            this.LoginButton.TabIndex = 23;
            this.LoginButton.Text = "Account Log In";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewCurrentEquipmentButton
            // 
            this.ViewCurrentEquipmentButton.Location = new System.Drawing.Point(327, 314);
            this.ViewCurrentEquipmentButton.Name = "ViewCurrentEquipmentButton";
            this.ViewCurrentEquipmentButton.Size = new System.Drawing.Size(273, 45);
            this.ViewCurrentEquipmentButton.TabIndex = 24;
            this.ViewCurrentEquipmentButton.Text = "View Available Hardware / Games";
            this.ViewCurrentEquipmentButton.UseVisualStyleBackColor = true;
            this.ViewCurrentEquipmentButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // CopyrightInfoButton
            // 
            this.CopyrightInfoButton.Location = new System.Drawing.Point(217, 437);
            this.CopyrightInfoButton.Name = "CopyrightInfoButton";
            this.CopyrightInfoButton.Size = new System.Drawing.Size(189, 62);
            this.CopyrightInfoButton.TabIndex = 25;
            this.CopyrightInfoButton.Text = "Copyright Info";
            this.CopyrightInfoButton.UseVisualStyleBackColor = true;
            this.CopyrightInfoButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 54);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Upcoming Events";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Game 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Game 2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Game 3";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(183, 211);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 31;
            this.button4.Text = "Book";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(183, 302);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 32;
            this.button5.Text = "Book";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(183, 397);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 33;
            this.button6.Text = "Book";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(46, 270);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 50);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(46, 176);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(131, 50);
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(46, 356);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(131, 50);
            this.pictureBox4.TabIndex = 36;
            this.pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 511);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CopyrightInfoButton);
            this.Controls.Add(this.ViewCurrentEquipmentButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.NoOfPeopleComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TimeBox);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.PlatformCombobox);
            this.Controls.Add(this.CheckBookingsButton);
            this.Controls.Add(this.SubmitBooking);
            this.Name = "Form1";
            this.Text = "User Interface";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SubmitBooking;
        private System.Windows.Forms.Button CheckBookingsButton;
        private System.Windows.Forms.ComboBox PlatformCombobox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox TimeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox NoOfPeopleComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button ViewCurrentEquipmentButton;
        private System.Windows.Forms.Button CopyrightInfoButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

