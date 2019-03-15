using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using Word = Microsoft.Office.Interop.Word;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ClassRoomHelper.Library.Services
{
	public static class ActiveFileController
	{
		public static List<string> GetWord()
		{
			List<string> ret=new List<string>();
			object oMissing = System.Reflection.Missing.Value;
			Word.Application winObj = (Word.Application)Marshal.GetActiveObject("Word.Application");
			//winObj.Documents.Save(true,Word.WdOriginalFormat.wdOriginalDocumentFormat);
			foreach(Word.Document x in winObj.Documents)
			{
				ret.Add(x.Path);
			}
			return ret;
		}
	}
}