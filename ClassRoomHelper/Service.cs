using ClassRoomHelper.Windows;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using ClassRoomHelper.Library.Services;
using System.Text;
using System.Speech.Synthesis;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace ClassRoomHelper
{
	public static class Service
	{
		public static IWin32Window owner=null;
		public static void Vote()
		{
			//if (owner == null) owner = new WindowWrapper(Program.manager.app.Handle);
			new Vote().ShowDialog(owner);
		}
		static Service(){
			explorer=new ProcessStartInfo("explorer");

		}
		//static Dictionary<string, int> it = new Dictionary<string, int>();
		private static ProcessStartInfo explorer;
		public static SpeechSynthesizer speech = new SpeechSynthesizer();
		public static void Speak(string info)
		{
			speech.SpeakAsync(info);
		}

		public static void ChooseNameRandomly()
		{
			
			var t = Program.NameSelector.NextPerson(Program.TurnsFileName);
			if (t == null)
			{
				MessageBox.Show("没有可用的学生信息");
				return;
			}
			//if (it.ContainsKey(t)) it[t]++;
			//else it.Add(t, 1);
			if (Program.Settings.VoiceNameCallOut)
			{
				if (Program.Settings.NameCallOutPre == null) Program.Settings.NameCallOutPre = "";
				if (Program.Settings.NameCallOutPost == null) Program.Settings.NameCallOutPost = "";
				//var speech = new SpeechSynthesizer();
				speech.SpeakAsync(Program.Settings.NameCallOutPre + t + Program.Settings.NameCallOutPost);
				//speech.Dispose();
				//GC.Collect();
			}
			//if (owner == null) owner = new WindowWrapper(Program.manager.app.Handle);
			var x = new NameSelectedWindow(t);
			x.ShowDialog(owner);
			x.Dispose();
			x = null;
			string ret="";
			/*foreach(var xx in it)
			{
				ret += xx.Key + " " + xx.Value+"\r\n";
			}
			File.WriteAllText("test.txt",ret);
			//GC.Collect();
			*/
		}

		internal static void OpenYesterDay()
		{
			switch (Program.Settings.ResortMode)
			{
				case ResortMode.AmPmSeparated:
				case ResortMode.Daily:
					OpenExplorer(Program.TargetDirParser.Get_Yesterday());
					break;
				case ResortMode.Weekly:
					MessageBox.Show("由于您当前的工作模式不是按天整理,\r\n我们将为您打开本周的课件文件夹", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
					OpenWeek();
					break;
				case ResortMode.Monthly:
					MessageBox.Show("由于您当前的工作模式不是按天整理,\r\n我们将为您打开本月的课件文件夹","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
					OpenWeek();
					break;
			}
		}

		public static void OpenRecently(){
			OpenExplorer(Program.TargetDirParser.Get());
		}
		public static void OpenWeek(){
			if(Program.Settings.ResortMode==ResortMode.Monthly){
				MessageBox.Show("您现在处于按月整理模式，我们将为您打开本月的课件文件夹。","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);

				OpenExplorer(Program.TargetDirParser.Get_Monthly());
			}else if(Program.Settings.ResortMode==ResortMode.Daily){
				MessageBox.Show("您现在处于按天整理模式，我们将为您打开本月的课件文件夹。","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);

				OpenExplorer(Program.TargetDirParser.Get_Monthly());
			}
			else if(Program.Settings.ResortMode==ResortMode.AmPmSeparated){
				MessageBox.Show("您现在处于按每天上下午整理模式，我们将为您打开本月的课件文件夹。","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);

				OpenExplorer(Program.TargetDirParser.Get_Monthly());
			}else
				OpenExplorer(Program.TargetDirParser.Get_Weekly());
		}
		public static void OpenMonth(){
			OpenExplorer(Program.TargetDirParser.Get_Monthly());
		}
		public static void OpenToday(){
			if(Program.Settings.ResortMode==ResortMode.Monthly){
				MessageBox.Show("您现在处于按月整理模式，我们将为您打开本月的课件文件夹。","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
				OpenExplorer(Program.TargetDirParser.Get_Monthly());
			}else if(Program.Settings.ResortMode==ResortMode.Weekly){
				MessageBox.Show("您现在处于按周整理模式，我们将为您打开本周的课件文件夹。","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
				OpenExplorer(Program.TargetDirParser.Get_Monthly());
				
			}else 
			OpenExplorer(Program.TargetDirParser.Get_Daily());
		}
		public static void OpenExplorer(string dir){
			
			if(!Directory.Exists(dir)){
				try{
					Directory.CreateDirectory(dir);

				}catch{
					MessageBox.Show("操作失败。","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
			try{
				explorer.Arguments=dir;
				Process.Start(explorer);
			}catch{
				MessageBox.Show("操作失败。","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}

		public async static Task BingWallpaper()
		{
			var path = Program.TargetDirParser.Get_Daily() + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + ".jpg";

			if (File.Exists(path)) {
				Library.WallpaperEngine.Set(Image.FromFile(path), Library.WallpaperEngine.Style.Stretched);

				return;
			}
			
			for(int i=0;i<=4;i++)
			try
			{
				await Library.WallpaperEngine.DownLoadWallpaper(path);
				break;
			}
			catch
			{
					Thread.Sleep(3000);
					if (i == 4)
					{
						MessageBox.Show("网络连接异常 , 请检查网络连接", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
			}
			Library.WallpaperEngine.Set(Image.FromFile(path), Library.WallpaperEngine.Style.Stretched);
		}
	}
}
