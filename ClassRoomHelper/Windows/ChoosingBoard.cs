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
	public partial class ChoosingBoard : Form
	{
		public CheckedListBox[] CheckedListBoxes;
		public void LoadData(IList<string> data)
		{

		}
		public ChoosingBoard()
		{
			InitializeComponent();
			CheckedListBoxes = new CheckedListBox[26];
			foreach(TabPage page in tabControl.TabPages)
			{
				if (page.Text == "总览")
				{
					continue;
				}
				else
				{
					
				}
			}
		}
	}
}
