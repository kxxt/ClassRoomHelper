﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace ClassRoomHelper
{
	/// <summary>
	/// AddConfigurationWindow.xaml 的交互逻辑
	/// </summary>
	public partial class NotificationWindow : Window
	{
		DispatcherTimer timer;
		int cnt = 15;
		public NotificationWindow()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		private void Window_Activated(object sender, EventArgs e)
		{
			timer = new DispatcherTimer();
			timer.Interval = new TimeSpan(0,0,1);
			timer.Tick += Timer_Tick;
			timer.Start();
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			if (cnt == 0)
			{
				timer.Stop();
				//CloseWindow a = closeWindow;
				timer.Dispatcher.Invoke(() => this.Close());
			}
			else 
			{
				cnt--;
				timer.Dispatcher.Invoke(() => this.timerText.Text=$"{cnt}秒后自动关闭 ......");
			};
		}
		delegate void CloseWindow(Window window);
		private void closeWindow(Window window)
		{
			window?.Close();
		}
	}
}
