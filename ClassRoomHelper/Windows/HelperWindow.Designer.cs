namespace ClassRoomHelper.Windows
{
	partial class HelperWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelperWindow));
			this.SuspendLayout();
			// 
			// HelperWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(120, 60);
			this.ControlBox = false;
			this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::ClassRoomHelper.Properties.Settings.Default, "HelperWindowLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Location = global::ClassRoomHelper.Properties.Settings.Default.HelperWindowLocation;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "HelperWindow";
			this.Opacity = 0.6D;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "HelperWindow";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.HelperWindow_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.HelperWindow_Paint);
			this.DoubleClick += new System.EventHandler(this.HelperWindow_DoubleClick);
			this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HelperWindow_MouseClick);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
			this.Move += new System.EventHandler(this.HelperWindow_Move);
			this.ResumeLayout(false);

		}

		#endregion
	}
}