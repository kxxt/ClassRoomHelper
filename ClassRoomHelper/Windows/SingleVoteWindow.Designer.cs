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
			this.choices = new System.Windows.Forms.ComboBox();
			this.modernButton2 = new RsWork.UI.Controls.ModernButton();
			this.votebtn = new RsWork.UI.Controls.ModernButton();
			this.textLabel1 = new ClassRoomHelper.Windows.Controls.TextLabel();
			this.titleLabel1 = new ClassRoomHelper.Windows.Controls.TitleLabel();
			this.modernButton1 = new RsWork.UI.Controls.ModernButton();
			this.SuspendLayout();
			// 
			// choices
			// 
			this.choices.Font = new System.Drawing.Font("黑体", 19F);
			this.choices.FormattingEnabled = true;
			this.choices.Location = new System.Drawing.Point(72, 175);
			this.choices.Name = "choices";
			this.choices.Size = new System.Drawing.Size(376, 33);
			this.choices.TabIndex = 0;
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
			this.modernButton2.Location = new System.Drawing.Point(342, 259);
			this.modernButton2.Name = "modernButton2";
			this.modernButton2.Size = new System.Drawing.Size(150, 42);
			this.modernButton2.TabIndex = 4;
			this.modernButton2.Text = "终止投票";
			this.modernButton2.UseVisualStyleBackColor = false;
			this.modernButton2.Click += new System.EventHandler(this.ModernButton2_Click);
			// 
			// votebtn
			// 
			this.votebtn.BackColor = System.Drawing.Color.Transparent;
			this.votebtn.BorderColor = System.Drawing.Color.White;
			this.votebtn.DisabledBorderColor = System.Drawing.Color.DarkGray;
			this.votebtn.DisabledForeColor = System.Drawing.Color.DarkGray;
			this.votebtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.votebtn.FlatAppearance.BorderSize = 2;
			this.votebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.votebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.votebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.votebtn.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.votebtn.ForeColor = System.Drawing.Color.White;
			this.votebtn.Location = new System.Drawing.Point(186, 259);
			this.votebtn.Name = "votebtn";
			this.votebtn.Size = new System.Drawing.Size(150, 42);
			this.votebtn.TabIndex = 5;
			this.votebtn.Text = "投票";
			this.votebtn.UseVisualStyleBackColor = false;
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
			// modernButton1
			// 
			this.modernButton1.BackColor = System.Drawing.Color.Transparent;
			this.modernButton1.BorderColor = System.Drawing.Color.White;
			this.modernButton1.DisabledBorderColor = System.Drawing.Color.DarkGray;
			this.modernButton1.DisabledForeColor = System.Drawing.Color.DarkGray;
			this.modernButton1.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.modernButton1.FlatAppearance.BorderSize = 2;
			this.modernButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.modernButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.modernButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.modernButton1.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.modernButton1.ForeColor = System.Drawing.Color.White;
			this.modernButton1.Location = new System.Drawing.Point(30, 259);
			this.modernButton1.Name = "modernButton1";
			this.modernButton1.Size = new System.Drawing.Size(150, 42);
			this.modernButton1.TabIndex = 6;
			this.modernButton1.Text = "弃权";
			this.modernButton1.UseVisualStyleBackColor = false;
			// 
			// SingleVoteWindow
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.DodgerBlue;
			this.ClientSize = new System.Drawing.Size(529, 371);
			this.Controls.Add(this.modernButton1);
			this.Controls.Add(this.votebtn);
			this.Controls.Add(this.modernButton2);
			this.Controls.Add(this.textLabel1);
			this.Controls.Add(this.titleLabel1);
			this.Controls.Add(this.choices);
			this.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "SingleVoteWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "进行投票";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Controls.TitleLabel titleLabel1;
		private Controls.TextLabel textLabel1;
		private RsWork.UI.Controls.ModernButton modernButton2;
		public RsWork.UI.Controls.ModernButton votebtn;
		public RsWork.UI.Controls.ModernButton modernButton1;
		public System.Windows.Forms.ComboBox choices;
	}
}