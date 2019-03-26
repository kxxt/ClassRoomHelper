namespace ClassRoomHelper.Windows
{
	partial class OOBE
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OOBE));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.defaultButton3 = new ClassRoomHelper.Windows.Controls.DefaultButton();
			this.defaultButton1 = new ClassRoomHelper.Windows.Controls.DefaultButton();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(900, 450);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
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
			this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.textBox1);
			this.splitContainer1.Panel2.Controls.Add(this.defaultButton3);
			this.splitContainer1.Panel2.Controls.Add(this.defaultButton1);
			this.splitContainer1.Size = new System.Drawing.Size(900, 540);
			this.splitContainer1.SplitterDistance = 450;
			this.splitContainer1.TabIndex = 1;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.White;
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Location = new System.Drawing.Point(96, 0);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.ShortcutsEnabled = false;
			this.textBox1.Size = new System.Drawing.Size(708, 86);
			this.textBox1.TabIndex = 4;
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// defaultButton3
			// 
			this.defaultButton3.AccessibleName = "Button";
			this.defaultButton3.Dock = System.Windows.Forms.DockStyle.Right;
			this.defaultButton3.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.defaultButton3.Image = ((System.Drawing.Image)(resources.GetObject("defaultButton3.Image")));
			this.defaultButton3.ImageSize = new System.Drawing.Size(40, 40);
			this.defaultButton3.Location = new System.Drawing.Point(804, 0);
			this.defaultButton3.Name = "defaultButton3";
			this.defaultButton3.Size = new System.Drawing.Size(96, 86);
			this.defaultButton3.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
			this.defaultButton3.TabIndex = 3;
			this.defaultButton3.Click += new System.EventHandler(this.DefaultButton3_Click);
			// 
			// defaultButton1
			// 
			this.defaultButton1.AccessibleName = "Button";
			this.defaultButton1.Dock = System.Windows.Forms.DockStyle.Left;
			this.defaultButton1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.defaultButton1.Image = ((System.Drawing.Image)(resources.GetObject("defaultButton1.Image")));
			this.defaultButton1.ImageSize = new System.Drawing.Size(40, 40);
			this.defaultButton1.Location = new System.Drawing.Point(0, 0);
			this.defaultButton1.Name = "defaultButton1";
			this.defaultButton1.Size = new System.Drawing.Size(96, 86);
			this.defaultButton1.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
			this.defaultButton1.TabIndex = 0;
			this.defaultButton1.Click += new System.EventHandler(this.DefaultButton1_Click);
			// 
			// OOBE
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(900, 540);
			this.Controls.Add(this.splitContainer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "OOBE";
			this.Text = "欢迎使用";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private Controls.DefaultButton defaultButton1;
		private Controls.DefaultButton defaultButton3;
		private System.Windows.Forms.TextBox textBox1;
	}
}