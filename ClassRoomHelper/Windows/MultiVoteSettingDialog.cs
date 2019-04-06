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
	public partial class MultiVoteSettingDialog : Form
	{
		public int count;
		public MultiVoteSettingDialog()
		{
			InitializeComponent();
		}

		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{

		}
		public (bool 弃权,bool 多选,int Max) Get()
		{
			return (checkBox2.Checked, checkBox1.Checked, Int32.Parse(maskedTextBox1.Text));
		}
		private void DefaultButton1_Click(object sender, EventArgs e)
		{
			try
			{
				var x = int.Parse(maskedTextBox1.Text);
				if (x <= 0 || x > count)
				{
					MessageBox.Show($"请输入非负整数 , 且小于{count}", "格式错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
			}
			catch
			{
				MessageBox.Show($"请输入非负整数 , 且小于{count}", "格式错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			
			this.Hide();
		}

		private void MaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{

		}
	}
}
