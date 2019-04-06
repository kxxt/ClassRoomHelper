﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassRoomHelper.Windows
{
	public partial class OOBE : RsWork.UI.Windows.BasicNoneBorderWinForm
	{
		public int index=-1;
		public List<Image> Images=new List<Image>();
		public List<string> desps=new List<string>();
		public OOBE()
		{
			InitializeComponent();
			for(int i = 0; i <= 3; i++)
			{
				Images.Add( Image.FromFile("Resources\\Pic\\"+i+".png"));
			}
			desps.Add("欢迎使用班级助手 , 我相信我一定会成为您所钟爱的班级小助手的 ,\r\n我们不妨继续吧 !");
			desps.Add("我能自动地为您整理最近使用过的课件 , 无论它是在U盘上还是在这台电脑上 ,\r\n我都能把它们整理的井井有序 , 让您的学生在课下仍然可以轻松使用 .");
			desps.Add("点名可能是一个令人头疼的问题 ,\r\n 如何在老师对名字的记忆熟悉度不同的情况下 ,\r\n 让每一个学生都有均等的表现机会呢 ? 答案就在我身上 !");
			desps.Add("在您的教室里还存在着写纸条统计投票的现象吗 ?\r\n该结束了 !");
			//desps
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
								Core.RemoveStartByTaskSch();
								Core.RemoveSkipUAC();
							}
							catch
							{

							}
							try
							{
								Core.SetStartByTaskSchAdmin();
								Program.Settings.StartAfterWindows = true;
							}
							catch
							{
								MessageBox.Show("失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

							}
						}
						else
						{
							Program.Settings.StartAfterWindows = false;
							try
							{
								Core.RemoveStartByTaskSch();
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
								Program.Settings.StartAfterWindows = true;
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
						new Configuation().ShowDialog();
						break;
					default:
						MessageBox.Show("已为您采用默认设置 .\r\n自动整理的课件将保存到程序目录下的\"Files\"文件夹中","设置完成",MessageBoxButtons.OK,MessageBoxIcon.Information);
						try
						{
							Directory.CreateDirectory(Program.TargetDirParser.Get());
						}
						catch
						{

						}
						break;
				}
				this.Close();
				return;
			}
			pictureBox1.BackgroundImage = Images[index];
			textBox1.Text = desps[index];
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
			textBox1.Text = desps[index];
			//throw new NotImplementedException();
		}

		private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
		}

		private void OOBE_FormClosed(object sender, FormClosedEventArgs e)
		{
			foreach(var item in Images)
			{
				item.Dispose();
			}
		}
	}
}
