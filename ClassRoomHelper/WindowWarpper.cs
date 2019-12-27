using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Interop;
namespace ClassRoomHelper
{
	public class WindowWrapper : System.Windows.Forms.IWin32Window
	{
		public WindowWrapper(IntPtr handle)
		{
			_hwnd = handle;
		}

		public WindowWrapper(Window window)
		{
			_hwnd = new WindowInteropHelper(window).Handle;
		}
		public const short SWP_NOMOVE = 0X2;
		public const short SWP_NOSIZE = 1;
		public const short SWP_NOZORDER = 0X4;
		public const int SWP_SHOWWINDOW = 0x0040;
		public IntPtr Handle
		{
			get { return _hwnd; }
		}
		[DllImport("user32.dll", EntryPoint = "SetWindowPos")]
		public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);
		private IntPtr _hwnd;
		[DllImport("user32.dll", SetLastError = true)]
		static public extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);
		[DllImport("user32.dll", SetLastError = true)]
		static public extern IntPtr FindWindow(string lpWindowClass, string lpWindowName);
		[DllImport("user32.dll", SetLastError = true)]
		static public extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string className, string windowTitle);
		const int GWL_HWNDPARENT = -8;
		[DllImport("user32.dll")]
		static public extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
	}
}
