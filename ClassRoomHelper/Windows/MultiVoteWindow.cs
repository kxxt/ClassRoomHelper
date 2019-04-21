using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassRoomHelper.Library.Poll;

namespace ClassRoomHelper.Windows
{
	public partial class MultiVoteWindow : Form
	{
		ChoosingBoard cb;
		public bool EnableNEnough;
		public int MaxLim;
		private bool IsAlive = true;
		NameSelectedWindow NameSelectedWindow;
		public int CurrentVoterId;
		public List<Idea> Ideas;
		public List<string> GiveUppers;
		public List<string> Voters;
		Random random;

		public bool Canceled { get; private set; }

		public void DisableGivingUp()
		{
			this.modernButton1.Enabled = false;
		}
		public void RemoveCurrentVoter()
		{
			if(Voters.Count-1>=CurrentVoterId)
			Voters.RemoveAt(CurrentVoterId);
		}
		public bool ConfirmGivingUp()
		{
			var ret = MessageBox.Show($"您是否要弃权 ? \r\n, 这是您的最后修改机会 .", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Information); ;
			if (ret == DialogResult.No) return false;
			return true;

		}
		public bool ConfirmVote()
		{
			var ret = MessageBox.Show($"您已成功投票 给 \"{new NotImplementedException()}\"  , \r\n是否确认 ? \r\n这是您的最后修改机会 .", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Information); ;
			if (ret == DialogResult.No) return false;
			return true;
		}
		public bool CallPersonToVote()
		{
			if (Voters.Count > 0)
			{
				CurrentVoterId = random.Next(0, Voters.Count - 1);
				//choices.SelectedIndex = 0;
				string str = "请"+Voters[CurrentVoterId]+"进行投票";
				Service.Speak(str);
				this.VoterLabel.Text = $"当前投票人: {Voters[CurrentVoterId]}";
				NameSelectedWindow.SelectedName = Voters[CurrentVoterId];
				NameSelectedWindow.Show();
				return true;
			}
			else
			{
				return false;
			}
		} 
		public void LoadData(List<string> data,List<string> voters)
		{
			for(int i = 0; i < data.Count; i++)
			{
				Ideas.Add(new Idea(data[i]));
			}
			cb.LoadData(data);
			cb.EnableNEnough = EnableNEnough;
			cb.MaxCheckCnt = MaxLim;
			cb.SetText();
			//data.Insert(0, "未选择");

			//choices.DataSource = data;
			Voters = voters;
		}
		public MultiVoteWindow()
		{
			InitializeComponent();
			random = new Random();
			NameSelectedWindow = new NameSelectedWindow("请上台投票"," ");
			Ideas = new List<Idea>();
			GiveUppers = new List<string>();
			cb = new ChoosingBoard();
		}

		private void ModernButton2_Click(object sender, EventArgs e)
		{
			if (DialogResult.Yes==MessageBox.Show("您确定要终止投票吗 ?\r\n您将丢失本此投票的所有数据 !\r\n请谨慎操作 .","停止投票",MessageBoxButtons.YesNo,MessageBoxIcon.Information))
			{
				this.Canceled = true;
				IsAlive = false;
				this.Close();
			}
		}

		private void Votebtn_Click(object sender, EventArgs e)
		{
			cb.tabControl.SelectedIndex = 27;
			cb.ShowDialog();
			if (cb.Okey)
			{
				foreach(string x in cb.listBox1.Items)
				{
					var q = Ideas.Where((ide) => ide.Desp == x).ToArray();
					if (q.Length > 0)
					{
						q[0].Add(Voters[CurrentVoterId]);
					}
				}
				RemoveCurrentVoter();
				if (!CallPersonToVote())
				{
					EndVoting();
				}
			}	
		}

		private void ModernButton1_Click(object sender, EventArgs e)
		{
			if (ConfirmGivingUp())
			{
				GiveUppers.Add(Voters[CurrentVoterId]);
				RemoveCurrentVoter();
				
				if (!CallPersonToVote())
				{
					EndVoting();
				}

			}
		}

		private void EndVoting()
		{
			//throw new NotImplementedException();
			Service.Speak("投票顺利完成 , 请主办人员检查结果 .");
			var x=new Idea("弃权");
			GiveUppers.ForEach(i => x.Add(i));
			Ideas.Add(x);
			var w = new SingleVoteFinishedWindow();
			w.LoadData(this.Ideas,this.Voters);
			IsAlive = false;
			this.Close();
			w.ShowDialog();
		}

		private void SingleVoteWindow_Shown(object sender, EventArgs e)
		{
			CallPersonToVote();
		}

		private void SingleVoteWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (IsAlive)
			{
				ModernButton2_Click(null, null);
				if (IsAlive)
				{
					e.Cancel = true;
				}
			}
		}

		private void SingleVoteWindow_Load(object sender, EventArgs e)
		{
			Service.speech.SpeakAsyncCancelAll();
			Service.Speak("投票活动开始 , 请投票人做好准备 .");

		}

		private void TitleLabel1_Click(object sender, EventArgs e)
		{

		}
	}
}
