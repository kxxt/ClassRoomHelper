namespace DataAnalyser
{
	partial class MainFrm
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.NextBtn = new System.Windows.Forms.Button();
			this.SrcTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.TargetTextBox = new System.Windows.Forms.TextBox();
			this.PbPPT = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.LbCurrent = new System.Windows.Forms.Label();
			this.PrevBtn = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.PPTPrevBtn = new System.Windows.Forms.Button();
			this.PPTNextBtn = new System.Windows.Forms.Button();
			this.CkbPPT = new System.Windows.Forms.CheckBox();
			this.ExportBtn = new System.Windows.Forms.Button();
			this.CbPPT = new System.Windows.Forms.ComboBox();
			this.PbImage = new System.Windows.Forms.PictureBox();
			this.CbImage = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.CkbImage = new System.Windows.Forms.CheckBox();
			this.ImportBtn = new System.Windows.Forms.Button();
			this.ExpProgressBar = new System.Windows.Forms.ProgressBar();
			this.LbExpProgress = new System.Windows.Forms.Label();
			this.LbTotalCount = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.PbPPT)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PbImage)).BeginInit();
			this.SuspendLayout();
			// 
			// NextBtn
			// 
			this.NextBtn.Location = new System.Drawing.Point(718, 368);
			this.NextBtn.Name = "NextBtn";
			this.NextBtn.Size = new System.Drawing.Size(75, 48);
			this.NextBtn.TabIndex = 0;
			this.NextBtn.Text = "Next";
			this.NextBtn.UseVisualStyleBackColor = true;
			// 
			// SrcTextBox
			// 
			this.SrcTextBox.Location = new System.Drawing.Point(119, 18);
			this.SrcTextBox.Name = "SrcTextBox";
			this.SrcTextBox.Size = new System.Drawing.Size(663, 21);
			this.SrcTextBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "Source Directory";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 12);
			this.label2.TabIndex = 4;
			this.label2.Text = "Target Directory";
			// 
			// TargetTextBox
			// 
			this.TargetTextBox.Location = new System.Drawing.Point(119, 45);
			this.TargetTextBox.Name = "TargetTextBox";
			this.TargetTextBox.Size = new System.Drawing.Size(663, 21);
			this.TargetTextBox.TabIndex = 3;
			// 
			// PbPPT
			// 
			this.PbPPT.Location = new System.Drawing.Point(14, 267);
			this.PbPPT.Name = "PbPPT";
			this.PbPPT.Size = new System.Drawing.Size(228, 149);
			this.PbPPT.TabIndex = 5;
			this.PbPPT.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 218);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(119, 12);
			this.label3.TabIndex = 6;
			this.label3.Text = "Current Information";
			// 
			// LbCurrent
			// 
			this.LbCurrent.AutoSize = true;
			this.LbCurrent.Location = new System.Drawing.Point(136, 218);
			this.LbCurrent.Name = "LbCurrent";
			this.LbCurrent.Size = new System.Drawing.Size(29, 12);
			this.LbCurrent.TabIndex = 7;
			this.LbCurrent.Text = "None";
			// 
			// PrevBtn
			// 
			this.PrevBtn.Location = new System.Drawing.Point(718, 314);
			this.PrevBtn.Name = "PrevBtn";
			this.PrevBtn.Size = new System.Drawing.Size(75, 48);
			this.PrevBtn.TabIndex = 8;
			this.PrevBtn.Text = "Prev";
			this.PrevBtn.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 242);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(83, 12);
			this.label5.TabIndex = 9;
			this.label5.Text = "PPT File Name";
			// 
			// PPTPrevBtn
			// 
			this.PPTPrevBtn.Location = new System.Drawing.Point(248, 299);
			this.PPTPrevBtn.Name = "PPTPrevBtn";
			this.PPTPrevBtn.Size = new System.Drawing.Size(72, 26);
			this.PPTPrevBtn.TabIndex = 11;
			this.PPTPrevBtn.Text = "Prev";
			this.PPTPrevBtn.UseVisualStyleBackColor = true;
			// 
			// PPTNextBtn
			// 
			this.PPTNextBtn.Location = new System.Drawing.Point(248, 267);
			this.PPTNextBtn.Name = "PPTNextBtn";
			this.PPTNextBtn.Size = new System.Drawing.Size(72, 26);
			this.PPTNextBtn.TabIndex = 10;
			this.PPTNextBtn.Text = "Next";
			this.PPTNextBtn.UseVisualStyleBackColor = true;
			// 
			// CkbPPT
			// 
			this.CkbPPT.AutoSize = true;
			this.CkbPPT.Location = new System.Drawing.Point(248, 332);
			this.CkbPPT.Name = "CkbPPT";
			this.CkbPPT.Size = new System.Drawing.Size(72, 16);
			this.CkbPPT.TabIndex = 12;
			this.CkbPPT.Text = "Selected";
			this.CkbPPT.UseVisualStyleBackColor = true;
			// 
			// ExportBtn
			// 
			this.ExportBtn.Location = new System.Drawing.Point(93, 83);
			this.ExportBtn.Name = "ExportBtn";
			this.ExportBtn.Size = new System.Drawing.Size(75, 23);
			this.ExportBtn.TabIndex = 14;
			this.ExportBtn.Text = "Export";
			this.ExportBtn.UseVisualStyleBackColor = true;
			this.ExportBtn.Click += new System.EventHandler(this.button5_Click);
			// 
			// CbPPT
			// 
			this.CbPPT.FormattingEnabled = true;
			this.CbPPT.Location = new System.Drawing.Point(101, 239);
			this.CbPPT.Name = "CbPPT";
			this.CbPPT.Size = new System.Drawing.Size(219, 20);
			this.CbPPT.TabIndex = 15;
			// 
			// PbImage
			// 
			this.PbImage.Location = new System.Drawing.Point(360, 267);
			this.PbImage.Name = "PbImage";
			this.PbImage.Size = new System.Drawing.Size(228, 149);
			this.PbImage.TabIndex = 16;
			this.PbImage.TabStop = false;
			// 
			// CbImage
			// 
			this.CbImage.FormattingEnabled = true;
			this.CbImage.Location = new System.Drawing.Point(459, 241);
			this.CbImage.Name = "CbImage";
			this.CbImage.Size = new System.Drawing.Size(219, 20);
			this.CbImage.TabIndex = 21;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(358, 244);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(95, 12);
			this.label6.TabIndex = 20;
			this.label6.Text = "Image File Name";
			// 
			// CkbImage
			// 
			this.CkbImage.AutoSize = true;
			this.CkbImage.Location = new System.Drawing.Point(594, 267);
			this.CkbImage.Name = "CkbImage";
			this.CkbImage.Size = new System.Drawing.Size(72, 16);
			this.CkbImage.TabIndex = 19;
			this.CkbImage.Text = "Selected";
			this.CkbImage.UseVisualStyleBackColor = true;
			// 
			// ImportBtn
			// 
			this.ImportBtn.Location = new System.Drawing.Point(12, 83);
			this.ImportBtn.Name = "ImportBtn";
			this.ImportBtn.Size = new System.Drawing.Size(75, 23);
			this.ImportBtn.TabIndex = 22;
			this.ImportBtn.Text = "Import";
			this.ImportBtn.UseVisualStyleBackColor = true;
			this.ImportBtn.Click += new System.EventHandler(this.ImportBtn_Click);
			// 
			// ExpProgressBar
			// 
			this.ExpProgressBar.Location = new System.Drawing.Point(173, 83);
			this.ExpProgressBar.Name = "ExpProgressBar";
			this.ExpProgressBar.Size = new System.Drawing.Size(607, 23);
			this.ExpProgressBar.TabIndex = 23;
			// 
			// LbExpProgress
			// 
			this.LbExpProgress.AutoSize = true;
			this.LbExpProgress.BackColor = System.Drawing.Color.Transparent;
			this.LbExpProgress.Location = new System.Drawing.Point(174, 88);
			this.LbExpProgress.Name = "LbExpProgress";
			this.LbExpProgress.Size = new System.Drawing.Size(131, 12);
			this.LbExpProgress.TabIndex = 24;
			this.LbExpProgress.Text = "Export Progress : 0/?";
			// 
			// LbTotalCount
			// 
			this.LbTotalCount.AutoSize = true;
			this.LbTotalCount.Location = new System.Drawing.Point(136, 206);
			this.LbTotalCount.Name = "LbTotalCount";
			this.LbTotalCount.Size = new System.Drawing.Size(29, 12);
			this.LbTotalCount.TabIndex = 26;
			this.LbTotalCount.Text = "None";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(11, 206);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(71, 12);
			this.label7.TabIndex = 25;
			this.label7.Text = "Total Count";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(136, 194);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 12);
			this.label4.TabIndex = 28;
			this.label4.Text = "None";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(11, 194);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(65, 12);
			this.label8.TabIndex = 27;
			this.label8.Text = "Current Id";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Red;
			this.button1.Location = new System.Drawing.Point(12, 112);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 29;
			this.button1.Text = "Debug";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// MainFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(805, 439);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.LbTotalCount);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.LbExpProgress);
			this.Controls.Add(this.ExpProgressBar);
			this.Controls.Add(this.ImportBtn);
			this.Controls.Add(this.CbImage);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.CkbImage);
			this.Controls.Add(this.PbImage);
			this.Controls.Add(this.CbPPT);
			this.Controls.Add(this.ExportBtn);
			this.Controls.Add(this.CkbPPT);
			this.Controls.Add(this.PPTPrevBtn);
			this.Controls.Add(this.PPTNextBtn);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.PrevBtn);
			this.Controls.Add(this.LbCurrent);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.PbPPT);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.TargetTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.SrcTextBox);
			this.Controls.Add(this.NextBtn);
			this.Name = "MainFrm";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.PbPPT)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PbImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button NextBtn;
		private System.Windows.Forms.TextBox SrcTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TargetTextBox;
		private System.Windows.Forms.PictureBox PbPPT;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label LbCurrent;
		private System.Windows.Forms.Button PrevBtn;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button PPTPrevBtn;
		private System.Windows.Forms.Button PPTNextBtn;
		private System.Windows.Forms.CheckBox CkbPPT;
		private System.Windows.Forms.Button ExportBtn;
		private System.Windows.Forms.ComboBox CbPPT;
		private System.Windows.Forms.PictureBox PbImage;
		private System.Windows.Forms.ComboBox CbImage;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox CkbImage;
		private System.Windows.Forms.Button ImportBtn;
		private System.Windows.Forms.ProgressBar ExpProgressBar;
		private System.Windows.Forms.Label LbExpProgress;
		private System.Windows.Forms.Label LbTotalCount;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button button1;
	}
}

