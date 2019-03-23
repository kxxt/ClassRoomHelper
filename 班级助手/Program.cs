using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using ClassRoomHelper;
using ClassRoomHelper.Library;
using System.ComponentModel;
using ClassRoomHelper.Library.Services;

namespace 班级助手
{
	class Program
	{
		static ProcessStartInfo main = new ProcessStartInfo();
		static void StartMain()
		{
			try
			{
				var x = Process.Start(main);

			}
			catch (Win32Exception ex)
			{
				//if(ex.HResult==)
				var re = MessageBox.Show("程序启动失败 , 下次启动时 ,\r\n 请在弹出的窗口中允许程序以管理员身份运行\r\n单击\"确定\"以重启应用程序,单击\"取消\"退出程序.", "错误", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
				if (re == DialogResult.OK)
				{
					Main(null);
					return;
				}
				else
				{
					return;
				}
			}
		}
		static void Main(string[] args)
		{
			if(args.Length==0)
			if (AdminChecker.IsAdministrator())
			{
				MessageBox.Show("请不要以管理员权限启动此程序","提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
				return;
			}
			
			//main.Verb = "runas";
			main.FileName = "ClassRoomHelper.exe";
			main.Arguments = "app";
			ProcessStartInfo sub = new ProcessStartInfo();
			sub.FileName = "CRHBackstageHelper.exe";
			sub.Arguments = "serve";

			var pp = Process.GetProcessesByName("ClassRoomHelper");
			if (pp.Length > 0)
			{
				StartMain();
				return;
			}
			//detect:
			var px = Process.GetProcessesByName("CRHBackstageHelper");
			if (px.Length > 0)
			{
				SharedMemory.SharedArray<IPCInfoStruct> x = new SharedMemory.SharedArray<IPCInfoStruct>("crh-ipc");
				IPCInfoStruct data;
				data.WorkingState = (int)WorkingState.ToExit;
				data.CollectMode = 0;
				data.ResortMode = 0;
				data.FileExistedSolution = 0;
				x.Write(ref data, 0);
				x.Dispose();
				//goto detect;
			}
			//MessageBox.Show("Finished");
			StartMain();
			Thread.Sleep(5000);
			Process.Start(sub);
		}
	}
}
