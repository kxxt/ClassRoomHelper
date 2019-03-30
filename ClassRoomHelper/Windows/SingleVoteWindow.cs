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
	public partial class SingleVoteWindow : Form
	{
		//public List<string> data;
		public void LoadData(List<string> data)
		{
			comboBox1.DataSource = data;
		}
		public SingleVoteWindow()
		{
			InitializeComponent();
		}

		private void ModernButton2_Click(object sender, EventArgs e)
		{

		}
	}
}
