using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using Syncfusion.WinForms.Controls;

namespace ClassRoomHelper.Windows
{
	public partial class SpeechWindow : SfForm
	{
		SpeechSynthesizer speech = new SpeechSynthesizer();

		public SpeechWindow()
		{
			InitializeComponent();
		}

		private void DefaultButton1_Click(object sender, EventArgs e)
		{
			speech.SpeakStarted += new EventHandler<SpeakStartedEventArgs>((_,__)=>
			{
				defaultButton3.Enabled = false;
			});
			speech.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>((_,__)=>
			{
				defaultButton3.Enabled = true;
			});
			speech.SpeakAsync(textBox1.Text);
		}

		private void DefaultButton1_Click_1(object sender, EventArgs e)
		{
			speech.SpeakAsyncCancelAll();
		}

		private void DefaultButton4_Click(object sender, EventArgs e)
		{
			try{
				var str = Clipboard.GetText();
				textBox1.Text = str;
			}
			catch
			{
				MessageBox.Show("操作失败.", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}

		private void SpeechWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			speech.Dispose();
		}
	}
}
