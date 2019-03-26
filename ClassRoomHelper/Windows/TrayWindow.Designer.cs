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
			this.titleLabel1 = new ClassRoomHelper.Windows.Controls.TitleLabel();
			this.titleLabel3 = new ClassRoomHelper.Windows.Controls.TitleLabel();
			this.titleLabel2 = new ClassRoomHelper.Windows.Controls.TitleLabel();
			this.Tray = new System.Windows.Forms.NotifyIcon(this.components);
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// titleLabel1
			// 
			this.titleLabel1.AutoSize = true;
			this.titleLabel1.BackColor = System.Drawing.Color.Transparent;
			this.titleLabel1.Font = new System.Drawing.Font("黑体", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.titleLabel1.ForeColor = System.Drawing.Color.DarkOrange;
			this.titleLabel1.Location = new System.Drawing.Point(139, 30);
			this.titleLabel1.Name = "titleLabel1";
			this.titleLabel1.Size = new System.Drawing.Size(426, 97);
			this.titleLabel1.TabIndex = 0;
			this.titleLabel1.Text = "班级助手";
			// 
			// titleLabel3
			// 
			this.titleLabel3.AutoSize = true;
			this.titleLabel3.BackColor = System.Drawing.Color.Transparent;
			this.titleLabel3.Font = new System.Drawing.Font("黑体", 28F);
			this.titleLabel3.ForeColor = System.Drawing.Color.Cyan;
			this.titleLabel3.Location = new System.Drawing.Point(182, 253);
			this.titleLabel3.Name = "titleLabel3";
			this.titleLabel3.Size = new System.Drawing.Size(340, 38);
			this.titleLabel3.TabIndex = 1;
			this.titleLabel3.Text = "正在启动 , 请稍后";
			// 
			// titleLabel2
			// 
			this.titleLabel2.AutoSize = true;
			this.titleLabel2.BackColor = System.Drawing.Color.Transparent;
			this.titleLabel2.Font = new System.Drawing.Font("黑体", 20F);
			this.titleLabel2.ForeColor = System.Drawing.Color.Gold;
			this.titleLabel2.Location = new System.Drawing.Point(628, 438);
			this.titleLabel2.Name = "titleLabel2";
			this.titleLabel2.Size = new System.Drawing.Size(82, 27);
			this.titleLabel2.TabIndex = 2;
			this.titleLabel2.Text = "V 2.0";
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
			// TrayWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(722, 474);
			this.Controls.Add(this.titleLabel2);
			this.Controls.Add(this.titleLabel3);
			this.Controls.Add(this.titleLabel1);
			this.Name = "TrayWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TrayWindow";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrayWindow_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TrayWindow_FormClosed);
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
	}
}