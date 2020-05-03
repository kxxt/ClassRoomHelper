﻿using ClassRoomHelper.Windows;
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

		public static void EverythingSearch(string text)
		{
			if (!File.Exists("Tools\\Everything.exe"))
			{
				MessageBox.Show("没有找到Everything.\r\n请将Everything复制到程序目录的Tools文件夹下 , 然后重试 .","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			else
			{
				try
				{
					Process.Start("Tools\\Everything.exe",$"-filter document -s \"{text}\"");
				}
				catch
				{
					MessageBox.Show("操作失败");
				}
			}
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

		public static void BingWallpaper()
		{
			try
			{
				Process.Start("CRHBackstageHelper.exe", "wallpaperengine \"" + Program.TargetDirParser.Get_Daily() + "\"");
			}
			catch
			{
				MessageBox.Show("操作失败");
			}
		}

		internal static void OpenYear()
		{
			OpenExplorer(Program.TargetDirParser.GetYear());
			
		}

		public static void ShowFullScreenCountDownNotification()
		{
			var x = new NotificationWindow();
			x.textPre.Text = $"距 {Program.Settings.Timer_EventName} 仅剩";
			TimeSpan timeSpan = (Program.Settings.Timer_Date - System.DateTime.Now.Date);
			int days = CountdownInfoProvider.DaysRemaining;
			x.textMid.Text = $"{days}";
			x.textPost.Text = "天";
			x.img.Source = WinAPI.CaptureWallpaper();
			x.ShowDialog();
			return;
		}
	}
}
