using System;
using player.Modula;

namespace player.Repository
{
	// Token: 0x02000017 RID: 23
	public interface IRepository
	{
		// Token: 0x0600010E RID: 270
		tokenResponse AuthenticateUser();

		// Token: 0x0600010F RID: 271
		ApiResponse CheckOrder(string productSku, string hardwareID, string token, Version version);
	}
}
