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
		}

		private void Widget_Paint(object sender, PaintEventArgs e)
		{
			if (Environment.OSVersion.Version.Major >= 6)
			{
				User32.SetWindowPos(base.Handle, 1, 0, 0, 0, 0, User32.SE_SHUTDOWN_PRIVILEGE);
			}
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
