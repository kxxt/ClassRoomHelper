﻿using ClassRoomHelper.Library.Services;
using ClassRoomHelper.Library;
using System;
using System.IO;
using System.IO.Pipes;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;

namespace CRHBackstageHelper
{
	public class Program
	{
		static bool inited;
		static TargetDirParser targetdp;
		static void Debug(object x)
		{
			Console.WriteLine(x);
		}
	
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
		public static async Task<int> Main(string[] args)
		{
			AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(FatalError);

			if (args.Length < 2)
			{
				
				{
					Server();
				}
				return 0;
				/*ProcessStartInfo main = new ProcessStartInfo();
				main.Verb = "runas";
				main.FileName = "ClassRoomHelper.exe";
				var ret=Process.Start(main);
				ret.WaitForExit();
				return;*/
			};
			if (args.Length==2&&args[0].Trim() == "wallpaperengine")
			{
				await WallPaperEngine(args[1]);
				return 0;
			}
			
			if (args[0].Trim().ToLower() == "serve")
			{
				Server();
				return 0;
			}

			init();
			targetdp.Root = args[1];
			Debug(args[0]);Debug(args[1]);
			if (!Directory.Exists(args[1]))
			{
				try
				{
					Directory.CreateDirectory(args[1]);
				}
				catch
				{
					return 0;
				}
			} 
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
			/*if (args.Length >= 4)
			{
				if (args[3] != "force-admin-run")
				{
					if (AdminChecker.IsAdministrator())
					{
						//MessageBox.Show("请不要以管理员权限启动此程序", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return 0;
					}
				}
			}
			else {
				if (AdminChecker.IsAdministrator())
				{
					//MessageBox.Show("请不要以管理员权限启动此程序", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return 0;
				}
			}*/
			int retrycnt = 3;
			retry:
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
				if (retrycnt > 0) {
					retrycnt--;
					goto retry;
				}
				Log.AppendException("Logs\\service.error",ex);
			}
			// 
			//Console.ReadLine();
			return 0;
			//
		}

		private async static Task<bool> WallPaperEngine(string v)
		{
			if (!Directory.Exists(v))
			{
				try
				{
					Directory.CreateDirectory(v);
				}
				catch
				{
					return false;
				}
			}
			v=v+ "\\" + DateTime.Now.ToString("yyyy-MM-dd") + ".jpg";
			if (File.Exists(v))
			{
				try
				{
					ClassRoomHelper.Library.WallpaperEngine.Set(Image.FromFile(v), ClassRoomHelper.Library.WallpaperEngine.Style.Stretched);
					return true;
				}
				catch
				{
					return false;
				}
			}
			
			bool success = false;
			for(int i = 0; i <= 10; i++)
			{
				try
				{
					await ClassRoomHelper.Library.WallpaperEngine.DownLoadWallpaper(v);
					success = true;
					break;
				}
				catch
				{
					Thread.Sleep(3000);
				}
			}
			if(success)
				try
				{
					ClassRoomHelper.Library.WallpaperEngine.Set(Image.FromFile(v), ClassRoomHelper.Library.WallpaperEngine.Style.Stretched);
					return true;
				}
				catch
				{
					return false;
				}

			return success;
		}

		private static void FatalError(object sender, UnhandledExceptionEventArgs e)
		{
			Log.AppendException("service-fatal-error.log", (Exception)e.ExceptionObject);
			//MessageBox.Show()
			throw (Exception)e.ExceptionObject;
		}

		public static void init()
		{
			FileExistedSolution = FileExistedSolution.Copy;
			targetdp = new TargetDirParser("", ResortMode.Daily);
		}
		public  static int Server()
		{
			if (!inited)
			{
				inited = true;
				init();
			}
			Debug("Sever Started");
			SharedMemory.SharedArray<IPCInfoStruct> x = null;
			try
			{
				x	 = new SharedMemory.SharedArray<IPCInfoStruct>("crh-ipc");

			}
			catch
			{
				Debug("HOST NOT FOUND");
				//Log.AppendException("Logs\\service.host-not-found",ex);
				return -1;
			}
			while (true)
			{
				IPCInfoStruct data;
				x.Read(out data,0);
				if ((WorkingState)data.WorkingState == WorkingState.ToRun)
				{
					data.WorkingState = (int)WorkingState.Idle;
					//MessageBox.Show("M Rev ed");
					Debug("Message Received");
					Debug("- Raw Message -");
					Debug(data.FileExistedSolution);
					Debug(data.CollectMode);
					Debug(((FileExistedSolution)data.FileExistedSolution).ToArg());
					Debug(((CollectMode)(data.CollectMode)).ToArg());
					//Debug(data.Target);
					Debug("---end---");
					var cm = (CollectMode)(data.CollectMode);
					targetdp.Mode = (ResortMode)data.ResortMode;
					
					FileExistedSolution = (FileExistedSolution)data.FileExistedSolution;
					string dir;
					try
					{
						targetdp.Root = File.ReadAllText(".config",System.Text.Encoding.UTF8);
						dir = targetdp.Get();
						if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
					}catch(Exception ex)
					{
						Log.AppendException("Logs\\serviceserver.err", ex);
						data.WorkingState = (int)WorkingState.InvalidTargetDir;
						x.Write(ref data, 0);
						continue;
					}
					try
					{
						switch (cm)
						{
							case CollectMode.ALL:
								FetchALL(dir);
								break;
							case CollectMode.DOC:
								FetchDOC(dir);
								break;
							case CollectMode.PPT:
								FetchPPT(dir);
								break;
							case CollectMode.XLS:
								FetchXLS(dir);
								break;
						}
					}catch(Exception ex)
					{
						Log.AppendException("Logs\\fetch.service.err", ex);
					}
					GC.Collect(2);
				}else if ((WorkingState)data.WorkingState == WorkingState.ToExit)
				{
					data.WorkingState = (int)WorkingState.Idle;
					x.Write(ref data, 0);
					Debug("Soon Exit");
					//Console.ReadLine();
					Environment.Exit(0);
				}
				x.Write(ref data, 0);
				Thread.Sleep(1000);
			}
			
		}

		static void Copy((string, string) info, string tdir,bool searchCommonFoldersIfFileNotFound=true,string optionalPrefix="")
		{
			//todo
			//Log.Append("debug.log",$"File Found : {info.Item1 + "\\" + info.Item2}");
			if (String.IsNullOrEmpty(tdir))
			{
				Debug("Empty Target Dir");
				return;
			}
			if (!File.Exists(info.Item1 + "\\" + info.Item2))
			{
				// 文件未保存或u盘已拔出
				Debug("File Not Found");
				if (!File.Exists("CommonFolders.txt")||!searchCommonFoldersIfFileNotFound)
				{
					return;
				}
				else
				{
					List<string> list;
					try
					{
						list=File.ReadAllLines("CommonFolders.txt", System.Text.Encoding.UTF8).ToList();
						list.ForEach(x => {
							x.Trim();
							if (!Directory.Exists(x))
							{
								Log.Append("Logs\\service.configerr", $"Folder \"{x}\" Not Found\n");
								list.Remove(x);
							}
						});
						
					}
					catch
					{
						Debug("COMMON Folders List Failed to load");
						Log.Append("Logs\\service.configerr", "COMMON Folders List Failed to load");
						return;
					}
					if (list != null)
					{
						list.ForEach(x =>
						{
							if (x.EndsWith("\\"))
							{
								x=x.Remove(x.Length - 1);
							}
							Copy((x, info.Item2), tdir, false,"[已还原]");
						});
					}
				}
				return;
			}
			if (tdir[tdir.Length - 1] != '\\')
			{
				tdir += '\\';
			}
			var tarf = tdir +optionalPrefix+ info.Item2;
			var fi = new FileInfo(tarf);
			var raw = new FileInfo(info.Item1 + "\\" + info.Item2);
			var rdir= tdir + "文件历史 - " + info.Item2;
			if (Directory.Exists(rdir))
			{
				//MessageBox.Show("Fuck");
				var di = new DirectoryInfo(rdir);
				bool repeated = false;
				foreach(var file in di.GetFiles())
				{
					if (file.Length == raw.Length)
					{
						repeated = true;
						Debug("Ignoring"+info.Item1+"\\"+info.Item2);
						break;
					}
				}
				if (!repeated)
				{
					int i = 1;
					for (; i <= 10086; i++)
					{
						if (!File.Exists(rdir+ "\\" + i + "-" + info.Item2)) break;
					}
					//File.Move(tarf, rdir+ "\\" + i + "-" + info.Item2);
					File.Copy(info.Item1 + "\\" + info.Item2, rdir + "\\" + i + "-" + info.Item2);
					
				}
				return;
			}
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
						File.Copy(info.Item1 + "\\" + info.Item2, tarf, true);
						break;
					case FileExistedSolution.Skip:
						break;
				}
			}
			else
			{
				File.Copy(info.Item1 + "\\" + info.Item2, tarf, true);
			}
		}
		static void FetchALL(string sdir)
		{
			var r = LateBindingOfficeDynamic.GetPowerpoint();
			r.AddRange(LateBindingOfficeDynamic.GetWord());
			r.AddRange(LateBindingOfficeDynamic.GetExcel());
			foreach (var it in r)
			{
				Debug(it.Item1 + "\\" + it.Item2);
				if (it.Item1.Contains(targetdp.Root))
				{
					Debug("Ignoring "+it.Item1 + "\\" + it.Item2);
					continue;
				}
				Copy(it, sdir);
			}
		}
		static void FetchPPT(string sdir)
		{
			var r = LateBindingOfficeDynamic.GetPowerpoint();
			foreach (var it in r)
			{
				Debug(it.Item1 + "\\" + it.Item2);
				if (it.Item1.Contains(targetdp.Root))
				{
					Debug("Ignoring " + it.Item1 + "\\" + it.Item2);
					continue;
				}
				Copy(it, sdir);
			}
		}
		static void FetchDOC(string sdir)
		{
			var r = LateBindingOfficeDynamic.GetWord();
			foreach (var it in r)
			{
				Debug(it.Item1 + "\\" + it.Item2);
				if (it.Item1.Contains(targetdp.Root))
				{
					Debug("Ignoring " + it.Item1 + "\\" + it.Item2);
					continue;
				}
				Copy(it, sdir);
			}
		}
		static void FetchXLS(string sdir)
		{
			var r = LateBindingOfficeDynamic.GetExcel();
			foreach (var it in r)
			{
				Debug(it.Item1 + "\\" + it.Item2);
				if (it.Item1.Contains(targetdp.Root))
				{
					Debug("Ignoring " + it.Item1 + "\\" + it.Item2);
					continue;
				}
				Copy(it, sdir);
			}
		}
	}
}
