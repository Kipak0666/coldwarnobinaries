using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace Cheat
{
	// Token: 0x02000007 RID: 7
	public class Memory
	{
		// Token: 0x06000060 RID: 96 RVA: 0x00005AC0 File Offset: 0x00003CC0
		public bool IsProcessRunning(string processName)
		{
			bool result;
			try
			{
				Process process = Process.GetProcessesByName(processName)[0];
				if (process.Handle.ToInt64() == 0L)
				{
					return false;
				}
				this.BaseAddress = process.MainModule.BaseAddress.ToInt64();
				this.ProcessID = process.Id;
				this.ProcessHandle = process.Handle;
				result = true;
			}
			catch
			{
				this.BaseAddress = 0L;
				this.ProcessID = 0;
				this.ProcessHandle = IntPtr.Zero;
				result = false;
			}
			return result;
		}

		// Token: 0x06000061 RID: 97
		[DllImport("kernel32.dll")]
		public static extern bool ReadProcessMemory(IntPtr hProcess, long lpBaseAddress, [Out] byte[] lpBuffer, uint nSize, out uint lpNumberOfBytesRead);

		// Token: 0x06000062 RID: 98 RVA: 0x00005B54 File Offset: 0x00003D54
		public string ReadString(long pAddress)
		{
			try
			{
				byte[] array = new byte[1280];
				uint num = 0U;
				if (Memory.ReadProcessMemory(this.ProcessHandle, pAddress, array, 1280U, out num))
				{
					string text = "";
					int num2 = 0;
					while (array[num2] != 0)
					{
						string str = text;
						char c = (char)array[num2];
						text = str + c.ToString();
						num2++;
					}
					return text;
				}
			}
			catch (Exception)
			{
			}
			return "";
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00005BD8 File Offset: 0x00003DD8
		public byte[] ReadBytes(long pAddress, int length)
		{
			byte[] array = new byte[length];
			uint num = 0U;
			Memory.ReadProcessMemory(this.ProcessHandle, pAddress, array, (uint)length, out num);
			return array;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00005C00 File Offset: 0x00003E00
		public float ReadFloat(long pAddress)
		{
			try
			{
				uint num = 0U;
				byte[] array = new byte[4];
				if (Memory.ReadProcessMemory(this.ProcessHandle, pAddress, array, 4U, out num))
				{
					return BitConverter.ToSingle(array, 0);
				}
			}
			catch (Exception)
			{
			}
			return 0f;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00005C50 File Offset: 0x00003E50
		public int ReadInt(long pAddress)
		{
			try
			{
				uint num = 0U;
				byte[] array = new byte[4];
				if (Memory.ReadProcessMemory(this.ProcessHandle, pAddress, array, 4U, out num))
				{
					return BitConverter.ToInt32(array, 0);
				}
			}
			catch (Exception)
			{
			}
			return 0;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00005C9C File Offset: 0x00003E9C
		public long ReadInt64(long pAddress)
		{
			try
			{
				uint num = 0U;
				byte[] array = new byte[8];
				if (Memory.ReadProcessMemory(this.ProcessHandle, pAddress, array, 8U, out num))
				{
					return BitConverter.ToInt64(array, 0);
				}
			}
			catch (Exception)
			{
			}
			return 0L;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00005CE8 File Offset: 0x00003EE8
		public long ReadUInt(long pAddress)
		{
			try
			{
				uint num = 0U;
				byte[] array = new byte[8];
				if (Memory.ReadProcessMemory(this.ProcessHandle, pAddress, array, 8U, out num))
				{
					return (long)BitConverter.ToUInt64(array, 0);
				}
			}
			catch (Exception)
			{
			}
			return 0L;
		}

		// Token: 0x06000068 RID: 104
		[DllImport("kernel32.dll")]
		public static extern bool WriteProcessMemory(IntPtr hProcess, long lpBaseAddress, byte[] lpBuffer, uint nSize, out uint lpNumberOfBytesRead);

		// Token: 0x06000069 RID: 105 RVA: 0x00005D34 File Offset: 0x00003F34
		public void WriteString(long pAddress, string pString)
		{
			try
			{
				uint num = 0U;
				if (Memory.WriteProcessMemory(this.ProcessHandle, pAddress, Encoding.UTF8.GetBytes(pString), (uint)pString.Length, out num))
				{
					byte[] lpBuffer = new byte[1];
					Memory.WriteProcessMemory(this.ProcessHandle, pAddress + (long)pString.Length, lpBuffer, 1U, out num);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00005D9C File Offset: 0x00003F9C
		public void WriteFloat(long pAddress, float value)
		{
			try
			{
				uint num = 0U;
				Memory.WriteProcessMemory(this.ProcessHandle, pAddress, BitConverter.GetBytes(value), 4U, out num);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00005DD8 File Offset: 0x00003FD8
		public void WriteInt(long pAddress, ulong value)
		{
			try
			{
				uint num = 0U;
				Memory.WriteProcessMemory(this.ProcessHandle, pAddress, BitConverter.GetBytes(value), 4U, out num);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00005DD8 File Offset: 0x00003FD8
		public void WriteUInt(long pAddress, ulong value)
		{
			try
			{
				uint num = 0U;
				Memory.WriteProcessMemory(this.ProcessHandle, pAddress, BitConverter.GetBytes(value), 4U, out num);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0400005E RID: 94
		public long BaseAddress;

		// Token: 0x0400005F RID: 95
		public int ProcessID;

		// Token: 0x04000060 RID: 96
		public IntPtr ProcessHandle;
	}
}
