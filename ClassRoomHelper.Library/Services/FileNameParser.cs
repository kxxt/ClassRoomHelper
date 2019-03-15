namespace ClassRoomHelper.Library.Services
{
    public class FileNameParser
    {
        public static string GetFilePath(string cmd)
		{
			if (string.IsNullOrEmpty(cmd)) return "";
			int a=0, b=cmd.Length-1,x=0;
			for(int i = 0; i < cmd.Length; i++)
			{
				if (cmd[i] == '"')
				{
					x++;
					if (x == 3) a = i;
					else if (x == 4) {
						b = i;
						break;
					}
				}
			}
			if (a == 0) return "";
			return cmd.Substring(a+1, (b== cmd.Length - 1?b:b-1)-a);
		}
    }
}