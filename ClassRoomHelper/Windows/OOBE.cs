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
		}

		private void DefaultButton3_Click(object sender, EventArgs e)
		{
			NextPage();
		}

		private void NextPage()
		{
			index++;
			pictureBox1.BackgroundImage = Images[index];
			//throw new NotImplementedException();
		}

		private void DefaultButton1_Click(object sender, EventArgs e)
		{
			PrevPage();
		}

		private void PrevPage()
		{
			//throw new NotImplementedException();
		}
	}
}
