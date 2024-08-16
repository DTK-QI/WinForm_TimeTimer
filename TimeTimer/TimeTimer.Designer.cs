
namespace TimeTimer
{
    partial class TimerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerForm));
            txtSerialNumber = new System.Windows.Forms.TextBox();
            Time = new System.Windows.Forms.Label();
            start = new System.Windows.Forms.Button();
            Stop = new System.Windows.Forms.Button();
            LongFormID = new System.Windows.Forms.Label();
            NowTime = new System.Windows.Forms.Label();
            listBoxRecords = new System.Windows.Forms.ListBox();
            Pause = new System.Windows.Forms.Button();
            buttonTogglePanel = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            User = new System.Windows.Forms.Label();
            bindingSource1 = new System.Windows.Forms.BindingSource(components);
            UserName = new System.Windows.Forms.TextBox();
            SytstemStatus = new System.Windows.Forms.PictureBox();
            HospID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SytstemStatus).BeginInit();
            SuspendLayout();
            // 
            // txtSerialNumber
            // 
            txtSerialNumber.BackColor = System.Drawing.SystemColors.Window;
            txtSerialNumber.Location = new System.Drawing.Point(211, 77);
            txtSerialNumber.Name = "txtSerialNumber";
            txtSerialNumber.Size = new System.Drawing.Size(192, 27);
            txtSerialNumber.TabIndex = 0;
            // 
            // Time
            // 
            Time.AutoSize = true;
            Time.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Time.Location = new System.Drawing.Point(85, 9);
            Time.Name = "Time";
            Time.Size = new System.Drawing.Size(39, 19);
            Time.TabIndex = 1;
            Time.Text = "時間";
            // 
            // start
            // 
            start.Cursor = System.Windows.Forms.Cursors.Hand;
            start.Image = (System.Drawing.Image)resources.GetObject("start.Image");
            start.Location = new System.Drawing.Point(40, 120);
            start.Name = "start";
            start.RightToLeft = System.Windows.Forms.RightToLeft.No;
            start.Size = new System.Drawing.Size(94, 29);
            start.TabIndex = 2;
            start.UseVisualStyleBackColor = true;
            start.Click += btnStart_Click;
            // 
            // Stop
            // 
            Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            Stop.Enabled = false;
            Stop.Image = (System.Drawing.Image)resources.GetObject("Stop.Image");
            Stop.Location = new System.Drawing.Point(286, 120);
            Stop.Name = "Stop";
            Stop.Size = new System.Drawing.Size(94, 29);
            Stop.TabIndex = 5;
            Stop.UseVisualStyleBackColor = true;
            Stop.Click += btnStop_Click;
            // 
            // LongFormID
            // 
            LongFormID.AutoSize = true;
            LongFormID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LongFormID.Location = new System.Drawing.Point(6, 80);
            LongFormID.Name = "LongFormID";
            LongFormID.Size = new System.Drawing.Size(118, 19);
            LongFormID.TabIndex = 6;
            LongFormID.Text = "院區-流水號(ID)";
            // 
            // NowTime
            // 
            NowTime.AutoSize = true;
            NowTime.Location = new System.Drawing.Point(129, 9);
            NowTime.Name = "NowTime";
            NowTime.Size = new System.Drawing.Size(69, 19);
            NowTime.TabIndex = 7;
            NowTime.Text = "00:00:00";
            NowTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBoxRecords
            // 
            listBoxRecords.FormattingEnabled = true;
            listBoxRecords.ItemHeight = 19;
            listBoxRecords.Location = new System.Drawing.Point(62, 190);
            listBoxRecords.Name = "listBoxRecords";
            listBoxRecords.Size = new System.Drawing.Size(294, 213);
            listBoxRecords.TabIndex = 8;
            // 
            // Pause
            // 
            Pause.Cursor = System.Windows.Forms.Cursors.Hand;
            Pause.Enabled = false;
            Pause.Image = (System.Drawing.Image)resources.GetObject("Pause.Image");
            Pause.Location = new System.Drawing.Point(164, 120);
            Pause.Name = "Pause";
            Pause.Size = new System.Drawing.Size(94, 29);
            Pause.TabIndex = 9;
            Pause.UseVisualStyleBackColor = true;
            Pause.Click += btnPause_Click;
            // 
            // buttonTogglePanel
            // 
            buttonTogglePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonTogglePanel.Image = Properties.Resources._9073113_double_caret_down_small_icon;
            buttonTogglePanel.Location = new System.Drawing.Point(10, 155);
            buttonTogglePanel.Name = "buttonTogglePanel";
            buttonTogglePanel.Size = new System.Drawing.Size(395, 29);
            buttonTogglePanel.TabIndex = 10;
            buttonTogglePanel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Location = new System.Drawing.Point(11, 190);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(394, 213);
            panel1.TabIndex = 11;
            // 
            // User
            // 
            User.AutoSize = true;
            User.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            User.Location = new System.Drawing.Point(40, 44);
            User.Name = "User";
            User.Size = new System.Drawing.Size(84, 19);
            User.TabIndex = 12;
            User.Text = "使用者名稱";
            // 
            // UserName
            // 
            UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            UserName.Location = new System.Drawing.Point(130, 41);
            UserName.Name = "UserName";
            UserName.Size = new System.Drawing.Size(273, 27);
            UserName.TabIndex = 13;
            // 
            // SytstemStatus
            // 
            SytstemStatus.BackgroundImage = Properties.Resources._34555_ball_green_icon;
            SytstemStatus.Location = new System.Drawing.Point(384, 9);
            SytstemStatus.Name = "SytstemStatus";
            SytstemStatus.Size = new System.Drawing.Size(19, 19);
            SytstemStatus.TabIndex = 14;
            SytstemStatus.TabStop = false;
            // 
            // HospID
            // 
            HospID.BackColor = System.Drawing.Color.White;
            HospID.Location = new System.Drawing.Point(130, 77);
            HospID.Name = "HospID";
            HospID.Size = new System.Drawing.Size(75, 27);
            HospID.TabIndex = 15;
            // 
            // TimerForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(415, 195);
            Controls.Add(HospID);
            Controls.Add(SytstemStatus);
            Controls.Add(UserName);
            Controls.Add(User);
            Controls.Add(panel1);
            Controls.Add(buttonTogglePanel);
            Controls.Add(Pause);
            Controls.Add(listBoxRecords);
            Controls.Add(NowTime);
            Controls.Add(LongFormID);
            Controls.Add(Stop);
            Controls.Add(start);
            Controls.Add(Time);
            Controls.Add(txtSerialNumber);
            ForeColor = System.Drawing.SystemColors.ControlText;
            Name = "TimerForm";
            Text = "Timer";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)SytstemStatus).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Label LongFormID;
        private System.Windows.Forms.Label NowTime;
        private System.Windows.Forms.ListBox listBoxRecords;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button buttonTogglePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.PictureBox SytstemStatus;
        private System.Windows.Forms.TextBox HospID;
    }
}

