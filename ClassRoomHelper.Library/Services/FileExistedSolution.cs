using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomHelper.Library.Services
{
	public enum FileExistedSolution
	{
		Skip,Cover,Copy
	}
	public static class FileExistedSolutionEx
	{
		public static string ToArg(this FileExistedSolution mode)
		{
			switch (mode)
			{
				case FileExistedSolution.Copy:
					return "copy";
				case FileExistedSolution.Cover:
					return "cover";
				case FileExistedSolution.Skip:
					return "skip";
				default:
					return "";
			}
		}
	}
}
