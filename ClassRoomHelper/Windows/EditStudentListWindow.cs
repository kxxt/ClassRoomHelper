using System;
using System.Windows.Forms;
using Syncfusion.WinForms.Controls;

namespace ClassRoomHelper.Windows
{
	public partial class EditStudentListWindow : RsWork.UI.Windows.BasicNoneBorderWinForm
	{
		
		public EditStudentListWindow()
		{
			InitializeComponent();
			
			//BindingList<string> list = new BindingList<string>();
			//list.
			//bs.DataSource = Program.NameSelector.Names;
			//listBox1.DataBindings.Add = Program.NameSelector.Names;
			//listBox1.DisplayMember;
			listBox1.DataSource = Program.NameSelector.Names;
			//Update();
		}

		private void DefaultButton1_Click(object sender, EventArgs e)
		{
			//listBox1.Items.Add("未命名");
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
			Program.NameSelector.Names.RemoveAt(listBox1.SelectedIndex);
		}

		private void DefaultButton3_Click(object sender, EventArgs e)
		{
			if (listBox1.SelectedIndex < 0) return;
			//MessageBox.Show(listBox1.SelectedIndex.ToString());
			//MessageBox.Show(Program.NameSelector.Names.ToString());
			if(textBox1.Text.Contains(",")){
				MessageBox.Show("学生姓名不能含有逗号.");
				textBox1.Text=Program.NameSelector.Names[listBox1.SelectedIndex];
				return;
				//todo
			}
			Program.NameSelector.Names[listBox1.SelectedIndex] = textBox1.Text;
		}

		private void DefaultButton4_Click(object sender, EventArgs e)
		{
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
