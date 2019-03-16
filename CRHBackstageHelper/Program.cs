using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using ClassRoomHelper.Library.Services;

namespace CRHBackstageHelper
{
	class Program
	{
		static FileExistedSolution FileExistedSolution;
		/// <summary>
		/// #1
		/// fetch-all fetch-ppt fetch-doc fetch-xls
		/// TargetDir
		/// FileExistedSolution
		/// #2
		/// 
		/// 
		/// 
		/// 
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			FileExistedSolution = FileExistedSolution.Copy;
			if (args.Length < 2) return;
			if (!Directory.Exists(args[1])) return;
			if (args.Length >= 3)
			{
				switch (args[2].Trim().ToLower())
				{
					case "copy":
						break;
					case "cover":
						FileExistedSolution = FileExistedSolution.Cover;
						break;
					case "skip":
						FileExistedSolution = FileExistedSolution.Skip;
						break;
				}
			}
			else
			{
				switch (args[0].Trim().ToLower())
				{
					case "fetch-all":
						break;
					case "fetch-ppt":
						break;
					case "fetch-xls":
						break;
					case "fetch-doc":
						break;
				}
			}
		}
		static void FetchPPT()
		{
			var r=ActiveFileController.GetPowerpoint();
			foreach(var it in r)
			{

			}
		}
		
	}
}
