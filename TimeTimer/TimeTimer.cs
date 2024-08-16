using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TimeTimer
{
    public partial class TimerForm : Form
    {
        private Timer timer;
        private DateTime startTime;
        private DateTime AlterTime;
        private TimeSpan elapsedTime;
        private TimeSpan TotalPauseTime;
        private DateTime PauseTime;
        private RecordModel record;
        private string TabPattern;

        private int isRunning; // 0 free 1 running 2 pause

        private Timer animationTimer;
        private bool isPanelVisible;
        private int panelHeightStep = 10; // 每次更新高度的增量
        private int maxPanelHeight;
        private int minPanelHeight = 0;

        private const int MinFormHeight = 250; // 最小高度
        private const int MaxFormHeight = 500; // 最大高度

        // 用於存儲紀錄的內部列表
        private List<RecordModel> records;

        public TimerForm()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000; // 1秒更新一次
            timer.Tick += Timer_Tick;
            records = new List<RecordModel>();
            record = new RecordModel();
            TabPattern = @"\t";

            // 初始化 Panel 和 Timer
            maxPanelHeight = panel1.Height;
            TotalPauseTime = new TimeSpan();
            isPanelVisible = true;
            animationTimer = new Timer();
            animationTimer.Interval = 30; // 每 30 毫秒更新一次
            animationTimer.Tick += AnimationTimer_Tick;
            buttonTogglePanel.Click += ButtonTogglePanel_Click;

            this.SizeChanged += Form1_SizeChanged;

        }

        

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (((DateTime.Now - AlterTime).Minutes - PauseTime.Minute) > 30)
            {
                AlterTime = DateTime.Now;
                MessageBox.Show("已使用30分鐘了~~ 記得休息一下");
            }

            elapsedTime = DateTime.Now - startTime - TotalPauseTime;
            NowTime.Text = elapsedTime.ToString(@"hh\:mm\:ss");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSerialNumber.Text))
            {
                MessageBox.Show("請輸入流水號(ID)！");
                return;
            }
            if (string.IsNullOrEmpty(UserName.Text))
            {
                MessageBox.Show("請輸入使用者名稱！");
                return;
            }

            txtSerialNumber.Cursor = Cursors.No;
            txtSerialNumber.BackColor = Color.Gray;
            UserName.Cursor = Cursors.No;
            UserName.BackColor = Color.Gray;

            if (isRunning == 0 )
            {
                startTime = DateTime.Now;
                AlterTime = DateTime.Now;
                this.Text = "Timer(計時中)";
                timer.Start();
                isRunning = 1;
                SytstemStatus.Image = Properties.Resources._34556_ball_red_icon;

                // 將 "開始" 動作記錄下來
                record.SerialNumber = txtSerialNumber.Text;
                record.UserName = UserName.Text;
                record.StartTime = DateTime.Now;
            }
            else if(isRunning == 2)
            {
                this.Text = "Timer(計時中)";
                TotalPauseTime += DateTime.Now - PauseTime;
                SytstemStatus.Image = Properties.Resources._34556_ball_red_icon;
                isRunning = 1;
                timer.Start();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (isRunning == 1)
            {
                this.Text = "Timer(暫停)";
                timer.Stop();
                isRunning = 2;
                SytstemStatus.Image = Properties.Resources._34557_yellow_ball_icon;
                PauseTime = DateTime.Now;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (isRunning == 1 || isRunning == 2)
            {
                this.Text = "Timer";
                timer.Stop();
                isRunning = 0;
                SytstemStatus.Image = Properties.Resources._34555_ball_green_icon;


                // 將結果保存到 ListBox
                record.EndTime = DateTime.Now;
                record.TotalPauseTime = TotalPauseTime;
                record.TotalUseTime = record.EndTime - record.StartTime - TotalPauseTime;
                records.Add(record);

                listBoxRecords.Items.Add($"ID:{record.SerialNumber} 時間:{record.TotalUseTime.ToString(@"hh\:mm\:ss\.fff")}");
                TotalPauseTime = new TimeSpan();
                record = new RecordModel();
            }

            txtSerialNumber.Cursor = Cursors.IBeam;
            txtSerialNumber.BackColor = Color.White;
            UserName.Cursor = Cursors.IBeam;
            UserName.BackColor = Color.White;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "文本文件 (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    writer.Write("使用者名稱\t");
                    writer.Write("長表號碼\t");
                    writer.Write("開始時間\t");
                    writer.Write("結束時間\t");
                    writer.Write("暫停總時間\t");
                    writer.Write("總使用時間\t\n");
                    foreach (var item in records)
                    {
                        writer.Write(item.UserName + "\t");
                        writer.Write(item.SerialNumber + "\t");
                        writer.Write(item.StartTime.ToString("yyyy-MM-dd HH:mm:ss.fff") + "\t");
                        writer.Write(item.EndTime.ToString("yyyy-MM-dd HH:mm:ss.fff") + "\t");
                        writer.Write(item.TotalPauseTime.ToString(@"hh\:mm\:ss\.fff") + "\t");
                        writer.Write(item.TotalUseTime.ToString(@"hh\:mm\:ss\.fff") + "\t\n");
                    }
                }

                MessageBox.Show("紀錄已成功導出！");
            }
        }

        private void ButtonTogglePanel_Click(object sender, EventArgs e)
        {
            // 開始動畫
            animationTimer.Start();
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            int formHeightStep = panelHeightStep; // 讓窗體的高度隨著 Panel 的高度變化

            if (isPanelVisible)
            {
                // Panel 正在隱藏，由上而下收起
                if (panel1.Height > minPanelHeight)
                {
                    panel1.Height -= panelHeightStep;
                    // 調整 Panel 的 Top 屬性，使 Panel 的頂部保持固定
                    panel1.Top += panelHeightStep;
                    this.Height += formHeightStep;
                }
                else
                {

                    // 完全隱藏後停止計時器
                    buttonTogglePanel.Image = Properties.Resources._9073113_double_caret_up_small_icon;
                    panel1.Height = minPanelHeight;
                    isPanelVisible = false;
                    animationTimer.Stop();
                }
            }
            else
            {
                // Panel 正在顯示，由上而下展開
                if (panel1.Height < maxPanelHeight)
                {
                    panel1.Height += panelHeightStep;
                    // 調整 Panel 的 Top 屬性，使 Panel 的頂部保持固定
                    panel1.Top -= panelHeightStep;
                    this.Height -= formHeightStep;
                }
                else
                {
                    // 完全顯示後停止計時器
                    buttonTogglePanel.Image = Properties.Resources._9073113_double_caret_down_small_icon;
                    panel1.Height = maxPanelHeight;
                    isPanelVisible = true;
                    animationTimer.Stop();
                }
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            // 限制窗體高度在指定範圍內
            if (this.Height < MinFormHeight)
            {
                this.Height = MinFormHeight;
            }
            else if (this.Height > MaxFormHeight)
            {
                this.Height = MaxFormHeight;
            }
        }

    }
}