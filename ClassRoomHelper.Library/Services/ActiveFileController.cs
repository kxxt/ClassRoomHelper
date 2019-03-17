using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using Powerpoint = Microsoft.Office.Interop.PowerPoint;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ClassRoomHelper.Library.Services
{
	public static class ActiveFileController
	{
		public static List<(string,string)> GetWord()
		{
			List<(string, string)> ret = new List<(string, string)>();
			object oMissing = System.Reflection.Missing.Value;
			Word.Application winObj;
			try
			{
				winObj = (Word.Application)Marshal.GetActiveObject("Word.Application");
			}
			catch(COMException ex)
			{
				//if ((int)0x800401E3 == -2147221021) return ret;
				if (ex.HResult != -2147221021) Log.AppendException("Logs\\officeerr.log",ex);
				return ret;
			}
			foreach(Word.Document x in winObj.Documents)
			{
				ret.Add((x.Path,x.Name));
			}
			return ret;
		}
		public static List<(string, string)> GetPowerpoint()
		{
			var ret = new List<(string, string)>();
			object oMissing = System.Reflection.Missing.Value;
			Powerpoint.Application winObj;
			try
			{
				winObj=(Powerpoint.Application)Marshal.GetActiveObject("PowerPoint.Application");
			}
			catch (COMException ex)
			{
				//if ((int)0x800401E3 == -2147221021) return ret;
				if (ex.HResult != -2147221021) Log.AppendException("Logs\\officeerr.log", ex);
				return ret;
			}
			foreach (Powerpoint.Presentation p in winObj.Presentations)
			{
				ret.Add((p.Path,p.Name));
			}
			return ret;
		}

		public static List<(string, string)> GetExcel()
		{
			var ret = new List<(string, string)>();
			object oMissing = System.Reflection.Missing.Value;
			Excel.Application winObj;
			try
			{
				winObj = (Excel.Application)Marshal.GetActiveObject("Excel.Application");

			}
			catch (COMException ex)
			{
				//if ((int)0x800401E3 == -2147221021) return ret;
				if (ex.HResult != -2147221021) Log.AppendException("Logs\\officeerr.log", ex);
				return ret;
			}
			foreach (Excel.Workbook p in winObj.Workbooks)
			{
				ret.Add((p.Path,p.Name));
			}
			return ret;
		}
	}
}