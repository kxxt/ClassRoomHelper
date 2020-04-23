namespace ClassRoomHelper.Windows
{
	partial class TrayWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrayWindow));
			this.Tray = new System.Windows.Forms.NotifyIcon(this.components);
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.titleLabel5 = new ClassRoomHelper.Windows.Controls.TitleLabel();
			this.titleLabel4 = new ClassRoomHelper.Windows.Controls.TitleLabel();
			this.titleLabel2 = new ClassRoomHelper.Windows.Controls.TitleLabel();
			this.titleLabel3 = new ClassRoomHelper.Windows.Controls.TitleLabel();
			this.titleLabel1 = new ClassRoomHelper.Windows.Controls.TitleLabel();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
			this.CameraTimer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// Tray
			// 
			this.Tray.Icon = ((System.Drawing.Icon)(resources.GetObject("Tray.Icon")));
			this.Tray.Text = "班级助手";
			this.Tray.Visible = true;
			this.Tray.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Tray_MouseClick);
			// 
			// timer1
			// 
			this.timer1.Interval = 3000;
			this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			// 
			// timer2
			// 
			this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
			// 
			// titleLabel5
			// 
			this.titleLabel5.AutoSize = true;
			this.titleLabel5.BackColor = System.Drawing.Color.Transparent;
			this.titleLabel5.Font = new System.Drawing.Font("Old English Text MT", 23F);
			this.titleLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.titleLabel5.Location = new System.Drawing.Point(12, 327);
			this.titleLabel5.Name = "titleLabel5";
			this.titleLabel5.Size = new System.Drawing.Size(619, 76);
			this.titleLabel5.TabIndex = 4;
			this.titleLabel5.Text = "(C)Copyright 2019 Believers in Science Studio\r\nhttps://kxxt.github.io";
			// 
			// titleLabel4
			// 
			this.titleLabel4.AutoSize = true;
			this.titleLabel4.BackColor = System.Drawing.Color.Transparent;
			this.titleLabel4.Font = new System.Drawing.Font("黑体", 20F);
			this.titleLabel4.ForeColor = System.Drawing.Color.Fuchsia;
			this.titleLabel4.Location = new System.Drawing.Point(12, 406);
			this.titleLabel4.Name = "titleLabel4";
			this.titleLabel4.Size = new System.Drawing.Size(572, 54);
			this.titleLabel4.TabIndex = 3;
			this.titleLabel4.Text = "感谢由 Unsplash.com 提供的高质量免费图片\r\n感谢由 Bing.com 提供的免费壁纸";
			// 
			// titleLabel2
			// 
			this.titleLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.titleLabel2.AutoSize = true;
			this.titleLabel2.BackColor = System.Drawing.Color.Transparent;
			this.titleLabel2.Font = new System.Drawing.Font("黑体", 20F);
			this.titleLabel2.ForeColor = System.Drawing.Color.Gold;
			this.titleLabel2.Location = new System.Drawing.Point(628, 438);
			this.titleLabel2.Name = "titleLabel2";
			this.titleLabel2.Size = new System.Drawing.Size(82, 27);
			this.titleLabel2.TabIndex = 2;
			this.titleLabel2.Text = "V 2.0";
			this.titleLabel2.Click += new System.EventHandler(this.titleLabel2_Click);
			// 
			// titleLabel3
			// 
			this.titleLabel3.AutoSize = true;
			this.titleLabel3.BackColor = System.Drawing.Color.Transparent;
			this.titleLabel3.Font = new System.Drawing.Font("黑体", 28F);
			this.titleLabel3.ForeColor = System.Drawing.Color.Yellow;
			this.titleLabel3.Location = new System.Drawing.Point(182, 253);
			this.titleLabel3.Name = "titleLabel3";
			this.titleLabel3.Size = new System.Drawing.Size(340, 38);
			this.titleLabel3.TabIndex = 1;
			this.titleLabel3.Text = "正在启动 , 请稍后";
			this.titleLabel3.Click += new System.EventHandler(this.titleLabel3_Click);
			// 
			// titleLabel1
			// 
			this.titleLabel1.AutoSize = true;
			this.titleLabel1.BackColor = System.Drawing.Color.Transparent;
			this.titleLabel1.Font = new System.Drawing.Font("黑体", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.titleLabel1.ForeColor = System.Drawing.Color.GreenYellow;
			this.titleLabel1.Location = new System.Drawing.Point(139, 30);
			this.titleLabel1.Name = "titleLabel1";
			this.titleLabel1.Size = new System.Drawing.Size(426, 97);
			this.titleLabel1.TabIndex = 0;
			this.titleLabel1.Text = "班级助手";
			this.titleLabel1.Click += new System.EventHandler(this.titleLabel1_Click);
			// 
			// videoSourcePlayer1
			// 
			this.videoSourcePlayer1.Location = new System.Drawing.Point(61, 136);
			this.videoSourcePlayer1.Name = "videoSourcePlayer1";
			this.videoSourcePlayer1.Size = new System.Drawing.Size(133, 114);
			this.videoSourcePlayer1.TabIndex = 5;
			this.videoSourcePlayer1.Text = "videoSourcePlayer1";
			this.videoSourcePlayer1.VideoSource = null;
			this.videoSourcePlayer1.Visible = false;
			// 
			// CameraTimer
			// 
			this.CameraTimer.Interval = 10000;
			this.CameraTimer.Tick += new System.EventHandler(this.CameraTimer_Tick);
			// 
			// TrayWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(722, 474);
			this.Controls.Add(this.videoSourcePlayer1);
			this.Controls.Add(this.titleLabel5);
			this.Controls.Add(this.titleLabel4);
			this.Controls.Add(this.titleLabel2);
			this.Controls.Add(this.titleLabel3);
			this.Controls.Add(this.titleLabel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TrayWindow";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TrayWindow";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrayWindow_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TrayWindow_FormClosed);
			this.Load += new System.EventHandler(this.TrayWindow_Load);
			this.Shown += new System.EventHandler(this.TrayWindow_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Controls.TitleLabel titleLabel1;
		private Controls.TitleLabel titleLabel3;
		private Controls.TitleLabel titleLabel2;
		private System.Windows.Forms.NotifyIcon Tray;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Timer timer2;
		private Controls.TitleLabel titleLabel4;
		private Controls.TitleLabel titleLabel5;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
		private System.Windows.Forms.Timer CameraTimer;
	}
}