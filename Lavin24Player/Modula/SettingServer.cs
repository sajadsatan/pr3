using System;

namespace player.Modula
{
	// Token: 0x0200001F RID: 31
	public class SettingServer
	{
		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600017B RID: 379 RVA: 0x000028A4 File Offset: 0x00000AA4
		// (set) Token: 0x0600017C RID: 380 RVA: 0x000028AC File Offset: 0x00000AAC
		public int Method { get; set; }

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600017D RID: 381 RVA: 0x000028B5 File Offset: 0x00000AB5
		// (set) Token: 0x0600017E RID: 382 RVA: 0x000028BD File Offset: 0x00000ABD
		public int Interval { get; set; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600017F RID: 383 RVA: 0x000028C6 File Offset: 0x00000AC6
		// (set) Token: 0x06000180 RID: 384 RVA: 0x000028CE File Offset: 0x00000ACE
		public int MaxRequest { get; set; }

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000181 RID: 385 RVA: 0x000028D7 File Offset: 0x00000AD7
		// (set) Token: 0x06000182 RID: 386 RVA: 0x000028DF File Offset: 0x00000ADF
		public string Options { get; set; }
	}
}
