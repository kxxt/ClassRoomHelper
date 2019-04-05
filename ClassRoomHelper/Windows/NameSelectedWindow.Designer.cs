namespace ClassRoomHelper.Windows
{
	partial class NameSelectedWindow
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
				timer2.Dispose();
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NameSelectedWindow));
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.titleLabel1 = new ClassRoomHelper.Windows.Controls.TitleLabel();
			this.titleLabel2 = new ClassRoomHelper.Windows.Controls.TitleLabel();
			this.titleLabel3 = new ClassRoomHelper.Windows.Controls.TitleLabel();
			this.SuspendLayout();
			// 
			// timer2
			// 
			this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
			// 
			// titleLabel1
			// 
			this.titleLabel1.BackColor = System.Drawing.Color.Transparent;
			this.titleLabel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.titleLabel1.Font = new System.Drawing.Font("黑体", 90F);
			this.titleLabel1.ForeColor = System.Drawing.Color.Black;
			this.titleLabel1.Location = new System.Drawing.Point(0, 0);
			this.titleLabel1.Name = "titleLabel1";
			this.titleLabel1.Size = new System.Drawing.Size(1161, 172);
			this.titleLabel1.TabIndex = 0;
			this.titleLabel1.Text = "已选中";
			this.titleLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.titleLabel1.Click += new System.EventHandler(this.Click);
			// 
			// titleLabel2
			// 
			this.titleLabel2.BackColor = System.Drawing.Color.Transparent;
			this.titleLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.titleLabel2.Font = new System.Drawing.Font("黑体", 160F);
			this.titleLabel2.ForeColor = System.Drawing.Color.Black;
			this.titleLabel2.Location = new System.Drawing.Point(0, 172);
			this.titleLabel2.Name = "titleLabel2";
			this.titleLabel2.Size = new System.Drawing.Size(1161, 695);
			this.titleLabel2.TabIndex = 1;
			this.titleLabel2.Text = "{Text}";
			this.titleLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.titleLabel2.Click += new System.EventHandler(this.Click);
			// 
			// titleLabel3
			// 
			this.titleLabel3.BackColor = System.Drawing.Color.Transparent;
			this.titleLabel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.titleLabel3.Font = new System.Drawing.Font("黑体", 90F);
			this.titleLabel3.ForeColor = System.Drawing.Color.Black;
			this.titleLabel3.Location = new System.Drawing.Point(0, 652);
			this.titleLabel3.Name = "titleLabel3";
			this.titleLabel3.Size = new System.Drawing.Size(1161, 215);
			this.titleLabel3.TabIndex = 2;
			this.titleLabel3.Text = "同学";
			this.titleLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.titleLabel3.Click += new System.EventHandler(this.Click);
			// 
			// NameSelectedWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1161, 867);
			this.Controls.Add(this.titleLabel3);
			this.Controls.Add(this.titleLabel2);
			this.Controls.Add(this.titleLabel1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NameSelectedWindow";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "NameSelectedWindow";
			this.TopMost = true;
			this.Shown += new System.EventHandler(this.NameSelectedWindow_Shown);
			this.VisibleChanged += new System.EventHandler(this.NameSelectedWindow_VisibleChanged);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Timer timer2;
		private Controls.TitleLabel titleLabel1;
		private Controls.TitleLabel titleLabel2;
		private Controls.TitleLabel titleLabel3;
	}
}