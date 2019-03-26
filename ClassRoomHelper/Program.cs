using System;
using System.Windows.Forms;
using ClassRoomHelper.Windows;
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using ClassRoomHelper.Library.Services;
using ClassRoomHelper.Library.NameSelector;

namespace ClassRoomHelper
{
	public class SingleInstanceManager : WindowsFormsApplicationBase
	{
		TrayWindow app;
		
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
		public static bool ShowingDesktopTool;
		public static bool ShowingHelperWindow;
		public static Widget Widget;
		public static HelperWindow HelperWindow;
		public static NameSelector NameSelector;
		public static TargetDirParser TargetDirParser;//= new TargetDirParser("", ResortMode.Daily);
		public static SharedMemory.SharedArray<IPCInfoStruct> InfoPipe;
		public static MainForm MainForm;
		public static ProcessStartInfo Helper;
		public static Properties.Settings Settings;
		public static bool WorkAsAdministrator=false;
		//public static bool IsCensorServiceRunning=false;
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
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
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			SingleInstanceManager manager = new SingleInstanceManager();
			//bg = new BlackBackground();
			//bg.Show();
			//Application.Run(new MainFrm());
			manager.Run(new string[] { });
			Program.Settings.Save();
			Core.ActionsBeforeAppExit();
		}
	}
}
