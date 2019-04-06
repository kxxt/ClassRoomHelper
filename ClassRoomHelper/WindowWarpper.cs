using System;
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

		public IntPtr Handle
		{
			get { return _hwnd; }
		}

		private IntPtr _hwnd;
	}
}
