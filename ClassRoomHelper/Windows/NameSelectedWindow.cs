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
		public NameSelectedWindow()
		{
			InitializeComponent();
		}
		public NameSelectedWindow(string name)
		{
			InitializeComponent();
			titleLabel2.Text = name;
		}

		private void Timer2_Tick(object sender, EventArgs e)
		{
			if (Opacity >= 0.1)
				this.Opacity -= 0.027;
			else
			{
				timer2.Dispose();
				this.Close();
			}
		}

		private void NameSelectedWindow_Shown(object sender, EventArgs e)
		{
			timer2.Start();
		}
	}
}
