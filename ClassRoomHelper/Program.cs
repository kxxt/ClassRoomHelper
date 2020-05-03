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
			MessageBox.Show("班级助手已在运行中");
			app.Tray_MouseClick(null,null);
			base.OnStartupNextInstance(eventArgs);
		}
	}
	static class Program
	{
		public static AForge.Video.DirectShow.FilterInfoCollection CameraInputs;
		public static System.Drawing.Text.PrivateFontCollection Fonts = new System.Drawing.Text.PrivateFontCollection();
		public const string TurnsFileName="turns.txt";
		public static OOBEWindow OOBE;
		public static SingleInstanceManager manager;
		public static bool FirstUse=false;
		public static bool ShowingDesktopTool;
		public static bool ShowingHelperWindow;
		public static MainWindow Widget;
		//public static HelperIm HelperWindow;
		public static NameSelector NameSelector;
		public static TargetDirParser TargetDirParser;//= new TargetDirParser("", ResortMode.Daily);
		public static SharedMemory.SharedArray<IPCInfoStruct> InfoPipe;
		public static MainForm MainForm;
		public static ProcessStartInfo Helper;
		public static AppConfig Settings;
		public static bool WorkAsAdministrator=false;
		public static List<DriveInfo> UDisks=new List<DriveInfo>();
		//public static bool IsCensorServiceRunning=false;
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjQ1ODQyQDMxMzgyZTMxMmUzMEVndVBVcVEycGV6UTN6L282bHkzanZlWUZPMFhEd3JOekY3aGxISHhBWlk9;MjQ1ODQzQDMxMzgyZTMxMmUzMGNTUklMNWR0UElveVVtVFpzdWJqVm0zTytpWU83dEEzMzhjSXVDVmhTc289;MjQ1ODQ0QDMxMzgyZTMxMmUzMERITU5JZkRDRUpGVmFBRVhCYjM2dks3b2Vweko1eUQrYkVwZXZzdUdqcHc9;MjQ1ODQ1QDMxMzgyZTMxMmUzMGhGaWxZRkF1SmVXcDg3YnpvK3VOTXA2MC9pMC93VU1Tc2V0R0k5bkg2VFU9;MjQ1ODQ2QDMxMzgyZTMxMmUzMGVVYzF0VFpIemgyYkwzWTVucTNzdHd5alI2RVhGeEJZWW01a1BzM2dGQm89;MjQ1ODQ3QDMxMzgyZTMxMmUzMEZBVFlPb3F2eVlYYmZRL0s3RkNscFNsb0dHL3hmRWs4MnZxSWp5c0hWcmc9;MjQ1ODQ4QDMxMzgyZTMxMmUzMG9Jekt3MmZ2citkcnlTZlBCdFpwTEpLaFlaYmhFV1JKOE95WHF4SHdNcjA9;MjQ1ODQ5QDMxMzgyZTMxMmUzMEpZN3NTSWd1MEZ0aXJmUVJhRlJiRm9XME5yUjVpQ0FBc0RHa0daUlV0QXM9;MjQ1ODUwQDMxMzgyZTMxMmUzMEQwZlhlTmQycll3aHFoenBsVUJyY2lWS2NVcjBnWmNBNGdhd0ZBaW5RaTA9;NT8mJyc2IWhia31ifWN9Z2ZoYmF8YGJ8ampqanNiYmlmamlmanMDHmghICQ8ITgnNjA7EzwmJz88PDh9MDw+;MjQ1ODUxQDMxMzgyZTMxMmUzMERkSHZpL25mMlprWjl2c3ZxYTlPRVowTy96b2hwZUNoUWFXZGJxeDQyRTA9");
			AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//MessageBox.Show("Debug");
			Core.LoadProperties();
			//MessageBox.Show("Debug2");
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
			Fonts.AddFontFile(Environment.CurrentDirectory+ "\\Resources\\HYShangWeiShouShuW.ttf");
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

		private static void CurrentDomain_UnhandledException(object sender, System.UnhandledExceptionEventArgs e)
		{
			MessageBox.Show(RsWork.Functions.Log.Logger.GetExceptionInfo((Exception)e.ExceptionObject));
#if DEBUG
			throw (Exception)e.ExceptionObject;
#endif
		}
	}
}
