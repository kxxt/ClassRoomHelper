using System;
using System.Windows.Forms;
using System.Speech.Synthesis;
using Syncfusion.WinForms.Controls;

namespace ClassRoomHelper.Windows
{
	public partial class SpeechWindow : RsWork.UI.Windows.BasicNoneBorderWinForm
	{
		string name="";
		//SpeechSynthesizer speech = new SpeechSynthesizer();
		SpeechSynthesizer speechx = new SpeechSynthesizer();
		public SpeechWindow()
		{
			InitializeComponent();
			speechx.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>((_, __) =>
			{
				MessageBox.Show("导出完成 , 已保存到桌面的 " + name, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
				name = "";
			});

		}

		private void DefaultButton1_Click(object sender, EventArgs e)
		{
			Service.speech.SpeakStarted += new EventHandler<SpeakStartedEventArgs>((_,__)=>
			{
				defaultButton3.Enabled = false;
			});
			Service.speech.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>((_,__)=>
			{
				defaultButton3.Enabled = true;
			});
			Service.speech.SpeakAsync(textBox1.Text);
		}

		private void DefaultButton1_Click_1(object sender, EventArgs e)
		{
			Service.speech.SpeakAsyncCancelAll();
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
			//speech.Dispose();
			speechx.Dispose();
			foreach(Control x in Controls)
			{
				x.Dispose();
			}
		}

		private void DefaultButton2_Click(object sender, EventArgs e)
		{
			if (name != "")
			{
				MessageBox.Show("每次只能进行一个文件的的输出 , 请等待当前文件输出结束 .","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			name = DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss") + ".wav";
			var filename = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + name;
			
			//speechx.SpeakAsyncCancelAll();
			//Thread.Sleep(1000);
			speechx.SetOutputToWaveFile(filename);
			speechx.SpeakAsync(textBox1.Text);
			
			//speechx.Dispose();
		}

		private void DefaultButton5_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
