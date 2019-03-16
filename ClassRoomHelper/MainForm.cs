using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassRoomHelper.Windows;
using ClassRoomHelper.Library.NameSelector;
using System.Speech.Synthesis;

namespace ClassRoomHelper
{
	public partial class MainForm : RsWork.UI.Windows.BasicNoneBorderWinForm
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void SfButton1_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void SfButton2_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void DefaultButton6_Click(object sender, EventArgs e)
		{
			new Windows.DebugForm().Show();
		}

		private void DefaultButton1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.BackgroundImage = null;
			GC.Collect();
		}

		private void SfButton6_Click(object sender, EventArgs e)
		{
			new Configuation().ShowDialog();
		}

		private void DefaultButton3_Click(object sender, EventArgs e)
		{

		}

		private void DefaultButton2_Click(object sender, EventArgs e)
		{
			var nc = new NameSelector();
			nc.Test_AddExampleData();
			//nc.Load();
			var t = nc.ChooseRandomly();
			if (Properties.Settings.Default.VoiceNameCallOut)
			{
				var speech = new SpeechSynthesizer();
				speech.SpeakAsync(Program.Settings.NameCallOutPre+$"{t.Item2}"+Program.Settings.NameCallOutPost);
				//speech.Dispose();
				//GC.Collect();
			}
		}
	}
}
