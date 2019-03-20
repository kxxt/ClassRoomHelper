using ClassRoomHelper.Library.Services;
using ClassRoomHelper.Library;
using System;
using System.IO;
using System.IO.Pipes;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace CRHBackstageHelper
{
	class Program
	{
		static void Debug(string x)
		{
			Console.WriteLine(x);
		}
		static Random rx;
		static FileExistedSolution FileExistedSolution;
		/// <summary>
		/// #1
		/// fetch-all fetch-ppt fetch-doc fetch-xls
		/// TargetDir
		/// FileExistedSolution
		/// #2
		/// server
		/// 
		/// 
		/// 
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			if (AdminChecker.IsAdministrator())
			{
				MessageBox.Show("请不要以管理员权限启动此程序", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			rx = new Random();
			FileExistedSolution = FileExistedSolution.Copy;
			if (args.Length < 2)
			{
				Server();
				return;
				/*ProcessStartInfo main = new ProcessStartInfo();
				main.Verb = "runas";
				main.FileName = "ClassRoomHelper.exe";
				var ret=Process.Start(main);
				ret.WaitForExit();
				return;*/
			};
			if (args[0].Trim().ToLower() == "serve")
			{
				Server();
				return;
			}
			Debug(args[0]);Debug(args[1]);
			if (!Directory.Exists(args[1])) return;
			if (args.Length >= 3)
			{
				Debug(args[2]);
				switch (args[2].Trim().ToLower())
				{
					case "copy":
						Debug("copy");
						break;
					case "cover":
						Debug("cover");
						FileExistedSolution = FileExistedSolution.Cover;
						break;
					case "skip":
						Debug("skip");
						FileExistedSolution = FileExistedSolution.Skip;
						break;
				}
			}
			try
			{
				switch (args[0].Trim().ToLower())
				{
					case "fetch-all":
						Debug("fetch-all");
						FetchALL(args[1]);
						break;
					case "fetch-ppt":
						Debug("fetch-ppt");
						FetchPPT(args[1]);
						break;
					case "fetch-xls":
						Debug("fetch-xls");
						FetchXLS(args[1]);
						break;
					case "fetch-doc":
						Debug("fetch-doc");
						FetchDOC(args[1]);
						break;
				}

			}catch(Exception ex)
			{
				ClassRoomHelper.Library.Log.AppendException("service.error",ex);
			}
			Console.ReadLine();
		}

		private static void Server()
		{
			SharedMemory.SharedArray<IPCInfoStruct> x = new SharedMemory.SharedArray<IPCInfoStruct>("crh-ipc");
			while (true)
			{
				IPCInfoStruct data;
				x.Read(out data,0);
				if ((WorkingState)data.WorkingState == WorkingState.ToRun)
				{
					data.WorkingState = (int)WorkingState.Idle;
					x.Write(ref data, 0);
					Debug("Message Received");
					Debug(((FileExistedSolution)data.FileExistedSolution).ToArg());
					Debug(((CollectMode)(data.CollectMode)).ToArg());
					//Debug(data.Target);
					Debug("---end---");
				}else if ((WorkingState)data.WorkingState == WorkingState.ToExit)
				{
					data.WorkingState = (int)WorkingState.Idle;
					x.Write(ref data, 0);
					Debug("Soon Exit");
					Console.ReadLine();
					Environment.Exit(0);
				}
				Thread.Sleep(1000);
			}
		}

		static void Copy((string, string) info, string tdir)
		{
			if (tdir[tdir.Length - 1] != '\\')
			{
				tdir += '\\';
			}
			var tarf = tdir + info.Item2;
			var fi = new FileInfo(tarf);
			var raw = new FileInfo(info.Item1 + "\\" + info.Item2);
			if (File.Exists(tarf) && fi.Length != raw.Length)
			{
				switch (FileExistedSolution)
				{
					case FileExistedSolution.Copy:
						var x = Directory.CreateDirectory(tdir + "文件历史 - " + info.Item2);
						int i = 1;
						for (; i <= 10086; i++)
						{
							if (!File.Exists(x.FullName + "\\" + i + "-" + info.Item2)) break;
						}
						File.Move(tarf, x.FullName + "\\" + i + "-" + info.Item2);
						File.Copy(info.Item1 + "\\" + info.Item2, x.FullName + "\\" + (i + 1) + "-" + info.Item2);
						break;
					case FileExistedSolution.Cover:
						File.Copy(info.Item1 + "\\" + info.Item2, tdir + info.Item2, true);
						break;
					case FileExistedSolution.Skip:
						break;
				}
			}
			else
			{
				File.Copy(info.Item1 + "\\" + info.Item2, tdir + info.Item2, true);
			}
		}
		static void FetchALL(string sdir)
		{
			var r = ActiveFileController.GetPowerpoint();
			r.AddRange(ActiveFileController.GetWord());
			r.AddRange(ActiveFileController.GetExcel());
			foreach (var it in r)
			{
				Debug(it.Item1 + "\\" + it.Item2);
				Copy(it, sdir);
			}
		}
		static void FetchPPT(string sdir)
		{
			var r = ActiveFileController.GetPowerpoint();
			foreach (var it in r)
			{
				Debug(it.Item1 + "\\" + it.Item2);
				Copy(it, sdir);
			}
		}
		static void FetchDOC(string sdir)
		{
			var r = ActiveFileController.GetWord();
			foreach (var it in r)
			{
				Debug(it.Item1 + "\\" + it.Item2);
				Copy(it, sdir);
			}
		}
		static void FetchXLS(string sdir)
		{
			var r = ActiveFileController.GetExcel();
			foreach (var it in r)
			{
				Debug(it.Item1 + "\\" + it.Item2);
				Copy(it, sdir);
			}
		}
	}
}
