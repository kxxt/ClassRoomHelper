using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using LessonUploaderTray;
using RsWork.Functions.Log;

using System.Threading;
using System.Diagnostics;

namespace LessonUploaderTray
{
	public static  class AppStartDector
	{
		static ManagementEventWatcher w = null;
		public static void Initilize()
		{
			
			WqlEventQuery q;
			try
			{
				q = new WqlEventQuery();
				q.EventClassName = "Win32_ProcessStartTrace";
				w = new ManagementEventWatcher(q);
				w.EventArrived += new EventArrivedEventHandler(ProcessStartEventArrived);
				w.Start();
				//Console.ReadLine(); // block main thread for test purposes
			}
			catch(Exception e)
			{
                if(CentralSettings.DebugMode)File.AppendAllText("appdetect.errorlog", CrashHandle.GetExceptionInfo(e));
			}
		}
		public static void ProcessStartEventArrived(object sender, EventArrivedEventArgs e)
		{
			//MessageInputBox.Show("", "");
			try
			{
				string name = e.NewEvent.Properties["ProcessName"].Value.ToString().ToLower();
				switch (name)
				{
					case "powerpnt.exe":
					case "winword.exe":
					case "excel.exe":
						var COL = ActivePPTChecker.GetFile();
						foreach (var x in COL)
						{
							if (string.IsNullOrEmpty(x)) continue;
							//Console.WriteLine(x);
							Thread.Sleep(5000);
							var xin = new ProcessStartInfo("cmd.exe", "/S /C " + "LessonCopierService.exe file \""+x+"\"")
							{
								CreateNoWindow = true,
								UseShellExecute = true,
								WindowStyle = ProcessWindowStyle.Hidden
							};
							try
							{
								Process.Start(xin);
							}
							catch(Exception ex)
							{
								File.AppendAllText("service.errlog","Error Starting Service .\r\n"+Logger.GetExceptionInfo(ex));
							}
						}

						//MessageInputBox.Show("PPT Started .", "");
						break;
					
				}

			}
			catch(Exception ex)
			{
				//Console.WriteLine("Error:"+Logger.GetExceptionInfo(ex));
				//MessageInputBox.Show("Error On Event Arrival", "b");
			}
			
		}

		public static void Stop()
		{
			w.Stop();
		}
	}
}
