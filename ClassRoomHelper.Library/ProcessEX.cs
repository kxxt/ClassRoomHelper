using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomHelper.Library
{
	public static class ProcessExtensions
	{
		public static bool IsAdminGroupMember(this System.Diagnostics.Process process)
		{
			return IsAdminGroupMember(process.Id);
		}

		private static bool IsAdminGroupMember(int processId)
		{
			IntPtr hPriToken = IntPtr.Zero, hImpToken = IntPtr.Zero;
			var hProcess = WinApi.OpenProcess(ProcessAccessFlags.QueryLimitedInformation, false, processId);
			if (hProcess == IntPtr.Zero) hProcess = WinApi.OpenProcess(ProcessAccessFlags.QueryInformation, false, processId); // < Vista
			var haveToken = WinApi.OpenProcessToken(hProcess, WinApi.TOKEN_DUPLICATE, out hPriToken);
			if (haveToken)
			{
				haveToken = WinApi.DuplicateTokenEx(hPriToken, WinApi.TOKEN_QUERY, IntPtr.Zero, WinApi.SecurityImpersonation, WinApi.TokenImpersonation, out hImpToken);
				WinApi.CloseHandle(hPriToken);
			}
			if (hProcess != IntPtr.Zero) WinApi.CloseHandle(hProcess);
			if (haveToken)
			{
				uint cbSid = 0;
				bool isMember = false;
				WinApi.CreateWellKnownSid(WELL_KNOWN_SID_TYPE.WinBuiltinAdministratorsSid, IntPtr.Zero, IntPtr.Zero, ref cbSid);
				IntPtr pSid = Marshal.AllocCoTaskMem(Convert.ToInt32(cbSid));
				var succeed = pSid != IntPtr.Zero && WinApi.CreateWellKnownSid(WELL_KNOWN_SID_TYPE.WinBuiltinAdministratorsSid, IntPtr.Zero, pSid, ref cbSid);
				succeed = succeed && WinApi.CheckTokenMembership(hImpToken, pSid, out isMember);
				Marshal.FreeCoTaskMem(pSid);
				WinApi.CloseHandle(hImpToken);
				return succeed && isMember;
			}
			return false;
		}
	}
}