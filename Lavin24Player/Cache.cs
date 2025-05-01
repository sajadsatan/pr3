using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace player
{
	// Token: 0x02000006 RID: 6
	internal class Cache
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00002FFC File Offset: 0x000011FC
		public long Length
		{
			get
			{
				return this._length;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00003014 File Offset: 0x00001214
		public string EncryptedVideoFilePath
		{
			get
			{
				return this._encryptedVideoFilePath;
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000302C File Offset: 0x0000122C
		public Cache(string encryptedVideoFilePath)
		{
			this._encryptedVideoFilePath = encryptedVideoFilePath;
			using (Stream stream = File.Open(encryptedVideoFilePath, FileMode.Open, FileAccess.Read, FileShare.Read))
			{
				using (Stream stream2 = File.Open(encryptedVideoFilePath, FileMode.Open, FileAccess.Read, FileShare.Read))
				{
					using (BinaryReader binaryReader = new BinaryReader(stream2))
					{
						this._length = 0L;
						stream2.Position = stream.Length - 4L;
						this._chunkCount = binaryReader.ReadInt32();
						stream2.Position = stream.Length - 4L - (long)(this._chunkCount * 4) - (long)(this._chunkCount * 4);
						this._encryptedChunkLength = new int[this._chunkCount];
						this._sourceChunkLength = new int[this._chunkCount];
						this._encryptedChunkPosition = new long[this._chunkCount];
						for (int i = 0; i < this._chunkCount; i++)
						{
							this._sourceChunkLength[i] = binaryReader.ReadInt32();
							this._length += (long)this._sourceChunkLength[i];
						}
						long num = 0L;
						for (int j = 0; j < this._chunkCount; j++)
						{
							this._encryptedChunkLength[j] = binaryReader.ReadInt32();
							this._encryptedChunkPosition[j] = num;
							num += (long)this._encryptedChunkLength[j];
						}
					}
				}
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003204 File Offset: 0x00001404
		public long GetEncryptedChunkPosition(long chunkIndex)
		{
			return this._encryptedChunkPosition[(int)(checked((IntPtr)chunkIndex))];
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003220 File Offset: 0x00001420
		public long GetEncryptedChunkLength(long chunkIndex)
		{
			return (long)this._encryptedChunkLength[(int)(checked((IntPtr)chunkIndex))];
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000323C File Offset: 0x0000143C
		public long GetSourceChunkLength(long chunkIndex)
		{
			return (long)this._sourceChunkLength[(int)(checked((IntPtr)chunkIndex))];
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003258 File Offset: 0x00001458
		private void RemoveOldCachedItems()
		{
			while (this._decryptedChunkByChunkIndex.Count >= Cache._maxDecryptedChunkCount && this._decryptedChunkIndexSortedByCreationTime.Count > 0)
			{
				this._decryptedChunkByChunkIndex.Remove(this._decryptedChunkIndexSortedByCreationTime[0]);
				this._decryptedChunkIndexSortedByCreationTime.RemoveAt(0);
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000032BC File Offset: 0x000014BC
		private DecryptedChunk GetOrAddDecryptedChunk(long chunkIndex)
		{
			object @lock = this._lock;
			DecryptedChunk decryptedChunk;
			lock (@lock)
			{
				bool flag2 = this._decryptedChunkByChunkIndex.Contains(chunkIndex);
				if (flag2)
				{
					decryptedChunk = (DecryptedChunk)this._decryptedChunkByChunkIndex[chunkIndex];
				}
				else
				{
					DecryptedChunk decryptedChunk2 = new DecryptedChunk(this, chunkIndex);
					this._decryptedChunkByChunkIndex.Add(chunkIndex, decryptedChunk2);
					this._decryptedChunkIndexSortedByCreationTime.Add(chunkIndex);
					this.RemoveOldCachedItems();
					decryptedChunk = decryptedChunk2;
				}
			}
			return decryptedChunk;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003360 File Offset: 0x00001560
		private bool CacheChunk(long chunkIndex)
		{
			object @lock = this._lock;
			bool flag3;
			lock (@lock)
			{
				bool flag2 = this._decryptedChunkByChunkIndex.Contains(chunkIndex);
				if (flag2)
				{
					flag3 = false;
				}
				else
				{
					DecryptedChunk decryptedChunk = new DecryptedChunk(this, chunkIndex);
					this._decryptedChunkByChunkIndex.Add(chunkIndex, decryptedChunk);
					this._decryptedChunkIndexSortedByCreationTime.Add(chunkIndex);
					this.RemoveOldCachedItems();
					flag3 = true;
				}
			}
			return flag3;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000033EC File Offset: 0x000015EC
		public byte[] GetDecryptedChunk(long chunkIndex)
		{
			DecryptedChunk orAddDecryptedChunk = this.GetOrAddDecryptedChunk(chunkIndex);
			int num = 0;
			long num2 = chunkIndex + 1L;
			while (num < Cache._additionalChunkToCache && num2 < (long)this._chunkCount && this._decryptedChunkByChunkIndex.Count < Cache._maxDecryptedChunkCount)
			{
				bool flag = this.CacheChunk(num2);
				if (flag)
				{
					num++;
				}
				num2 += 1L;
			}
			int num3 = Program.check_software();
			bool flag2 = num3 == 1;
			if (flag2)
			{
				MessageBox.Show("خطای 340: کد خطا به پشتیبان اعلام شود");
				Application.Exit();
			}
			else
			{
				bool flag3 = num3 == 2;
				if (flag3)
				{
					MessageBox.Show("نرم افزار های ضبط تصویر را ببنیدید و مجدد امتحان نمایید.");
					Application.Exit();
				}
				else
				{
					bool flag4 = num3 == 3;
					if (flag4)
					{
						MessageBox.Show("ریموت دسکتاپ خود را ببندید و مجدد امتحان نمایید.");
						Application.Exit();
					}
				}
			}
			return orAddDecryptedChunk.DecryptedData;
		}

		// Token: 0x04000008 RID: 8
		private string _encryptedVideoFilePath;

		// Token: 0x04000009 RID: 9
		private int[] _encryptedChunkLength;

		// Token: 0x0400000A RID: 10
		private long[] _encryptedChunkPosition;

		// Token: 0x0400000B RID: 11
		private int[] _sourceChunkLength;

		// Token: 0x0400000C RID: 12
		private int _chunkCount;

		// Token: 0x0400000D RID: 13
		private long _length;

		// Token: 0x0400000E RID: 14
		private Hashtable _decryptedChunkByChunkIndex = new Hashtable();

		// Token: 0x0400000F RID: 15
		private List<long> _decryptedChunkIndexSortedByCreationTime = new List<long>();

		// Token: 0x04000010 RID: 16
		private static int _maxDecryptedChunkCount = 16;

		// Token: 0x04000011 RID: 17
		private static int _additionalChunkToCache = 4;

		// Token: 0x04000012 RID: 18
		private object _lock = new object();
	}
}
