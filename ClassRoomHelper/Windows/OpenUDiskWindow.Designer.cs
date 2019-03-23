namespace ClassRoomHelper.Windows
{
	partial class OpenUDiskWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenUDiskWindow));
			this.panel1 = new System.Windows.Forms.Panel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.titleLabel1 = new ClassRoomHelper.Windows.Controls.TitleLabel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.titleLabel1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(963, 500);
			this.panel1.TabIndex = 1;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			// 
			// titleLabel1
			// 
			this.titleLabel1.AutoSize = true;
			this.titleLabel1.BackColor = System.Drawing.Color.Transparent;
			this.titleLabel1.Font = new System.Drawing.Font("黑体", 75F);
			this.titleLabel1.Location = new System.Drawing.Point(35, 200);
			this.titleLabel1.Name = "titleLabel1";
			this.titleLabel1.Size = new System.Drawing.Size(892, 100);
			this.titleLabel1.TabIndex = 0;
			this.titleLabel1.Text = "已自动为您打开U盘";
			// 
			// OpenUDiskWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(963, 500);
			this.Controls.Add(this.panel1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "OpenUDiskWindow";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "OpenUDiskWindow";
			this.TopMost = true;
			this.Shown += new System.EventHandler(this.OpenUDiskWindow_Shown);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Controls.TitleLabel titleLabel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Timer timer1;
	}
}