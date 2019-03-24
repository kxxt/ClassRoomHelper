using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomHelper.Library.Services
{
	public static class LateBindingOffice
	{
		public static List<(string, string)> GetWord()
		{
			List<(string, string)> ret = new List<(string, string)>();
			// Get the class type and instantiate Excel.
			Type objClassType;
			objClassType = Type.GetTypeFromProgID("Word.Application");
			object oMissing = System.Reflection.Missing.Value;
			object oApp = Activator.CreateInstance(objClassType);
			
			object winObj;
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
			object docs = GetProperty(winObj, "Documents");
			int count = (int)GetProperty(docs, "Count");
			for(int i = 0; i < count; i++)
			{

			}
			//{
			//	ret.Add((x.Path, x.Name));
			//}
			return ret;
		}
		#region private Wrappers
		private static void SetProperty(object obj, string sProperty, object oValue)
		{
			object[] oParam = new object[1];
			oParam[0] = oValue;
			obj.GetType().InvokeMember(sProperty, BindingFlags.SetProperty, null, obj, oParam);
		}
		private static object GetProperty(object obj, string sProperty, object oValue)
		{
			object[] oParam = new object[1];
			oParam[0] = oValue;
			return obj.GetType().InvokeMember
				(sProperty, BindingFlags.GetProperty, null, obj, oParam);
		}
		private static object GetProperty(object obj, string sProperty, object oValue1, object oValue2)
		{
			object[] oParam = new object[2];
			oParam[0] = oValue1;
			oParam[1] = oValue2;
			return obj.GetType().InvokeMember
			(sProperty, BindingFlags.GetProperty, null, obj, oParam);
		}
		private static object GetProperty(object obj, string sProperty)
		{
			return obj.GetType().InvokeMember
			(sProperty, BindingFlags.GetProperty, null, obj, null);
		}
		private static object InvokeMethod(object obj, string sProperty, object[] oParam)
		{
			return obj.GetType().InvokeMember
			(sProperty, BindingFlags.InvokeMethod, null, obj, oParam);
		}
		private static object InvokeMethod(object obj, string sProperty, object oValue)
		{
			object[] oParam = new object[1];
			oParam[0] = oValue;
			return obj.GetType().InvokeMember
			(sProperty, BindingFlags.InvokeMethod, null, obj, oParam);
		}
		#endregion
	}
}
