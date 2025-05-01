using System;
using System.IO;
using System.Threading;

namespace player
{
	// Token: 0x02000007 RID: 7
	internal class DecryptedChunk
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000026 RID: 38 RVA: 0x000034C0 File Offset: 0x000016C0
		public byte[] DecryptedData
		{
			get
			{
				this._decryptionThread.Join();
				return this._decryptedData;
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002199 File Offset: 0x00000399
		public DecryptedChunk(Cache cache, long chunkIndex)
		{
			this._cache = cache;
			this._chunkIndex = chunkIndex;
			this._decryptionThread = new Thread(new ThreadStart(this.Decrypt));
			this._decryptionThread.Start();
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000034E4 File Offset: 0x000016E4
		private void Decrypt()
		{
			using (Stream stream = File.Open(this._cache.EncryptedVideoFilePath, FileMode.Open, FileAccess.Read, FileShare.Read))
			{
				stream.Position = this._cache.GetEncryptedChunkPosition(this._chunkIndex);
				byte[] array = new byte[this._cache.GetEncryptedChunkLength(this._chunkIndex)];
				stream.Read(array, 0, array.Length);
				this._decryptedData = Program.Decrypt(array, array.Length);
			}
		}

		// Token: 0x04000013 RID: 19
		private Cache _cache;

		// Token: 0x04000014 RID: 20
		private Thread _decryptionThread;

		// Token: 0x04000015 RID: 21
		private long _chunkIndex;

		// Token: 0x04000016 RID: 22
		private byte[] _decryptedData;
	}
}
