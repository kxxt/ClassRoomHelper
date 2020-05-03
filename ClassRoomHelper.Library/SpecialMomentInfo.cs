using System;

namespace ClassRoomHelper.Library
{
	public class SpecialMomentInfo
	{
		DateTime time;
		string displayName;
		string action;

		public DateTime Time { get => time; set => time = value; }
		public string DisplayName { get => displayName; set => displayName = value; }
		public string Action { get => action; set => action = value; }

		public void SetTimeBeforeExamBegin(ExamInfo exam,int min)
		{
			Time = exam.BeginTime - new TimeSpan(0, min, 0);
		}
		public void SetTimeBeforeExamEnd(ExamInfo exam,int min)
		{
			Time = exam.EndTime - new TimeSpan(0, min, 0);
		}
	}
}