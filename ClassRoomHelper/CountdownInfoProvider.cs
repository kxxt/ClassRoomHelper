using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomHelper
{
	public class CountdownInfoProvider
	{
		public static int DaysRemaining { get
			{
				TimeSpan timeSpan = (Program.Settings.Timer_Date - System.DateTime.Now.Date);
				int days = (timeSpan.Hours > 0 ? timeSpan.Days + 1 : timeSpan.Days);
				return days;
			} 
		}
		public static bool IsCountdownCorrect
		{
			get
			{
				TimeSpan timeSpan = (Program.Settings.Timer_Date - System.DateTime.Now.Date);
				return timeSpan > new TimeSpan();
			}
		}
		public static string Event => Program.Settings.Timer_EventName;
		public static DateTime TargetDate => Program.Settings.Timer_Date;
		public static string CountdownString
		{
			get
			{
				return $"距离 {Event} 仅剩 {DaysRemaining} 天";
			}
		}
		public static bool Mod10 => DaysRemaining % 10 == 0;
		public static bool Mod5 => DaysRemaining % 5 == 0;
		public static bool LessThan10 => DaysRemaining < 10;
	}
}
