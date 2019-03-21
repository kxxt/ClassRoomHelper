using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomHelper.Library
{
	internal class WinApi
	{
		public const int TOKEN_DUPLICATE = 0x0002;
		public const int TOKEN_QUERY = 0x00000008;
		public const int SecurityImpersonation = 2;
		public const int TokenImpersonation = 2;

		[DllImport("advapi32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool OpenProcessToken(IntPtr ProcessHandle, UInt32 DesiredAccess, out IntPtr TokenHandle);

		[DllImport("advapi32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DuplicateTokenEx(IntPtr hTok, UInt32 DesiredAccess, IntPtr SecAttPtr, int ImpLvl, int TokType, out IntPtr TokenHandle);

		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern IntPtr OpenProcess(ProcessAccessFlags processAccess, bool bInheritHandle, int processId);

		[DllImport("advapi32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CreateWellKnownSid(WELL_KNOWN_SID_TYPE WellKnownSidType, IntPtr DomainSid, IntPtr pSid, ref uint cbSid);

		[DllImport("advapi32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CheckTokenMembership(IntPtr TokenHandle, IntPtr SidToCheck, out bool IsMember);

		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern int GetCurrentProcessId();

		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern int CloseHandle(IntPtr h);

		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool QueryFullProcessImageName([In]IntPtr hProcess, [In]int dwFlags, [Out]StringBuilder lpExeName, ref int lpdwSize);
	}

	[Flags]
	internal enum ProcessAccessFlags : uint
	{
		All = 0x001F0FFF,
		Terminate = 0x00000001,
		CreateThread = 0x00000002,
		VirtualMemoryOperation = 0x00000008,
		VirtualMemoryRead = 0x00000010,
		VirtualMemoryWrite = 0x00000020,
		DuplicateHandle = 0x00000040,
		CreateProcess = 0x000000080,
		SetQuota = 0x00000100,
		SetInformation = 0x00000200,
		QueryInformation = 0x00000400,
		QueryLimitedInformation = 0x00001000,
		Synchronize = 0x00100000
	}

	internal enum WELL_KNOWN_SID_TYPE
	{
		WinNullSid = 0,
		WinWorldSid = 1,
		WinLocalSid = 2,
		WinCreatorOwnerSid = 3,
		WinCreatorGroupSid = 4,
		WinCreatorOwnerServerSid = 5,
		WinCreatorGroupServerSid = 6,
		WinNtAuthoritySid = 7,
		WinDialupSid = 8,
		WinNetworkSid = 9,
		WinBatchSid = 10,
		WinInteractiveSid = 11,
		WinServiceSid = 12,
		WinAnonymousSid = 13,
		WinProxySid = 14,
		WinEnterpriseControllersSid = 15,
		WinSelfSid = 16,
		WinAuthenticatedUserSid = 17,
		WinRestrictedCodeSid = 18,
		WinTerminalServerSid = 19,
		WinRemoteLogonIdSid = 20,
		WinLogonIdsSid = 21,
		WinLocalSystemSid = 22,
		WinLocalServiceSid = 23,
		WinNetworkServiceSid = 24,
		WinBuiltinDomainSid = 25,
		WinBuiltinAdministratorsSid = 26,
		WinBuiltinUsersSid = 27,
		WinBuiltinGuestsSid = 28,
		WinBuiltinPowerUsersSid = 29,
		WinBuiltinAccountOperatorsSid = 30,
		WinBuiltinSystemOperatorsSid = 31,
		WinBuiltinPrintOperatorsSid = 32,
		WinBuiltinBackupOperatorsSid = 33,
		WinBuiltinReplicatorSid = 34,
		WinBuiltinPreWindows2000CompatibleAccessSid = 35,
		WinBuiltinRemoteDesktopUsersSid = 36,
		WinBuiltinNetworkConfigurationOperatorsSid = 37,
		WinAccountAdministratorSid = 38,
		WinAccountGuestSid = 39,
		WinAccountKrbtgtSid = 40,
		WinAccountDomainAdminsSid = 41,
		WinAccountDomainUsersSid = 42,
		WinAccountDomainGuestsSid = 43,
		WinAccountComputersSid = 44,
		WinAccountControllersSid = 45,
		WinAccountCertAdminsSid = 46,
		WinAccountSchemaAdminsSid = 47,
		WinAccountEnterpriseAdminsSid = 48,
		WinAccountPolicyAdminsSid = 49,
		WinAccountRasAndIasServersSid = 50,
		WinNTLMAuthenticationSid = 51,
		WinDigestAuthenticationSid = 52,
		WinSChannelAuthenticationSid = 53,
		WinThisOrganizationSid = 54,
		WinOtherOrganizationSid = 55,
		WinBuiltinIncomingForestTrustBuildersSid = 56,
		WinBuiltinPerfMonitoringUsersSid = 57,
		WinBuiltinPerfLoggingUsersSid = 58,
		WinBuiltinAuthorizationAccessSid = 59,
		WinBuiltinTerminalServerLicenseServersSid = 60
	}
}
