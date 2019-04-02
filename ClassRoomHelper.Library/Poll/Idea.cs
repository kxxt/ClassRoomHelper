using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomHelper.Library.Poll
{
	public class Idea
	{
		public static List<Idea> CreateIdeasFromList(List<string> list)
		{
			var ret = new List<Idea>();
			foreach(var s in list)
			{
				ret.Add(new Idea(s));
			}
			return ret;
		} 
		HashSet<string> people;
		public bool Add(string student)
		{
			if (people.Contains(student))
			{
				return false;
			}
			else
			{
				people.Add(student);
				return true;
			}
		}
		public bool Remove(string student)
		{
			if (people.Contains(student))
			{
				people.Remove(student);
				return true;
			}
			else
			{
				
				return false;
			}
		}
		
		public string GetCSVLine()
		{
			var ret=$"\"{Desp}\",{people.Count},";
			foreach(var x in people)
			{
				ret = ret + x+",";
			}
			return ret;
		}
		/*
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
		Dictionary<string, bool> StudentInfo;*/
		public string Desp;
		public int Votes { get
			{
				return people.Count;
			} }
		//int Votes;
		public Idea(string desp) {
			Desp = desp;
			people = new HashSet<string>();

		}
		public Idea()
		{
			Desp = "未命名";
			//Votes = 0;
			people = new HashSet<string>();
			//StudentInfo = new Dictionary<string, bool>();
		}
	}
}
