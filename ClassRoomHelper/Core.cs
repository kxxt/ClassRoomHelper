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
using System.Management;

namespace ClassRoomHelper
{
	public  class Core
	{
		public static void StartService(CollectMode mode)
		{
			if (!Directory.Exists(Program.Settings.TargetDir))
			{
				Program.Settings.TargetDir = new DirectoryInfo(Environment.CurrentDirectory).CreateSubdirectory("Files").FullName;
				MessageBox.Show("您所指定的保存目录不存在,\r\n已自动为您将保存目录重置为程序目录下Files文件夹 .\r\n您可以到\"设置\"中更改 .","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
				Program.Settings.Save();
			}
			string modex = mode.ToArg();
			string existedsl = Program.Settings.FileExistedSolution.ToArg();
			Program.Helper.Arguments = modex+" \""+Program.Settings.TargetDir+"\" "+existedsl+" force-admin-run";
			if (Program.Settings.DebugEnabled) Program.Helper.WindowStyle = ProcessWindowStyle.Normal;
			try
			{
				Process.Start(Program.Helper);

			}
			catch(Exception ex)
			{
				Log.AppendException("Logs\\bgservice.starterr",ex);
			}
			//Process.Start("explorer",Program.Settings.TargetDir);
		}
		public static void ConfigureSharedMemory()
		{
			// 0 : Working State
			// 1 :
			Program.InfoPipe = new SharedMemory.SharedArray<IPCInfoStruct>("crh-ipc",1);
		}
		/// <summary>
		/// With Admin
		/// </summary>
		/// <param name="mode"></param>
		public static void ServiceWayOne(CollectMode mode)
		{
			MessageBox.Show("WayOne");
			StartService(mode);
		}
		static DateTime lastrun=new DateTime(1900,1,1);
		static TimeSpan timeSpan = new TimeSpan(0, 0, 1);
		/// <summary>
		/// Without Admin
		/// </summary>
		/// <param name="mode"></param>
		public static void ServiceWayTwo(CollectMode mode)
		{
			if (DateTime.Now - lastrun < timeSpan)
			{
				return;
			}
			else
			{
				lastrun = DateTime.Now;
			}
			MessageBox.Show("WayTwo");
			try
			{
				var ps = Process.GetProcessesByName("CRHBackstageHelper");
				if (ps.Length <= 0)
				{
					Log.Append("Logs\\bgservice.hang.err",DateTime.Now+" Service Not Found .\r\n");
				}
				else
				{
					IPCInfoStruct data;
					data.WorkingState = (int)WorkingState.ToRun;
					//data.Target = "M:\\投稿用途";
					data.CollectMode = (int)mode;
					data.FileExistedSolution = (int)Program.Settings.FileExistedSolution;
					File.WriteAllText(".target",Program.Settings.TargetDir);
					Program.InfoPipe.Write(ref data, 0);
				}
			}
			catch(Exception ex)
			{
				Log.AppendException("Logs\\service.without.err",ex);
			}
		}
		public static void ServiceHook(object sender,EventArrivedEventArgs e)
		{
			try
			{
				var ppt = Process.GetProcessesByName("powerpnt");
				if (ppt.Length > 0)
				{
					if (ppt[0].IsAdminGroupMember())
					{
						ServiceWayOne(CollectMode.PPT);
					}
				}
				else
				{
					ServiceWayTwo(CollectMode.PPT);
				}
				if (Program.Settings.CollectMode == CollectMode.PPT) return;
				var word = Process.GetProcessesByName("winword");
				var excel = Process.GetProcessesByName("excel");
				if (word.Length > 0)
				{
					if (word[0].IsAdminGroupMember())
					{
						ServiceWayOne(CollectMode.DOC);
					}
				}
				else
				{
					ServiceWayTwo(CollectMode.DOC);
				}
				if (excel.Length > 0)
				{
					if (excel[0].IsAdminGroupMember())
					{
						ServiceWayOne(CollectMode.XLS);
					}
				}
				else
				{
					ServiceWayTwo(CollectMode.XLS);
				}
				//StartService();
			}
			catch (Exception ex)
			{
				Log.AppendException("logs\\bgservice.start", ex);
			}
		}
		public static void StartCensorService()
		{
			//if(Program.Settings.FirstUse)
			Program.IsCensorServiceRunning = true;
			AppDetector.Initilize();
			AppDetector.Start();
			AppDetector.ProcessStarted += new System.Management.EventArrivedEventHandler(ServiceHook);
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
			ConfigureSharedMemory();
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
