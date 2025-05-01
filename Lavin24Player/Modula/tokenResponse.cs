using System;

namespace player.Modula
{
	// Token: 0x02000021 RID: 33
	public class tokenResponse
	{
		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600019B RID: 411 RVA: 0x000029A3 File Offset: 0x00000BA3
		// (set) Token: 0x0600019C RID: 412 RVA: 0x000029AB File Offset: 0x00000BAB
		public string token { get; set; }

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600019D RID: 413 RVA: 0x000029B4 File Offset: 0x00000BB4
		// (set) Token: 0x0600019E RID: 414 RVA: 0x000029BC File Offset: 0x00000BBC
		public string user_email { get; set; }

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600019F RID: 415 RVA: 0x000029C5 File Offset: 0x00000BC5
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x000029CD File Offset: 0x00000BCD
		public string user_nicename { get; set; }

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x000029D6 File Offset: 0x00000BD6
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x000029DE File Offset: 0x00000BDE
		public string user_display_name { get; set; }

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x000029E7 File Offset: 0x00000BE7
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x000029EF File Offset: 0x00000BEF
		public int status { get; set; }
	}
}
