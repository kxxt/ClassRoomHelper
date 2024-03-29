﻿using ClassRoomHelper.Library;
using ClassRoomHelper.Library.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Westwind.Utilities.Configuration;

namespace ClassRoomHelper
{
	public class AppConfig : AppConfiguration
	{
		private string targetDir;
		private CollectMode collectMode;
		private string timer_EventName;
		private bool timer_Enabled;
		private DateTime timer_Date;
		public bool Ready = false;
		public void SetInitialized()
		{
			InitializeCalled = true;
		}
		public AppConfig()
		{
			TargetDir = "";
			DesktopTool_AutoShow = true;
			UMgr_Enabled = true;
			UMgr_ShowDialog = true;
			DebugLevel = DebugLevel.AllException;
			DebugEnabled = true;
			ResortMode = ResortMode.Daily;
			StartAfterWindows = false;
			FirstUse = true;
			CleanMode = CleanMode.Never;
			VoiceNameCallOut = true;
			NameCallOutPost = "同学";
			NameCallOutPre = "";
			FileExistedSolution = FileExistedSolution.Copy;
			CollectMode = CollectMode.ALL;
			HelperWindowLocation = new Point(0, 0);
			ShowHelperWindow = false;
			DesktopToolLoc = new Point(0, 0);
			Timer_EventName = "高考";
			Timer_Enabled = true;
			Timer_Date = Convert.ToDateTime("2020/7/7");
			WallpaperEngine_Enabled = true;
			WallpaperEngine_SavePicture = true;
			BugFixForSeewo = false;
			CICEnabled = true;
			CICEncryptedSave = true;
			CICCamera = 0;
			RecordData = true;
			Timer_AutoRenew = true;
			ThemeColor = Color.FromArgb(128, 128, 255);
		}
		public static void Save(AppConfig config,string fileName="crh.config")
		{
			File.WriteAllText(fileName, config.WriteAsString(),Encoding.UTF8);
		}
		public void Save(string fileName = "crh.config")
		{
			File.WriteAllText(fileName, this.WriteAsString(), Encoding.UTF8);
		}
		public static AppConfig Load(string fileName = "crh.config")
		{
			var conf = new AppConfig();
			conf.Read(File.ReadAllText(fileName, Encoding.UTF8));
			return conf;
		}
		#region Properties
		public String TargetDir { get {  return targetDir; } set { targetDir = value; OnTargetDirChanged(); } }

		private void OnTargetDirChanged()
		{
			if (!InitializeCalled||!Ready) return;
			if (Program.TargetDirParser == null) return;
			Program.TargetDirParser.Root = this.TargetDir;
			try
			{
				System.IO.File.WriteAllText(".config", this.TargetDir, System.Text.Encoding.UTF8);
			}
			catch
			{

			}
		}

		public bool DesktopTool_AutoShow { get; set; }
		public bool UMgr_Enabled { get; set; }
		public bool UMgr_ShowDialog { get; set; }
		public DebugLevel DebugLevel { get; set; }
		public bool DebugEnabled { get; set; }
		public ResortMode ResortMode { get; set; }
		public bool StartAfterWindows { get; set; }
		public bool FirstUse { get; set; }
		public CleanMode CleanMode { get; set; }
		public bool VoiceNameCallOut { get; set; }
		public string NameCallOutPre { get; set; }
		public string NameCallOutPost { get; set; }
		public FileExistedSolution FileExistedSolution { get; set; }
		public CollectMode CollectMode { get {  return collectMode; } set { collectMode = value; OnCollectModeChanged(); } }

		private void OnCollectModeChanged()
		{
			if (!InitializeCalled||!Ready) return;
			if (Program.TargetDirParser == null) return;
			Program.TargetDirParser.Mode = this.ResortMode;
		}

		public Point HelperWindowLocation { get; set; }
		public bool ShowHelperWindow { get; set; }
		public Point DesktopToolLoc { get; set; }
		public string Timer_EventName { get {  return timer_EventName; } set { timer_EventName = value; OnTimerChanged(); } }

		private void OnTimerChanged()
		{
			if (!InitializeCalled||!Ready) return;
			if (this.Timer_Enabled)
			{
				int days = CountdownInfoProvider.DaysRemaining;
				Program.Widget.Title.Text = CountdownInfoProvider.CountdownString;
				if (days <= 10 || days % 10 == 0)
				{
					Program.Widget.Title.Text += "！！！";
					Program.Widget.Title.Foreground = System.Windows.Media.Brushes.Red;
					Program.Widget.Title.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));
					//Program.Widget.Opacity = 1;
				}

				else if (days % 5 == 0)
				{
					Program.Widget.Title.Foreground = System.Windows.Media.Brushes.Yellow;
					Program.Widget.Title.Background = System.Windows.Media.Brushes.Black;
					Program.Widget.Title.Text += "！";
					//Program.Widget.Opacity = 0.6;
				}
				else
				{
					Program.Widget.Title.Foreground = System.Windows.Media.Brushes.Black;
					Program.Widget.Title.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(51, 255, 255, 255));
					//Program.Widget.Opacity = 0.6;
				}
			}
			//Program.Widget.Title.Text = $"距 {Program.Settings.Timer_EventName} 还有 {(Program.Settings.Timer_Date-System.DateTime.Now).Days } 天";
			else
				Program.Widget.Title.Text = "快捷功能";
		}

		public bool Timer_Enabled { get {  return timer_Enabled; } set { timer_Enabled = value; OnTimerChanged(); } }
		public DateTime Timer_Date { get { return timer_Date; } set { timer_Date = value; OnTimerChanged(); } }
		public bool WallpaperEngine_Enabled { get; set; }
		public bool BugFixForSeewo { get; set; }
		public bool CICEnabled { get; set; }
		public bool CICEncryptedSave { get; set; }
		public int CICCamera { get; set; }
		public bool RecordData { get; set; }
		public bool Timer_AutoRenew { get; set; }
		public bool WallpaperEngine_SavePicture { get; set; }
		public Color ThemeColor { get; set; }
		#endregion
	}
}
