using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace ClassRoomHelper
{
	/// <summary>
	/// MainWindow.xaml 的交互逻辑
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			if(System.Windows.MessageBox.Show("是否要关闭桌面小工具?","关闭",MessageBoxButton.YesNo,MessageBoxImage.Question)==MessageBoxResult.Yes)
			this.Hide();
			Program.ShowingDesktopTool = false;
		}
		private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			this.DragMove();
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			Service.ChooseNameRandomly();
			if (Program.Settings.BugFixForSeewo)BugFixForSeewo();
		}
		private void BugFixForSeewo()
		{
			SetCursorPos(Screen.PrimaryScreen.WorkingArea.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2);
		}
		[DllImport("User32.dll")]
		private static extern bool SetCursorPos(int x, int y);
		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			Service.Vote();
			if (Program.Settings.BugFixForSeewo) BugFixForSeewo();
		}

		private void Window_DragLeave(object sender, System.Windows.DragEventArgs e)
		{
			//System.Windows.MessageBox.Show("");
			Program.Settings.DesktopToolLoc =new System.Drawing.Point( (int)this.Left,(int)this.Top);
			Program.Settings.Save();
		}

		private void Button_Click_3(object sender, RoutedEventArgs e)
		{
			Service.OpenRecently();
			if (Program.Settings.BugFixForSeewo) BugFixForSeewo();
		}

		private void Button_Click_4(object sender, RoutedEventArgs e)
		{
			try
			{
				Process.Start("https://jinan.xueanquan.com/");
			}
			catch
			{
				System.Windows.MessageBox.Show("失败", "错误", MessageBoxButton.OK, MessageBoxImage.Error);
			}
			if (Program.Settings.BugFixForSeewo) BugFixForSeewo();
		}

		private void Button_Click_5(object sender, RoutedEventArgs e)
		{
			try
			{
				Process.Start("http://tv.cctv.com/lm/xwzk/");
			}
			catch
			{
				System.Windows.MessageBox.Show("失败", "错误", MessageBoxButton.OK, MessageBoxImage.Error);
			}
			if (Program.Settings.BugFixForSeewo) BugFixForSeewo();
		}
		internal class User32
		{
			public const int SE_SHUTDOWN_PRIVILEGE = 0x13;
			[DllImport("user32.dll")]
			public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
			[DllImport("user32.dll")]
			public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
			[DllImport("user32.dll")]
			public static extern bool SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int X, int Y, int cx,
			int cy, uint uFlags);
		}

		private void Button_Click_6(object sender, RoutedEventArgs e)
		{
			Service.OpenMonth();
			if (Program.Settings.BugFixForSeewo) BugFixForSeewo();
		}

		private void Button_Click_7(object sender, RoutedEventArgs e)
		{
			Service.EverythingSearch(searchBox.Text);
		}

		private void Button_Click_8(object sender, RoutedEventArgs e)
		{
			//settingDialogHost.ShowDialog(settingDialogHost.DialogContent);
			new SettingsWindow().ShowDialog();
			//System.Windows.MessageBox.Show($"{(int)this.Left},{(int)this.Top}");
			//Program.Settings.DesktopToolLoc = new System.Drawing.Point((int)this.Left, (int)this.Top);
			//Program.Settings.Save();
		}

		private void Window_LocationChanged(object sender, EventArgs e)
		{
			//Program.Settings.DesktopToolLoc = new System.Drawing.Point((int)this.Left, (int)this.Top);

		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			//this.Move
			//System.Windows.MessageBox.Show("");
			//this.Left = Program.Settings.DesktopToolLoc.X;
			//this.Top = Program.Settings.DesktopToolLoc.Y;
			var handle=new WindowInteropHelper(this).Handle;
			WindowWrapper.SetWindowPos(handle, 0, Program.Settings.DesktopToolLoc.X,Program.Settings.DesktopToolLoc.Y, (int)this.Width, (int)this.Height, WindowWrapper.SWP_NOZORDER | WindowWrapper.SWP_SHOWWINDOW);
			WindowWrapper.DisableAltF4(this);
		}

		private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			Program.Settings.DesktopToolLoc = new System.Drawing.Point((int)this.Left, (int)this.Top);
			Program.Settings.Save();
		}

		private void Button_Click_9(object sender, RoutedEventArgs e)
		{
			//settingDialogHost.
		}

		private void Button_Click_10(object sender, RoutedEventArgs e)
		{
			new AboutWindow().ShowDialog();
		}

		private void Button_Click_11(object sender, RoutedEventArgs e)
		{

		}

		private void Button_Click_12(object sender, RoutedEventArgs e)
		{
			System.Windows.MessageBox.Show("功能尚未实现 , 敬请期待 .", "Hint", MessageBoxButton.OK, MessageBoxImage.Information);
		}

		private void Button_Click_13(object sender, RoutedEventArgs e)
		{
			Service.OpenYear();
			if (Program.Settings.BugFixForSeewo) BugFixForSeewo();
		}

		private void Button_Click_14(object sender, RoutedEventArgs e)
		{
			try
			{
				Process.Start("http://mail.163.com");
			}
			catch
			{
				System.Windows.MessageBox.Show("失败", "错误", MessageBoxButton.OK, MessageBoxImage.Error);
			}
			if (Program.Settings.BugFixForSeewo) BugFixForSeewo();
		}

		private void Button_Click_15(object sender, RoutedEventArgs e)
		{
			Service.ShowFullScreenCountDownNotification();
			return;
			try
			{
				Process.Start("https://github.com/kxxt/ClassRoomHelper");
			}
			catch
			{
				System.Windows.MessageBox.Show("失败", "错误", MessageBoxButton.OK, MessageBoxImage.Error);
			}
			if (Program.Settings.BugFixForSeewo) BugFixForSeewo();
		}

		private void Button_Click_16(object sender, RoutedEventArgs e)
		{
			System.Windows.MessageBox.Show("功能尚未实现 , 敬请期待 .", "Hint", MessageBoxButton.OK, MessageBoxImage.Information);
		}
	}
}
