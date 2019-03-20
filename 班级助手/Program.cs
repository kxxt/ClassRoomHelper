using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassRoomHelper;
using ClassRoomHelper.Library;

namespace 班级助手
{
	class Program
	{
		static void Main(string[] args)
		{
			
			if (AdminChecker.IsAdministrator())
			{
				MessageBox.Show("请不要以管理员权限启动此程序","提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
				return;
			}
			ProcessStartInfo main = new ProcessStartInfo();
			main.Verb = "runas";
			main.FileName = "ClassRoomHelper.exe";
			ProcessStartInfo sub = new ProcessStartInfo();
			sub.FileName = "CRHBackstageHelper.exe";
			sub.Arguments = "service";
			Process.Start(main);
			Process.Start(sub);
		}
	}
}
