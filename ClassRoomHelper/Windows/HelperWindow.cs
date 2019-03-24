using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassRoomHelper.Windows
{
	public partial class HelperWindow : Form
	{
		private bool mouseDown = false;
		private bool mouseMove = false;
		private Point lastLocation;
		/*protected override void OnDragDrop(DragEventArgs drgevent)
		{
			
		
			ReleaseCapture();
			SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
			base.OnDragDrop(drgevent);
		}*/
		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			mouseDown = true;
			lastLocation = e.Location;
		}

		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			if (mouseDown)
			{
				mouseMove = true;
				this.Location = new Point(
					(this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

				this.Update();
			}
		}

		private void Form1_MouseUp(object sender, MouseEventArgs e)
		{
			mouseDown = false;
			mouseMove = false;
		}
		ActionSelectionWindow w;
		public HelperWindow()
		{
			InitializeComponent();
			Height = 60;
			w = new ActionSelectionWindow();
			Width = 60;
			//Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
		}
		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
		private static extern IntPtr CreateRoundRectRgn
		(
			int nLeftRect,     // x-coordinate of upper-left corner
			int nTopRect,      // y-coordinate of upper-left corner
			int nRightRect,    // x-coordinate of lower-right corner
			int nBottomRect,   // y-coordinate of lower-right corner
			int nWidthEllipse, // height of ellipse
			int nHeightEllipse // width of ellipse
		);
		[System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
		private static extern bool DeleteObject(System.IntPtr hObject);

		private void HelperWindow_Paint(object sender, PaintEventArgs e)
		{
			/*System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
			path.AddEllipse(0, 0, 100, 100);
			this.Region = new Region(path);*/
			
			System.IntPtr ptr = CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10);
			this.Region = System.Drawing.Region.FromHrgn(ptr);
			DeleteObject(ptr);
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void HelperWindow_Load(object sender, EventArgs e)
		{
			Height = 60;
			Width = 60;
			//this.Left = (SystemInformation.PrimaryMonitorMaximizedWindowSize.Width - this.Width) / 2;
			//this.Top = (SystemInformation.PrimaryMonitorMaximizedWindowSize.Height - this.Height) / 2;
		}

		private void HelperWindow_DoubleClick(object sender, EventArgs e)
		{
			//MessageBox.Show($"{this.Height},{this.Width}");
		}

		private void HelperWindow_MouseClick(object sender, MouseEventArgs e)
		{
			if (mouseMove) return;
			w.ShowDialog();
		}

		private void HelperWindow_Move(object sender, EventArgs e)
		{
			Program.Settings.HelperWindowLocation = this.Location;

		}
	}
}
