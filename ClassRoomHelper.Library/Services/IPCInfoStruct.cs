using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ClassRoomHelper.Library;

namespace ClassRoomHelper.Library.Services
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct IPCInfoStruct
	{
		//[Flags]
		//[MarshalAs(UnmanagedType.I8)]
		public int FileExistedSolution;
		//[MarshalAs(UnmanagedType.ByValTStr,SizeConst =256)]
		//public  Char[305] Target;
		//[MarshalAs(UnmanagedType.I8)]
		public int CollectMode;
		//[MarshalAs(UnmanagedType.I8)]
		public int WorkingState;
	}
}
