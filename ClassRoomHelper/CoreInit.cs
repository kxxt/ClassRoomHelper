using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassRoomHelper.Library.Services;

namespace ClassRoomHelper
{
	public static class CoreInit
	{
		public static void StartCensorService()
		{
			//if(Program.Settings.FirstUse)
			Program.IsCensorServiceRunning = true;
			AppDetector.Initilize();
			AppDetector.Start();
			AppDetector.ProcessStarted += new System.Management.EventArrivedEventHandler((sender,args)=>
			{
				// TODO :
				Program.Helper.Arguments = "fetch-all ";
				Process.Start(Program.Helper);
			});
		}
		public static void LoadProperties()
		{
			string s = Application.ExecutablePath;
			Environment.CurrentDirectory = s.Substring(0, s.Length - 19);
			Program.Helper = new System.Diagnostics.ProcessStartInfo();
			Program.Helper.FileName = Environment.CurrentDirectory + "CRHBackstageHelper.exe";
			Program.Helper.CreateNoWindow = true;
			Program.Helper.UseShellExecute = true;
			Program.Helper.WorkingDirectory = Environment.CurrentDirectory;
			Program.Helper.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
		}
		public static void Load()
		{
			LoadProperties();
			StartCensorService();
			Thread.Sleep(1000);
			Program.Settings = new Properties.Settings();
		}
	}
}
