using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomHelper.Library
{
	public class VoteData:IDisposable
	{
		public Dictionary<string, Dictionary<string,short>> Data;
		public void Initilize()
		{

		}

		public void Dispose()
		{
			if (Data != null)
			{
				Data = null;
				GC.Collect();
			}
		}
	}
}
