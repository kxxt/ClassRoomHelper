using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassRoomHelper.Library.Services;
namespace ClassRoomHelper.Windows
{
	public partial class DebugForm : Form
	{
		public DebugForm()
		{
			InitializeComponent();
		}

		private void DefaultButton1_Click(object sender, EventArgs e)
		{
			var x=ActiveFileController.GetWord();
			foreach(var a in x)
			{
				MessageBox.Show(a.Item1 + "\r\n" + a.Item2);
			}
		}

		private void DefaultButton3_Click(object sender, EventArgs e)
		{
			var x = ActiveFileController.GetExcel();
			foreach (var a in x)
			{
				MessageBox.Show(a.Item1+"\r\n"+a.Item2);
			}
		}

		private void DefaultButton2_Click(object sender, EventArgs e)
		{
			var x = ActiveFileController.GetPowerpoint();
			foreach (var a in x)
			{
				MessageBox.Show(a.Item1 + "\r\n" + a.Item2);
			}
		}

		private void DefaultButton4_Click(object sender, EventArgs e)
		{
			CSCreateLowIntegrityProcess.Tool.CreateLowIntegrityProcess("CRHBackstageHelper.exe fetch-all D:\\Sync copy");
		}

		private void DefaultButton5_Click(object sender, EventArgs e)
		{
			IPCInfoStruct data;
			data.WorkingState = (int)WorkingState.ToRun;
			//data.Target = "M:\\投稿用途";
			data.CollectMode = (int)CollectMode.ALL;
			data.FileExistedSolution =(int) FileExistedSolution.Copy;
			Program.InfoPipe.Write(ref data, 0);
		}

		private void DefaultButton6_Click(object sender, EventArgs e)
		{
			IPCInfoStruct data;
			data.WorkingState = (int)WorkingState.ToExit;
			data.CollectMode = (int)CollectMode.ALL;
			data.FileExistedSolution = (int)FileExistedSolution.Copy;
			Program.InfoPipe.Write(ref data, 0);
		}
	}
}
