namespace ClassRoomHelper.Windows
{
	partial class DebugForm
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
			this.defaultButton6 = new ClassRoomHelper.Windows.Controls.DefaultButton();
			this.defaultButton5 = new ClassRoomHelper.Windows.Controls.DefaultButton();
			this.defaultButton4 = new ClassRoomHelper.Windows.Controls.DefaultButton();
			this.defaultButton3 = new ClassRoomHelper.Windows.Controls.DefaultButton();
			this.defaultButton2 = new ClassRoomHelper.Windows.Controls.DefaultButton();
			this.defaultButton1 = new ClassRoomHelper.Windows.Controls.DefaultButton();
			this.defaultButton7 = new ClassRoomHelper.Windows.Controls.DefaultButton();
			this.defaultButton8 = new ClassRoomHelper.Windows.Controls.DefaultButton();
			this.SuspendLayout();
			// 
			// defaultButton6
			// 
			this.defaultButton6.AccessibleName = "Button";
			this.defaultButton6.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.defaultButton6.Location = new System.Drawing.Point(12, 183);
			this.defaultButton6.Name = "defaultButton6";
			this.defaultButton6.Size = new System.Drawing.Size(141, 28);
			this.defaultButton6.TabIndex = 5;
			this.defaultButton6.Text = "SendExit";
			this.defaultButton6.Click += new System.EventHandler(this.DefaultButton6_Click);
			// 
			// defaultButton5
			// 
			this.defaultButton5.AccessibleName = "Button";
			this.defaultButton5.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.defaultButton5.Location = new System.Drawing.Point(12, 149);
			this.defaultButton5.Name = "defaultButton5";
			this.defaultButton5.Size = new System.Drawing.Size(141, 28);
			this.defaultButton5.TabIndex = 4;
			this.defaultButton5.Text = "SendMessage";
			this.defaultButton5.Click += new System.EventHandler(this.DefaultButton5_Click);
			// 
			// defaultButton4
			// 
			this.defaultButton4.AccessibleName = "Button";
			this.defaultButton4.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.defaultButton4.Location = new System.Drawing.Point(12, 115);
			this.defaultButton4.Name = "defaultButton4";
			this.defaultButton4.Size = new System.Drawing.Size(141, 28);
			this.defaultButton4.TabIndex = 3;
			this.defaultButton4.Text = "StartService";
			this.defaultButton4.Click += new System.EventHandler(this.DefaultButton4_Click);
			// 
			// defaultButton3
			// 
			this.defaultButton3.AccessibleName = "Button";
			this.defaultButton3.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.defaultButton3.Location = new System.Drawing.Point(13, 47);
			this.defaultButton3.Name = "defaultButton3";
			this.defaultButton3.Size = new System.Drawing.Size(141, 28);
			this.defaultButton3.TabIndex = 2;
			this.defaultButton3.Text = "Detect Excel";
			this.defaultButton3.Click += new System.EventHandler(this.DefaultButton3_Click);
			// 
			// defaultButton2
			// 
			this.defaultButton2.AccessibleName = "Button";
			this.defaultButton2.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.defaultButton2.Location = new System.Drawing.Point(12, 81);
			this.defaultButton2.Name = "defaultButton2";
			this.defaultButton2.Size = new System.Drawing.Size(141, 28);
			this.defaultButton2.TabIndex = 1;
			this.defaultButton2.Text = "Detect PPT";
			this.defaultButton2.Click += new System.EventHandler(this.DefaultButton2_Click);
			// 
			// defaultButton1
			// 
			this.defaultButton1.AccessibleName = "Button";
			this.defaultButton1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.defaultButton1.Location = new System.Drawing.Point(13, 13);
			this.defaultButton1.Name = "defaultButton1";
			this.defaultButton1.Size = new System.Drawing.Size(141, 28);
			this.defaultButton1.TabIndex = 0;
			this.defaultButton1.Text = "Detect Word";
			this.defaultButton1.Click += new System.EventHandler(this.DefaultButton1_Click);
			// 
			// defaultButton7
			// 
			this.defaultButton7.AccessibleName = "Button";
			this.defaultButton7.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.defaultButton7.Location = new System.Drawing.Point(12, 217);
			this.defaultButton7.Name = "defaultButton7";
			this.defaultButton7.Size = new System.Drawing.Size(204, 28);
			this.defaultButton7.TabIndex = 6;
			this.defaultButton7.Text = "Check Word Admin";
			this.defaultButton7.Click += new System.EventHandler(this.DefaultButton7_Click);
			// 
			// defaultButton8
			// 
			this.defaultButton8.AccessibleName = "Button";
			this.defaultButton8.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.defaultButton8.Location = new System.Drawing.Point(12, 251);
			this.defaultButton8.Name = "defaultButton8";
			this.defaultButton8.Size = new System.Drawing.Size(204, 28);
			this.defaultButton8.TabIndex = 7;
			this.defaultButton8.Text = "GetWeekly";
			this.defaultButton8.Click += new System.EventHandler(this.DefaultButton8_Click);
			// 
			// DebugForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.defaultButton8);
			this.Controls.Add(this.defaultButton7);
			this.Controls.Add(this.defaultButton6);
			this.Controls.Add(this.defaultButton5);
			this.Controls.Add(this.defaultButton4);
			this.Controls.Add(this.defaultButton3);
			this.Controls.Add(this.defaultButton2);
			this.Controls.Add(this.defaultButton1);
			this.Name = "DebugForm";
			this.Text = "DebugForm";
			this.ResumeLayout(false);

		}

		#endregion

		private Controls.DefaultButton defaultButton1;
		private Controls.DefaultButton defaultButton2;
		private Controls.DefaultButton defaultButton3;
		private Controls.DefaultButton defaultButton4;
		private Controls.DefaultButton defaultButton5;
		private Controls.DefaultButton defaultButton6;
		private Controls.DefaultButton defaultButton7;
		private Controls.DefaultButton defaultButton8;
	}
}