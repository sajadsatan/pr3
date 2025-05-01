using System;
using player.Modula;
using player.Repository;

namespace player.Service
{
	// Token: 0x02000015 RID: 21
	public class ActivateService
	{
		// Token: 0x06000107 RID: 263 RVA: 0x00002706 File Offset: 0x00000906
		public ActivateService(IRepository repository)
		{
			this._repository = repository;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00013098 File Offset: 0x00011298
		public tokenResponse AuthenticateUser()
		{
			return this._repository.AuthenticateUser();
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000130B8 File Offset: 0x000112B8
		public ApiResponse CheckOrder(string ProductSku, string hardwareID, string token, Version version)
		{
			return this._repository.CheckOrder(ProductSku, hardwareID, token, version);
		}

		// Token: 0x04000111 RID: 273
		private IRepository _repository;
	}
}
