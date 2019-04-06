﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassRoomHelper.Windows
{
	public partial class Widget : RsWork.UI.Windows.BasicNoneBorderWinForm
	{
		public Widget()
		{
			InitializeComponent();
			this.Location = Program.Settings.DesktopToolLoc;
		}

		private void Widget_Paint(object sender, PaintEventArgs e)
		{
			if (Environment.OSVersion.Version.Major >= 6)
			{
				User32.SetWindowPos(base.Handle, 1, 0, 0, 0, 0, User32.SE_SHUTDOWN_PRIVILEGE);
			}
		}

		private void TitleLabel1_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);

		}

		private void ModernButton1_Click(object sender, EventArgs e)
		{
			Service.OpenRecently();
		}

		private void ModernButton2_Click(object sender, EventArgs e)
		{
			Service.OpenYesterDay();
		}

		private void ModernButton3_Click(object sender, EventArgs e)
		{
			Service.ChooseNameRandomly();
		}

		private void ModernButton4_Click(object sender, EventArgs e)
		{
			if (!Program.ShowingHelperWindow)
			{
				Program.ShowingHelperWindow = true;
				Program.HelperWindow.Show();
			}
			else
			{
				Program.ShowingHelperWindow = false;
				Program.HelperWindow.Hide();
			}
		}

		private void Widget_Move(object sender, EventArgs e)
		{
			Program.Settings.DesktopToolLoc = this.Location;

		}

		private void ModernButton4_Click_1(object sender, EventArgs e)
		{
			Service.Vote();
		}
	}
	internal class User32
	{
		public const int SE_SHUTDOWN_PRIVILEGE = 0x13;
		[DllImport("user32.dll")]
		public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
		[DllImport("user32.dll")]
		public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
		[DllImport("user32.dll")]
		public static extern bool SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int X, int Y, int cx,
		int cy, uint uFlags);
	}
}
