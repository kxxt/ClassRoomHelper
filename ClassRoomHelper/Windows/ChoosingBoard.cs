using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassRoomHelper.Windows
{
	public partial class ChoosingBoard : Form
	{
		public int MaxCheckCnt;
		private HashSet<int> set;
		private void ParseData()
		{

		}
		public Dictionary<(char, int), int> Reflexs;
		public CheckedListBox[] CheckedListBoxes;
		public void LoadData(IList<string> data)
		{
			for (int i = 0; i < data.Count; i++)
			{
				string x = (string)data[i];
				char init = Chinese.GetPYFirstChar(x);
				int id = CheckedListBoxes[init - 'A' + 1].Items.Add(x, false);
				Reflexs.Add((init, id), i);
			}
		}
		public ChoosingBoard()
		{
			InitializeComponent();
			CheckedListBoxes = new CheckedListBox[26];
			Reflexs = new Dictionary<(char, int), int>();
			//var list = (System.Collections.IList);
			for (int i = 0; i <= 26; i++)
			{
				var page = tabControl.TabPages[i];
				if (page.Text == "总览")
				{
					continue;
				}
				else
				{
					CheckedListBoxes[i].ItemCheck += (_, e) =>
					{
						if (e.NewValue == CheckState.Checked)
						{
							if (set.Count == MaxCheckCnt)
							{
								MessageBox.Show("所选项目数超过最大限制","警告",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
								CheckedListBoxes[i].SetSelected(e.Index, false);
								return;
							}
							set.Add(Reflexs[((char)((char)(i - 1) + 'A'), e.Index)]);

						}
						else
						{
							set.Remove(Reflexs[((char)((char)(i - 1) + 'A'), e.Index)]);
						}
					};
					page.Controls.Add(CheckedListBoxes[i]);
				}
			}
		}
	}
}
