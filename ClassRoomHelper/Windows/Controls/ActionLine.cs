using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassRoomHelper.Windows.Controls
{
	public partial class ActionLine : UserControl
	{
		public void Set(string name, ref short score)
		{
			this.score = score;
			this.textLabel1.Text = name;
		}
		short score;
		public ActionLine()
		{
			InitializeComponent();
		}
		public ActionLine(string name,ref short score)
		{
			InitializeComponent();
			this.score = score;
			this.textLabel1.Text = name;
		}

		private void DefaultButton2_Click(object sender, EventArgs e)
		{
			score++;
			UpdateScore();
		}

		private void UpdateScore()
		{
			this.textLabel2.Text = "分数: " + score;
		}

		private void DefaultButton1_Click(object sender, EventArgs e)
		{
			score--;
			UpdateScore();
		}
	}
}
