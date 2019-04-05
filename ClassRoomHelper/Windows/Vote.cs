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
		private List<string> GatherVoterInfo()
		{
			//var ret = new List<string>();
			BindingList<string> data = new BindingList<string>();
			foreach(var x in Program.NameSelector.Names)
			{
				data.Add(x);
			}
			EditStudentListWindow window = new EditStudentListWindow();
			window.AsListEditor("编辑投票人", "编辑投票人", data);
			window.ShowDialog();
			if (window.Canceled)
			{
				window.Dispose();
				return null;
			}
			if (data.Count <= 1)
			{
				MessageBox.Show("由于选项不足,投票已取消.", "取消投票", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return null;
			}
			return data.ToList();

		}
		public Vote()
		{
			InitializeComponent();
		}

		private void ModernButton1_Click(object sender, EventArgs e)
		{
			BindingList<string> data = new BindingList<string>();
			EditStudentListWindow window = new EditStudentListWindow();
			window.AsListEditor("编辑选项","编辑选项,\r\n请在编辑完成后点击保存按钮",data);
			window.ShowDialog();
			if (window.Canceled)
			{
				window.Dispose();
				return;
			}
			else if (data.Count <= 1)
			{
				MessageBox.Show("由于选项不足,投票已取消.","取消投票",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
				return;
			}
			var voters = GatherVoterInfo();
			if (voters==null)
			{
				return;
			}
			else if (data.Count <= 1)
			{
				MessageBox.Show("由于投票人不足,投票已取消.", "取消投票", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			SingleVoteWindow sw = new SingleVoteWindow();
			sw.LoadData(data.ToList<string>(),voters);
			sw.ShowDialog();
			if (sw.Canceled)
			{
				return;
			}

		}
	}
}
