using System;
using System.Windows.Forms;
using ClassRoomHelper.Windows;
using System.Speech.Synthesis;
using ClassRoomHelper.Library;
namespace ClassRoomHelper
{
	public partial class MainForm : RsWork.UI.Windows.BasicNoneBorderWinForm
	{
		//Configuation configuation;
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
			//Program.HelperWindow.Close();
			Program.Widget.Close();
			Application.Exit();
			Environment.Exit(0);
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
				configuationx.ShowDialog(Service.owner);
				configuationx.Dispose();
				//configuationx = null;
				//GC.Collect();
			}
			//FreeMemory.ClearMemory();
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
				x.Show(Service.owner);
			
		}

		private void SfButton4_Click(object sender, EventArgs e)
		{
			var x = new EditStudentListWindow();
			x.InitilizeNames();
			x.ShowDialog(Service.owner);
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
				Program.HelperWindow.Show(Service.owner);
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

		private void DefaultButton9_Click(object sender, EventArgs e)
		{
			
			MessageBox.Show("\"班级助手\"是我设计用来在教室电脑上使用的一套程序."+"\r\n"+
"当初, 我是为了收集并整理老师上课使用的课件才设计了这款程序."+"\r\n"+
"那时, 我还将微软 Office 365 的 OneDrive 网盘服务接入了程序, 使得新课件自动上传到网盘上, "+"\r\n"+
"不仅如此, 借助 OneIndex 项目和 Zeit 的 Serverless Hosting免费云程序托管服务, "+"\r\n"+
"我还成功建立了一个网站, 让同学们可以无需登录网盘即可访问离线的教室电脑上的所有课件."+"\r\n"+
"出于某些原因, (如云服务暴露身份, 需要 Office 365 订阅等),参赛程序不包含云服务组件."+"\r\n"+
 " 现在,将近半年过去了,它的功能也丰富了." + "\r\n" +
 "它现在不仅可以整理课件,还可以随机选同学起来回答问题," + "\r\n" +
"还可以朗读中英文段,甚至将来还可以在教室进行电子投票," + "\r\n" +
"这结束了画\"正\"字投票的时代,开辟了一条高效投票的新途径," + "\r\n" +
"大大节省了同学们的时间.","关于");
			MessageBox.Show("运行条件:" + "\r\n" +
"*Windows 7 Service Pack 1 及以上的系统" + "\r\n" +
"* 安装有.Net Framework 4.7" + "\r\n" +
"* 如需要使用课件整理功能, 需要安装有 Microsoft Office 的 2007 或更高版本" + "\r\n" +
"  未测试过非 Microsoft 办公套件(如 Google Docs, 金山 WPS, LibreOffice)是否可行" + "\r\n" +
"* 为了获得更好的使用体验, 请允许应用程序开机自启动" + "\r\n" +
"* 建议在正版的 Windows 系统上运行程序, 并使用正版 Office(绿色版 / 绿化版 不行)", "运行条件");
		}

		private void DefaultButton10_Click(object sender, EventArgs e)
		{
			//MessageBox.Show("功能暂未开放,敬请期待","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
			new Vote().ShowDialog(Service.owner);
		}
	}
}
