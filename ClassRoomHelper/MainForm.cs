using System;
using System.Windows.Forms;
using ClassRoomHelper.Windows;
using System.Speech.Synthesis;

namespace ClassRoomHelper
{
	public partial class MainForm : RsWork.UI.Windows.BasicNoneBorderWinForm
	{
		SpeechSynthesizer speech=new SpeechSynthesizer();
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
			Application.Exit();
			//Environment.Exit(0);
		}

		private void DefaultButton6_Click(object sender, EventArgs e)
		{
			new Windows.DebugForm().Show();
		}

		private void DefaultButton1_Click(object sender, EventArgs e)
		{
			speech.Dispose();
			this.Close();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.BackgroundImage = null;
			GC.Collect();
		}

		private void SfButton6_Click(object sender, EventArgs e)
		{
			var x = new Configuation();
				x.ShowDialog();
			x.Dispose();
			GC.Collect(3);
		}

		private void DefaultButton3_Click(object sender, EventArgs e)
		{

		}

		private void DefaultButton2_Click(object sender, EventArgs e)
		{
			
			//nc.Test_AddExampleData();
			//nc.Load();
			var t = Program.NameSelector.ChooseRandomly();
			if (t == null)
			{
				MessageBox.Show("没有可用的学生信息");
				return;
			}
			if (Properties.Settings.Default.VoiceNameCallOut)
			{
				//var speech = new SpeechSynthesizer();
				speech.SpeakAsync(Program.Settings.NameCallOutPre+t+Program.Settings.NameCallOutPost);
				//speech.Dispose();
				//GC.Collect();
			}
		}

		private void DefaultButton7_Click(object sender, EventArgs e)
		{
			var x = new SpeechWindow();
				x.Show();
			
		}

		private void SfButton4_Click(object sender, EventArgs e)
		{
			var x = new EditStudentListWindow();
			x.ShowDialog();
			x.Dispose();
		}

		private void DefaultButton8_Click(object sender, EventArgs e)
		{
			GC.Collect(3);
		}
	}
}
