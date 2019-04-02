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
			if (window.Canceled)
			{
				window.Dispose();
				return;
			}
			if (data.Count <= 1)
			{
				MessageBox.Show("由于选项不足,投票已取消.","取消投票",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
				return;
			}
			SingleVoteWindow sw = new SingleVoteWindow();
			sw.LoadData(data.ToList<string>());
			sw.votebtn.Click += new EventHandler((_,__)=>
			{
				var ret=MessageBox.Show($"您已成功投票 给 \"{sw.choices.SelectedItem.ToString()}\" \r\n , 是否确认 ? \r\n, 这是您的最后修改机会 .", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Information); ;
				if (ret == DialogResult.No) return;
				else
				{

				}
				// todo
			});
			sw.ShowDialog();

		}
	}
}
