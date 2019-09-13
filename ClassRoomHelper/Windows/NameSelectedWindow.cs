using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassRoomHelper.Windows
{
	public partial class NameSelectedWindow : RsWork.UI.Windows.BasicNoneBorderWinForm
	{
		public string SelectedName { get => titleLabel2.Text; set => titleLabel2.Text = value; }
		
		public NameSelectedWindow()
		{
			InitializeComponent();
		}
		public NameSelectedWindow(string name)
		{
			InitializeComponent();
			titleLabel2.Text = name;
		}
		public NameSelectedWindow(string up,string down)
		{
			InitializeComponent();
			titleLabel1.Text = up;
			titleLabel3.Text = down;
		}
		private void Timer2_Tick(object sender, EventArgs e)
		{
			if (Opacity >= 0.1)
				this.Opacity -= 0.045;
			else
			{
				//timer2.Dispose();
				this.Hide();
			}
		}
		private void Click(object sender,EventArgs e)
		{
			this.Hide();
		}
		private void NameSelectedWindow_Shown(object sender, EventArgs e)
		{
			timer2.Start();
			this.Opacity = 1;
		}

		private void Panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void NameSelectedWindow_VisibleChanged(object sender, EventArgs e)
		{
			this.Opacity = 1;
		}
	}
}
