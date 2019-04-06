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
		public int Checked;
		public IList<string> data;
		private void ParseData()
		{

		}
		public Dictionary<(char, int), (bool 选择,int 对应码,int 列表码)> Reflexs;
		public CheckedListBox[] CheckedListBoxes;
		public void UncheckAll()
		{
			foreach(var x in CheckedListBoxes)
			{

				x.ClearSelected();
				
			}
		}
		public void LoadData(IList<string> data)
		{
			this.data = data;
			for (int i = 0; i < data.Count; i++)
			{
				string x = (string)data[i];
				char init = Chinese.GetPYFirstChar(x);
				int id;
				if (init == '?')
				{
					id= 0;
				}
				else id= CheckedListBoxes[init - 'A' + 1].Items.Add(x, false);
				Reflexs.Add((init, id), (false,i,-1));
			}
		
		}
		public ChoosingBoard()
		{
			InitializeComponent();
			CheckedListBoxes = new CheckedListBox[27];
			Checked= 0;
			Reflexs = new Dictionary<(char, int), (bool,int,int)>();
			//var list = (System.Collections.IList);
			for (int i = 0; i <= 26; i++)
			{
				int tmp = i;
				CheckedListBoxes[i] = new CheckedListBox();
				CheckedListBoxes[i].Dock = DockStyle.Fill;
				var page = tabControl.TabPages[i];
				if (page.Text == "总览")
				{
					continue;
				}
				else
				{
					CheckedListBoxes[tmp].ItemCheck += (_, e) =>
					{

						if (e.NewValue == CheckState.Checked)
						{
							if (Checked == MaxCheckCnt)
							{
								MessageBox.Show("所选项目数超过最大限制","警告",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
								e.NewValue = CheckState.Unchecked;
								//CheckedListBoxes[tmp].SetSelected(e.Index, false);
								return;
							}
							int x = listBox1.Items.Add(data[
										Reflexs[((char)((char)(tmp - 1) + 'A'), e.Index)].对应码
									]);
							MessageBox.Show(x.ToString());
							Reflexs[((char)((char)(tmp - 1) + 'A'), e.Index)] = (
								true,
								Reflexs[((char)((char)(tmp - 1) + 'A'), e.Index)].对应码,
									x
							);
							//textBox1.Text = FormatSet();
							
							Checked++;
						}
						else
						{
							
							var x = Reflexs[((char)((char)(tmp - 1) + 'A'), e.Index)].列表码;
							MessageBox.Show(x.ToString());
							if (x >= 0) listBox1.Items.RemoveAt(x);
							
							Reflexs[((char)((char)(tmp - 1) + 'A'), e.Index)]= (false, Reflexs[((char)((char)(tmp - 1) + 'A'), e.Index)].对应码,-1);
							//textBox1.Text = FormatSet();
							--Checked;
						}

					};
					page.Controls.Add(CheckedListBoxes[i]);
				}
			}
		}
		public bool ConfirmGivingUp()
		{
			var ret = MessageBox.Show($"您是否要弃权 ? \r\n, 这是您的最后修改机会 .", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Information); ;
			if (ret == DialogResult.No) return false;
			return true;

		}
		private void DefaultButton3_Click(object sender, EventArgs e)
		{
			if (ConfirmGivingUp())
			{
				throw new NotImplementedException();
			}
		}
	}
}
