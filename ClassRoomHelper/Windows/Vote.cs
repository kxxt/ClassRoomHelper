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
			else if (voters.Count <= 1)
			{
				MessageBox.Show("由于投票人不足,投票已取消.", "取消投票", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			SingleVoteWindow sw = new SingleVoteWindow();
			sw.LoadData(data.ToList<string>(),voters);
			if(DialogResult.No==MessageBox.Show("是否允许投票人弃权 ?", "设置", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
			{
				sw.DisableGivingUp();
			}
			sw.ShowDialog();
			if (sw.Canceled)
			{
				return;
			}

		}

		private void ModernButton2_Click(object sender, EventArgs e)
		{
			BindingList<string> data = new BindingList<string>();
			var voters = new BindingList<string>();
			foreach (var name in Program.NameSelector.Names)
			{
				data.Add(name);
				voters.Add(name);
			}
			EditStudentListWindow window = new EditStudentListWindow();
			window.AsListEditor("编辑候选人", "编辑候选人,\r\n请在编辑完成后点击保存按钮", data);
			window.ShowDialog();
			if (window.Canceled)
			{
				window.Dispose();
				return;
			}
			else if (data.Count <= 1)
			{
				MessageBox.Show("由于候选人不足,投票已取消.", "取消投票", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			window = new EditStudentListWindow();
			window.AsListEditor("编辑投票人", "编辑投票人,\r\n请在编辑完成后点击保存按钮",voters);
			if (voters == null)
			{
				return;
			}
			else if (voters.Count <= 1)
			{
				MessageBox.Show("由于投票人不足,投票已取消.", "取消投票", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			SingleVoteWindow sw = new SingleVoteWindow();
			sw.LoadData(data.ToList<string>(), voters.ToList<string>());
			if (DialogResult.No == MessageBox.Show("是否允许投票人弃权 ?", "设置", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
			{
				sw.DisableGivingUp();
			}
			sw.ShowDialog();
			if (sw.Canceled)
			{
				return;
			}
		}

		private void ModernButton3_Click(object sender, EventArgs e)
		{
			bool enableNEnough, enableGivingup;int max;
			BindingList<string> data = new BindingList<string>();
			var voters = new BindingList<string>();
			foreach (var name in Program.NameSelector.Names)
			{
				data.Add(name);
				voters.Add(name);
			}
			EditStudentListWindow window = new EditStudentListWindow();
			window.AsListEditor("编辑候选人", "编辑候选人,\r\n请在编辑完成后点击保存按钮", data);
			window.ShowDialog();
			if (window.Canceled)
			{
				window.Dispose();
				return;
			}
			else if (data.Count <= 1)
			{
				MessageBox.Show("由于候选人不足,投票已取消.", "取消投票", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			window = new EditStudentListWindow();
			window.AsListEditor("编辑投票人", "编辑投票人,\r\n请在编辑完成后点击保存按钮", voters);
			if (voters == null)
			{
				return;
			}
			else if (voters.Count <= 1)
			{
				MessageBox.Show("由于投票人不足,投票已取消.", "取消投票", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			var sw=new MultiVoteSettingDialog();
			sw.count = data.Count;
			sw.ShowDialog();
			(enableGivingup,enableNEnough,max)=sw.Get();
			ChoosingBoard cb = new ChoosingBoard();
			cb.MaxCheckCnt = max;
			cb.LoadData(data);
			cb.ShowDialog();
		}
	}
}
