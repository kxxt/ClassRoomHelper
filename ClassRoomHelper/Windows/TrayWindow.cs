using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassRoomHelper.Library;
using RsWork.UI.Windows;
namespace ClassRoomHelper.Windows
{
	public partial class TrayWindow : BasicNoneBorderWinForm
	{
		public DateTime LastTime=new DateTime(1990,1,1);
		public TimeSpan CoolDownTime=new TimeSpan(0,0,1);
		public const int WM_DEVICECHANGE = 0x219;
		public const int DBT_DEVICEARRIVAL = 0x8000;
		public const int DBT_DEVICEQUERYREMOVE = 0x8001;
		public const int DBT_DEVICEQUERYREMOVEFAILED = 0x8002;
		public const int DBT_DEVICEREMOVECOMPLETE = 0x8004;
		public const int DBT_DEVICEREMOVEPENDING = 0x8003;
		protected override void WndProc(ref Message m)
		{
			
			if (m.Msg == WM_DEVICECHANGE)
			{
				/*if (DateTime.Now - LastTime <= CoolDownTime)
				{
					//MessageBox.Show("Test");
					base.WndProc(ref m);
					Console.WriteLine("Need to Cool Down .");
					return;
				}*/
				//MessageBox.Show("Test2");
				//Console.WriteLine("Running");
				LastTime = DateTime.Now;
				switch (m.WParam.ToInt32())
				{
					case DBT_DEVICEARRIVAL:
						try
						{
							if (!Program.Settings.UMgr_Enabled)break;

							DriveInfo[] s = DriveInfo.GetDrives();
							foreach (DriveInfo drive in s)
							{
								if (drive.DriveType == DriveType.Removable)
								{
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
						}
						catch
						{

						}
									break;
					case DBT_DEVICEQUERYREMOVE:
						break;
					case DBT_DEVICEQUERYREMOVEFAILED:
						break;
					case DBT_DEVICEREMOVECOMPLETE:
						break;
					case DBT_DEVICEREMOVEPENDING:
						break;
					default:
						break;
				}
			}
			base.WndProc(ref m);
		}
		public TrayWindow()
		{
			InitializeComponent();
			this.Disposed += new EventHandler(TrayWindow_FormClosed);
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			//MessageBox.Show(Environment.CurrentDirectory);
			this.Hide();
			this.BackgroundImage = null;
			timer1.Dispose();
			timer2.Dispose();
			titleLabel1.Dispose();
			titleLabel2.Dispose();
			titleLabel3.Dispose();
			GC.Collect();
		
			if (Program.FirstUse)
			{
				this.Tray.BalloonTipText = "您可以拖动悬浮球和桌面小工具,我们将记住它的位置\r\n班级助手仍在后台运行,单击托盘区的图标来打开主界面";
				Tray.BalloonTipTitle = "班级助手";
				Tray.BalloonTipIcon = ToolTipIcon.Info;
				Tray.ShowBalloonTip(7);
			}
		}

		private async void TrayWindow_Shown(object sender, EventArgs e)
		{
			/*delegate x=() =>
			{
				string s = Application.ExecutablePath;
				Environment.CurrentDirectory = s.Substring(0, s.Length - 19);
				Program.Helper = new System.Diagnostics.ProcessStartInfo();
				Program.Helper.FileName = Environment.CurrentDirectory + "CRHBackstageHelper.exe";
				return true;
			};*/
			timer2.Start();
			await Task.Run(() =>
			{
				Core.preLoad();
				//Program.Settings.
			});
			if (Program.FirstUse)
			{
				using (var oobe = new OOBE())
				{
					oobe.ShowDialog();
				}
			}
			await Task.Run(() =>
			{
				Core.postLoad();
				//Program.Settings.
			});
			if (Program.Settings.ShowHelperWindow)
			{
				Program.ShowingHelperWindow = true;
				Program.HelperWindow.Show();

			}
			if (Program.Settings.DesktopTool_AutoShow)
			{
				Program.ShowingDesktopTool = true;
				Program.Widget.Show();
			}
			Timer1_Tick(null, null);
			//timer1?.Start();
		}
		
		/*private Task LoadApp()
		{
			return Task.Run(()=>
			{
				Core.Load();
				//Program.Settings.
			});
		}*/
		

		public void Tray_MouseClick(object sender, MouseEventArgs e)
		{
			if (Program.MainForm == null)
			{
				Program.MainForm = new MainForm();
				Program.MainForm.Show();
				Program.MainForm.Activate();
			}
			else
			{
				Program.MainForm.Close();
				Program.MainForm = null;
				//GC.Collect();
				//FreeMemory.ClearMemory();
			}
			
		}

		private void TrayWindow_FormClosing(object sender, FormClosingEventArgs e)
		{

		}

		private void TrayWindow_FormClosed(object sender, EventArgs e)
		{
			Core.SendExitMessage();
		}

		private void Timer2_Tick(object sender, EventArgs e)
		{
			if(Opacity>=0.1)
				this.Opacity -= 0.03;
		}

		private void TrayWindow_Load(object sender, EventArgs e)
		{

		}
	}
}
