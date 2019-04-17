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
		//private DateTime lastDrag = new DateTime(1900, 1, 1);
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
				//if(DateTime.Now-lastDrag>=new TimeSpan(0,0,5))
				
				this.Update();
			}
		}

		private void Form1_MouseUp(object sender, MouseEventArgs e)
		{
			mouseDown = false;
			mouseMove = false;
			Point delta = new Point(Location.X - lastLocation.X, Location.Y - lastLocation.Y);
			Program.Settings.Save();
		}
		//ActionSelectionWindow w;
		public HelperWindow()
		{
			InitializeComponent();
			//Height = 60;
			//w = new ActionSelectionWindow();
			//Width = 60;
			//Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
		}
		

		

		private void Button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void HelperWindow_Load(object sender, EventArgs e)
		{
			//Height = 60;
			//Width = 60;
			//this.Left = (SystemInformation.PrimaryMonitorMaximizedWindowSize.Width - this.Width) / 2;
			//this.Top = (SystemInformation.PrimaryMonitorMaximizedWindowSize.Height - this.Height) / 2;
		}

		private void HelperWindow_DoubleClick(object sender, EventArgs e)
		{
			//MessageBox.Show($"{this.Height},{this.Width}");
		}

		private void HelperWindow_MouseClick(object sender, MouseEventArgs e)
		{
			if (mouseMove&&sender!=null) return;
			//w.ShowDialog();
		}

		private void HelperWindow_Move(object sender, EventArgs e)
		{
			Program.Settings.HelperWindowLocation = this.Location;

		}

		private void ModernButton1_Click(object sender, EventArgs e)
		{

		}

		private void DefaultButton1_Click(object sender, EventArgs e)
		{
			Service.ChooseNameRandomly();
		}

		private void DefaultButton2_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
