namespace ClassRoomHelper.Windows
{
	partial class ActionSelectionWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActionSelectionWindow));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.titleLabel1 = new ClassRoomHelper.Windows.Controls.TitleLabel();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.FlatAppearance.BorderSize = 4;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("黑体", 40F);
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(18, 76);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(255, 512);
			this.button1.TabIndex = 1;
			this.button1.Text = "随机点名";
			this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Transparent;
			this.button2.FlatAppearance.BorderSize = 4;
			this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("黑体", 40F);
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.Location = new System.Drawing.Point(279, 76);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(255, 512);
			this.button2.TabIndex = 2;
			this.button2.Text = "朗读文段";
			this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Transparent;
			this.button3.FlatAppearance.BorderSize = 4;
			this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("黑体", 40F);
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.Location = new System.Drawing.Point(540, 76);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(255, 512);
			this.button3.TabIndex = 3;
			this.button3.Text = "打开U盘";
			this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Transparent;
			this.button4.FlatAppearance.BorderSize = 4;
			this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("黑体", 40F);
			this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
			this.button4.Location = new System.Drawing.Point(801, 76);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(255, 512);
			this.button4.TabIndex = 4;
			this.button4.Text = "取消操作";
			this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Button4_Click);
			// 
			// titleLabel1
			// 
			this.titleLabel1.AutoSize = true;
			this.titleLabel1.BackColor = System.Drawing.Color.Transparent;
			this.titleLabel1.Font = new System.Drawing.Font("黑体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.titleLabel1.Location = new System.Drawing.Point(370, 9);
			this.titleLabel1.Name = "titleLabel1";
			this.titleLabel1.Size = new System.Drawing.Size(308, 48);
			this.titleLabel1.TabIndex = 0;
			this.titleLabel1.Text = "选择一个操作";
			// 
			// ActionSelectionWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1068, 600);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.titleLabel1);
			this.Name = "ActionSelectionWindow";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "选择一个操作";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Controls.TitleLabel titleLabel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
	}
}