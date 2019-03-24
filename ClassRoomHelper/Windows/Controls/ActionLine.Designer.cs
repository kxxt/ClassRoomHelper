namespace ClassRoomHelper.Windows.Controls
{
	partial class ActionLine
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

		#region 组件设计器生成的代码

		/// <summary> 
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.textLabel1 = new ClassRoomHelper.Windows.Controls.TextLabel();
			this.textLabel2 = new ClassRoomHelper.Windows.Controls.TextLabel();
			this.defaultButton1 = new ClassRoomHelper.Windows.Controls.DefaultButton();
			this.defaultButton2 = new ClassRoomHelper.Windows.Controls.DefaultButton();
			this.SuspendLayout();
			// 
			// textLabel1
			// 
			this.textLabel1.AutoSize = true;
			this.textLabel1.BackColor = System.Drawing.Color.Transparent;
			this.textLabel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.textLabel1.Font = new System.Drawing.Font("黑体", 18F);
			this.textLabel1.Location = new System.Drawing.Point(0, 0);
			this.textLabel1.Name = "textLabel1";
			this.textLabel1.Size = new System.Drawing.Size(82, 24);
			this.textLabel1.TabIndex = 0;
			this.textLabel1.Text = "{Text}";
			// 
			// textLabel2
			// 
			this.textLabel2.AutoSize = true;
			this.textLabel2.BackColor = System.Drawing.Color.Transparent;
			this.textLabel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.textLabel2.Font = new System.Drawing.Font("黑体", 18F);
			this.textLabel2.Location = new System.Drawing.Point(343, 0);
			this.textLabel2.Name = "textLabel2";
			this.textLabel2.Size = new System.Drawing.Size(70, 24);
			this.textLabel2.TabIndex = 3;
			this.textLabel2.Text = "分数:";
			// 
			// defaultButton1
			// 
			this.defaultButton1.AccessibleName = "Button";
			this.defaultButton1.Dock = System.Windows.Forms.DockStyle.Right;
			this.defaultButton1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.defaultButton1.Location = new System.Drawing.Point(291, 0);
			this.defaultButton1.Name = "defaultButton1";
			this.defaultButton1.Size = new System.Drawing.Size(52, 37);
			this.defaultButton1.TabIndex = 4;
			this.defaultButton1.Text = "-1";
			// 
			// defaultButton2
			// 
			this.defaultButton2.AccessibleName = "Button";
			this.defaultButton2.Dock = System.Windows.Forms.DockStyle.Right;
			this.defaultButton2.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.defaultButton2.Location = new System.Drawing.Point(239, 0);
			this.defaultButton2.Name = "defaultButton2";
			this.defaultButton2.Size = new System.Drawing.Size(52, 37);
			this.defaultButton2.TabIndex = 5;
			this.defaultButton2.Text = "+1";
			// 
			// ActionLine
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.Controls.Add(this.defaultButton2);
			this.Controls.Add(this.defaultButton1);
			this.Controls.Add(this.textLabel2);
			this.Controls.Add(this.textLabel1);
			this.Name = "ActionLine";
			this.Size = new System.Drawing.Size(413, 37);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextLabel textLabel1;
		private TextLabel textLabel2;
		private DefaultButton defaultButton1;
		private DefaultButton defaultButton2;
	}
}
