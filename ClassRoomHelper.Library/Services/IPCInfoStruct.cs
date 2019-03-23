namespace ClassRoomHelper.Library.Services
{
	//[StructLayout(LayoutKind.Sequential)]
	public struct IPCInfoStruct
	{
		//[Flags]
		public int ResortMode;
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
