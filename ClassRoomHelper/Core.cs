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
using Microsoft.Win32;
using TaskScheduler;
using ClassRoomHelper.Windows;

namespace ClassRoomHelper
{
	public  class Core
	{
		internal static void SetUp()
		{
			TryRemoveStartUpCompletely();
			if (Program.WorkAsAdministrator)
			{
				try
				{
					Core.SetStartUp();
					Program.Settings.StartAfterWindows = true;
				}
				catch
				{
					MessageBox.Show("失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
					Program.Settings.StartAfterWindows = false;
					TryRemoveStartUpCompletely();
				}
			}
			else
			{
				try
				{
					Core.SetSkipUAC();
					Core.SetStartByTaskSch();
					Program.Settings.StartAfterWindows = true;
				}
				catch
				{
					MessageBox.Show("失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
					TryRemoveStartUpCompletely();
				}
			}
		}
		#region StartUp
		public static void RemoveSkipUAC()
		{
			try
			{
				var scheduler = new TaskScheduler.TaskScheduler();
				scheduler.Connect();
				//var task = scheduler.GetFolder("\\").GetTask("ClassRoomHelperSkipUAC");
				scheduler.GetFolder("\\").DeleteTask("ClassRoomHelperSkipUAC", 0);
			}
			catch
			{

			}
			
		}
		public static void RemoveStartByTaskSch()
		{
			try
			{
				var scheduler = new TaskScheduler.TaskScheduler();
				scheduler.Connect();
				//var task = scheduler.GetFolder("\\").GetTask("ClassRoomHelperSkipUAC");
				scheduler.GetFolder("\\").DeleteTask("ClassRoomHelperStartUp", 0);
			}
			catch
			{

			}
		}
		public static void SetStartByTaskSch()
		{
			var scheduler = new TaskScheduler.TaskScheduler();
			scheduler.Connect(); //连接, 还有一些登录参数可选.
			var task = scheduler.NewTask(0); //官方文档上, 这个参数后面加了注释reserved.
			task.RegistrationInfo.Author = "班级助手";
			task.RegistrationInfo.Description = "班级助手";
			task.Settings.Enabled = true; //or false, 开关.
										  //在启动的时候执行, 一开始只写了Logon, 不过发现开机的时候登录并没有触发.
										  //task.Triggers.Create(_TASK_TRIGGER_TYPE2.TASK_TRIGGER_BOOT);
										  //注销后登录什么的.
			task.Triggers.Create(_TASK_TRIGGER_TYPE2.TASK_TRIGGER_LOGON);
			var action = task.Actions.Create(_TASK_ACTION_TYPE.TASK_ACTION_EXEC) as IExecAction;
			//上面的Triggers.Create也会像Actions.Create一样分别返回类型为IBootTrigger, ILogonTrigger的对象(自己as或者强制转换一下).
			//可以做更多设置.
			//这里就是设置为用户能达到的最高权限.
			task.Principal.RunLevel = _TASK_RUNLEVEL.TASK_RUNLEVEL_LUA;
			action.Path = Environment.CurrentDirectory + "\\班级助手.exe"; //需要启动的程序路径.
			action.WorkingDirectory = Environment.CurrentDirectory;
			action.Arguments = "autorun"; //参数.
			var folder = scheduler.GetFolder(@"\"); //这里是Task的根文件夹, 还可以用folder.CreateFolder来创建自己的目录.
													//注册任务. 这里的TASK_LOGON_INTERACTIVE_TOKEN就是说使用用户当前的登录信息(如果已经登录).
			folder.RegisterTaskDefinition("ClassRoomHelperStartUp", task, (int)_TASK_CREATION.TASK_CREATE_OR_UPDATE, null, null, _TASK_LOGON_TYPE.TASK_LOGON_INTERACTIVE_TOKEN);		
		}
		public static void SetStartByTaskSchAdmin()
		{
			var scheduler = new TaskScheduler.TaskScheduler();
			scheduler.Connect(); //连接, 还有一些登录参数可选.
			//if(scheduler.GetFolder("\\").GetTask())
			var task = scheduler.NewTask(0); //官方文档上, 这个参数后面加了注释reserved.
			task.RegistrationInfo.Author = "班级助手";
			task.RegistrationInfo.Description = "班级助手";
			task.Settings.Enabled = true; //or false, 开关.
										  //在启动的时候执行, 一开始只写了Logon, 不过发现开机的时候登录并没有触发.
										  //task.Triggers.Create(_TASK_TRIGGER_TYPE2.TASK_TRIGGER_BOOT);
										  //注销后登录什么的.
			task.Triggers.Create(_TASK_TRIGGER_TYPE2.TASK_TRIGGER_LOGON);
			var action = task.Actions.Create(_TASK_ACTION_TYPE.TASK_ACTION_EXEC) as IExecAction;
			//上面的Triggers.Create也会像Actions.Create一样分别返回类型为IBootTrigger, ILogonTrigger的对象(自己as或者强制转换一下).
			//可以做更多设置.
			//这里就是设置为用户能达到的最高权限.
			task.Principal.RunLevel = _TASK_RUNLEVEL.TASK_RUNLEVEL_HIGHEST;
			action.Path = Environment.CurrentDirectory + "\\班级助手.exe"; //需要启动的程序路径.
			action.WorkingDirectory = Environment.CurrentDirectory;
			//action.Arguments = "autorun"; //参数.
			var folder = scheduler.GetFolder(@"\"); //这里是Task的根文件夹, 还可以用folder.CreateFolder来创建自己的目录.
													//注册任务. 这里的TASK_LOGON_INTERACTIVE_TOKEN就是说使用用户当前的登录信息(如果已经登录).
			folder.RegisterTaskDefinition("ClassRoomHelperStartUp", task, (int)_TASK_CREATION.TASK_CREATE_OR_UPDATE, null, null, _TASK_LOGON_TYPE.TASK_LOGON_INTERACTIVE_TOKEN);
		}
		internal static void ActionsBeforeAppExit()
        {
           try{
			   File.Delete("AdminMode");
		   }catch{

		   }
			
        }

        public static void SetSkipUAC()
		{
				var scheduler = new TaskScheduler.TaskScheduler();
				scheduler.Connect(); //连接, 还有一些登录参数可选.
				var task = scheduler.NewTask(0); //官方文档上, 这个参数后面加了注释reserved.
				task.RegistrationInfo.Author = "班级助手";
				task.RegistrationInfo.Description = "班级助手跳过UAC";
				task.Settings.Enabled = true; //or false, 开关.
											  //在启动的时候执行, 一开始只写了Logon, 不过发现开机的时候登录并没有触发.
											  //task.Triggers.Create(_TASK_TRIGGER_TYPE2.TASK_TRIGGER_BOOT);
											  //注销后登录什么的.
				task.Triggers.Create(_TASK_TRIGGER_TYPE2.TASK_TRIGGER_LOGON);
				var action = task.Actions.Create(_TASK_ACTION_TYPE.TASK_ACTION_EXEC) as IExecAction;
				//上面的Triggers.Create也会像Actions.Create一样分别返回类型为IBootTrigger, ILogonTrigger的对象(自己as或者强制转换一下).
				//可以做更多设置.
				//这里就是设置为用户能达到的最高权限.
				task.Principal.RunLevel = _TASK_RUNLEVEL.TASK_RUNLEVEL_HIGHEST;
				action.Path = Environment.CurrentDirectory + "\\班级助手.exe"; //需要启动的程序路径.
				action.WorkingDirectory = Environment.CurrentDirectory;
				action.Arguments = "skipuac"; //参数.
				var folder = scheduler.GetFolder(@"\"); //这里是Task的根文件夹, 还可以用folder.CreateFolder来创建自己的目录.
														//注册任务. 这里的TASK_LOGON_INTERACTIVE_TOKEN就是说使用用户当前的登录信息(如果已经登录).
				folder.RegisterTaskDefinition("ClassRoomHelperSkipUAC", task, (int)_TASK_CREATION.TASK_CREATE_OR_UPDATE, null, null, _TASK_LOGON_TYPE.TASK_LOGON_INTERACTIVE_TOKEN);
				//注册成功, 删除注册表内的启动项, 这里的SetRegister是我自己写的, 替换掉即可.
				//SetRegistry(dir, “Pacgen”, null);
		}
		public static void RemoveStartup()
		{
			//if (!CheckStartup()) { MessageBox.Show("Not Start Up"); return; };
			File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + "班级助手.lnk");
		}
		public static bool CheckStartup()
		{
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + "班级助手.lnk")) return true;
			else return false;
		}
		public static void SetStartUp()
		{
			//if (CheckStartup()) { MessageBox.Show("Start Up");return; };
			var Startup = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
			//MessageBox.Show(Startup);
			IWshRuntimeLibrary.WshShell wsh= new IWshRuntimeLibrary.WshShell();
			IWshRuntimeLibrary.IWshShortcut shortcut = wsh.CreateShortcut(
			Startup + "\\班级助手.lnk") as IWshRuntimeLibrary.IWshShortcut;
			shortcut.Arguments = "";
			shortcut.TargetPath = Environment.CurrentDirectory+"\\班级助手.exe";
			// not sure about what this is for
			//shortcut.WindowStyle = 1;
			shortcut.Description = "班级助手";
			
			shortcut.WindowStyle =(int) IWshRuntimeLibrary.WshWindowStyle.WshNormalFocus;
			shortcut.WorkingDirectory = Environment.CurrentDirectory;
			shortcut.Save();
		}
		public static void RemoveAutoRun()
		{
			RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

			if (CheckAutoRun())
				// Remove the value from the registry so that the application doesn't start
				rkApp.DeleteValue("ClassRoomHelper", false);
		}
		public static bool CheckAutoRun()
		{
			// The path to the key where Windows looks for startup applications
			RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

			if (rkApp.GetValue("ClassRoomHelper") == null)
				// The value doesn't exist, the application is not set to run at startup
				return false;
			else
				// The value exists, the application is set to run at startup
				return true;
		}
		public static void SetAutoRun()
		{
			RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

			if (!CheckAutoRun())
				// Add the value in the registry so that the application runs at startup
				rkApp.SetValue("ClassRoomHelper", Environment.CurrentDirectory+"\\"+"班级助手.exe");
		}
		#endregion
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
			Program.Helper.Arguments = modex+" \""+Program.TargetDirParser.Get()+"\" "+existedsl;
			//if (Program.Settings.DebugEnabled) Program.Helper.WindowStyle = ProcessWindowStyle.Normal;
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
			//MessageBox.Show("WayOne");
			StartService(mode);
		}
		static DateTime lastrun=new DateTime(1900,1,1);
		static TimeSpan timeSpan = new TimeSpan(0, 0, 1);
		public static void SendMessage(CollectMode collectMode,ResortMode? resortMode=null,FileExistedSolution? fileExistedSolution=null)
		{
			if (fileExistedSolution == null) fileExistedSolution = Program.Settings.FileExistedSolution;
			if (resortMode == null) resortMode = Program.Settings.ResortMode;
			IPCInfoStruct data;
			Program.InfoPipe.Read(out data, 0);
			if (data.WorkingState == (int)WorkingState.InvalidTargetDir)
			{
				OnTargetDirInvalid();
			}
			data.WorkingState = (int)WorkingState.ToRun;

			data.CollectMode = (int)collectMode;
			data.ResortMode = (int)resortMode;
			data.FileExistedSolution = (int)fileExistedSolution;
			//File.WriteAllText(".target", Program.Settings.TargetDir);
			Program.InfoPipe.Write(ref data, 0);
		}

		private static void OnTargetDirInvalid()
		{
			//throw new NotImplementedException();
			Program.manager.app.Pop("工作目录无效 , 这可能是由于你选择了U盘作为工作目录,而现在拔出了U盘.\r\n已重置为班级助手目录下的\"Files\"目录 .\r\n如有需要,请前往设置更改 .", "班级助手");
			//MessageBox.Show("工作目录无效 , 这可能是由于你选择了U盘作为工作目录,而现在拔出了U盘.\r\n已重置为班级助手目录下的\"Files\"目录 .\r\n如有需要,请前往设置更改 .","班级助手",MessageBoxButtons.OK,MessageBoxIcon.Information);
			Program.Settings.TargetDir = Environment.CurrentDirectory + "\\Files";
			Program.Settings.Save();
			try
			{
				File.WriteAllText(".config", Program.Settings.TargetDir,Encoding.UTF8);
			}
			catch(Exception ex)
			{
				MessageBox.Show("重置失败","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
				Log.AppendException("Logs\\workdir.reset.err",ex);
			}
		}

		public static void SendExitMessage()
		{
			IPCInfoStruct data;
			data.WorkingState = (int)WorkingState.ToExit;
			data.CollectMode = 0;
			data.ResortMode = 0;
			data.FileExistedSolution = 0;
			Program.InfoPipe.Write(ref data, 0);
		}
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
			SendMessage(mode);
			//MessageBox.Show("WayTwo");
			/*try
			{
				var ps = Process.GetProcessesByName("CRHBackstageHelper");
				if (ps.Length <= 0)
				{
					Log.Append("Logs\\bgservice.hang.err",DateTime.Now+" Service Not Found .\r\n");
				}
				else
				{
					
				}
			}
			catch(Exception ex)
			{
				Log.AppendException("Logs\\service.without.err",ex);
			}*/
		}
		public static void RecoverDefaultSettings()
		{
			Program.Settings.FirstUse = true;
			Program.Settings.DebugEnabled = false;
			Program.Settings.CollectMode = CollectMode.ALL;
			Program.Settings.TargetDir = Environment.CurrentDirectory + "\\Files";
			Program.Settings.ResortMode = ResortMode.Daily;
			Program.Settings.FileExistedSolution = FileExistedSolution.Copy;
			Program.Settings.ShowHelperWindow = true;
			Program.Settings.UMgr_Enabled = true;
			Program.Settings.UMgr_ShowDialog = true;
			Program.Settings.VoiceNameCallOut = true;
			Program.Settings.NameCallOutPre = "";
			Program.Settings.NameCallOutPost = "同学,请回答问题";
			Program.Settings.HelperWindowLocation = new System.Drawing.Point(200, 200);
			Program.Settings.DesktopTool_AutoShow = true;
			Program.Settings.Save();
		}
		public static void ServiceHook(object sender,EventArrivedEventArgs e)
		{
			Thread.Sleep(3000);
			try
			{
				if (Program.Settings.CollectMode == CollectMode.PPT)
				{
					if(Program.WorkAsAdministrator)ServiceWayOne(CollectMode.PPT);
					ServiceWayTwo(CollectMode.PPT);
				}
				else
				{
					if(Program.WorkAsAdministrator)ServiceWayOne(CollectMode.ALL);
					ServiceWayTwo(CollectMode.ALL);
				}
			}
			catch (Exception ex)
			{
				Log.AppendException("logs\\bgservice.start", ex);
			}
		}
		public static void StartCensorService()
		{
			//if(Program.Settings.FirstUse)
			//Program.IsCensorServiceRunning = true;
			AppDetector.Initilize();
			AppDetector.Start();
			AppDetector.ProcessStarted += new System.Management.EventArrivedEventHandler(ServiceHook);
		}
		public static void LoadProperties()
		{
			string s = Application.ExecutablePath;
			Environment.CurrentDirectory = s.Substring(0, s.Length - 19);
			Program.Settings = new Properties.Settings();
			if (Program.FirstUse)
			{
				//MessageBox.Show("HI");
				Core.RecoverDefaultSettings();
			}
			Program.Helper = new ProcessStartInfo();
			Program.Helper.FileName = Environment.CurrentDirectory + "\\CRHBackstageHelper.exe";
			Program.Helper.CreateNoWindow = true;
			Program.Helper.UseShellExecute = true;
			Program.Helper.WorkingDirectory = Environment.CurrentDirectory;
			Program.Helper.WindowStyle = ProcessWindowStyle.Hidden;
			Program.TargetDirParser = new TargetDirParser(Program.Settings.TargetDir, Program.Settings.ResortMode);
			Program.HelperWindow = new Windows.HelperIm();
			Program.Widget = new Windows.Widget();
			Program.ShowingHelperWindow = false;
			Program.ShowingDesktopTool = false;
		}
		public static void LoadStudentList()
		{
			Program.NameSelector = new Library.NameSelector.NameSelector();
			if (File.Exists("stulist.txt"))
			{
				try
				{
					Program.NameSelector.Load("stulist.txt");
					if (File.Exists(Program.TurnsFileName))
					{
						Program.NameSelector.ReadSequence(Program.TurnsFileName);

					}
					else
					{
						Program.NameSelector.GenerateSequence(Program.TurnsFileName);
						Program.NameSelector.ReadSequence(Program.TurnsFileName);

					}
				}
				catch 
				{
					MessageBox.Show("学生名单加载失败","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
					throw;
				}
			}
		}
		public static void preLoad()
		{
			//AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
			LoadProperties();
			ConfigureSharedMemory();
			LoadStudentList();
			try
			{
				Program.WorkAsAdministrator = File.Exists("AdminMode");
			}
			catch
			{
				Program.WorkAsAdministrator = false;
			}
		}

		private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
		{
			MessageBox.Show("班级助手发生严重错误 , 请尝试重启应用程序或重新安装 !","致命错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
			//throw new ExceptionW
			Environment.Exit(-1);
		}

		public static  void postLoad()
		{
			
			
			//Program.HelperWindow = new Windows.HelperWindow();
			//Program.Widget = new Windows.Widget();
			//Program.HelperWindow = new HelperWindow();
			
			
			try
			{
				StartCensorService();
				
			}catch(System.Management.ManagementException ex)
			{
				Log.AppendException("Logs\\wmi.err", ex);
				//MessageBox.Show(Log.GetExceptionInfo(ex));
			}
			Service.Speak("");
			SystemEvents.SessionEnding += SystemEvents_SessionEnding;
			Thread.Sleep(1000);
			
		}

		private static void SystemEvents_SessionEnding(object sender, SessionEndingEventArgs e)
		{
			ActionsBeforeAppExit();
			Application.Exit();
		}
		public static void TryRemoveStartUpCompletely()
		{
			try { Core.RemoveStartByTaskSch(); }
			catch { }
			try { Core.RemoveAutoRun(); }
			catch { }
			try { Core.RemoveSkipUAC(); }
			catch { }
			try { Core.RemoveStartup(); }
			catch { }
		}
	}
}
