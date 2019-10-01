using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ClassRoomHelper.Library
{
	public static class Log
	{
		public static void Append(string fn,string c)
		{
			try
			{
				File.AppendAllText(fn, c);
			}
			catch
			{
				
			}
		}
		public static void AppendException(string fn,Exception c)
		{
			Append(fn, GetExceptionInfo(c));
		}
		static public string GetExceptionInfo(Exception ex)
		{
			var message = new StringBuilder();
			message.AppendLine("Source:" + ex.Source);
			message.AppendLine("Text Info:" + ex.ToString());
			message.AppendLine("Message:" + ex.Message);
			message.AppendLine("Help Link:" + ex.HelpLink);
			//message.AppendLine("Error Code:"+ex.HResult.ToString());
			message.AppendLine("Stack Trace:" + ex.StackTrace);
			message.AppendLine("Error Function:" + ex.TargetSite);
			message.AppendLine("Error Hash Code:" + ex.GetHashCode());
			foreach (DictionaryEntry data in ex.Data)
				message.AppendLine(string.Format("Key:{0}\nValue:{1}", data.Key, data.Value));

			var iex = ex;
			while (iex.InnerException != null)
			{
				message.AppendLine("--------Inner Exception--------");
				iex = iex.InnerException;
				message.AppendLine("Source:" + iex.Source);
				message.AppendLine("Text Info:" + iex.ToString());
				message.AppendLine("Message:" + iex.Message);
				message.AppendLine("Help Link:" + iex.HelpLink);
				//message.AppendLine("Error Code:" + iex.HResult.ToString());
				message.AppendLine("Stack Trace:" + iex.StackTrace);
				message.AppendLine("Error Function:" + iex.TargetSite);
				message.AppendLine("Error Hash Code:" + iex.GetHashCode());
				foreach (DictionaryEntry data in ex.Data)
					message.AppendLine(string.Format("Key:{0}\nValue:{1}", data.Key, data.Value));

			}
			return message.ToString();
		}
		
	}
}
