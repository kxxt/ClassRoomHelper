using System;
using System.Diagnostics;
using System.Windows.Forms;
using ClassRoomHelper.Library;
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
				MessageBox.Show(a.Item1 + "\r\n" + a.Item2);
			}
		}

		private void DefaultButton3_Click(object sender, EventArgs e)
		{
			var x = ActiveFileController.GetExcel();
			foreach (var a in x)
			{
				MessageBox.Show(a.Item1+"\r\n"+a.Item2);
			}
		}

		private void DefaultButton2_Click(object sender, EventArgs e)
		{
			var x = ActiveFileController.GetPowerpoint();
			foreach (var a in x)
			{
				MessageBox.Show(a.Item1 + "\r\n" + a.Item2);
			}
		}

		private void DefaultButton4_Click(object sender, EventArgs e)
		{
			CSCreateLowIntegrityProcess.Tool.CreateLowIntegrityProcess("CRHBackstageHelper.exe fetch-all D:\\Sync copy");
		}

		private void DefaultButton5_Click(object sender, EventArgs e)
		{
			/*IPCInfoStruct data;
			data.WorkingState = (int)WorkingState.ToRun;
			data.
			//data.Target = "M:\\投稿用途";
			data.CollectMode = (int)CollectMode.DOC;
			data.FileExistedSolution =(int) FileExistedSolution.Copy;
			Program.InfoPipe.Write(ref data, 0);*/
			Core.SendMessage(CollectMode.DOC);
		}

		private void DefaultButton6_Click(object sender, EventArgs e)
		{
			Core.SendExitMessage();
		}

		private void DefaultButton7_Click(object sender, EventArgs e)
		{
			var word = Process.GetProcessesByName("winword");
			if (word.Length > 0)
			{
				if (word[0].IsAdminGroupMember())
				{
					MessageBox.Show("Yes");
				}
				else
				{
					MessageBox.Show("No");
				}
			}
		}

		private void DefaultButton8_Click(object sender, EventArgs e)
		{
			TargetDirParser tdp = new TargetDirParser(Program.Settings.TargetDir, ResortMode.Weekly);
			MessageBox.Show(tdp.Get());
		}
	}
}
