
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerForm));
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.Time = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.LongFormID = new System.Windows.Forms.Label();
            this.NowTime = new System.Windows.Forms.Label();
            this.listBoxRecords = new System.Windows.Forms.ListBox();
            this.Pause = new System.Windows.Forms.Button();
            this.buttonTogglePanel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.User = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.UserName = new System.Windows.Forms.TextBox();
            this.SytstemStatus = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SytstemStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtSerialNumber.Location = new System.Drawing.Point(110, 77);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(237, 27);
            this.txtSerialNumber.TabIndex = 0;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Time.Location = new System.Drawing.Point(65, 9);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(39, 19);
            this.Time.TabIndex = 1;
            this.Time.Text = "時間";
            // 
            // start
            // 
            this.start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start.Image = ((System.Drawing.Image)(resources.GetObject("start.Image")));
            this.start.Location = new System.Drawing.Point(10, 120);
            this.start.Name = "start";
            this.start.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.start.Size = new System.Drawing.Size(94, 29);
            this.start.TabIndex = 2;
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Export
            // 
            this.Export.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Export.Image = ((System.Drawing.Image)(resources.GetObject("Export.Image")));
            this.Export.Location = new System.Drawing.Point(311, 120);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(94, 29);
            this.Export.TabIndex = 4;
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Stop
            // 
            this.Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Stop.Image = ((System.Drawing.Image)(resources.GetObject("Stop.Image")));
            this.Stop.Location = new System.Drawing.Point(211, 120);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(94, 29);
            this.Stop.TabIndex = 5;
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // LongFormID
            // 
            this.LongFormID.AutoSize = true;
            this.LongFormID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LongFormID.Location = new System.Drawing.Point(23, 80);
            this.LongFormID.Name = "LongFormID";
            this.LongFormID.Size = new System.Drawing.Size(81, 19);
            this.LongFormID.TabIndex = 6;
            this.LongFormID.Text = "流水號(ID)";
            // 
            // NowTime
            // 
            this.NowTime.AutoSize = true;
            this.NowTime.Location = new System.Drawing.Point(110, 9);
            this.NowTime.Name = "NowTime";
            this.NowTime.Size = new System.Drawing.Size(69, 19);
            this.NowTime.TabIndex = 7;
            this.NowTime.Text = "00:00:00";
            this.NowTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBoxRecords
            // 
            this.listBoxRecords.FormattingEnabled = true;
            this.listBoxRecords.ItemHeight = 19;
            this.listBoxRecords.Location = new System.Drawing.Point(62, 190);
            this.listBoxRecords.Name = "listBoxRecords";
            this.listBoxRecords.Size = new System.Drawing.Size(294, 213);
            this.listBoxRecords.TabIndex = 8;
            // 
            // Pause
            // 
            this.Pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pause.Image = ((System.Drawing.Image)(resources.GetObject("Pause.Image")));
            this.Pause.Location = new System.Drawing.Point(111, 120);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(94, 29);
            this.Pause.TabIndex = 9;
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // buttonTogglePanel
            // 
            this.buttonTogglePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTogglePanel.Image = global::TimeTimer.Properties.Resources._9073113_double_caret_down_small_icon;
            this.buttonTogglePanel.Location = new System.Drawing.Point(10, 155);
            this.buttonTogglePanel.Name = "buttonTogglePanel";
            this.buttonTogglePanel.Size = new System.Drawing.Size(395, 29);
            this.buttonTogglePanel.TabIndex = 10;
            this.buttonTogglePanel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(11, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 213);
            this.panel1.TabIndex = 11;
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.User.Location = new System.Drawing.Point(20, 44);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(84, 19);
            this.User.TabIndex = 12;
            this.User.Text = "使用者名稱";
            // 
            // UserName
            // 
            this.UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserName.Location = new System.Drawing.Point(110, 41);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(237, 27);
            this.UserName.TabIndex = 13;
            // 
            // SytstemStatus
            // 
            this.SytstemStatus.BackgroundImage = global::TimeTimer.Properties.Resources._34555_ball_green_icon;
            this.SytstemStatus.Location = new System.Drawing.Point(386, 9);
            this.SytstemStatus.Name = "SytstemStatus";
            this.SytstemStatus.Size = new System.Drawing.Size(19, 19);
            this.SytstemStatus.TabIndex = 14;
            this.SytstemStatus.TabStop = false;
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 195);
            this.Controls.Add(this.SytstemStatus);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.User);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonTogglePanel);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.listBoxRecords);
            this.Controls.Add(this.NowTime);
            this.Controls.Add(this.LongFormID);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.start);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.txtSerialNumber);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "TimerForm";
            this.Text = "Timer";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SytstemStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button Export;
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
    }
}

