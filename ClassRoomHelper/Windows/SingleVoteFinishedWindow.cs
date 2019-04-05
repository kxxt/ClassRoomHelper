using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassRoomHelper.Library.Poll;

namespace ClassRoomHelper.Windows
{
	public partial class SingleVoteFinishedWindow : Form
	{
		List<Idea> Ideas;
		List<string> Voters;
		public SingleVoteFinishedWindow()
		{
			InitializeComponent();
		}

		private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		public void LoadData(List<Idea> ideas, List<string> voters)
		{
			Ideas = ideas;
			
			Voters = voters;
			Ideas.Sort();
			for(int i = 0; i < Ideas.Count; i++)
			{
				string voter = "";
				foreach(var p in Ideas[i].People)
				{
					voter += p+",";
					
				}
				int cur=data.Rows.Add();
				data.Rows[cur].SetValues(new [] {Ideas[i].Desp,Ideas[i].Votes.ToString(),voter});
			}
			//throw new NotImplementedException();
		}

		private void DefaultButton2_Click(object sender, EventArgs e)
		{
			int prev = -1,order=0,giveupid=-1;
			Service.speech.SpeakAsyncCancelAll();
			for(int i=0; i < Ideas.Count; i++)
			{
				if (Ideas[i].Desp == "弃权")
				{
					giveupid = i;
					continue;
				}
				if (Ideas[i].Votes == prev)
				{
					Service.Speak($"并列第{order}名是{Ideas[i].Desp} , 共计{Ideas[i].Votes}票.");
				}
				else
				{
					order++;
					Service.Speak($"第{order}名是{Ideas[i].Desp} , 共计{Ideas[i].Votes}票.");
				}
				prev = Ideas[i].Votes;
			}
			if (giveupid >= 0&& Ideas[giveupid].Votes>0)
			Service.Speak($"另外 , 有{Ideas[giveupid].Votes}人弃权.");
		}

		private void DefaultButton1_Click(object sender, EventArgs e)
		{
			string csv = Idea.GetCSVHead() + "\r\n";
			Ideas.ForEach(x => { csv += x.GetCSVLine(); });
			string fn = "投票结果-" + DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss")+".csv";
			try
			{
				File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\" + fn, csv,Encoding.UTF8);
			}
			catch
			{
				MessageBox.Show("保存失败","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			MessageBox.Show($"保存成功 ,\r\n已保存在桌面的{fn} .","保存",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
	}
}
