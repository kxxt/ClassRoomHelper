using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomHelper.Library.Poll
{
	public class Idea
	{
		public bool UpVote(string student)
		{
			if (StudentInfo.ContainsKey(student))
			{
				if (StudentInfo[student])
				{
					return false;
				}
				else
				{
					StudentInfo[student] = true;
					Votes++;
					return true;
				}
			}
			StudentInfo.Add(student, true);
			Votes++;
			return true;
		}
		public bool DownVote(string student)
		{
			if (StudentInfo.ContainsKey(student))
			{
				if (StudentInfo[student])
				{
					StudentInfo[student] = false;
					Votes--;
					return true;
				}
				else
				{
					
					return false;
				}
			}
			return false;
		}
		Dictionary<string, bool> StudentInfo;
		string Desp;
		int Votes;
		public Idea()
		{
			Desp = "未命名";
			Votes = 0;
			StudentInfo = new Dictionary<string, bool>();
		}
	}
}
