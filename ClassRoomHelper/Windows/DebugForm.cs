using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using ClassRoomHelper.Library;
using ClassRoomHelper.Library.Services;
namespace ClassRoomHelper.Windows
{
	public partial class DebugForm : Form
	{
		short score = 100;
		public DebugForm()
		{
			InitializeComponent();
		}

		private void DefaultButton1_Click(object sender, EventArgs e)
		{
			var x=LateBindingOfficeDynamic.GetWord();
			foreach(var a in x)
			{
				MessageBox.Show(a.Item1 + "\r\n" + a.Item2);
			}
		}

		private void DefaultButton3_Click(object sender, EventArgs e)
		{
			var x = LateBindingOfficeDynamic.GetExcel();
			foreach (var a in x)
			{
				MessageBox.Show(a.Item1+"\r\n"+a.Item2);
			}
		}

		private void DefaultButton2_Click(object sender, EventArgs e)
		{
			var x = LateBindingOfficeDynamic.GetPowerpoint();
			foreach (var a in x)
			{
				MessageBox.Show(a.Item1 + "\r\n" + a.Item2);
			}
		}

		private void DefaultButton4_Click(object sender, EventArgs e)
		{
			//CSCreateLowIntegrityProcess.Tool.CreateLowIntegrityProcess("CRHBackstageHelper.exe fetch-all D:\\Sync copy");
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

		private void DefaultButton9_Click(object sender, EventArgs e)
		{
			var t = new HelperWindow();
			t.Show();
		}

		private void DefaultButton10_Click(object sender, EventArgs e)
		{
			Core.SetStartUp();
		}

		private void DefaultButton11_Click(object sender, EventArgs e)
		{
			Core.SetSkipUAC();
		}

		private void DefaultButton12_Click(object sender, EventArgs e)
		{
			Core.RemoveSkipUAC();
		}

		private void DefaultButton13_Click(object sender, EventArgs e)
		{
			Core.RemoveStartup();
		}

		private void DefaultButton15_Click(object sender, EventArgs e)
		{
			Core.SetStartByTaskSch();
		}

		private void DefaultButton14_Click(object sender, EventArgs e)
		{
			Core.RemoveStartByTaskSch();
		}

		private void DefaultButton16_Click(object sender, EventArgs e)
		{
			new OOBE().ShowDialog();
		}

		private void DefaultButton19_Click(object sender, EventArgs e)
		{
			var x = LateBindingOfficeDynamic.GetWord();
			foreach (var a in x)
			{
				MessageBox.Show(a.Item1 + "\r\n" + a.Item2);
			}
		}

		private void DefaultButton17_Click(object sender, EventArgs e)
		{
			var x = LateBindingOfficeDynamic.GetExcel();
			foreach (var a in x)
			{
				MessageBox.Show(a.Item1 + "\r\n" + a.Item2);
			}
		}

		private void DefaultButton18_Click(object sender, EventArgs e)
		{
			var x = LateBindingOfficeDynamic.GetPowerpoint();
			foreach (var a in x)
			{
				MessageBox.Show(a.Item1 + "\r\n" + a.Item2);
			}
		}

		private void DebugForm_Load(object sender, EventArgs e)
		{
			//actionLine1.Set("测试人员", ref score);
		}

		private void DefaultButton20_Click(object sender, EventArgs e)
		{
			MessageBox.Show(score.ToString());
		}

		private void DefaultButton21_Click(object sender, EventArgs e)
		{
			EjectUSB eject = new EjectUSB();
			MessageBox.Show(eject.Eject(eject.USBEject("H:")).ToString());
		}

		private async void DefaultButton22_Click(object sender, EventArgs e)
		{
			string xml = await (await Library.WallpaperEngine.GetInformation()).Content.ReadAsStringAsync();
			MessageBox.Show(WallpaperEngine.GetImageUrl(xml)
			);
		}

		private async void DefaultButton23_Click(object sender, EventArgs e)
		{
			string url = WallpaperEngine.GetImageUrl(await(await Library.WallpaperEngine.GetInformation()).Content.ReadAsStringAsync());
			var path = Program.TargetDirParser.Get_Daily() + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + ".jpg";
			//WallpaperEngine.HttpDownloadFile(url,path);
			//WallpaperEngine.Set(Image.FromFile(path), WallpaperEngine.Style.Stretched);

		}
	}
}
