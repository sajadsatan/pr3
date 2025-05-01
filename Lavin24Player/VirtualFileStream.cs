using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace player
{
	// Token: 0x02000014 RID: 20
	internal class VirtualFileStream : IStream
	{
		// Token: 0x060000FA RID: 250 RVA: 0x00002671 File Offset: 0x00000871
		public VirtualFileStream(string encryptedVideoFilePath)
		{
			this._cache = new Cache(encryptedVideoFilePath);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000026A2 File Offset: 0x000008A2
		private VirtualFileStream(Cache cache)
		{
			this._cache = cache;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00012E54 File Offset: 0x00011054
		public void Read(byte[] pv, int cb, IntPtr pcbRead)
		{
			bool flag = this._position < 0L || this._position > this._cache.Length;
			int num;
			if (flag)
			{
				num = 0;
			}
			else
			{
				object @lock = this._lock;
				lock (@lock)
				{
					int num2 = 0;
					int num3 = cb;
					int num4 = 0;
					while (num3 > 0 && this._position < this._cache.Length)
					{
						long num5 = this._position / (long)Program.ChunkSize;
						bool flag3 = -1L == this._currentChunkIndex || this._currentChunkIndex != num5;
						if (flag3)
						{
							this._currentChunkIndex = num5;
							this._currentChunk = this._cache.GetDecryptedChunk(num5);
						}
						int num6 = (int)(this._position - this._currentChunkIndex * (long)Program.ChunkSize);
						int num7 = (int)(this._cache.GetSourceChunkLength(this._currentChunkIndex) - (long)num6);
						bool flag4 = num7 < num3;
						int num8;
						if (flag4)
						{
							num8 = num7;
						}
						else
						{
							num8 = num3;
						}
						Array.Copy(this._currentChunk, num6, pv, num4, num8);
						num3 -= num8;
						num2 += num8;
						num4 += num8;
						this._position += (long)num8;
					}
					num = num2;
				}
			}
			bool flag5 = IntPtr.Zero != pcbRead;
			if (flag5)
			{
				Marshal.WriteIntPtr(pcbRead, new IntPtr(num));
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000026CE File Offset: 0x000008CE
		public void Write(byte[] pv, int cb, IntPtr pcbWritten)
		{
			throw new Exception("The method or operation is not implemented.");
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000026DB File Offset: 0x000008DB
		public void Clone(out IStream ppstm)
		{
			ppstm = new VirtualFileStream(this._cache);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00012FEC File Offset: 0x000111EC
		public void Seek(long dlibMove, int dwOrigin, IntPtr plibNewPosition)
		{
			object @lock = this._lock;
			lock (@lock)
			{
				switch (dwOrigin)
				{
				case 0:
					this._position = dlibMove;
					break;
				case 1:
					this._position += dlibMove;
					break;
				case 2:
					this._position = this._cache.Length + dlibMove;
					break;
				}
			}
			bool flag2 = IntPtr.Zero != plibNewPosition;
			if (flag2)
			{
				Marshal.WriteInt64(plibNewPosition, this._position);
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000026EB File Offset: 0x000008EB
		public void Stat(out global::System.Runtime.InteropServices.ComTypes.STATSTG pstatstg, int grfStatFlag)
		{
			pstatstg = default(global::System.Runtime.InteropServices.ComTypes.STATSTG);
			pstatstg.cbSize = this._cache.Length;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000026CE File Offset: 0x000008CE
		public void Commit(int grfCommitFlags)
		{
			throw new Exception("The method or operation is not implemented.");
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000026CE File Offset: 0x000008CE
		public void CopyTo(IStream pstm, long cb, IntPtr pcbRead, IntPtr pcbWritten)
		{
			throw new Exception("The method or operation is not implemented.");
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000026CE File Offset: 0x000008CE
		public void LockRegion(long libOffset, long cb, int dwLockType)
		{
			throw new Exception("The method or operation is not implemented.");
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000026CE File Offset: 0x000008CE
		public void Revert()
		{
			throw new Exception("The method or operation is not implemented.");
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000026CE File Offset: 0x000008CE
		public void SetSize(long libNewSize)
		{
			throw new Exception("The method or operation is not implemented.");
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000026CE File Offset: 0x000008CE
		public void UnlockRegion(long libOffset, long cb, int dwLockType)
		{
			throw new Exception("The method or operation is not implemented.");
		}

		// Token: 0x0400010C RID: 268
		private byte[] _currentChunk;

		// Token: 0x0400010D RID: 269
		private long _currentChunkIndex = -1L;

		// Token: 0x0400010E RID: 270
		private long _position = 0L;

		// Token: 0x0400010F RID: 271
		private object _lock = new object();

		// Token: 0x04000110 RID: 272
		private Cache _cache;
	}
}
