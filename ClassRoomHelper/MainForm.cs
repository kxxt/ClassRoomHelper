using System;
using System.Windows.Forms;
using ClassRoomHelper.Windows;
using System.Speech.Synthesis;
using ClassRoomHelper.Library;
namespace ClassRoomHelper
{
	public partial class MainForm : RsWork.UI.Windows.BasicNoneBorderWinForm
	{
		Configuation configuation;
		//public SpeechSynthesizer speech=new SpeechSynthesizer();
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
			//speech.Dispose();
			this.Close();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.BackgroundImage = null;
			GC.Collect();
		}

		private void SfButton6_Click(object sender, EventArgs e)
		{
			using (var configuationx = new Configuation())
			{
				configuationx.ShowDialog();
				configuationx.Dispose();
				//configuationx = null;
				//GC.Collect();
			}
			FreeMemory.ClearMemory();
		}

		private void DefaultButton3_Click(object sender, EventArgs e)
		{
			if (!Program.ShowingDesktopTool)
			{
				Program.ShowingDesktopTool = true;
				Program.Widget.Show();
			}
			else
			{
				Program.ShowingDesktopTool = false;
				Program.Widget.Hide();
			}
		}

		private void DefaultButton2_Click(object sender, EventArgs e)
		{
			Service.ChooseNameRandomly();
			//nc.Test_AddExampleData();
			//nc.Load();

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
			GC.Collect();
		}

		private void TitleLabel1_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);

		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			if (!Program.Settings.DebugEnabled)
			{
				defaultButton8.Visible = false;
				defaultButton6.Visible = false;
			}
		}

		private void DefaultButton5_Click(object sender, EventArgs e)
		{
			Service.OpenMonth();
		}

		private void SfButton5_Click(object sender, EventArgs e)
		{
			if (!Program.ShowingHelperWindow)
			{
				Program.ShowingHelperWindow= true;
				Program.HelperWindow.Show();
			}
			else
			{
				Program.ShowingHelperWindow = false;
				Program.HelperWindow.Hide();
			}
		}

		private void DefaultButton4_Click(object sender, EventArgs e)
		{
			Service.OpenRecently();
		}
	}
}
