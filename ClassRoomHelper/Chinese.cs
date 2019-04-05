using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.International.Converters.PinYinConverter;

namespace ClassRoomHelper
{
	public class Chinese
	{
		public static char GetPYFirstChar(String x)
		{
			if (string.IsNullOrWhiteSpace(x)) return '?';
			if ((x[0]>='a'&&x[0]<='z')||(x[0] >= 'A' && x[0] <= 'Z'))
			{
				return char.ToUpper(x[0]);
			}
			else if(ChineseChar.IsValidChar(x[0]))
			{
				return char.ToUpper(GetPY(x[0])[0]);
            }
			else
			{
				return '?';
			}
		}
		private static string GetPY(char word)
		{
			var chineseChar = new ChineseChar(word);

			return chineseChar.Pinyins[0].ToString();
		}
	}
}
