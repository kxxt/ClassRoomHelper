namespace ClassRoomHelper.Windows
{
	partial class SingleVoteFinishedWindow
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingleVoteFinishedWindow));
			this.data = new System.Windows.Forms.DataGridView();
			this.defaultButton1 = new ClassRoomHelper.Windows.Controls.DefaultButton();
			this.defaultButton2 = new ClassRoomHelper.Windows.Controls.DefaultButton();
			this.titleLabel1 = new ClassRoomHelper.Windows.Controls.TitleLabel();
			this.Option = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Voter = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
			this.SuspendLayout();
			// 
			// data
			// 
			this.data.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("黑体", 20F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Option,
            this.Result,
            this.Voter});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("黑体", 20F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.data.DefaultCellStyle = dataGridViewCellStyle2;
			this.data.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.data.Location = new System.Drawing.Point(0, 48);
			this.data.Name = "data";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("黑体", 20F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.data.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.data.RowTemplate.Height = 35;
			this.data.Size = new System.Drawing.Size(800, 402);
			this.data.TabIndex = 0;
			this.data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
			// 
			// defaultButton1
			// 
			this.defaultButton1.AccessibleName = "Button";
			this.defaultButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.defaultButton1.Dock = System.Windows.Forms.DockStyle.Left;
			this.defaultButton1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.defaultButton1.Location = new System.Drawing.Point(0, 0);
			this.defaultButton1.Name = "defaultButton1";
			this.defaultButton1.Size = new System.Drawing.Size(146, 48);
			this.defaultButton1.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.defaultButton1.TabIndex = 1;
			this.defaultButton1.Text = "保存结果";
			this.defaultButton1.UseVisualStyleBackColor = false;
			this.defaultButton1.Click += new System.EventHandler(this.DefaultButton1_Click);
			// 
			// defaultButton2
			// 
			this.defaultButton2.AccessibleName = "Button";
			this.defaultButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.defaultButton2.Dock = System.Windows.Forms.DockStyle.Right;
			this.defaultButton2.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.defaultButton2.Location = new System.Drawing.Point(654, 0);
			this.defaultButton2.Name = "defaultButton2";
			this.defaultButton2.Size = new System.Drawing.Size(146, 48);
			this.defaultButton2.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.defaultButton2.TabIndex = 2;
			this.defaultButton2.Text = "宣布结果";
			this.defaultButton2.UseVisualStyleBackColor = false;
			this.defaultButton2.Click += new System.EventHandler(this.DefaultButton2_Click);
			// 
			// titleLabel1
			// 
			this.titleLabel1.BackColor = System.Drawing.Color.Linen;
			this.titleLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.titleLabel1.Font = new System.Drawing.Font("黑体", 20F);
			this.titleLabel1.ForeColor = System.Drawing.Color.Red;
			this.titleLabel1.Location = new System.Drawing.Point(146, 0);
			this.titleLabel1.Name = "titleLabel1";
			this.titleLabel1.Size = new System.Drawing.Size(508, 48);
			this.titleLabel1.TabIndex = 3;
			this.titleLabel1.Text = "恭喜您 , 投票顺利结束";
			this.titleLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Option
			// 
			this.Option.HeaderText = "选项";
			this.Option.Name = "Option";
			this.Option.ReadOnly = true;
			this.Option.Width = 200;
			// 
			// Result
			// 
			this.Result.HeaderText = "计数";
			this.Result.Name = "Result";
			this.Result.ReadOnly = true;
			// 
			// Voter
			// 
			this.Voter.HeaderText = "投票人";
			this.Voter.Name = "Voter";
			this.Voter.ReadOnly = true;
			this.Voter.Width = 1000;
			// 
			// SingleVoteFinishedWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.titleLabel1);
			this.Controls.Add(this.defaultButton2);
			this.Controls.Add(this.defaultButton1);
			this.Controls.Add(this.data);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SingleVoteFinishedWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "投票结束";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView data;
		private Controls.DefaultButton defaultButton1;
		private Controls.DefaultButton defaultButton2;
		private Controls.TitleLabel titleLabel1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Option;
		private System.Windows.Forms.DataGridViewTextBoxColumn Result;
		private System.Windows.Forms.DataGridViewTextBoxColumn Voter;
	}
}