using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassRoomHelper.Library.NameSelector;
namespace ClassRoomHelper.Library
{
	public class VoteData:IDisposable
	{
		public Dictionary<string, Dictionary<string,short>> Data;
		private List<string> TableReflexes;
		public string TableHead;
		private void BuildHead(){
			TableHead="姓名";
			for(int i=0;i<TableReflexes.Count;i++){
				TableHead+=$",{TableReflexes[i]}";
			}
		}
		public void ExportCSV(string filename){
			string csv="";
			BuildHead();

		}
		public void AddSelectionClass(string classname){
			foreach(var item in Data){
				item.Value.Add(classname,0);
			}
			TableReflexes.Add(classname);
		}
		public void Initilize(NameSelector ns)
		{
			TableReflexes=new List<string>();
			foreach(var item in ns.Names){
				Data.Add(item,new Dictionary<string,short>());
			}
		}

		public void Dispose()
		{
			if (Data != null)
			{
				Data = null;
				GC.Collect();
			}
		}
	}
}
