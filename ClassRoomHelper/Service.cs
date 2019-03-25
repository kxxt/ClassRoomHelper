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

namespace ClassRoomHelper
{
	public static class Service
	{
		static Service(){
			explorer=new ProcessStartInfo("explorer");

		}
		private static ProcessStartInfo explorer;
		public static SpeechSynthesizer speech = new SpeechSynthesizer();
		public static void ChooseNameRandomly()
		{
			var t = Program.NameSelector.ChooseRandomly();
			if (t == null)
			{
				MessageBox.Show("没有可用的学生信息");
				return;
			}
			if (Properties.Settings.Default.VoiceNameCallOut)
			{
				if (Program.Settings.NameCallOutPre == null) Program.Settings.NameCallOutPre = "";
				if (Program.Settings.NameCallOutPost == null) Program.Settings.NameCallOutPost = "";
				//var speech = new SpeechSynthesizer();
				speech.SpeakAsync(Program.Settings.NameCallOutPre + t + Program.Settings.NameCallOutPost);
				//speech.Dispose();
				//GC.Collect();
			}
			var x = new NameSelectedWindow(t);
			x.ShowDialog();
			x.Dispose();
			x = null;
			//GC.Collect();
			
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
			OpenExplorer(Program.TargetDirParser.Get_Monthly);
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
	}
}
