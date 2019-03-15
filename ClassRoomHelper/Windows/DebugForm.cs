using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassRoomHelper.Library.Services;
namespace ClassRoomHelper.Windows
{
	public partial class DebugForm : Form
	{
		public DebugForm()
		{
			InitializeComponent();
		}

		private void DefaultButton1_Click(object sender, EventArgs e)
		{
			var x=ActiveFileController.GetWord();
			foreach(var a in x)
			{
				MessageBox.Show(a);
			}
		}
	}
}
