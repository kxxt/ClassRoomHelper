using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomHelper.Library.Services
{
	public enum CollectMode
	{
		PPT=1,DOC=2,XLS=3,ALL=4
	}
	public static class CollectModeEx
	{
		public static string ToArg(this CollectMode mode)
		{
			switch (mode)
			{
				case CollectMode.ALL:
					return "fetch-all";
				case CollectMode.PPT:
					return "fetch-ppt";
				case CollectMode.DOC:
					return "fetch-doc";
				case CollectMode.XLS:
					return "fetch-xls";
				default:
					return "";
			}
		}
	}
}
