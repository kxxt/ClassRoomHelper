namespace ClassRoomHelper.Windows
{
	partial class SingleVoteWindow
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.titleLabel1 = new ClassRoomHelper.Windows.Controls.TitleLabel();
			this.textLabel1 = new ClassRoomHelper.Windows.Controls.TextLabel();
			this.modernButton2 = new RsWork.UI.Controls.ModernButton();
			this.modernButton3 = new RsWork.UI.Controls.ModernButton();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("黑体", 19F);
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(72, 175);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(376, 33);
			this.comboBox1.TabIndex = 0;
			// 
			// titleLabel1
			// 
			this.titleLabel1.AutoSize = true;
			this.titleLabel1.BackColor = System.Drawing.Color.Transparent;
			this.titleLabel1.Font = new System.Drawing.Font("黑体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.titleLabel1.ForeColor = System.Drawing.Color.White;
			this.titleLabel1.Location = new System.Drawing.Point(151, 9);
			this.titleLabel1.Name = "titleLabel1";
			this.titleLabel1.Size = new System.Drawing.Size(212, 48);
			this.titleLabel1.TabIndex = 1;
			this.titleLabel1.Text = "进行投票";
			// 
			// textLabel1
			// 
			this.textLabel1.AutoSize = true;
			this.textLabel1.BackColor = System.Drawing.Color.Transparent;
			this.textLabel1.Font = new System.Drawing.Font("黑体", 20F);
			this.textLabel1.ForeColor = System.Drawing.Color.Yellow;
			this.textLabel1.Location = new System.Drawing.Point(174, 91);
			this.textLabel1.Name = "textLabel1";
			this.textLabel1.Size = new System.Drawing.Size(166, 27);
			this.textLabel1.TabIndex = 2;
			this.textLabel1.Text = "当前投票人:";
			// 
			// modernButton2
			// 
			this.modernButton2.BackColor = System.Drawing.Color.Transparent;
			this.modernButton2.BorderColor = System.Drawing.Color.White;
			this.modernButton2.DisabledBorderColor = System.Drawing.Color.DarkGray;
			this.modernButton2.DisabledForeColor = System.Drawing.Color.DarkGray;
			this.modernButton2.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.modernButton2.FlatAppearance.BorderSize = 2;
			this.modernButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.modernButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.modernButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.modernButton2.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.modernButton2.ForeColor = System.Drawing.Color.White;
			this.modernButton2.Location = new System.Drawing.Point(262, 259);
			this.modernButton2.Name = "modernButton2";
			this.modernButton2.Size = new System.Drawing.Size(150, 42);
			this.modernButton2.TabIndex = 4;
			this.modernButton2.Text = "终止投票";
			this.modernButton2.UseVisualStyleBackColor = false;
			this.modernButton2.Click += new System.EventHandler(this.ModernButton2_Click);
			// 
			// modernButton3
			// 
			this.modernButton3.BackColor = System.Drawing.Color.Transparent;
			this.modernButton3.BorderColor = System.Drawing.Color.White;
			this.modernButton3.DisabledBorderColor = System.Drawing.Color.DarkGray;
			this.modernButton3.DisabledForeColor = System.Drawing.Color.DarkGray;
			this.modernButton3.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.modernButton3.FlatAppearance.BorderSize = 2;
			this.modernButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.modernButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.modernButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.modernButton3.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.modernButton3.ForeColor = System.Drawing.Color.White;
			this.modernButton3.Location = new System.Drawing.Point(106, 259);
			this.modernButton3.Name = "modernButton3";
			this.modernButton3.Size = new System.Drawing.Size(150, 42);
			this.modernButton3.TabIndex = 5;
			this.modernButton3.Text = "投票";
			this.modernButton3.UseVisualStyleBackColor = false;
			// 
			// SingleVoteWindow
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.DodgerBlue;
			this.ClientSize = new System.Drawing.Size(529, 371);
			this.Controls.Add(this.modernButton3);
			this.Controls.Add(this.modernButton2);
			this.Controls.Add(this.textLabel1);
			this.Controls.Add(this.titleLabel1);
			this.Controls.Add(this.comboBox1);
			this.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.Name = "SingleVoteWindow";
			this.Text = "进行投票";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBox1;
		private Controls.TitleLabel titleLabel1;
		private Controls.TextLabel textLabel1;
		private RsWork.UI.Controls.ModernButton modernButton2;
		private RsWork.UI.Controls.ModernButton modernButton3;
	}
}