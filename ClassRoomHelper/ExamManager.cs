using ClassRoomHelper.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomHelper
{
	public static class ExamManager
	{
		private static ExamInfo current = null;

		public static ExamInfo Current { get => current; set => current = value; }
		public static void ActionExecutor(string action,string param)
		{
			switch (action)
			{
				case "read-exam-rules":
					break;
				case "read-hand-out-form":
					break;
				case "read-hand-out-papers":
					break;
				case "read-exam-begin":
					break;
				case "read-exam-end":
					break;
				case "read-exam-preend":
					break;
				default:
					break;
			}
		}
		public static void RunExam(ExamInfo exam)
		{

		}
		public static void StopExam()
		{

		}
	}
}
