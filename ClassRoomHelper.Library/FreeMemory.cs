using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomHelper.Library
{
	public class FreeMemory
	{
		[DllImport("kernel32.dll", EntryPoint = "SetProcessWorkingSetSize")]
		public static extern int SetProcessWorkingSetSize(IntPtr process, int minSize, int maxSize);
		public static void ClearMemory()
		{
			GC.Collect();
			GC.WaitForPendingFinalizers();
			if (Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1);
			}
		}
	}
}
