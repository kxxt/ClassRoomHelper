using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomHelper.Library
{
	public static class WallpaperEngine
	{
		private static string urlbase = "https://cn.bing.com";
		private static string rawurl = "https://cn.bing.com/HPImageArchive.aspx?format=xml&idx=0&n=1";
		public async static Task<HttpResponseMessage> GetInformation()
		{
			HttpClient httpClient = new HttpClient();
			return await httpClient.GetAsync(rawurl);
		}
		public static string GetImageUrl(string xml)
		{
			int a = xml.IndexOf("<url>")+"<url>".Length;
			int b = xml.IndexOf("</url>");
			return urlbase+xml.Substring(a, b - a);
		}
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);
		public static async Task DownLoadWallpaper(string path)
		{
			string url = GetImageUrl(await (await GetInformation()).Content.ReadAsStringAsync());
			HttpDownloadFile(url, path);
		}
		
		private static string HttpDownloadFile(string url, string path)
		{
			// 设置参数
			HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
			//发送请求并获取相应回应数据
			HttpWebResponse response = request.GetResponse() as HttpWebResponse;
			//直到request.GetResponse()程序才开始向目标网页发送Post请求
			Stream responseStream = response.GetResponseStream();
			//创建本地文件写入流
			Stream stream = new FileStream(path, FileMode.Create);
			byte[] bArr = new byte[1024];
			int size = responseStream.Read(bArr, 0, (int)bArr.Length);
			while (size > 0)
			{
				stream.Write(bArr, 0, size);
				size = responseStream.Read(bArr, 0, (int)bArr.Length);
			}
			stream.Close();
			responseStream.Close();
			return path;
		}
		const int SPI_SETDESKWALLPAPER = 20;
		const int SPIF_UPDATEINIFILE = 0x01;
		const int SPIF_SENDWININICHANGE = 0x02;

		
		public enum Style : int
		{
			Tiled,
			Centered,
			Stretched
		}

		public static void Set(Image img, Style style)
		{
			string tempPath = Path.Combine(Path.GetTempPath(), "wallpaper.bmp");
			img.Save(tempPath, System.Drawing.Imaging.ImageFormat.Bmp);

			RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
			if (style == Style.Stretched)
			{
				key.SetValue(@"WallpaperStyle", 2.ToString());
				key.SetValue(@"TileWallpaper", 0.ToString());
			}

			if (style == Style.Centered)
			{
				key.SetValue(@"WallpaperStyle", 1.ToString());
				key.SetValue(@"TileWallpaper", 0.ToString());
			}

			if (style == Style.Tiled)
			{
				key.SetValue(@"WallpaperStyle", 1.ToString());
				key.SetValue(@"TileWallpaper", 1.ToString());
			}

			var a = SystemParametersInfo(SPI_SETDESKWALLPAPER,
				0,
				tempPath,
				SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
		}
	}
}
