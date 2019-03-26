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
	public partial class OOBE : BaseForm
	{
		public int index=-1;
		public List<Image> Images=new List<Image>();
		public List<string> desps=new List<string>();
		public OOBE()
		{
			InitializeComponent();
			for(int i = 0; i <= 2; i++)
			{
				Images.Add( Image.FromFile("Resources\\Pic\\"+i+".png"));
			}
			desps.Add("欢迎使用");
			desps.Add("");
			NextPage();
		}

		private void DefaultButton3_Click(object sender, EventArgs e)
		{
			NextPage();
		}

		private void NextPage()
		{
			index++;
			if (index == Images.Count)
			{
				var x=MessageBox.Show("为了您更好的使用体验 ,\r\n"+
								" 是否要允许我开机自动启动 ,\r\n"+
								"从开机起就为您提升课堂效率 ?",
								"来自班级助手的温馨提示",
								MessageBoxButtons.YesNo,
								MessageBoxIcon.Information);
				switch (x)
				{
					case DialogResult.Yes:
						if (Program.WorkAsAdministrator)
						{
							try
							{
								Core.RemoveStartByTaskSch();

							}
							catch
							{

							}
							try
							{
								Core.SetStartByTaskSchAdmin();

							}
							catch
							{
								MessageBox.Show("失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

							}
						}
						else
						{
							try
							{
								Core.RemoveStartByTaskSch();
								Core.RemoveSkipUAC();
							}
							catch
							{

							}
							try
							{
								Core.SetSkipUAC();
								Core.SetStartByTaskSch();

							}
							catch
							{
								MessageBox.Show("失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}
						break;
					default:
						break;
				}
				var ret=MessageBox.Show("您是否要进行一次详尽的个性化设置?\r\n选择\"取消\"以使用默认设置,您可以稍后在设置中更改.","为第一次使用做准备",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
				switch (ret)
				{
					case DialogResult.OK:
						using (var con=new Configuation())
						{
							con.ShowDialog();
						}
						break;
					default:
						MessageBox.Show("已为您采用默认设置 .\r\n自动整理的课件将保存到程序目录下的\"Files\"文件夹中","设置完成",MessageBoxButtons.OK,MessageBoxIcon.Information);
						break;
				}
				this.Close();
				return;
			}
			pictureBox1.BackgroundImage = Images[index];
			//throw new NotImplementedException();
		}

		private void DefaultButton1_Click(object sender, EventArgs e)
		{
			PrevPage();
		}

		private void PrevPage()
		{
			index--;
			if (index < 0)
			{
				index = 0;
				MessageBox.Show("已到最前面的一张 .", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			pictureBox1.BackgroundImage = Images[index];
			//throw new NotImplementedException();
		}
	}
}
