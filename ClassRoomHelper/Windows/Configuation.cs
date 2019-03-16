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
	public partial class Configuation : BaseForm
	{
		public Configuation()
		{
			InitializeComponent();
		}

		private void Configuation_FormClosing(object sender, FormClosingEventArgs e)
		{
			Program.Settings.TargetDir = textBox1.Text;
			Program.Settings.NameCallOutPre = textBox2.Text;
			Program.Settings.NameCallOutPost = textBox3.Text;
			Program.Settings.Save();
			MessageBox.Show("设置已保存 .","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}

		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			Program.Settings.DesktopTool_AutoShow = checkBox1.Checked;
		}

		private void CheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			Program.Settings.DesktopTool_ShowCalc = checkBox2.Checked;
		}

		private void CheckBox3_CheckedChanged(object sender, EventArgs e)
		{
			Program.Settings.DesktopTool_ShowScissors = checkBox3.Checked;
		}

		private void CheckBox8_CheckedChanged(object sender, EventArgs e)
		{
			Program.Settings.DesktopTool_ShowNameSelector = checkBox8.Checked;
		}

		private void CheckBox6_CheckedChanged(object sender, EventArgs e)
		{
			Program.Settings.StartAfterWindows = checkBox8.Checked;
		}

		private void CheckBox5_CheckedChanged(object sender, EventArgs e)
		{
			Program.Settings.DebugEnabled = checkBox5.Checked;

		}

		private void CheckBox9_CheckedChanged(object sender, EventArgs e)
		{
			Program.Settings.VoiceNameCallOut = checkBox9.Checked;
		}

		private void RadioButton1_CheckedChanged(object sender, EventArgs e)
		{
			if(radioButton1.Checked)
				Program.Settings.FileExistedSolution = Library.Services.FileExistedSolution.Skip;
		}

		private void RadioButton2_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton2.Checked)
				Program.Settings.FileExistedSolution = Library.Services.FileExistedSolution.Cover;
		}

		private void RadioButton3_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton3.Checked)
				Program.Settings.FileExistedSolution = Library.Services.FileExistedSolution.Copy;
		}

		private void CheckBox7_CheckedChanged(object sender, EventArgs e)
		{
			Program.Settings.UMgr_Enabled = checkBox7.Checked;
		}

		private void CheckBox4_CheckedChanged(object sender, EventArgs e)
		{
			Program.Settings.UMgr_ShowDialog = checkBox4.Checked;
		}

		private void RadioButton4_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton4.Checked)
			{
				Program.Settings.ResortMode = Library.Services.ResortMode.Monthly;
			}
		}

		private void RadioButton5_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton5.Checked)
			{
				Program.Settings.ResortMode = Library.Services.ResortMode.Daily;
			}
		}

		private void RadioButton6_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton6.Checked)
			{
				Program.Settings.ResortMode = Library.Services.ResortMode.AmPmSeparated;
			}
		}

		private void RadioButton7_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton7.Checked)
			{
				Program.Settings.CleanMode = Library.Services.CleanMode.Never;
			}
		}

		private void RadioButton8_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton8.Checked)
			{
				Program.Settings.CleanMode = Library.Services.CleanMode.Daily;
			}
		}

		private void RadioButton10_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton10.Checked)
			{
				Program.Settings.CleanMode = Library.Services.CleanMode.EveryTwoDays;
			}
		}

		private void RadioButton9_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton9.Checked)
			{
				Program.Settings.CleanMode = Library.Services.CleanMode.LastMonth;
			}
		}
	}
}
