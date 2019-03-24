using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomHelper.Library.Services
{
	public static class LateBindingOfficeDynamic

	{
		public static List<(string, string)> GetWord()
		{
			List<(string, string)> ret = new List<(string, string)>();
			object oMissing = System.Reflection.Missing.Value;
			dynamic winObj;
			try
			{
				winObj = Marshal.GetActiveObject("Word.Application");
			}
			catch (COMException ex)
			{
				//if ((int)0x800401E3 == -2147221021) return ret;
				if (ex.HResult != -2147221021) Log.AppendException("Logs\\officeerr.log", ex);
				return ret;
			}
			foreach (dynamic x in winObj.Documents)
			{
				//winObj.Documents.
				ret.Add((x.Path, x.Name));
			}
			return ret;
		}
		public static List<(string, string)> GetPowerpoint()
		{
			List<(string, string)> ret = new List<(string, string)>();
			object oMissing = System.Reflection.Missing.Value;
			dynamic winObj;
			try
			{
				winObj = Marshal.GetActiveObject("Powerpoint.Application");
			}
			catch (COMException ex)
			{
				//if ((int)0x800401E3 == -2147221021) return ret;
				if (ex.HResult != -2147221021) Log.AppendException("Logs\\officeerr.log", ex);
				return ret;
			}
			foreach (dynamic x in winObj.Presentations)
			{
				//winObj.Documents.
				ret.Add((x.Path, x.Name));
			}
			return ret;
		}
		public static List<(string, string)> GetExcel()
		{
			List<(string, string)> ret = new List<(string, string)>();
			object oMissing = System.Reflection.Missing.Value;
			dynamic winObj;
			try
			{
				winObj = Marshal.GetActiveObject("Excel.Application");
			}
			catch (COMException ex)
			{
				//if ((int)0x800401E3 == -2147221021) return ret;
				if (ex.HResult != -2147221021) Log.AppendException("Logs\\officeerr.log", ex);
				return ret;
			}
			foreach (dynamic x in winObj.Workbooks)
			{
				//winObj.Documents.
				ret.Add((x.Path, x.Name));
			}
			return ret;
		}
	}
}
