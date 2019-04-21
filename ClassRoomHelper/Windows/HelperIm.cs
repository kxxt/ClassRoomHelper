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
	public partial class HelperIm :RsWork.UI.Windows.BasicNoneBorderWinForm
	{
		public HelperIm()
		{
			InitializeComponent();
		}

		private void DefaultButton2_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void DefaultButton1_Click(object sender, EventArgs e)
		{
			Service.ChooseNameRandomly();
		}

		private void HelperIm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Program.Settings.HelperWindowLocation = this.Location;
			Program.Settings.Save();
		}

		private void HelperIm_Load(object sender, EventArgs e)
		{
			this.Location = Program.Settings.HelperWindowLocation;
		}
	}
}
