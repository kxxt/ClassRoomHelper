using System;
using System.Drawing;

namespace ClassRoomHelper.Properties {
    
    
    // 通过此类可以处理设置类的特定事件: 
    //  在更改某个设置的值之前将引发 SettingChanging 事件。
    //  在更改某个设置的值之后将引发 PropertyChanged 事件。
    //  在加载设置值之后将引发 SettingsLoaded 事件。
    //  在保存设置值之前将引发 SettingsSaving 事件。
    internal sealed partial class Settings {
        
        public Settings() {
			// // 若要为保存和更改设置添加事件处理程序，请取消注释下列行: 
			//
			this.PropertyChanged += this.Settings_PropertyChanged;
            //this.SettingChanging += this.SettingChangingEventHandler;
            //
            // this.SettingsSaving += this.SettingsSavingEventHandler;
            //
        }

		private void Settings_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			switch (e.PropertyName)
			{
				case "TargetDir":
					if (Program.TargetDirParser == null) return;
					Program.TargetDirParser.Root = Program.Settings.TargetDir;
					try
					{
						System.IO.File.WriteAllText(".config", Program.Settings.TargetDir, System.Text.Encoding.UTF8);
					}
					catch
					{

					}

					break;
				case "CollectMode":
					if (Program.TargetDirParser == null) return;

					Program.TargetDirParser.Mode = Program.Settings.ResortMode;
					break;
				case "Timer_Enabled":
				case "Timer_EventName":
				case "Timer_Date":
					if (Program.Settings.Timer_Enabled)
					{
						TimeSpan timeSpan = (Program.Settings.Timer_Date - System.DateTime.Now.Date);
						int days = (timeSpan.Hours > 0 ? timeSpan.Days + 1 : timeSpan.Days);
						Program.Widget.Title.Text = Program.Widget.Title.Text = $"距 {Program.Settings.Timer_EventName} 还有 {days} 天";
						if (days <= 10 || days % 10 == 0)
						{
							Program.Widget.Title.Text += "！！！";
							Program.Widget.Title.Foreground = System.Windows.Media.Brushes.Red;
							Program.Widget.Title.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));
							//Program.Widget.Opacity = 1;
						}

						else if (days % 5 == 0)
						{
							Program.Widget.Title.Foreground = System.Windows.Media.Brushes.Yellow;
							Program.Widget.Title.Background = System.Windows.Media.Brushes.Black;
							Program.Widget.Title.Text += "！";
							//Program.Widget.Opacity = 0.6;
						}
						else
						{
							Program.Widget.Title.Foreground = System.Windows.Media.Brushes.Black;
							Program.Widget.Title.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(51, 255, 255, 255));
							//Program.Widget.Opacity = 0.6;
						}
					}
					//Program.Widget.Title.Text = $"距 {Program.Settings.Timer_EventName} 还有 {(Program.Settings.Timer_Date-System.DateTime.Now).Days } 天";
					else
						Program.Widget.Title.Text = "快捷功能";
					break;
			}

			//throw new System.NotImplementedException();
		}

		private void SettingChangingEventHandler(object sender, System.Configuration.SettingChangingEventArgs e) {
			// 在此处添加用于处理 SettingChangingEvent 事件的代码。
		}
        
        private void SettingsSavingEventHandler(object sender, System.ComponentModel.CancelEventArgs e) {
            // 在此处添加用于处理 SettingsSaving 事件的代码。
        }
    }
}
