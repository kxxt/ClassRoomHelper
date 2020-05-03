using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomHelper.Library
{
	public class ExamInfo
	{
		string _category;
		List<SpecialMomentInfo> _preExamSpecialMomentInfos;
		DateTime _beginTime;
		DateTime _endTime;
		List<SpecialMomentInfo> _specialMomentInfos;

		public string Category { get => _category; set => _category = value; }
		public List<SpecialMomentInfo> PreExamSpecialMomentInfos { get => _preExamSpecialMomentInfos; set => _preExamSpecialMomentInfos = value; }
		public DateTime BeginTime { get => _beginTime; set => _beginTime = value; }
		public DateTime EndTime { get => _endTime; set => _endTime = value; }
		public List<SpecialMomentInfo> SpecialMomentInfos { get => _specialMomentInfos; set => _specialMomentInfos = value; }

		public ExamInfo()
		{
			PreExamSpecialMomentInfos = new List<SpecialMomentInfo>();
			SpecialMomentInfos = new List<SpecialMomentInfo>();
		}
		public static ExamInfo operator +(ExamInfo examTimeInfo,SpecialMomentInfo specialMomentInfo)
		{
			examTimeInfo.AddSpecialMoment(specialMomentInfo);
			return examTimeInfo;
		}

		public void AddSpecialMoment(SpecialMomentInfo specialMomentInfo)
		{
			this.SpecialMomentInfos.Add(specialMomentInfo);
		}
		public void AddPreExamSpecialMoment(SpecialMomentInfo specialMomentInfo)
		{
			this.PreExamSpecialMomentInfos.Add(specialMomentInfo);
		}

	}
}
