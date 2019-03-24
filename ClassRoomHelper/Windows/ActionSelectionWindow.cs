using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Speech.Synthesis;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace ClassRoomHelper.Windows
{
	public partial class ActionSelectionWindow : RsWork.UI.Windows.BasicNoneBorderWinForm
	{
		//SpeechSynthesizer speech = new SpeechSynthesizer();
		public ActionSelectionWindow()
		{
			InitializeComponent();
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			Service.ChooseNameRandomly();
			this.Close();
			//speech.SpeakCompleted += this.Speech_SpeakCompleted;
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			//if (!Program.Settings.UMgr_Enabled) return;
			try
			{
				DriveInfo[] s = DriveInfo.GetDrives();
				bool Opened = false ;
				foreach (DriveInfo drive in s)
				{
					if (drive.DriveType == DriveType.Removable)
					{
						Opened = true;
						//MessageBox.Show(drive.DriveFormat);
						string fs = drive.DriveFormat.ToLower();
						if (fs != "ntfs" && fs != "refs" && fs != "fat" && fs != "fat32" && fs != "exfat") continue;
						/*if (drive.VolumeLabel == "")
						{
							drive.VolumeLabel = "U盘" + new Random().Next(1, 999).ToString();
						}*/

						Process.Start("explorer.exe", drive.RootDirectory.FullName);
						if(Program.Settings.UMgr_ShowDialog)
						new OpenUDiskWindow().Show();
					}
				}
				if (!Opened) MessageBox.Show("没有可打开的U盘","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			catch
			{
				MessageBox.Show("失败","错误",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			this.Close();
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			new SpeechWindow().Show();
			this.Close();
		}
	}
}
