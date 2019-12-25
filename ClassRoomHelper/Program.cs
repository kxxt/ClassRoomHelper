using System;
using System.Windows.Forms;
using ClassRoomHelper.Windows;
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using ClassRoomHelper.Library.Services;
using ClassRoomHelper.Library.NameSelector;
using System.IO;
using System.Collections.Generic;

namespace ClassRoomHelper
{
	public class SingleInstanceManager : WindowsFormsApplicationBase
	{
		public TrayWindow app;
		
		public SingleInstanceManager()
		{
			this.IsSingleInstance = true;
			this.ShutdownStyle = ShutdownMode.AfterAllFormsClose;
		}

		protected override bool OnStartup(Microsoft.VisualBasic.ApplicationServices.StartupEventArgs eventArgs)
		{
			app = new TrayWindow();
			Application.Run(app);
			return false;
		}

		protected override void OnStartupNextInstance(StartupNextInstanceEventArgs eventArgs)
		{
			app.Tray_MouseClick(null,null);
			base.OnStartupNextInstance(eventArgs);
		}
	}
	static class Program
	{
		public static AForge.Video.DirectShow.FilterInfoCollection CameraInputs;
		public static System.Drawing.Font DisplayFont;
		public static System.Drawing.Text.PrivateFontCollection Fonts = new System.Drawing.Text.PrivateFontCollection();
		public const string TurnsFileName="turns.txt";
		public static OOBE OOBE;
		public static SingleInstanceManager manager;
		public static bool FirstUse=false;
		public static bool ShowingDesktopTool;
		public static bool ShowingHelperWindow;
		public static Widget Widget;
		public static HelperIm HelperWindow;
		public static NameSelector NameSelector;
		public static TargetDirParser TargetDirParser;//= new TargetDirParser("", ResortMode.Daily);
		public static SharedMemory.SharedArray<IPCInfoStruct> InfoPipe;
		public static MainForm MainForm;
		public static ProcessStartInfo Helper;
		public static Properties.Settings Settings;
		public static bool WorkAsAdministrator=false;
		public static List<DriveInfo> UDisks=new List<DriveInfo>();
		//public static bool IsCensorServiceRunning=false;
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Core.LoadProperties();
			if (args.Length == 0)
			{
				MessageBox.Show("请启动班级助手程序,而不是此程序.","提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				return;
			}
			else if (args[0].Trim().ToLower() != "app")
			{
				MessageBox.Show("请启动班级助手程序,而不是此程序.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			Fonts.AddFontFile(Environment.CurrentDirectory+"\\Fonts\\title.ttf");
			Fonts.AddFontFile(Environment.CurrentDirectory + "\\Fonts\\text.ttf");
			//DisplayFont=new System.Drawing.Font(Fonts[0],)
			try
			{
				Program.FirstUse = File.Exists("FirstRun");
				if (FirstUse)
				{
					File.Delete("FirstRun");
				}
			}
			catch
			{
				Program.FirstUse = true;
			}
			
			manager = new SingleInstanceManager();
			//bg = new BlackBackground();
			//bg.Show();
			//Application.Run(new MainFrm());
			manager.Run(new string[] { });
			if (Program.Settings == null) return;
			Program.Settings.Save();
			Core.ActionsBeforeAppExit();
		}
	}
}
