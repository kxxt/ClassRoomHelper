using System;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.WinForms.Controls;

namespace ClassRoomHelper.Windows
{
	public partial class EditStudentListWindow : RsWork.UI.Windows.BasicNoneBorderWinForm
	{
		private bool ToCancel=true;
		public bool Canceled = false;
		bool WorkAsListEditor = false;
		public void AsListEditor(string title,string hint, System.ComponentModel.BindingList<string> data)
		{
			listBox1.DataSource = data;
			Text = title;
			textLabel2.Text = hint;
			WorkAsListEditor = true;
		}
		public EditStudentListWindow()
		{
			InitializeComponent();
			
			//BindingList<string> list = new BindingList<string>();
			//list.
			//bs.DataSource = Program.NameSelector.Names;
			//listBox1.DataBindings.Add = Program.NameSelector.Names;
			//listBox1.DisplayMember;
			
			//Update();
		}
		public void InitilizeNames()
		{
			listBox1.DataSource = Program.NameSelector.Names;
		}
		private void DefaultButton1_Click(object sender, EventArgs e)
		{
			//listBox1.Items.Add("未命名");
			if (WorkAsListEditor)
			{
				(listBox1.DataSource as BindingList<string>).Add("未命名");
				return;
			}
			Program.NameSelector.Names.Add("未命名");
			//Update();
		}

		private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBox1.SelectedIndex < 0) return;
			//if (listBox1.SelectedItem == null) MessageBox.Show("Fuck");
			textBox1.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
		}

		private void DefaultButton2_Click(object sender, EventArgs e)
		{
			if (WorkAsListEditor)
			{
				(listBox1.DataSource as BindingList<string>).RemoveAt(listBox1.SelectedIndex);
				return;
			}
			Program.NameSelector.Names.RemoveAt(listBox1.SelectedIndex);
		}

		private void DefaultButton3_Click(object sender, EventArgs e)
		{
			if (listBox1.SelectedIndex < 0) return;
			//MessageBox.Show(listBox1.SelectedIndex.ToString());
			//MessageBox.Show(Program.NameSelector.Names.ToString());
			if(textBox1.Text.Contains(",")){
				MessageBox.Show("不能含有逗号.");
				if (WorkAsListEditor)
				{
					textBox1.Text=(listBox1.DataSource as BindingList<string>)[listBox1.SelectedIndex];
					
				}
				else textBox1.Text=Program.NameSelector.Names[listBox1.SelectedIndex];
				return;
				//todo
			}
			if (WorkAsListEditor)
			{
				(listBox1.DataSource as BindingList<string>)[listBox1.SelectedIndex] = textBox1.Text;
			}
			else 
			Program.NameSelector.Names[listBox1.SelectedIndex] = textBox1.Text;
		}

		private void DefaultButton4_Click(object sender, EventArgs e)
		{
			if (WorkAsListEditor)
			{
				if (DialogResult.Yes==MessageBox.Show("是否已编辑完毕 ?","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Information))
				{
					ToCancel = false;
					this.Close();
				}
				return;
			}
				
			try
			{
				Program.NameSelector.Save("stulist.txt");

			}
			catch
			{
				MessageBox.Show("保存失败");
			}
		}

		private void TitleLabel1_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
		}

		private void DefaultButton5_Click(object sender, EventArgs e)
		{

			this.Close();
		}

		private void EditStudentListWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (WorkAsListEditor)
			{
				if (!ToCancel) return;
				var ret = MessageBox.Show("确定要取消投票吗?","取消",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
				switch (ret)
				{
					case DialogResult.OK:
						Canceled = true;
						return;
					default:
						e.Cancel = true;
						Canceled = false;
						return;
				}
			}
			try
			{
				Program.NameSelector.Save("stulist.txt");

			}
			catch
			{
				MessageBox.Show("保存失败");
				return;
			}
			MessageBox.Show("已保存","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
	}
}
