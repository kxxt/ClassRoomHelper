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
		///————————————————
		///版权声明：以下两个函数为CSDN博主「lxl379386901」的原创文章，遵循 CC 4.0 BY-SA 版权协议，转载请附上原文出处链接及本声明。
		///原文链接：https://blog.csdn.net/lxl379386901/article/details/47975811
		/// <summary>
		/// Alt + F4 无效化处理
		/// </summary>
		/// <param name="window">Alt + F4 要无效的窗口</param>
		/// <returns>Alt + F4 无效化处理</returns>
		/// <remarks>返回Action是方便调用处需要同时进行很多处理时+=，-=用</remarks>
		public static Action DisableAltF4(Window window)
		{
			var source = HwndSource.FromHwnd(new WindowInteropHelper(window).Handle);
			source.AddHook(DisableAltF4WndHookProc);
			return () => source.RemoveHook(DisableAltF4WndHookProc);
		}

		/// <summary>
		/// Alt + F4无效化窗口消息
		/// </summary>
		public static IntPtr DisableAltF4WndHookProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
		{
			const int WM_SYSKEYDOWN = 0x0104;
			const int VK_F4 = 0x73;

			if (msg == WM_SYSKEYDOWN && wParam.ToInt32() == VK_F4)
			{
				handled = true;
			}

			return IntPtr.Zero;
		}


	}
}
