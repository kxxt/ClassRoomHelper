namespace ClassRoomHelper.Windows
{
	partial class HelperIm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelperIm));
			this.defaultButton2 = new ClassRoomHelper.Windows.Controls.DefaultButton();
			this.defaultButton1 = new ClassRoomHelper.Windows.Controls.DefaultButton();
			this.SuspendLayout();
			// 
			// defaultButton2
			// 
			this.defaultButton2.AccessibleName = "Button";
			this.defaultButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.defaultButton2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.defaultButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.defaultButton2.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.defaultButton2.ForeColor = System.Drawing.Color.Black;
			this.defaultButton2.Location = new System.Drawing.Point(0, 93);
			this.defaultButton2.Name = "defaultButton2";
			this.defaultButton2.Size = new System.Drawing.Size(92, 28);
			this.defaultButton2.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.defaultButton2.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.defaultButton2.Style.FocusedForeColor = System.Drawing.Color.DimGray;
			this.defaultButton2.Style.ForeColor = System.Drawing.Color.Black;
			this.defaultButton2.Style.HoverBackColor = System.Drawing.Color.Red;
			this.defaultButton2.Style.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.defaultButton2.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.defaultButton2.Style.PressedForeColor = System.Drawing.Color.White;
			this.defaultButton2.TabIndex = 2;
			this.defaultButton2.Text = "隐藏";
			this.defaultButton2.UseVisualStyleBackColor = false;
			this.defaultButton2.Click += new System.EventHandler(this.DefaultButton2_Click);
			// 
			// defaultButton1
			// 
			this.defaultButton1.AccessibleName = "Button";
			this.defaultButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.defaultButton1.Dock = System.Windows.Forms.DockStyle.Top;
			this.defaultButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.defaultButton1.Font = new System.Drawing.Font("黑体", 13F);
			this.defaultButton1.ForeColor = System.Drawing.Color.Black;
			this.defaultButton1.Location = new System.Drawing.Point(0, 0);
			this.defaultButton1.Name = "defaultButton1";
			this.defaultButton1.Size = new System.Drawing.Size(92, 33);
			this.defaultButton1.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.defaultButton1.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.defaultButton1.Style.FocusedForeColor = System.Drawing.Color.DimGray;
			this.defaultButton1.Style.ForeColor = System.Drawing.Color.Black;
			this.defaultButton1.Style.HoverBackColor = System.Drawing.Color.Red;
			this.defaultButton1.Style.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.defaultButton1.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.defaultButton1.Style.PressedForeColor = System.Drawing.Color.White;
			this.defaultButton1.TabIndex = 1;
			this.defaultButton1.Text = "随机点名";
			this.defaultButton1.UseVisualStyleBackColor = false;
			this.defaultButton1.Click += new System.EventHandler(this.DefaultButton1_Click);
			// 
			// HelperIm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.Moccasin;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(92, 121);
			this.Controls.Add(this.defaultButton2);
			this.Controls.Add(this.defaultButton1);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Location = new System.Drawing.Point(300, 300);
			this.MaximumSize = new System.Drawing.Size(92, 121);
			this.Name = "HelperIm";
			this.ShowInTaskbar = false;
			this.Text = "悬浮窗";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HelperIm_FormClosing);
			this.Load += new System.EventHandler(this.HelperIm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Controls.DefaultButton defaultButton1;
		private Controls.DefaultButton defaultButton2;
	}
}