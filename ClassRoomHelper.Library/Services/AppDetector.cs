using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;

using System.Threading;
using System.Diagnostics;

namespace ClassRoomHelper.Library.Services
{
	public static  class AppDetector
	{
		public static EventArrivedEventHandler ProcessStarted;
		static ManagementEventWatcher w = null;
		public static void Initilize()
		{
			
			WqlEventQuery q;
			try
			{
				q = new WqlEventQuery("SELECT * FROM Win32_ProcessStartTrace WHERE processname = 'powerpnt.exe' OR processname = 'winword.exe' OR processname = 'excel.exe' OR processname = 'wps.exe' OR processname = 'wpp.exe' OR processname = 'et.exe'");
				//q.EventClassName = "Win32_ProcessStartTrace";
				//q.
				w = new ManagementEventWatcher(q);
				w.EventArrived += new EventArrivedEventHandler(ProcessStartEventArrived);
				//w.Start();
				//Console.ReadLine(); // block main thread for test purposes
			}
			catch(Exception e)
			{
				//todo
			}
		}
		public static void ProcessStartEventArrived(object sender, EventArrivedEventArgs e)
		{
			string name = e.NewEvent.Properties["ProcessName"].Value.ToString().ToLower();
			switch (name)
			{
				case "powerpnt.exe":
				case "winword.exe":
				case "excel.exe":
				case "wps.exe":
				case "wpp.exe":
				case "et.exe":
					ProcessStarted?.Invoke(sender, e);
					break;
			}
			//ProcessStarted?.Invoke(sender, e);
		}
		/* public static void ProcessStartEventArrived(object sender, EventArrivedEventArgs e)
		{
			foreach(var handle in ProcessStarted)
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
			
		}*/
		public static List<string> GetProcessCommandLine(int processName){
			List<string> results = new List<string>();
			string wmiQuery = string.Format("select CommandLine from Win32_Process where Name='{0}'", processName);
			using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(wmiQuery))
			{
				using (ManagementObjectCollection retObjectCollection = searcher.Get()) {
					foreach (ManagementObject retObject in retObjectCollection)
					{
						results.Add((string)retObject["CommandLine"]);
					}
				}
			}
			return results;
		}
		public static void Stop()
		{
			w.Stop();
		}
		public static void Start()
		{
			w.Start();
		}
	}
}
