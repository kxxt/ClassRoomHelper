using System;
using System.IO;
using System.Windows.Forms;
using RsWork.UI.Windows;
namespace ClassRoomHelper.Windows
{
	public partial class Configuation : BasicNoneBorderWinForm
	{
		bool loading=true;
		bool loaded = false;
		public Configuation()
		{
			InitializeComponent();
			//StartAfterWindows = Program.Settings.StartAfterWindows;
		}
		

		private void Configuation_FormClosing(object sender, FormClosingEventArgs e)
		{
			Program.Settings.TargetDir = textBox1.Text;
			Program.Settings.NameCallOutPre = textBox2.Text;
			Program.Settings.NameCallOutPost = textBox3.Text;
			Program.Settings.Timer_EventName = textBox4.Text;
			Program.Settings.CICCamera = Int32.Parse(maskedTextBox1.Text);
			Program.Settings.Timer_Date = dateTimePicker1.Value;
			Program.Settings.Save();
			Program.TargetDirParser.Root = Program.Settings.TargetDir;
			Program.TargetDirParser.Mode = Program.Settings.ResortMode;
			File.WriteAllText(".config",Program.Settings.TargetDir);
			MessageBox.Show("设置已保存 .","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
			loaded = false;
		}

		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			Program.Settings.DesktopTool_AutoShow = checkBox1.Checked;
		}

		

		private void CheckBox6_CheckedChanged(object sender, EventArgs e)
		{
			if (loading) return;
			Program.Settings.StartAfterWindows = checkBox6.Checked;
			
			if (checkBox6.Checked)
			{
				Core.SetUp();
			}
			else
			{
				Core.TryRemoveStartUpCompletely();
			}
			MessageBox.Show("设置完成");
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

		private void Configuation_Load(object sender, EventArgs e)
		{
			textBox1.Text = Program.Settings.TargetDir;
			textBox2.Text = Program.Settings.NameCallOutPre;
			textBox3.Text = Program.Settings.NameCallOutPost;
			textBox4.Text = Program.Settings.Timer_EventName;
			maskedTextBox1.Text = Program.Settings.CICCamera.ToString();
			dateTimePicker1.Value = Program.Settings.Timer_Date;
			checkBox1.Checked=Program.Settings.DesktopTool_AutoShow  ;
			checkBox6.Checked=Program.Settings.StartAfterWindows ;
			checkBox5.Checked=Program.Settings.DebugEnabled ;
			checkBox9.Checked=Program.Settings.VoiceNameCallOut ;
			checkBox3.Checked = Program.Settings.WallpaperEngine_Enabled;
			checkBox7.Checked=Program.Settings.UMgr_Enabled ;
			checkBox4.Checked=Program.Settings.UMgr_ShowDialog;
			checkBox12.Checked = Program.Settings.ShowHelperWindow;
			checkBox2.Checked = Program.Settings.Timer_Enabled;
			checkBox8.Checked = Program.Settings.BugFixForSeewo;
			checkBox11.Checked = Program.Settings.CICEnabled;
			checkBox13.Checked = Program.Settings.CICEncryptedSave;
			checkBox14.Checked = Program.Settings.RecordData;
			checkBox15.Checked = Program.Settings.Timer_AutoRenew;
			switch (Program.Settings.FileExistedSolution)
			{
				case Library.Services.FileExistedSolution.Copy:
					radioButton3.Checked = true;
					break;
				case Library.Services.FileExistedSolution.Cover:
					radioButton2.Checked = true;
					break;
				case Library.Services.FileExistedSolution.Skip:
					radioButton1.Checked = true;
					break;
			default:
					radioButton3.Select();
					break;
			}
			switch (Program.Settings.ResortMode)
			{
				case Library.Services.ResortMode.AmPmSeparated:
					radioButton6.Checked = true;
					break;
				case Library.Services.ResortMode.Daily:
					radioButton5.Checked = true;
					break;
				case Library.Services.ResortMode.Monthly:
					radioButton4.Checked = true;
					break;
				case Library.Services.ResortMode.Weekly:
					radioButton11.Checked = true;
					break;
				default:
					radioButton5.Select();
					break;
			}
			switch (Program.Settings.CollectMode)
			{
				case Library.Services.CollectMode.PPT:
					checkBox10.Checked = true;
					break;
				default:
					checkBox10.Checked = false;

					break;
			}
			loading = false;
			loaded = true;
			//System.Speech.Synthesis.TtsEngine.
		}

		private void DefaultButton1_Click(object sender, EventArgs e)
		{
			fb.ShowDialog();
			textBox1.Text = fb.SelectedPath;
		}

		private void RadioButton11_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton11.Checked)
			{
				Program.Settings.ResortMode = Library.Services.ResortMode.Weekly;
			}
		}

		private void DefaultButton2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void CheckBox10_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox10.Checked)
			{
				Program.Settings.CollectMode = Library.Services.CollectMode.PPT;
			}
			else
			{
				Program.Settings.CollectMode = Library.Services.CollectMode.ALL;

			}
		}

		private void CheckBox12_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox12.Checked)
			{
				Program.Settings.ShowHelperWindow =true;
			}
			else
			{
				Program.Settings.ShowHelperWindow = false;

			}
		}

		private void CheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox2.Checked)
			{
				Program.Settings.Timer_Enabled= true;
			}
			else
			{
				Program.Settings.Timer_Enabled = false;

			}
		}

		private void GroupBox1_Enter(object sender, EventArgs e)
		{

		}

		private async void CheckBox3_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox3.Checked)
			{
				Program.Settings.WallpaperEngine_Enabled = true;
				Service.BingWallpaper();
			}
			else
			{
				Program.Settings.WallpaperEngine_Enabled = false;

			}
		}

		private void CheckBox8_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox8.Checked)
			{
				Program.Settings.BugFixForSeewo = true;
				
			}
			else
			{
				Program.Settings.BugFixForSeewo = false;

			}
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void checkBox11_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox11.Checked)
			{
				Program.Settings.CICEnabled = true;

			}
			else
			{
				Program.Settings.CICEnabled = false;

			}
			if(loaded)
			MessageBox.Show("Please Restart Application to Apply Changes","Hint",MessageBoxButtons.OK,MessageBoxIcon.Warning);
		}

		private void checkBox13_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox13.Checked)
			{
				Program.Settings.CICEncryptedSave = true;

			}
			else
			{
				Program.Settings.CICEncryptedSave = false;

			}
			if(loaded)
			MessageBox.Show("Please Restart Application to Apply Changes", "Hint", MessageBoxButtons.OK, MessageBoxIcon.Warning);

		}

		private void textLabel9_Click(object sender, EventArgs e)
		{

		}

		private void checkBox14_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox11.Checked)
			{
				Program.Settings.RecordData= true;

			}
			else
			{
				Program.Settings.RecordData = false;

			}
			if (loaded)
				MessageBox.Show("Please Restart Application to Apply Changes", "Hint", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void checkBox15_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox15.Checked)
			{
				Program.Settings.Timer_AutoRenew= true;

			}
			else
			{
				Program.Settings.Timer_AutoRenew = false;

			}
			if (loaded)
				MessageBox.Show("请重新启动应用程序来应用设置", "Hint", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
	}
}
