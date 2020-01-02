using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Forms;
using DialogResultx = System.Windows.Forms.DialogResult;
using MessageBox = System.Windows.Forms.MessageBox;
using ClassRoomHelper.Windows;
using System.IO;

namespace ClassRoomHelper
{
	/// <summary>
	/// OOBEWindow.xaml 的交互逻辑
	/// </summary>
	public partial class OOBEWindow : Window
	{
		public OOBEWindow()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			System.Windows.Forms.Application.Exit();
			this.Close();
			Environment.Exit(0);
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			var x = MessageBox.Show("为了您更好的使用体验 ,\r\n" +
								" 是否要允许我开机自动启动 ,\r\n" +
								"从开机起就为您提升课堂效率 ?",
								"来自班级助手的温馨提示",
								MessageBoxButtons.YesNo,
								MessageBoxIcon.Information);
			Core.TryRemoveStartUpCompletely();
			switch (x)
			{
				case DialogResultx.Yes:
					Core.SetUp();
					break;
				default:
					Program.Settings.StartAfterWindows = false;
					break;
			}
			var ret = MessageBox.Show("您是否要进行一次详尽的个性化设置?\r\n选择\"取消\"以使用默认设置,您可以稍后在设置中更改.", "为第一次使用做准备", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
			switch (ret)
			{
				case DialogResultx.OK:
					new Configuation().ShowDialog();
					break;
				default:
					MessageBox.Show("已为您采用默认设置 .\r\n自动整理的课件将保存到程序目录下的\"Files\"文件夹中", "设置完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

		private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			this.DragMove();
		}
	}
}
