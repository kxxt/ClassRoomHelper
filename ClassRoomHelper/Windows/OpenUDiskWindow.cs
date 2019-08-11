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
		public void EjectWindowSetup()
		{
			this.titleLabel1.Text = "U盘已安全弹出";
		}
		private void OpenUDiskWindow_Shown(object sender, EventArgs e)
		{
			timer1.Start();
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				this.Opacity -= 0.058;
			}
			catch
			{
				this.Close();
			}
			

		}

		private void TitleLabel1_Click(object sender, EventArgs e)
		{

		}
	}
}
