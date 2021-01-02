using System;
using System.Threading;
using System.Windows.Forms;

namespace Cheat
{
    // Token: 0x02000003 RID: 3
    public partial class Form1 : Form
	{
		// Token: 0x0600000C RID: 12 RVA: 0x00002080 File Offset: 0x00000280
		private long PlayerCompPtr(int index)
		{
			if (this.memory.IsProcessRunning(this.TargetProcessName))
			{
				return this.memory.ReadInt64(this.memory.BaseAddress + (long)this.PlayerBase) + (long)(this.PC_ArraySize_Offset * index);
			}
			return 0L;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002698 File Offset: 0x00000898
		private long PlayerPedPtr(int index)
		{
			if (this.memory.IsProcessRunning(this.TargetProcessName))
			{
				return this.memory.ReadInt64(this.memory.BaseAddress + (long)this.PlayerBase + 8L) + (long)(this.PP_ArraySize_Offset * index);
			}
			return 0L;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000020C0 File Offset: 0x000002C0
		private long ZMGlobalBase
		{
			get
			{
				if (this.memory.IsProcessRunning(this.TargetProcessName))
				{
					return this.memory.ReadInt64(this.memory.BaseAddress + (long)this.PlayerBase + 96L);
				}
				return 0L;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000F RID: 15 RVA: 0x000026E8 File Offset: 0x000008E8
		private long ZMBotBase
		{
			get
			{
				if (this.memory.IsProcessRunning(this.TargetProcessName))
				{
					return this.memory.ReadInt64(this.memory.BaseAddress + (long)this.PlayerBase + 104L) + (long)this.PP_ArraySize_Offset;
				}
				return 0L;
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002048 File Offset: 0x00000248
		private void button1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002738 File Offset: 0x00000938
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002048 File Offset: 0x00000248
		private void Form1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002048 File Offset: 0x00000248
		private void xptracker_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002048 File Offset: 0x00000248
		private void xptracker_Scroll(object sender, EventArgs e)
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002048 File Offset: 0x00000248
		private void trackBar1_Scroll(object sender, EventArgs e)
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002048 File Offset: 0x00000248
		private void listView_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000028D4 File Offset: 0x00000AD4
		private void button2_Click(object sender, EventArgs e)
		{
			if (this.memory.IsProcessRunning(this.TargetProcessName))
			{
				long num = this.PlayerCompPtr(0);
				if (num != 0L)
				{
					this.TeleportPos[0] = this.memory.ReadFloat(num + 3560L);
					this.TeleportPos[1] = this.memory.ReadFloat(num + 3564L);
					this.TeleportPos[2] = this.memory.ReadFloat(num + 3568L);
				}
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002048 File Offset: 0x00000248
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000020FA File Offset: 0x000002FA
		private void ZombieTelePort()
		{
			this.ThreadZombieTelePort = new Thread(delegate ()
			{
				while (this.bunifuCheckbox1.Checked)
				{
					if (this.memory.IsProcessRunning(this.TargetProcessName))
					{
						for (int i = 80; i < 300; i++)
						{
							long num = this.PlayerPedPtr(i);
							int num2 = this.memory.ReadInt(num + 8L);
							if (this.memory.ReadInt(num + 920L) != 0 && (num2 == 1074856960 || num2 == 1115136))
							{
								this.memory.WriteFloat(num + 700L, this.TeleportPos[0]);
								this.memory.WriteFloat(num + 700L + 4L, this.TeleportPos[1]);
								this.memory.WriteFloat(num + 700L + 8L, this.TeleportPos[2]);
								this.memory.WriteFloat(num + 700L + 12L, this.TeleportPos[0]);
								this.memory.WriteFloat(num + 700L + 4L + 12L, this.TeleportPos[1]);
								this.memory.WriteFloat(num + 700L + 8L + 12L, this.TeleportPos[2]);
								this.memory.WriteFloat(num + 700L + 12L + 12L, this.TeleportPos[0]);
								this.memory.WriteFloat(num + 700L + 4L + 12L + 12L, this.TeleportPos[1]);
								this.memory.WriteFloat(num + 700L + 8L + 12L + 12L, this.TeleportPos[2]);
							}
						}
					}
				}
			});
			this.ThreadZombieTelePort.IsBackground = true;
			this.ThreadZombieTelePort.Start();
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002048 File Offset: 0x00000248
		private void button3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000212A File Offset: 0x0000032A
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002048 File Offset: 0x00000248
		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002950 File Offset: 0x00000B50
		private void button3_Click_1(object sender, EventArgs e)
		{
			if (this.memory.IsProcessRunning(this.TargetProcessName))
			{
				if (Convert.ToBoolean(this.memory.ReadInt(this.memory.BaseAddress + 310927216L) > 1))
				{
					this.button3.Text = "In Game";
					return;
				}
				this.button3.Text = "Not In Game";
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002048 File Offset: 0x00000248
		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002131 File Offset: 0x00000331
		private void enableGodMod()
		{
			this.ThreadZombieTelePort = new Thread(delegate ()
			{
				while (this.bunifuCheckbox3.Checked)
				{
					int count = this.listView.CheckedItems.Count;
					for (int i = 0; i < count; i++)
					{
						long num = this.PlayerCompPtr(i);
						this.memory.WriteInt(num + (long)this.PC_GodMode, 160UL);
					}
				}
				Thread.Sleep(5);
			});
			this.ThreadZombieTelePort.IsBackground = true;
			this.ThreadZombieTelePort.Start();
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002048 File Offset: 0x00000248
		private void checkBox4_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002161 File Offset: 0x00000361
		private void maxAmmo()
		{
			this.ThreadAmmo = new Thread(delegate ()
			{
				while (this.bunifuCheckbox4.Checked)
				{
					int count = this.listView.CheckedItems.Count;
					for (int i = 0; i < count; i++)
					{
						long num = this.PlayerCompPtr(i);
						this.memory.WriteInt(num + (long)this.PC_MaxAmmo, 250UL);
						this.memory.WriteInt(num + (long)this.PC_MaxAmmo + 8L, 250UL);
						this.memory.WriteInt(num + (long)this.PC_Ammo, 100UL);
						this.memory.WriteInt(num + (long)this.PC_Ammo + 4L, 100UL);
					}
				}
				Thread.Sleep(5);
			});
			this.ThreadAmmo.IsBackground = true;
			this.ThreadAmmo.Start();
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002191 File Offset: 0x00000391
		private void checkBox6_CheckedChanged(object sender, EventArgs e)
		{
			if (this.memory.IsProcessRunning(this.TargetProcessName))
			{
				this.memory.WriteFloat(this.memory.BaseAddress + (long)this.JumpHight, 10000f);
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002048 File Offset: 0x00000248
		private void checkBox5_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000021C9 File Offset: 0x000003C9
		private void ZombieOneShot()
		{
			this.OneShot = new Thread(delegate ()
			{
				while (this.bunifuCheckbox5.Checked)
				{
					if (this.memory.IsProcessRunning(this.TargetProcessName))
					{
						for (int i = 80; i < 300; i++)
						{
							long num = this.PlayerPedPtr(i);
							int num2 = this.memory.ReadInt(num + 8L);
							if (this.memory.ReadInt(num + 920L) != 0 && (num2 == 1074856960 || num2 == 1115136))
							{
								this.memory.WriteInt(num + 920L, 1UL);
							}
						}
					}
				}
				Thread.Sleep(1);
			});
			this.OneShot.IsBackground = true;
			this.OneShot.Start();
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002048 File Offset: 0x00000248
		private void Numeric_JumpHeight_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002048 File Offset: 0x00000248
		private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002048 File Offset: 0x00000248
		private void bunifuSlider1_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002048 File Offset: 0x00000248
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002048 File Offset: 0x00000248
		private void button4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002048 File Offset: 0x00000248
		private void listView_SelectedIndexChanged_1(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000212A File Offset: 0x0000032A
		private void button5_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000021F9 File Offset: 0x000003F9
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			this.mouseDown = true;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000029C0 File Offset: 0x00000BC0
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.mouseDown)
			{
				this.mouseX = Control.MousePosition.X - 200;
				this.mouseY = Control.MousePosition.Y - 40;
				base.SetDesktopLocation(this.mouseX, this.mouseY);
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002202 File Offset: 0x00000402
		private void panel1_MouseUp(object sender, MouseEventArgs e)
		{
			this.mouseDown = false;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002048 File Offset: 0x00000248
		private void label4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002048 File Offset: 0x00000248
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000220B File Offset: 0x0000040B
		private void button7_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Click \"Refresh Players\" once in game at the screen where you choose your weapons. \n\nSelect the players by clicking the checkmark next to their name.");
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002048 File Offset: 0x00000248
		private void label5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002048 File Offset: 0x00000248
		private void label6_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002048 File Offset: 0x00000248
		private void label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000028D4 File Offset: 0x00000AD4
		private void bunifuTileButton1_Click(object sender, EventArgs e)
		{
			if (this.memory.IsProcessRunning(this.TargetProcessName))
			{
				long num = this.PlayerCompPtr(0);
				if (num != 0L)
				{
					this.TeleportPos[0] = this.memory.ReadFloat(num + 3560L);
					this.TeleportPos[1] = this.memory.ReadFloat(num + 3564L);
					this.TeleportPos[2] = this.memory.ReadFloat(num + 3568L);
				}
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002218 File Offset: 0x00000418
		private void bunifuCheckbox1_OnChange_1(object sender, EventArgs e)
		{
			if (this.memory.IsProcessRunning(this.TargetProcessName))
			{
				if (this.bunifuCheckbox1.Checked)
				{
					this.ZombieTelePort();
					return;
				}
				this.ThreadZombieTelePort.Abort();
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002A18 File Offset: 0x00000C18
		private void bunifuCheckbox2_OnChange(object sender, EventArgs e)
		{
			if (this.memory.IsProcessRunning(this.TargetProcessName))
			{
				if (this.bunifuCheckbox2.Checked)
				{
					this.memory.WriteUInt(this.ZMGlobalBase + (long)this.ZM_Global_ZombiesIgnoreAll, 1UL);
					return;
				}
				this.memory.WriteUInt(this.ZMGlobalBase + (long)this.ZM_Global_ZombiesIgnoreAll, 0UL);
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002A7C File Offset: 0x00000C7C
		private void bunifuCheckbox3_OnChange(object sender, EventArgs e)
		{
			if (this.memory.IsProcessRunning(this.TargetProcessName))
			{
				if (this.bunifuCheckbox3.Checked)
				{
					this.enableGodMod();
					return;
				}
				this.ThreadZombieTelePort.Abort();
				int count = this.listView.CheckedItems.Count;
				for (int i = 0; i < count; i++)
				{
					long num = this.PlayerCompPtr(i);
					this.memory.WriteInt(num + (long)this.PC_GodMode, 32UL);
				}
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002AF8 File Offset: 0x00000CF8
		private void bunifuCheckbox4_OnChange(object sender, EventArgs e)
		{
			if (this.memory.IsProcessRunning(this.TargetProcessName))
			{
				if (this.bunifuCheckbox4.Checked)
				{
					this.maxAmmo();
					return;
				}
				this.ThreadAmmo.Abort();
				int count = this.listView.CheckedItems.Count;
				for (int i = 0; i < count; i++)
				{
					long num = this.PlayerCompPtr(i);
					this.memory.WriteInt(num + (long)this.PC_MaxAmmo, 250UL);
					this.memory.WriteInt(num + (long)this.PC_MaxAmmo + 8L, 250UL);
					this.memory.WriteInt(num + (long)this.PC_Ammo, 50UL);
					this.memory.WriteInt(num + (long)this.PC_Ammo + 4L, 50UL);
				}
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002048 File Offset: 0x00000248
		private void bunifuCustomLabel1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000224C File Offset: 0x0000044C
		private void bunifuCheckbox5_OnChange(object sender, EventArgs e)
		{
			if (this.memory.IsProcessRunning(this.TargetProcessName))
			{
				if (this.bunifuCheckbox5.Checked)
				{
					this.ZombieOneShot();
					return;
				}
				this.OneShot.Abort();
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002BC8 File Offset: 0x00000DC8
		private void bunifuTileButton2_Click(object sender, EventArgs e)
		{
			if (this.memory.IsProcessRunning(this.TargetProcessName))
			{
				int count = this.listView.CheckedItems.Count;
				for (int i = 0; i < count; i++)
				{
					long num = this.PlayerCompPtr(i);
					this.memory.WriteInt(num + (long)this.PC_Points, 50000UL);
				}
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002C28 File Offset: 0x00000E28
		private void bunifuSlider1_ValueChanged_1(object sender, EventArgs e)
		{
			int value = this.bunifuSlider1.Value;
			this.label1.Text = value.ToString();
			if (this.memory.IsProcessRunning(this.TargetProcessName))
			{
				this.memory.WriteFloat(this.memory.BaseAddress + (long)this.XPScaleZM, (float)value);
				this.memory.WriteFloat(this.memory.BaseAddress + (long)this.XPScaleZM + 8L, (float)value);
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002CAC File Offset: 0x00000EAC
		private void bunifuSlider2_ValueChanged(object sender, EventArgs e)
		{
			int value = this.bunifuSlider2.Value;
			this.label2.Text = value.ToString();
			if (this.memory.IsProcessRunning(this.TargetProcessName))
			{
				this.memory.WriteFloat(this.memory.BaseAddress + (long)this.GunXPScaleZM, (float)value);
				this.memory.WriteFloat(this.memory.BaseAddress + (long)this.GunXPScaleZM + 8L, (float)value);
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002D30 File Offset: 0x00000F30
		private void bunifuTileButton3_Click(object sender, EventArgs e)
		{
			this.listView.Items.Clear();
			if (this.memory.IsProcessRunning(this.TargetProcessName))
			{
				for (int i = 0; i < 4; i++)
				{
					long num = this.PlayerCompPtr(i);
					string text = this.memory.ReadString(num + (long)this.PC_Name) ?? "";
					if (text != "" && text != "UnnamedPlayer")
					{
						ListViewItem listViewItem = new ListViewItem();
						listViewItem.Text = text;
						listViewItem.SubItems.Add(text);
						this.listView.Items.Add(listViewItem);
					}
				}
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002048 File Offset: 0x00000248
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002048 File Offset: 0x00000248
		private void textBox9_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002048 File Offset: 0x00000248
		private void bunifuCustomLabel2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002DD8 File Offset: 0x00000FD8
		private void bunifuTileButton4_Click(object sender, EventArgs e)
		{
			if (this.memory.IsProcessRunning(this.TargetProcessName))
			{
				int count = this.listView.CheckedItems.Count;
				for (int i = 0; i < count; i++)
				{
					long num = this.PlayerPedPtr(i);
					this.memory.ReadInt(num + 8L);
					if (this.memory.ReadInt(num + 920L) != 0)
					{
						this.memory.WriteInt(num + 920L, 0UL);
					}
				}
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002048 File Offset: 0x00000248
		private void bunifuCustomLabel5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002E58 File Offset: 0x00001058

		// Token: 0x06000047 RID: 71 RVA: 0x00002280 File Offset: 0x00000480
		private void button6_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x04000002 RID: 2
		private int mouseX;

		// Token: 0x04000003 RID: 3
		private int mouseY;

		// Token: 0x04000004 RID: 4
		private bool mouseDown;

		// Token: 0x04000005 RID: 5
		private Thread OneShot;

		// Token: 0x04000006 RID: 6
		private Thread ThreadZombieTelePort;

		// Token: 0x04000007 RID: 7
		private Thread ThreadAmmo;

		// Token: 0x04000008 RID: 8
		public float[] TeleportPos = new float[3];

		// Token: 0x04000009 RID: 9
		public int GameMode = 310927216;

		// Token: 0x0400000A RID: 10
		public int PlayerBase = 265315656;

		// Token: 0x0400000B RID: 11
		public int TimeScaleBase = 249383412;

		// Token: 0x0400000C RID: 12
		public int CMDBufferBase = 292272864;

		// Token: 0x0400000D RID: 13
		public int XPScaleZM = 265479520;

		// Token: 0x0400000E RID: 14
		public int GunXPScaleZM = 265479536;

		// Token: 0x0400000F RID: 15
		public int JumpHight = 279450696;

		// Token: 0x04000010 RID: 16
		public int PC_ArraySize_Offset = 47152;

		// Token: 0x04000011 RID: 17
		public int PC_CurrentUsedWeaponID = 40;

		// Token: 0x04000012 RID: 18
		public int PC_SetWeaponID = 176;

		// Token: 0x04000013 RID: 19
		public int PC_InfraredVision = 3686;

		// Token: 0x04000014 RID: 20
		public int PC_GodMode = 3687;

		// Token: 0x04000015 RID: 21
		public int PC_RapidFire1 = 3692;

		// Token: 0x04000016 RID: 22
		public int PC_RapidFire2 = 3712;

		// Token: 0x04000017 RID: 23
		public int PC_MaxAmmo = 4960;

		// Token: 0x04000018 RID: 24
		public int PC_Ammo = 5076;

		// Token: 0x04000019 RID: 25
		public int PC_Points = 23780;

		// Token: 0x0400001A RID: 26
		public int PC_Name = 23514;

		// Token: 0x0400001B RID: 27
		public int PC_RunSpeed = 23600;

		// Token: 0x0400001C RID: 28
		public int PC_ClanTags = 24668;

		// Token: 0x0400001D RID: 29
		public int PP_ArraySize_Offset = 1528;

		// Token: 0x0400001E RID: 30
		public int PP_Health = 920;

		// Token: 0x0400001F RID: 31
		public int PP_MaxHealth = 924;

		// Token: 0x04000020 RID: 32
		public int PP_Coords = 724;

		// Token: 0x04000021 RID: 33
		public int PP_Heading_Z = 52;

		// Token: 0x04000022 RID: 34
		public int PP_Heading_XY = 56;

		// Token: 0x04000023 RID: 35
		public int ZM_Global_ZombiesIgnoreAll = 20;

		// Token: 0x04000024 RID: 36
		public int ZM_Global_ZMLeftCount = 60;

		// Token: 0x04000025 RID: 37
		public int ZM_Bot_List_Offset = 8;

		// Token: 0x04000026 RID: 38
		public int ZM_Bot_ArraySize_Offset = 1528;

		// Token: 0x04000027 RID: 39
		public int ZM_Bot_Health = 920;

		// Token: 0x04000028 RID: 40
		public int ZM_Bot_MaxHealth = 924;

		// Token: 0x04000029 RID: 41
		public string TargetProcessName = "BlackOpsColdWar";

		// Token: 0x0400002A RID: 42
		private Memory memory = new Memory();

		// Token: 0x0400002B RID: 43
		public int ZM_Bot_Coords = 724;

		// Token: 0x0400002C RID: 44
		public int CMDBB_Exec = -27;

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
			MessageBox.Show("Kipak#0666");
		}

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton6_Click(object sender, EventArgs e)
        {
			MessageBox.Show("Kipak#0666");

		}
	}
}