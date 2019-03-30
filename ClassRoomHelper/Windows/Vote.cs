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
	public partial class Vote : Form
	{
		public Vote()
		{
			InitializeComponent();
		}

		private void ModernButton1_Click(object sender, EventArgs e)
		{
			BindingList<string> data = new BindingList<string>();
			EditStudentListWindow window = new EditStudentListWindow();
			window.AsListEditor("编辑选项","编辑选项",data);
			window.ShowDialog();
			if (data.Count <= 1)
			{
				MessageBox.Show("由于选项不足,投票已取消.","取消投票",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
				return;
			}

		}
	}
}
