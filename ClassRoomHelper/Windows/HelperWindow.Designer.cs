namespace ClassRoomHelper.Windows
{
	partial class HelperWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelperWindow));
			this.defaultButton2 = new ClassRoomHelper.Windows.Controls.DefaultButton();
			this.defaultButton1 = new ClassRoomHelper.Windows.Controls.DefaultButton();
			this.SuspendLayout();
			// 
			// defaultButton2
			// 
			this.defaultButton2.AccessibleName = "Button";
			this.defaultButton2.BackColor = System.Drawing.Color.Aqua;
			this.defaultButton2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.defaultButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.defaultButton2.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.defaultButton2.Location = new System.Drawing.Point(0, 79);
			this.defaultButton2.Name = "defaultButton2";
			this.defaultButton2.Size = new System.Drawing.Size(96, 28);
			this.defaultButton2.Style.BackColor = System.Drawing.Color.Aqua;
			this.defaultButton2.TabIndex = 1;
			this.defaultButton2.Text = "隐藏";
			this.defaultButton2.UseVisualStyleBackColor = false;
			this.defaultButton2.Click += new System.EventHandler(this.DefaultButton2_Click);
			// 
			// defaultButton1
			// 
			this.defaultButton1.AccessibleName = "Button";
			this.defaultButton1.BackColor = System.Drawing.Color.Aqua;
			this.defaultButton1.Dock = System.Windows.Forms.DockStyle.Top;
			this.defaultButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.defaultButton1.Font = new System.Drawing.Font("黑体", 13F);
			this.defaultButton1.Location = new System.Drawing.Point(0, 0);
			this.defaultButton1.Name = "defaultButton1";
			this.defaultButton1.Size = new System.Drawing.Size(96, 33);
			this.defaultButton1.Style.BackColor = System.Drawing.Color.Aqua;
			this.defaultButton1.TabIndex = 0;
			this.defaultButton1.Text = "随机点名";
			this.defaultButton1.UseVisualStyleBackColor = false;
			this.defaultButton1.Click += new System.EventHandler(this.DefaultButton1_Click);
			// 
			// HelperWindow
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(96, 107);
			this.ControlBox = false;
			this.Controls.Add(this.defaultButton2);
			this.Controls.Add(this.defaultButton1);
			this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "HelperWindow";
			this.Opacity = 0.6D;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "班级助手悬浮窗";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.HelperWindow_Load);
			this.DoubleClick += new System.EventHandler(this.HelperWindow_DoubleClick);
			this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HelperWindow_MouseClick);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
			this.Move += new System.EventHandler(this.HelperWindow_Move);
			this.ResumeLayout(false);

		}

		#endregion

		private Controls.DefaultButton defaultButton1;
		private Controls.DefaultButton defaultButton2;
	}
}