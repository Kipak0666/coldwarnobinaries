using System.Runtime.InteropServices;

namespace Cheat
{
    // Token: 0x02000008 RID: 8
    internal static class NativeMethods
	{
		// Token: 0x0600006E RID: 110
		[DllImport("kernel32.dll", SetLastError = true)]
		internal static extern int AllocConsole();

		// Token: 0x0600006F RID: 111
		[DllImport("kernel32.dll", SetLastError = true)]
		internal static extern int FreeConsole();
	}
}