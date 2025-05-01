using System;

namespace player.Modula
{
	// Token: 0x0200001C RID: 28
	public class ApiResponse
	{
		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00002803 File Offset: 0x00000A03
		// (set) Token: 0x0600016B RID: 363 RVA: 0x0000280B File Offset: 0x00000A0B
		public string elfo { get; set; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00002814 File Offset: 0x00000A14
		// (set) Token: 0x0600016D RID: 365 RVA: 0x0000281C File Offset: 0x00000A1C
		public string statusCode { get; set; }

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00002825 File Offset: 0x00000A25
		// (set) Token: 0x0600016F RID: 367 RVA: 0x0000282D File Offset: 0x00000A2D
		public string statusText { get; set; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000170 RID: 368 RVA: 0x00002836 File Offset: 0x00000A36
		// (set) Token: 0x06000171 RID: 369 RVA: 0x0000283E File Offset: 0x00000A3E
		public Subtitle su { get; set; }
	}
}
