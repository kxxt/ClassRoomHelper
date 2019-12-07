using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using AForge.Controls;
using AForge.Video.DirectShow;
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
							

							DriveInfo[] s = DriveInfo.GetDrives();
							foreach (DriveInfo drive in s)
							{
								if (drive.DriveType == DriveType.Removable)
								{
									//MessageBox.Show(drive.DriveFormat);
									string fs = drive.DriveFormat.ToLower();
									
									if (fs != "ntfs" && fs != "refs" && fs != "fat" && fs != "fat32" && fs != "exfat") continue;
									Program.UDisks.Add(drive);								
									/*if (drive.VolumeLabel == "")
									{
										drive.VolumeLabel = "U盘" + new Random().Next(1, 999).ToString();
									}*/
									if (!Program.Settings.UMgr_Enabled)
									{
										break;

									}

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
			this.Shown+=new EventHandler(CapturePicture);
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
				this.Tray.BalloonTipText = "您可以拖动桌面小工具,我们将记住它的位置\r\n班级助手仍在后台运行,单击托盘区的图标来打开主界面";
				Tray.BalloonTipTitle = "班级助手";
				Tray.BalloonTipIcon = ToolTipIcon.Info;
				Tray.ShowBalloonTip(5000);
			}
			if (Program.Settings.RecordData)
			{
				string path = Program.TargetDirParser.Get_Daily() + "\\Data\\";
				if (!Directory.Exists(path))
				{
					Directory.CreateDirectory(path);
				}
				string filename = path + "Record.data";
				if(!File.Exists(filename))
					try
					{
						TimeSpan timeSpan = (Program.Settings.Timer_Date - System.DateTime.Now.Date);
						string Text = Program.Widget.Title.Text = $"距 {Program.Settings.Timer_EventName} 还有 {(timeSpan.Hours > 0 ? timeSpan.Days + 1 : timeSpan.Days)} 天\r\n";
						File.WriteAllText(filename,Text);
					}
					catch
					{
						if (Program.Settings.DebugEnabled) throw;
					}
			}
			//Service.BingWallpaper();
		}
		public void ShowBalloonTip(string text,string title,int time=5000,ToolTipIcon icon = ToolTipIcon.Info)
		{
			this.Tray.BalloonTipText = text;
			this.Tray.BalloonTipTitle = title;
			this.Tray.BalloonTipIcon = icon;
			Tray.ShowBalloonTip(time);
		}
		private void CapturePicture(object sender, EventArgs e)
		{
			Program.CameraInputs = new FilterInfoCollection(FilterCategory.VideoInputDevice);
			if (Program.Settings.CICEnabled && Program.CameraInputs.Count > 0)
			{

				//VideoSourcePlayer videoSourcePlayer1 = new VideoSourcePlayer();
				if (Program.Settings.CICCamera + 1 > Program.CameraInputs.Count)
				{
					System.Windows.Forms.MessageBox.Show("Error!\r\nCamera Identity Out of Range .\r\nWe have reseted it to 0.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					Program.Settings.CICCamera = 0;
					Program.Settings.Save();
				}
				VideoCaptureDevice videoSource = new VideoCaptureDevice(Program.CameraInputs[Program.Settings.CICCamera].MonikerString);
				//videoSource.
				videoSource.DesiredFrameSize = new System.Drawing.Size(320, 240);
				videoSource.DesiredFrameRate = 1;
				videoSourcePlayer1.VideoSource = videoSource;
				videoSourcePlayer1.Start();
				CameraTimer.Start();
				/*Thread.Sleep(1000);
				var videoFrame = videoSourcePlayer1.GetCurrentVideoFrame();
				var Hbitmap = videoFrame.GetHbitmap();
				BitmapSource bitmapSource = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
								Hbitmap,
								IntPtr.Zero,
								 Int32Rect.Empty,
								BitmapSizeOptions.FromEmptyOptions());
				PngBitmapEncoder pE = new PngBitmapEncoder();
				pE.Frames.Add(BitmapFrame.Create(bitmapSource));
				var ImgPath = Program.TargetDirParser.Get_Daily() + "\\Data\\" ;
				if (!Directory.Exists(ImgPath))
				{
					Directory.CreateDirectory(ImgPath);
				}
				string picName = ImgPath + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss.fff") + ( Program.Settings.CICEncryptedSave?".dat":".jpg");
				if (File.Exists(picName))
				{
					File.Delete(picName);
				}
				using (Stream stream = File.Create(picName))
				{
					pE.Save(stream);
				}
				videoSourcePlayer1.SignalToStop();
				videoSourcePlayer1.WaitForStop();
				videoSourcePlayer1.Dispose();
				*/
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
			Service.owner = new WindowWrapper(Program.manager.app.Handle);
			await Task.Run(() =>
			{
				Core.preLoad();
				//Program.Settings.
			});
			if (Program.FirstUse)
			{
				Program.OOBE = new OOBE();
				
					Program.OOBE.ShowDialog();
					Program.OOBE.Dispose();
				Program.OOBE = null;
			}
			await Task.Run(() =>
			{
				Core.postLoad();
				//Program.Settings.
			});
			Service.BingWallpaper();
			//backgroundWorker1.DoWork += this.BackgroundWorker1_DoWork;
			//backgroundWorker1.RunWorkerAsync();
			Timer1_Tick(null, null);
			/*if (Program.Settings.WallpaperEngine_Enabled)
			{
				await Service.BingWallpaper();
			}*/
			
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
			
			//timer1?.Start();
		}

		/*private void BackgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			if (Program.Settings.WallpaperEngine_Enabled)
			{
				Service.BingWallpaper();
			}
		}*/

		/*private Task LoadApp()
		{
			return Task.Run(()=>
			{
				Core.Load();
				//Program.Settings.
			});
		}*/

		public void Pop(string text,string title)
		{
			Tray.BalloonTipText = text;
			Tray.BalloonTipTitle = title;
			Tray.BalloonTipIcon = ToolTipIcon.Info;
			Tray.ShowBalloonTip(20);
		}
		public void Tray_MouseClick(object sender, MouseEventArgs e)
		{
			if (Program.OOBE != null)
			{
				Program.OOBE.Activate();
				return;
			}
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
			this.titleLabel1.Font =new System.Drawing.Font( Program.Fonts.Families[0],72);
			this.titleLabel1.Left = (this.Width - titleLabel1.Width) / 2;
			
		}

		private void CameraTimer_Tick(object sender, EventArgs e)
		{
			try
			{
				var videoFrame = videoSourcePlayer1.GetCurrentVideoFrame();
				var Hbitmap = videoFrame.GetHbitmap();
				BitmapSource bitmapSource = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
								Hbitmap,
								IntPtr.Zero,
								 Int32Rect.Empty,
								BitmapSizeOptions.FromEmptyOptions());
				PngBitmapEncoder pE = new PngBitmapEncoder();
				pE.Frames.Add(BitmapFrame.Create(bitmapSource));
				var ImgPath = Program.TargetDirParser.Get_Daily() + "\\Data\\";
				if (!Directory.Exists(ImgPath))
				{
					Directory.CreateDirectory(ImgPath);
				}
				string picName = ImgPath + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss.fff") + (Program.Settings.CICEncryptedSave ? ".dat" : ".jpg");
				if (File.Exists(picName))
				{
					File.Delete(picName);
				}
				using (Stream stream = File.Create(picName))
				{
					pE.Save(stream);
				}
			}
			catch
			{
				System.Windows.Forms.MessageBox.Show("Camera not ready.\r\nPlease check your camera.", "Internal Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			videoSourcePlayer1.SignalToStop();
			videoSourcePlayer1.WaitForStop();
			videoSourcePlayer1.Dispose();
			CameraTimer.Stop();
			CameraTimer.Dispose();
		}
	}
}
