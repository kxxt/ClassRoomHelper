namespace ClassRoomHelper.Windows
{
	partial class MultiVoteSettingDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiVoteSettingDialog));
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.textLabel1 = new ClassRoomHelper.Windows.Controls.TextLabel();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.defaultButton1 = new ClassRoomHelper.Windows.Controls.DefaultButton();
			this.SuspendLayout();
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.ForeColor = System.Drawing.Color.White;
			this.checkBox1.Location = new System.Drawing.Point(17, 85);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(125, 28);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "允许弃权";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.ForeColor = System.Drawing.Color.White;
			this.checkBox2.Location = new System.Drawing.Point(17, 19);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(245, 28);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "可选不够最大投票数";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// textLabel1
			// 
			this.textLabel1.AutoSize = true;
			this.textLabel1.BackColor = System.Drawing.Color.Transparent;
			this.textLabel1.Font = new System.Drawing.Font("黑体", 19F);
			this.textLabel1.ForeColor = System.Drawing.Color.White;
			this.textLabel1.Location = new System.Drawing.Point(12, 56);
			this.textLabel1.Name = "textLabel1";
			this.textLabel1.Size = new System.Drawing.Size(142, 26);
			this.textLabel1.TabIndex = 3;
			this.textLabel1.Text = "最多投票数";
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.AsciiOnly = true;
			this.maskedTextBox1.Location = new System.Drawing.Point(155, 53);
			this.maskedTextBox1.Mask = "9999999";
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(100, 35);
			this.maskedTextBox1.TabIndex = 4;
			this.maskedTextBox1.ValidatingType = typeof(int);
			this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MaskedTextBox1_MaskInputRejected);
			// 
			// defaultButton1
			// 
			this.defaultButton1.AccessibleName = "Button";
			this.defaultButton1.Font = new System.Drawing.Font("黑体", 18F);
			this.defaultButton1.Location = new System.Drawing.Point(12, 119);
			this.defaultButton1.Name = "defaultButton1";
			this.defaultButton1.Size = new System.Drawing.Size(272, 49);
			this.defaultButton1.TabIndex = 5;
			this.defaultButton1.Text = "开始投票";
			this.defaultButton1.Click += new System.EventHandler(this.DefaultButton1_Click);
			// 
			// MultiVoteSettingDialog
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.DodgerBlue;
			this.ClientSize = new System.Drawing.Size(296, 180);
			this.Controls.Add(this.defaultButton1);
			this.Controls.Add(this.maskedTextBox1);
			this.Controls.Add(this.textLabel1);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBox1);
			this.Font = new System.Drawing.Font("黑体", 18F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MultiVoteSettingDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "投票设置";
			this.Load += new System.EventHandler(this.MultiVoteSettingDialog_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private Controls.TextLabel textLabel1;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
		private Controls.DefaultButton defaultButton1;
	}
}