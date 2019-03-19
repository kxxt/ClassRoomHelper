using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassRoomHelper.Library.Services;
using ClassRoomHelper.Library;
using System.IO;

namespace ClassRoomHelper
{
	public  class Core
	{
		public static void StartService()
		{
			if (!Directory.Exists(Program.Settings.TargetDir))
			{
				Program.Settings.TargetDir = new DirectoryInfo(Environment.CurrentDirectory).CreateSubdirectory("Files").FullName;
				MessageBox.Show("您所指定的保存目录不存在,\r\n已自动为您将保存目录重置为程序目录下Files文件夹 .\r\n您可以到\"设置\"中更改 .","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
				Program.Settings.Save();
			}
			string mode = Program.Settings.CollectMode.ToArg();
			string existedsl = Program.Settings.FileExistedSolution.ToArg();
			Program.Helper.Arguments = mode+" \""+Program.Settings.TargetDir+"\" "+existedsl;
			if (Program.Settings.DebugEnabled) Program.Helper.WindowStyle = ProcessWindowStyle.Normal;
			Process.Start(Program.Helper);
			//Process.Start("explorer",Program.Settings.TargetDir);
		}
		public static void StartCensorService()
		{
			//if(Program.Settings.FirstUse)
			Program.IsCensorServiceRunning = true;
			AppDetector.Initilize();
			AppDetector.Start();
			AppDetector.ProcessStarted += new System.Management.EventArrivedEventHandler((_,__)=>
			{
				try
				{
					StartService();
				}catch(Exception ex)
				{
					Log.AppendException("logs\\bgservice.start",ex);
				}
			});
		}
		public static void LoadProperties()
		{
			string s = Application.ExecutablePath;
			Environment.CurrentDirectory = s.Substring(0, s.Length - 19);
			Program.Helper = new System.Diagnostics.ProcessStartInfo();
			Program.Helper.FileName = Environment.CurrentDirectory + "\\CRHBackstageHelper.exe";
			Program.Helper.CreateNoWindow = true;
			Program.Helper.UseShellExecute = true;
			Program.Helper.WorkingDirectory = Environment.CurrentDirectory;
			Program.Helper.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
		}
		public static  void Load()
		{
			LoadProperties();
			try
			{
				StartCensorService();

			}catch(System.Management.ManagementException ex)
			{
				MessageBox.Show(Log.GetExceptionInfo(ex));
			}
			Thread.Sleep(1000);
			Program.Settings = new Properties.Settings();
		}
	}
}
