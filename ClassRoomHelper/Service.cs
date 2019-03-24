using ClassRoomHelper.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Speech.Synthesis;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassRoomHelper
{
	public static class Service
	{
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
	}
}
