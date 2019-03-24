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
	public partial class OpenUDiskWindow : RsWork.UI.Windows.BasicNoneBorderWinForm
	{
		
		public OpenUDiskWindow()
		{
			InitializeComponent();
		}

		private void OpenUDiskWindow_Shown(object sender, EventArgs e)
		{
			timer1.Start();
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				this.Opacity -= 0.05;
			}
			catch
			{
				this.Close();
			}
			

		}
	}
}
