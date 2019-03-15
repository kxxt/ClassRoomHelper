using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassRoomHelper
{
	public partial class MainForm : RsWork.UI.Windows.BasicNoneBorderWinForm
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void SfButton1_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void SfButton2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void DefaultButton6_Click(object sender, EventArgs e)
		{
			new Windows.DebugForm().Show();
		}
	}
}
