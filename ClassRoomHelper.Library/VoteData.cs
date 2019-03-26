using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassRoomHelper.Library.NameSelector;
namespace ClassRoomHelper.Library
{
	public struct VotePersonInfo{
		short RemainingVotingCount;
		short Weight;
	}
	public class VoteData:IDisposable
	{
		public Dictionary<string, (VotePersonInfo,Dictionary<string,short>)> Data;
		private List<string> TableReflexes;
		
		public string TableHead;
		private void BuildHead(){
			TableHead="姓名";
			for(int i=0;i<TableReflexes.Count;i++){
				TableHead+=$",{TableReflexes[i]}";
			}
			TableHead+=Environment.NewLine;
		}
		public void PrivilegedVote(string student,string classname,int weight){
			Data[student].Value[classname].Value+=weight;

		}
		private string BuildInfoPiece(KeyValuePair<string, (VotePersonInfo,Dictionary<string,short>)> info){
			string ret="";
			ret+=info.Key+",";
			for(int i=0;i<=TableReflexes.Count;i++){
				ret=ret+info.Value.item2[TableReflexes[i]].Value.ToString()+",";
			}
		}
		public void ExportCSV(string filename){
			string csv="";
			BuildHead();
			foreach(var data in Data){
				csv=csv+BuildInfoPiece(data)+"\r\n";
			}
		}

		public bool Vote(string actor,string student,string classname,int weight){
			
			if(Data[actor].Value.Item1.RemainingVotingCount>0){
				Data[actor].Value.Item1.RemainingVotingCount--;
				Data[student].Value[classname].Value+=weight;
				return true;
			}else{
				return false;
			}
			
		}
		public void AddSelectionClass(string classname){
			foreach(var item in Data){
				item.Value.Add(classname,0);
			}
			TableReflexes.Add(classname);
		}
		public void Initilize(NameSelector.NameSelector ns,short votingcnt)
		{
			TableReflexes=new List<string>();
			foreach(var item in ns.Names){
				var data=new (VotePersonInfo,Dictionary<string,short>)();
				data.Item1.RemainingVotingCount=votingcnt;
				Data.Add(item,data );
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
