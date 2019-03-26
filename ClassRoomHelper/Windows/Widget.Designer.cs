namespace ClassRoomHelper.Windows
{
	partial class Widget
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Widget));
			this.titleLabel1 = new ClassRoomHelper.Windows.Controls.TitleLabel();
			this.defaultButton1 = new ClassRoomHelper.Windows.Controls.DefaultButton();
			this.SuspendLayout();
			// 
			// titleLabel1
			// 
			this.titleLabel1.AutoSize = true;
			this.titleLabel1.BackColor = System.Drawing.Color.Transparent;
			this.titleLabel1.Font = new System.Drawing.Font("黑体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.titleLabel1.Location = new System.Drawing.Point(113, 9);
			this.titleLabel1.Name = "titleLabel1";
			this.titleLabel1.Size = new System.Drawing.Size(212, 48);
			this.titleLabel1.TabIndex = 1;
			this.titleLabel1.Text = "班级助手";
			// 
			// defaultButton1
			// 
			this.defaultButton1.AccessibleName = "Button";
			this.defaultButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.defaultButton1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.defaultButton1.Image = ((System.Drawing.Image)(resources.GetObject("defaultButton1.Image")));
			this.defaultButton1.ImageSize = new System.Drawing.Size(40, 40);
			this.defaultButton1.Location = new System.Drawing.Point(12, 68);
			this.defaultButton1.Name = "defaultButton1";
			this.defaultButton1.Size = new System.Drawing.Size(194, 190);
			this.defaultButton1.Style.BackColor = System.Drawing.Color.Violet;
			this.defaultButton1.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
			this.defaultButton1.TabIndex = 2;
			this.defaultButton1.Text = "最近使用的课件";
			this.defaultButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// Widget
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(456, 562);
			this.Controls.Add(this.defaultButton1);
			this.Controls.Add(this.titleLabel1);
			this.Font = new System.Drawing.Font("黑体", 14F);
			this.Margin = new System.Windows.Forms.Padding(5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Widget";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Widget";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Widget_Paint);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Controls.TitleLabel titleLabel1;
		private Controls.DefaultButton defaultButton1;
	}
}