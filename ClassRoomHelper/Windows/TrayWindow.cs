using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using RsWork.UI.Windows;
namespace ClassRoomHelper.Windows
{
	public partial class TrayWindow : BasicNoneBorderWinForm
	{
		public TrayWindow()
		{
			InitializeComponent();
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			//MessageBox.Show(Environment.CurrentDirectory);
			this.Hide();
			this.BackgroundImage = null;
			timer1.Dispose();
			titleLabel1.Dispose();
			titleLabel2.Dispose();
			titleLabel3.Dispose();
			GC.Collect();	
		}

		private async void TrayWindow_Shown(object sender, EventArgs e)
		{
			/*delegate x=() =>
			{
				string s = Application.ExecutablePath;
				Environment.CurrentDirectory = s.Substring(0, s.Length - 19);
				Program.Helper = new System.Diagnostics.ProcessStartInfo();
				Program.Helper.FileName = Environment.CurrentDirectory + "CRHBackstageHelper.exe";
				return true;
			};*/
			await Load();
			Timer1_Tick(null, null);
			//timer1?.Start();
		}
		
		private Task Load()
		{
			return Task.Run(()=>
			{
				string s = Application.ExecutablePath;
				Environment.CurrentDirectory = s.Substring(0, s.Length - 19);
				Program.Helper = new System.Diagnostics.ProcessStartInfo();
				Program.Helper.FileName = Environment.CurrentDirectory + "CRHBackstageHelper.exe";
				Program.Helper.CreateNoWindow = true;
				Program.Helper.UseShellExecute = true;
				Program.Helper.WorkingDirectory = Environment.CurrentDirectory;
				Program.Helper.WindowStyle=System.Diagnostics.ProcessWindowStyle.Hidden;
				Thread.Sleep(1000);
				Program.Settings = new Properties.Settings();
				//Program.Settings.
			});
		}
		private void BeginInvoke(Func<bool> p)
		{
			p();
		}

		private void Tray_MouseClick(object sender, MouseEventArgs e)
		{
			if (Program.MainForm == null)
			{
				Program.MainForm = new MainForm();
				Program.MainForm.ShowDialog();
			}
			else
			{
				Program.MainForm.Close();
				Program.MainForm = null;
				GC.Collect(2);
			}
			
		}
	}
}
