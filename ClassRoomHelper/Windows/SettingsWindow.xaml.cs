using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
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
using MessageBox = System.Windows.MessageBox;

namespace ClassRoomHelper
{
	/// <summary>
	/// MainWindow.xaml 的交互逻辑
	/// </summary>
	public partial class SettingsWindow : Window
	{
		private bool noChangesMade;
		private bool ready = false;

		public SettingsWindow()
		{
			InitializeComponent();
		}

		private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			this.DragMove();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			if (noChangesMade) QuitWithoutSaving();
			if (MessageBox.Show("您确定要关闭吗?\r\n您所做的所有更改将会丢失!", "警告", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
			{
				QuitWithoutSaving();
			}
			else
			{
				return;
			}
		}

		private void QuitWithoutSaving()
		{
			this.Close();
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			return;
			if (Save())
			{

			}
			else
			{

			}
		}

		private bool Save()
		{
			throw new NotImplementedException();
		}

		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			return;
			if (MessageBox.Show("您确定要将所有设置还原为出厂设置吗?\r\n您的个性化设置将会丢失!", "警告", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
			{
				if (ResetSettings())
				{

				}
				else
				{

				}
			}
			else return;
		}

		private bool ResetSettings()
		{
			throw new NotImplementedException();
		}

		private void ResortModeRadioButton1_Checked(object sender, RoutedEventArgs e)
		{
			if (ready)
			{
				Program.Settings.ResortMode = Library.Services.ResortMode.Monthly;
			}
		}

		private void ResortModeRadioButton4_Checked(object sender, RoutedEventArgs e)
		{
			if (ready)
			{
				Program.Settings.ResortMode = Library.Services.ResortMode.AmPmSeparated;
			}
		}

		private void ResortModeRadioButton3_Checked(object sender, RoutedEventArgs e)
		{
			if (ready)
			{
				Program.Settings.ResortMode = Library.Services.ResortMode.Daily;
			}
		}

		private void ResortModeRadioButton2_Checked(object sender, RoutedEventArgs e)
		{
			if (ready)
			{
				Program.Settings.ResortMode = Library.Services.ResortMode.Weekly;
			}
		}

		private void FileExistedSolutionRadioButton1_Checked(object sender, RoutedEventArgs e)
		{
			if (ready)
			{
				Program.Settings.FileExistedSolution = Library.Services.FileExistedSolution.Skip;
			}
		}

		private void FileExistedSolutionRadioButton2_Checked(object sender, RoutedEventArgs e)
		{
			if (ready)
			{
				Program.Settings.FileExistedSolution= Library.Services.FileExistedSolution.Cover;
			}
		}

		private void FileExistedSolutionRadioButton3_Checked(object sender, RoutedEventArgs e)
		{
			if (ready)
			{
				Program.Settings.FileExistedSolution = Library.Services.FileExistedSolution.Copy;
			}
		}

		private void CheckBox_Checked(object sender, RoutedEventArgs e)
		{
			if (ready)
			{
				Program.Settings.CollectMode = Library.Services.CollectMode.PPT;
			}
		}

		private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
		{
			if (ready)
			{
				Program.Settings.CollectMode = Library.Services.CollectMode.ALL;
			}
		}

		private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
		{
			if (ready)
			{
				Program.Settings.WallpaperEngine_Enabled = true;
			}
		}

		private void CheckBox_Unchecked_1(object sender, RoutedEventArgs e)
		{
			if (ready)
			{
				Program.Settings.WallpaperEngine_Enabled = false;
			}
		}

		private void RadioButton_Checked(object sender, RoutedEventArgs e)
		{
			if (ready)
			{
				Program.Settings.UMgr_Enabled = false;
			}
		}

		private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
		{
			if (!ready) return;
			Program.Settings.UMgr_Enabled = true;
			Program.Settings.UMgr_ShowDialog = true;
		}

		private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
		{
			if (!ready) return;
			Program.Settings.UMgr_Enabled = true;
			Program.Settings.UMgr_ShowDialog = false;
		}

		private void CheckBox_Checked_2(object sender, RoutedEventArgs e)
		{
			if (!ready) return;
			Program.Settings.BugFixForSeewo = true;
		}

		private void CheckBox_Unloaded(object sender, RoutedEventArgs e)
		{
			if (!ready) return;
			Program.Settings.BugFixForSeewo = false;
		}

		private void CheckBox_Checked_3(object sender, RoutedEventArgs e)
		{
			if (!ready) return;
			Program.Settings.VoiceNameCallOut = true;
		}

		private void CheckBox_Unchecked_2(object sender, RoutedEventArgs e)
		{
			if (!ready) return;
			Program.Settings.VoiceNameCallOut = false;
		}

		private void TextBox_LostFocus(object sender, RoutedEventArgs e)
		{
			if (!ready) return;
			Program.Settings.NameCallOutPre = NamePreTextbox.Text;
		}

		private void NamePostTextbox_LostFocus(object sender, RoutedEventArgs e)
		{
			if (!ready) return;
			Program.Settings.NameCallOutPost = NamePostTextbox.Text;
		}
	}
}
