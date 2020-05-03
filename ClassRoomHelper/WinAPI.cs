using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace ClassRoomHelper
{
	public static class WinAPI
	{
		// https://msdn.microsoft.com/en-us/library/windows/desktop/dd162758(v=vs.85).aspx
		[DllImport("user32.dll", EntryPoint = "PaintDesktop")]
		public static extern int PaintDesktop(IntPtr hdc);

		// https://msdn.microsoft.com/en-us/library/windows/desktop/ms633504(v=vs.85).aspx
		[DllImport("user32.dll", EntryPoint = "GetDesktopWindow", SetLastError = true)]
		public static extern IntPtr GetDesktopWindow();

		// http://msdn.microsoft.com/en-us/library/dd144871(VS.85).aspx
		[DllImport("user32.dll")]
		public static extern IntPtr GetDC(IntPtr hwnd);

		// http://msdn.microsoft.com/en-us/library/dd162920(VS.85).aspx
		[DllImport("user32.dll")]
		public static extern int ReleaseDC(IntPtr hwnd, IntPtr dc);

		#region gdi32
		// http://msdn.microsoft.com/en-us/library/dd183370(VS.85).aspx
		[DllImport("gdi32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool BitBlt(IntPtr hDestDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, Int32 dwRop);

		// http://msdn.microsoft.com/en-us/library/dd183488(VS.85).aspx
		[DllImport("gdi32.dll")]
		public static extern IntPtr CreateCompatibleBitmap(IntPtr hdc, int nWidth, int nHeight);

		// http://msdn.microsoft.com/en-us/library/dd183489(VS.85).aspx
		[DllImport("gdi32.dll", SetLastError = true)]
		public static extern IntPtr CreateCompatibleDC(IntPtr hdc);

		// http://msdn.microsoft.com/en-us/library/dd162957(VS.85).aspx
		[DllImport("gdi32.dll", ExactSpelling = true, PreserveSig = true, SetLastError = true)]
		public static extern IntPtr SelectObject(IntPtr hdc, IntPtr hgdiobj);

		// http://msdn.microsoft.com/en-us/library/dd183539(VS.85).aspx
		[DllImport("gdi32.dll")]
		public static extern bool DeleteObject(IntPtr hObject);

		public const int SRCCOPY = 0xCC0020;
        #endregion
        // From https://www.gooosie.com/2016/11/15/get-wallpaper-in-windows-with-csharp/
        public static BitmapSource CaptureWallpaper()
        {
            BitmapSource bitmapSource = null;
            IntPtr sourceDC = IntPtr.Zero;
            IntPtr targetDC = IntPtr.Zero;
            IntPtr compatibleBitmapHandle = IntPtr.Zero;
            BitmapImage bitmapImage = null;

            try
            {
                // 拿到桌面窗口的dc，只在Win10静态壁纸下测试过，其他情况肯定是要改的，找桌面窗口句柄的方法还要再封装一下，不过我比较咸鱼先这样写了。。。
                sourceDC = GetDC(WindowWrapper.FindWindowEx(
                    WindowWrapper.FindWindowEx(
                        WindowWrapper.FindWindow("Progman", "Program Manager"),
                        IntPtr.Zero, "SHELLDLL_DefView", ""
                    ),
                    IntPtr.Zero, "SysListView32", "FolderView"
                ));
                // 创建一个兼容sourceDC的内存DC
                targetDC = CreateCompatibleDC(sourceDC);
                // 创建一个兼容targetDC的位图
                compatibleBitmapHandle = CreateCompatibleBitmap(sourceDC, (int)SystemParameters.PrimaryScreenWidth, (int)SystemParameters.PrimaryScreenHeight);
                // 把位图指定到targetDC环境中
                SelectObject(targetDC, compatibleBitmapHandle);
                // 把桌面画到sourceDC上
                PaintDesktop(sourceDC);
                // 然后从sourceDC复制到targetDC
                BitBlt(targetDC, 0, 0, (int)SystemParameters.PrimaryScreenWidth, (int)SystemParameters.PrimaryScreenHeight, sourceDC, 0, 0, SRCCOPY);
                // 把hBitmap转换成BitmapSource
                bitmapSource = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                    compatibleBitmapHandle, IntPtr.Zero, Int32Rect.Empty,
                    BitmapSizeOptions.FromEmptyOptions());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                DeleteObject(compatibleBitmapHandle);
                ReleaseDC(IntPtr.Zero, sourceDC);
                ReleaseDC(IntPtr.Zero, targetDC);
            }
            return bitmapSource;
        }
    }
}
