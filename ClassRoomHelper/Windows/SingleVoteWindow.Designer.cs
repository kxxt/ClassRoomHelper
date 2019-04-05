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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingleVoteWindow));
			this.choices = new System.Windows.Forms.ComboBox();
			this.modernButton2 = new RsWork.UI.Controls.ModernButton();
			this.votebtn = new RsWork.UI.Controls.ModernButton();
			this.modernButton1 = new RsWork.UI.Controls.ModernButton();
			this.VoterLabel = new ClassRoomHelper.Windows.Controls.TextLabel();
			this.titleLabel1 = new ClassRoomHelper.Windows.Controls.TitleLabel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// choices
			// 
			this.choices.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.choices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.choices.Font = new System.Drawing.Font("黑体", 19F);
			this.choices.FormattingEnabled = true;
			this.choices.ImeMode = System.Windows.Forms.ImeMode.NoControl;
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
			this.modernButton2.Dock = System.Windows.Forms.DockStyle.Right;
			this.modernButton2.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.modernButton2.FlatAppearance.BorderSize = 2;
			this.modernButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.modernButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.modernButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.modernButton2.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.modernButton2.ForeColor = System.Drawing.Color.White;
			this.modernButton2.Location = new System.Drawing.Point(327, 0);
			this.modernButton2.Name = "modernButton2";
			this.modernButton2.Size = new System.Drawing.Size(150, 44);
			this.modernButton2.TabIndex = 4;
			this.modernButton2.Text = "终止投票";
			this.modernButton2.UseVisualStyleBackColor = false;
			this.modernButton2.Click += new System.EventHandler(this.ModernButton2_Click);
			// 
			// votebtn
			// 
			this.votebtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
			this.votebtn.Location = new System.Drawing.Point(164, 1);
			this.votebtn.Margin = new System.Windows.Forms.Padding(2);
			this.votebtn.Name = "votebtn";
			this.votebtn.Size = new System.Drawing.Size(150, 42);
			this.votebtn.TabIndex = 5;
			this.votebtn.Text = "投票";
			this.votebtn.UseVisualStyleBackColor = false;
			this.votebtn.Click += new System.EventHandler(this.Votebtn_Click);
			// 
			// modernButton1
			// 
			this.modernButton1.BackColor = System.Drawing.Color.Transparent;
			this.modernButton1.BorderColor = System.Drawing.Color.White;
			this.modernButton1.DisabledBorderColor = System.Drawing.Color.DarkGray;
			this.modernButton1.DisabledForeColor = System.Drawing.Color.DarkGray;
			this.modernButton1.Dock = System.Windows.Forms.DockStyle.Left;
			this.modernButton1.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.modernButton1.FlatAppearance.BorderSize = 2;
			this.modernButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.modernButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.modernButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.modernButton1.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.modernButton1.ForeColor = System.Drawing.Color.White;
			this.modernButton1.Location = new System.Drawing.Point(0, 0);
			this.modernButton1.Name = "modernButton1";
			this.modernButton1.Size = new System.Drawing.Size(150, 44);
			this.modernButton1.TabIndex = 6;
			this.modernButton1.Text = "弃权";
			this.modernButton1.UseVisualStyleBackColor = false;
			this.modernButton1.Click += new System.EventHandler(this.ModernButton1_Click);
			// 
			// VoterLabel
			// 
			this.VoterLabel.BackColor = System.Drawing.Color.Transparent;
			this.VoterLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.VoterLabel.Font = new System.Drawing.Font("黑体", 20F);
			this.VoterLabel.ForeColor = System.Drawing.Color.Yellow;
			this.VoterLabel.Location = new System.Drawing.Point(0, 67);
			this.VoterLabel.Name = "VoterLabel";
			this.VoterLabel.Size = new System.Drawing.Size(529, 49);
			this.VoterLabel.TabIndex = 2;
			this.VoterLabel.Text = "当前投票人:";
			this.VoterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// titleLabel1
			// 
			this.titleLabel1.BackColor = System.Drawing.Color.Transparent;
			this.titleLabel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.titleLabel1.Font = new System.Drawing.Font("黑体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.titleLabel1.ForeColor = System.Drawing.Color.White;
			this.titleLabel1.Location = new System.Drawing.Point(0, 0);
			this.titleLabel1.Name = "titleLabel1";
			this.titleLabel1.Size = new System.Drawing.Size(529, 67);
			this.titleLabel1.TabIndex = 1;
			this.titleLabel1.Text = "进行投票";
			this.titleLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.titleLabel1.Click += new System.EventHandler(this.TitleLabel1_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.modernButton1);
			this.panel1.Controls.Add(this.modernButton2);
			this.panel1.Controls.Add(this.votebtn);
			this.panel1.Location = new System.Drawing.Point(25, 252);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(477, 44);
			this.panel1.TabIndex = 7;
			// 
			// SingleVoteWindow
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.DodgerBlue;
			this.ClientSize = new System.Drawing.Size(529, 339);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.VoterLabel);
			this.Controls.Add(this.titleLabel1);
			this.Controls.Add(this.choices);
			this.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SingleVoteWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "进行投票";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SingleVoteWindow_FormClosing);
			this.Load += new System.EventHandler(this.SingleVoteWindow_Load);
			this.Shown += new System.EventHandler(this.SingleVoteWindow_Shown);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private Controls.TitleLabel titleLabel1;
		private Controls.TextLabel VoterLabel;
		private RsWork.UI.Controls.ModernButton modernButton2;
		public RsWork.UI.Controls.ModernButton votebtn;
		public RsWork.UI.Controls.ModernButton modernButton1;
		public System.Windows.Forms.ComboBox choices;
		private System.Windows.Forms.Panel panel1;
	}
}