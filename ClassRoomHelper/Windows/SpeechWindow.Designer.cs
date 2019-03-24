namespace ClassRoomHelper.Windows
{
	partial class SpeechWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpeechWindow));
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.textLabel1 = new ClassRoomHelper.Windows.Controls.TextLabel();
			this.defaultButton2 = new ClassRoomHelper.Windows.Controls.DefaultButton();
			this.defaultButton1 = new ClassRoomHelper.Windows.Controls.DefaultButton();
			this.defaultButton4 = new ClassRoomHelper.Windows.Controls.DefaultButton();
			this.defaultButton3 = new ClassRoomHelper.Windows.Controls.DefaultButton();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Font = new System.Drawing.Font("黑体", 12F);
			this.textBox1.Location = new System.Drawing.Point(0, 0);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(995, 389);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "在此处输入文段...";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.textBox1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.textLabel1);
			this.splitContainer1.Panel2.Controls.Add(this.defaultButton2);
			this.splitContainer1.Panel2.Controls.Add(this.defaultButton1);
			this.splitContainer1.Panel2.Controls.Add(this.defaultButton4);
			this.splitContainer1.Panel2.Controls.Add(this.defaultButton3);
			this.splitContainer1.Size = new System.Drawing.Size(995, 435);
			this.splitContainer1.SplitterDistance = 389;
			this.splitContainer1.SplitterWidth = 1;
			this.splitContainer1.TabIndex = 1;
			// 
			// textLabel1
			// 
			this.textLabel1.AutoSize = true;
			this.textLabel1.BackColor = System.Drawing.Color.Transparent;
			this.textLabel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.textLabel1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.textLabel1.ForeColor = System.Drawing.Color.Red;
			this.textLabel1.Location = new System.Drawing.Point(619, 0);
			this.textLabel1.Name = "textLabel1";
			this.textLabel1.Size = new System.Drawing.Size(272, 32);
			this.textLabel1.TabIndex = 5;
			this.textLabel1.Text = "* : 此朗读功能为机器提供 , 不适用\r\n于阅读古诗文等 ,适用于阅读公告.";
			// 
			// defaultButton2
			// 
			this.defaultButton2.AccessibleName = "Button";
			this.defaultButton2.Dock = System.Windows.Forms.DockStyle.Left;
			this.defaultButton2.Font = new System.Drawing.Font("黑体", 17F);
			this.defaultButton2.Image = ((System.Drawing.Image)(resources.GetObject("defaultButton2.Image")));
			this.defaultButton2.ImageSize = new System.Drawing.Size(35, 35);
			this.defaultButton2.Location = new System.Drawing.Point(463, 0);
			this.defaultButton2.Name = "defaultButton2";
			this.defaultButton2.Size = new System.Drawing.Size(156, 45);
			this.defaultButton2.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
			this.defaultButton2.TabIndex = 4;
			this.defaultButton2.Text = "导出wav";
			this.defaultButton2.Click += new System.EventHandler(this.DefaultButton2_Click);
			// 
			// defaultButton1
			// 
			this.defaultButton1.AccessibleName = "Button";
			this.defaultButton1.Dock = System.Windows.Forms.DockStyle.Left;
			this.defaultButton1.Font = new System.Drawing.Font("黑体", 17F);
			this.defaultButton1.Image = ((System.Drawing.Image)(resources.GetObject("defaultButton1.Image")));
			this.defaultButton1.ImageSize = new System.Drawing.Size(35, 35);
			this.defaultButton1.Location = new System.Drawing.Point(338, 0);
			this.defaultButton1.Name = "defaultButton1";
			this.defaultButton1.Size = new System.Drawing.Size(125, 45);
			this.defaultButton1.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
			this.defaultButton1.TabIndex = 3;
			this.defaultButton1.Text = "停止";
			this.defaultButton1.Click += new System.EventHandler(this.DefaultButton1_Click_1);
			// 
			// defaultButton4
			// 
			this.defaultButton4.AccessibleName = "Button";
			this.defaultButton4.Dock = System.Windows.Forms.DockStyle.Left;
			this.defaultButton4.Font = new System.Drawing.Font("黑体", 17F);
			this.defaultButton4.Image = ((System.Drawing.Image)(resources.GetObject("defaultButton4.Image")));
			this.defaultButton4.ImageSize = new System.Drawing.Size(35, 35);
			this.defaultButton4.Location = new System.Drawing.Point(138, 0);
			this.defaultButton4.Name = "defaultButton4";
			this.defaultButton4.Size = new System.Drawing.Size(200, 45);
			this.defaultButton4.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
			this.defaultButton4.TabIndex = 2;
			this.defaultButton4.Text = "从剪贴板粘贴";
			this.defaultButton4.Click += new System.EventHandler(this.DefaultButton4_Click);
			// 
			// defaultButton3
			// 
			this.defaultButton3.AccessibleName = "Button";
			this.defaultButton3.Dock = System.Windows.Forms.DockStyle.Left;
			this.defaultButton3.Font = new System.Drawing.Font("黑体", 17F);
			this.defaultButton3.Image = ((System.Drawing.Image)(resources.GetObject("defaultButton3.Image")));
			this.defaultButton3.ImageSize = new System.Drawing.Size(35, 35);
			this.defaultButton3.Location = new System.Drawing.Point(0, 0);
			this.defaultButton3.Name = "defaultButton3";
			this.defaultButton3.Size = new System.Drawing.Size(138, 45);
			this.defaultButton3.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
			this.defaultButton3.TabIndex = 1;
			this.defaultButton3.Text = "朗读";
			this.defaultButton3.Click += new System.EventHandler(this.DefaultButton1_Click);
			// 
			// SpeechWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(995, 435);
			this.ControlBox = true;
			this.Controls.Add(this.splitContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SpeechWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "朗读文段 ( 中英文均可 )";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SpeechWindow_FormClosing);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private Controls.DefaultButton defaultButton1;
		private Controls.DefaultButton defaultButton4;
		private Controls.DefaultButton defaultButton3;
		private Controls.DefaultButton defaultButton2;
		private Controls.TextLabel textLabel1;
	}
}