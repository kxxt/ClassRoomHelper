namespace ClassRoomHelper
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.sfButton2 = new ClassRoomHelper.Windows.Controls.DefaultButton();
			this.titleLabel1 = new ClassRoomHelper.Windows.Controls.TitleLabel();
			this.sfButton3 = new ClassRoomHelper.Windows.Controls.DefaultButton();
			this.sfButton4 = new ClassRoomHelper.Windows.Controls.DefaultButton();
			this.sfButton5 = new ClassRoomHelper.Windows.Controls.DefaultButton();
			this.sfButton6 = new ClassRoomHelper.Windows.Controls.DefaultButton();
			this.defaultButton1 = new ClassRoomHelper.Windows.Controls.DefaultButton();
			this.SuspendLayout();
			// 
			// sfButton2
			// 
			this.sfButton2.AccessibleName = "Button";
			this.sfButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.sfButton2.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.sfButton2.Image = ((System.Drawing.Image)(resources.GetObject("sfButton2.Image")));
			this.sfButton2.ImageSize = new System.Drawing.Size(35, 35);
			this.sfButton2.Location = new System.Drawing.Point(543, 370);
			this.sfButton2.Name = "sfButton2";
			this.sfButton2.Size = new System.Drawing.Size(96, 73);
			this.sfButton2.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
			this.sfButton2.TabIndex = 1;
			this.sfButton2.Text = "退出";
			this.sfButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.sfButton2.Click += new System.EventHandler(this.SfButton2_Click);
			// 
			// titleLabel1
			// 
			this.titleLabel1.AutoSize = true;
			this.titleLabel1.BackColor = System.Drawing.Color.Transparent;
			this.titleLabel1.Font = new System.Drawing.Font("黑体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.titleLabel1.Location = new System.Drawing.Point(25, 25);
			this.titleLabel1.Name = "titleLabel1";
			this.titleLabel1.Size = new System.Drawing.Size(212, 48);
			this.titleLabel1.TabIndex = 2;
			this.titleLabel1.Text = "班级助手";
			// 
			// sfButton3
			// 
			this.sfButton3.AccessibleName = "Button";
			this.sfButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.sfButton3.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.sfButton3.Location = new System.Drawing.Point(504, 106);
			this.sfButton3.Name = "sfButton3";
			this.sfButton3.Size = new System.Drawing.Size(116, 72);
			this.sfButton3.TabIndex = 3;
			this.sfButton3.Text = "退出";
			// 
			// sfButton4
			// 
			this.sfButton4.AccessibleName = "Button";
			this.sfButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.sfButton4.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.sfButton4.Location = new System.Drawing.Point(349, 106);
			this.sfButton4.Name = "sfButton4";
			this.sfButton4.Size = new System.Drawing.Size(116, 72);
			this.sfButton4.TabIndex = 4;
			// 
			// sfButton5
			// 
			this.sfButton5.AccessibleName = "Button";
			this.sfButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.sfButton5.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.sfButton5.Image = ((System.Drawing.Image)(resources.GetObject("sfButton5.Image")));
			this.sfButton5.ImageSize = new System.Drawing.Size(30, 30);
			this.sfButton5.Location = new System.Drawing.Point(195, 106);
			this.sfButton5.Name = "sfButton5";
			this.sfButton5.Size = new System.Drawing.Size(116, 72);
			this.sfButton5.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
			this.sfButton5.TabIndex = 5;
			this.sfButton5.Text = "暂停服务";
			this.sfButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// sfButton6
			// 
			this.sfButton6.AccessibleName = "Button";
			this.sfButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.sfButton6.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.sfButton6.Image = ((System.Drawing.Image)(resources.GetObject("sfButton6.Image")));
			this.sfButton6.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.sfButton6.ImageSize = new System.Drawing.Size(30, 30);
			this.sfButton6.Location = new System.Drawing.Point(33, 106);
			this.sfButton6.Name = "sfButton6";
			this.sfButton6.Size = new System.Drawing.Size(116, 72);
			this.sfButton6.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
			this.sfButton6.TabIndex = 6;
			this.sfButton6.Text = "设置";
			this.sfButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.sfButton6.UseVisualStyleBackColor = false;
			// 
			// defaultButton1
			// 
			this.defaultButton1.AccessibleName = "Button";
			this.defaultButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.defaultButton1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.defaultButton1.Image = ((System.Drawing.Image)(resources.GetObject("defaultButton1.Image")));
			this.defaultButton1.ImageSize = new System.Drawing.Size(35, 35);
			this.defaultButton1.Location = new System.Drawing.Point(645, 370);
			this.defaultButton1.Name = "defaultButton1";
			this.defaultButton1.Size = new System.Drawing.Size(96, 73);
			this.defaultButton1.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
			this.defaultButton1.TabIndex = 7;
			this.defaultButton1.Text = "最小化";
			this.defaultButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(760, 455);
			this.Controls.Add(this.defaultButton1);
			this.Controls.Add(this.sfButton6);
			this.Controls.Add(this.sfButton5);
			this.Controls.Add(this.sfButton4);
			this.Controls.Add(this.sfButton3);
			this.Controls.Add(this.titleLabel1);
			this.Controls.Add(this.sfButton2);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "班级助手";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private ClassRoomHelper.Windows.Controls.DefaultButton sfButton2;
		private Windows.Controls.TitleLabel titleLabel1;
		private ClassRoomHelper.Windows.Controls.DefaultButton sfButton3;
		private ClassRoomHelper.Windows.Controls.DefaultButton sfButton4;
		private ClassRoomHelper.Windows.Controls.DefaultButton sfButton5;
		private ClassRoomHelper.Windows.Controls.DefaultButton sfButton6;
		private Windows.Controls.DefaultButton defaultButton1;
	}
}

