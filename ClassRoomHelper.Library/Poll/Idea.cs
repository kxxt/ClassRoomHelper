using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomHelper.Library.Poll
{
	public class Idea:IComparable<Idea>
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
		public static bool operator <(Idea i1,Idea i2)
		{
			return i1.Votes < i2.Votes;
		}
		public static bool operator ==(Idea i1, Idea i2)
		{
			return i1.Votes == i2.Votes;
		}
		public static bool operator !=(Idea i1, Idea i2)
		{
			return i1.Votes != i2.Votes;
		}
		public static bool operator >(Idea i1, Idea i2)
		{
			return i2.Votes < i1.Votes;
		}
		public HashSet<string> People;
		public bool Add(string student)
		{
			if (People.Contains(student))
			{
				return false;
			}
			else
			{
				People.Add(student);
				return true;
			}
		}
		public bool Remove(string student)
		{
			if (People.Contains(student))
			{
				People.Remove(student);
				return true;
			}
			else
			{
				
				return false;
			}
		}
		public static string GetCSVHead()
		{
			return "选项,票数,投票人,";
		}
		public string GetCSVLine()
		{
			var ret=$"\"{Desp}\",{People.Count},";
			foreach(var x in People)
			{
				ret = ret + x+",";
			}
			return ret+"\r\n";
		}

		public int CompareTo(Idea other)
		{
			if (this.Votes > other.Votes)
				return -1;
			else if (this.Votes == other.Votes)
				return 0;
			else
				return 1;
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
				return People.Count;
			} }
		//int Votes;
		public Idea(string desp) {
			Desp = desp;
			People = new HashSet<string>();

		}
		public Idea()
		{
			Desp = "未命名";
			//Votes = 0;
			People = new HashSet<string>();
			//StudentInfo = new Dictionary<string, bool>();
		}
	}
}
