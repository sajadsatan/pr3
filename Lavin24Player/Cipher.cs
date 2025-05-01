using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace player
{
	// Token: 0x02000008 RID: 8
	public static class Cipher
	{
		// Token: 0x06000029 RID: 41 RVA: 0x00003570 File Offset: 0x00001770
		public static string Encrypt(string plainText, string password)
		{
			bool flag = plainText == null;
			string text;
			if (flag)
			{
				text = null;
			}
			else
			{
				bool flag2 = password == null;
				if (flag2)
				{
					password = string.Empty;
				}
				byte[] bytes = Encoding.UTF8.GetBytes(plainText);
				byte[] array = Encoding.UTF8.GetBytes(password);
				array = SHA256.Create().ComputeHash(array);
				byte[] array2 = Cipher.Encrypt(bytes, array);
				text = Convert.ToBase64String(array2);
			}
			return text;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000035D8 File Offset: 0x000017D8
		public static string Decrypt(string encryptedText, string password)
		{
			bool flag = encryptedText == null;
			string text;
			if (flag)
			{
				text = null;
			}
			else
			{
				bool flag2 = password == null;
				if (flag2)
				{
					password = string.Empty;
				}
				byte[] array = Convert.FromBase64String(encryptedText);
				byte[] array2 = Encoding.UTF8.GetBytes(password);
				array2 = SHA256.Create().ComputeHash(array2);
				byte[] array3 = Cipher.Decrypt(array, array2);
				text = Encoding.UTF8.GetString(array3);
			}
			return text;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003640 File Offset: 0x00001840
		private static byte[] Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
		{
			byte[] array = null;
			byte[] array2 = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
				{
					Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, array2, 1000);
					rijndaelManaged.KeySize = 256;
					rijndaelManaged.BlockSize = 128;
					rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
					rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
					rijndaelManaged.Mode = CipherMode.CBC;
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
						cryptoStream.Close();
					}
					array = memoryStream.ToArray();
				}
			}
			return array;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003754 File Offset: 0x00001954
		private static byte[] Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
		{
			byte[] array = null;
			byte[] array2 = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
				{
					Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, array2, 1000);
					rijndaelManaged.KeySize = 256;
					rijndaelManaged.BlockSize = 128;
					rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
					rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
					rijndaelManaged.Mode = CipherMode.CBC;
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
						cryptoStream.Close();
					}
					array = memoryStream.ToArray();
				}
			}
			return array;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003868 File Offset: 0x00001A68
		public static string EncryptStringphp(string plainText, byte[] key, byte[] iv)
		{
			Aes aes = Aes.Create();
			aes.Mode = CipherMode.CBC;
			byte[] array = new byte[32];
			Array.Copy(key, 0, array, 0, 32);
			aes.Key = array;
			aes.IV = iv;
			MemoryStream memoryStream = new MemoryStream();
			ICryptoTransform cryptoTransform = aes.CreateEncryptor();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write);
			byte[] bytes = Encoding.ASCII.GetBytes(plainText);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.FlushFinalBlock();
			byte[] array2 = memoryStream.ToArray();
			memoryStream.Close();
			cryptoStream.Close();
			return Convert.ToBase64String(array2, 0, array2.Length);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003910 File Offset: 0x00001B10
		public static string DecryptStringphp(string cipherText, byte[] key, byte[] iv)
		{
			Aes aes = Aes.Create();
			aes.Mode = CipherMode.CBC;
			byte[] array = new byte[32];
			Array.Copy(key, 0, array, 0, 32);
			aes.Key = array;
			aes.IV = iv;
			MemoryStream memoryStream = new MemoryStream();
			ICryptoTransform cryptoTransform = aes.CreateDecryptor();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write);
			string text = string.Empty;
			try
			{
				byte[] array2 = Convert.FromBase64String(cipherText);
				cryptoStream.Write(array2, 0, array2.Length);
				cryptoStream.FlushFinalBlock();
				byte[] array3 = memoryStream.ToArray();
				text = Encoding.ASCII.GetString(array3, 0, array3.Length);
			}
			finally
			{
				memoryStream.Close();
				cryptoStream.Close();
			}
			return text;
		}
	}
}
