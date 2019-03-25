using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomHelper.Library.Services
{
	public class TargetDirParser
	{
		string root;
		ResortMode mode;

		public string Root { get => this.root; set => this.root = value; }
		public ResortMode Mode { get => this.mode; set => this.mode = value; }

		public TargetDirParser(string root,ResortMode mode)
		{
			this.Root = root;
			this.Mode = mode;
		}
		private string ChineseNumber(int x)
		{
			switch (x)
			{
				case 1:return "一";
				case 2:return "二";
				case 3:return "三";
				case 4:return "四";
				case 5:return "五";
				default:return "未知";
			}
		}
		public string Get_Weekly()
		{
			return Get_Monthly()
				+"\\"+"第"+ChineseNumber((int)Math.Ceiling(DateTime.Now.Day/7.0))+"周";
		}
		public string Get_Monthly()
		{
			return Root + "\\" + DateTime.Now.ToString("yyyy") + "年"
				+ "\\" + DateTime.Now.Month + "月";
		}
		public string Get_Daily()
		{
			return Get_Monthly()
				+ "\\"+DateTime.Now.ToString("dd");

		}
		public string Get_AmPmSeparated()
		{
			return Get_Daily()
				+"\\"+(DateTime.Now.Hour<=12?"上午":"下午");
		}
		public string Get()
		{
			switch (Mode) {
				case ResortMode.AmPmSeparated:
					return Get_AmPmSeparated();
				case ResortMode.Daily:
					return Get_Daily();
				case ResortMode.Weekly:
					return Get_Weekly();
				case ResortMode.Monthly:
					return Get_Monthly();
				default:return null;
			}
		}
	}
}
