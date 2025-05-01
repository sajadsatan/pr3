using System;
using System.Diagnostics;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using DeviceId;
using LibVLCSharp.Shared;
using Microsoft.Win32;
using Newtonsoft.Json;
using NodaTime;
using player.Modula;
using player.Properties;

namespace player
{
	// Token: 0x02000012 RID: 18
	internal static class Program
	{
		// Token: 0x060000D9 RID: 217
		[DllImport("dwmapi.dll", PreserveSig = false)]
		public static extern bool DwmIsCompositionEnabled();

		// Token: 0x060000DA RID: 218 RVA: 0x000105B8 File Offset: 0x0000E7B8
		public static string convert_Subtitle_to_string(Subtitle su)
		{
			string text = JsonConvert.SerializeObject(su);
			return text.ToString();
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000105D8 File Offset: 0x0000E7D8
		public static bool CheckForInternetConnection()
		{
			bool flag;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					using (webClient.OpenRead("http://google.com/generate_204"))
					{
						flag = true;
					}
				}
			}
			catch
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00010644 File Offset: 0x0000E844
		public static Subtitle Process_Sub(string su_json)
		{
			bool flag = su_json != "";
			Subtitle subtitle2;
			if (flag)
			{
				Subtitle subtitle = JsonConvert.DeserializeObject<Subtitle>(su_json);
				subtitle2 = subtitle;
			}
			else
			{
				subtitle2 = new Subtitle();
			}
			return subtitle2;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00010678 File Offset: 0x0000E878
		public static int random_position_sub()
		{
			Random random = new Random();
			return random.Next(0, 9);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0001069C File Offset: 0x0000E89C
		public static void show_subtitle(string su_json, MediaPlayer _mp)
		{
			Program.duration_show_s = 0;
			Program.interval_show_s = 0;
			Program.position_random_sub = false;
			_mp.SetMarqueeInt(VideoMarqueeOption.Enable, 0);
			Subtitle subtitle = Program.Process_Sub(su_json);
			bool flag = su_json != "";
			if (flag)
			{
				bool flag2 = subtitle.status == "1";
				if (flag2)
				{
					bool flag3 = subtitle.type == "1";
					if (flag3)
					{
						_mp.SetMarqueeInt(VideoMarqueeOption.Enable, 1);
						Program.duration_show_s = 0;
						Program.interval_show_s = 0;
					}
					else
					{
						bool flag4 = subtitle.type == "2";
						if (flag4)
						{
							bool flag5 = subtitle.duration_show_s != 0 && subtitle.interval_show_s != 0;
							if (flag5)
							{
								Program.duration_show_s = subtitle.duration_show_s;
								Program.interval_show_s = subtitle.interval_show_s;
								_mp.SetMarqueeInt(VideoMarqueeOption.Enable, 0);
							}
						}
					}
					_mp.SetMarqueeInt(VideoMarqueeOption.Size, (int)short.Parse(subtitle.font_size));
					_mp.SetMarqueeInt(VideoMarqueeOption.Opacity, (int)short.Parse(subtitle.Opacity));
					bool flag6 = subtitle.position_type == "11";
					if (flag6)
					{
						_mp.SetMarqueeInt(VideoMarqueeOption.Position, (int)short.Parse("0"));
					}
					else
					{
						bool flag7 = subtitle.position_type == "12";
						if (flag7)
						{
							_mp.SetMarqueeInt(VideoMarqueeOption.Position, (int)short.Parse("10"));
						}
						else
						{
							bool flag8 = subtitle.position_type != "10";
							if (flag8)
							{
								_mp.SetMarqueeInt(VideoMarqueeOption.Position, (int)short.Parse(subtitle.position_type));
							}
							else
							{
								Program.position_random_sub = true;
								_mp.SetMarqueeInt(VideoMarqueeOption.Position, 9);
							}
						}
					}
					_mp.SetMarqueeInt(VideoMarqueeOption.X, (int)short.Parse(subtitle.margin_X));
					_mp.SetMarqueeInt(VideoMarqueeOption.Y, (int)short.Parse(subtitle.margin_y));
					_mp.SetMarqueeString(VideoMarqueeOption.Text, subtitle.txt);
					string txt_color = subtitle.txt_color;
					string text = txt_color;
					uint num = <PrivateImplementationDetails>.ComputeStringHash(text);
					if (num <= 1618317229U)
					{
						if (num <= 327924046U)
						{
							if (num != 151353621U)
							{
								if (num != 315452821U)
								{
									if (num == 327924046U)
									{
										if (text == "0xC0C0C0")
										{
											_mp.SetMarqueeInt(VideoMarqueeOption.Color, 12632256);
										}
									}
								}
								else if (text == "0x000080")
								{
									_mp.SetMarqueeInt(VideoMarqueeOption.Color, 128);
								}
							}
							else if (text == "0x800000")
							{
								_mp.SetMarqueeInt(VideoMarqueeOption.Color, 8388608);
							}
						}
						else if (num <= 657591885U)
						{
							if (num != 600072221U)
							{
								if (num == 657591885U)
								{
									if (text == "0xFF00FF")
									{
										_mp.SetMarqueeInt(VideoMarqueeOption.Color, 16711935);
									}
								}
							}
							else if (text == "0x808000")
							{
								_mp.SetMarqueeInt(VideoMarqueeOption.Color, 8421376);
							}
						}
						else if (num != 1241223149U)
						{
							if (num == 1618317229U)
							{
								if (text == "0xFFFFFF")
								{
									_mp.SetMarqueeInt(VideoMarqueeOption.Color, 16777215);
								}
							}
						}
						else if (text == "0x00FF00")
						{
							_mp.SetMarqueeInt(VideoMarqueeOption.Color, 65280);
						}
					}
					else if (num <= 2363204909U)
					{
						if (num <= 2048259589U)
						{
							if (num != 1985159181U)
							{
								if (num == 2048259589U)
								{
									if (text == "0x008000")
									{
										_mp.SetMarqueeInt(VideoMarqueeOption.Color, 32768);
									}
								}
							}
							else if (text == "0xFFFF00")
							{
								_mp.SetMarqueeInt(VideoMarqueeOption.Color, 16776960);
							}
						}
						else if (num != 2315421565U)
						{
							if (num == 2363204909U)
							{
								if (text == "0x0000FF")
								{
									_mp.SetMarqueeInt(VideoMarqueeOption.Color, 255);
								}
							}
						}
						else if (text == "0x008080")
						{
							_mp.SetMarqueeInt(VideoMarqueeOption.Color, 32896);
						}
					}
					else if (num <= 2730046861U)
					{
						if (num != 2480445477U)
						{
							if (num == 2730046861U)
							{
								if (text == "0x000000")
								{
									_mp.SetMarqueeInt(VideoMarqueeOption.Color, 0);
								}
							}
						}
						else if (text == "0x808080")
						{
							_mp.SetMarqueeInt(VideoMarqueeOption.Color, 8421504);
						}
					}
					else if (num != 4085238285U)
					{
						if (num == 4235290925U)
						{
							if (text == "0xFF0000")
							{
								_mp.SetMarqueeInt(VideoMarqueeOption.Color, 16711680);
							}
						}
					}
					else if (text == "0x00FFFF")
					{
						_mp.SetMarqueeInt(VideoMarqueeOption.Color, 65535);
					}
				}
			}
			else
			{
				_mp.SetMarqueeInt(VideoMarqueeOption.Enable, 0);
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00010BDC File Offset: 0x0000EDDC
		public static byte[] Encrypt(byte[] input, int size)
		{
			TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
			byte[] array;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, tripleDESCryptoServiceProvider.CreateEncryptor(Program.Key, Program.IV), CryptoStreamMode.Write))
				{
					cryptoStream.Write(input, 0, size);
					cryptoStream.FlushFinalBlock();
					array = new byte[memoryStream.Length];
					memoryStream.Position = 0L;
					memoryStream.Read(array, 0, array.Length);
				}
			}
			return array;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00010C84 File Offset: 0x0000EE84
		public static byte[] Decrypt(byte[] input, int size)
		{
			byte[] array = new byte[size];
			TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
			using (MemoryStream memoryStream = new MemoryStream(input))
			{
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, tripleDESCryptoServiceProvider.CreateDecryptor(Program.Key, Program.IV), CryptoStreamMode.Read))
				{
					cryptoStream.Read(array, 0, size);
				}
			}
			return array;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00010D0C File Offset: 0x0000EF0C
		public static bool NotMotherboard(string motherboardID)
		{
			return motherboardID == null || motherboardID == "" || motherboardID == "To be filled by O.E.M." || motherboardID == " " || motherboardID == "  " || motherboardID == "N/A" || motherboardID == "n/a" || motherboardID == "Default string" || motherboardID == "default string" || motherboardID == "NA" || motherboardID == "onboard number type2" || motherboardID == " onboard number type1";
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00010DC4 File Offset: 0x0000EFC4
		public static string getMotherBoardID()
		{
			string text = "";
			try
			{
				ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BaseBoard");
				ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
				foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
				{
					ManagementObject managementObject = (ManagementObject)managementBaseObject;
					text = managementObject["SerialNumber"].ToString();
				}
			}
			catch (Exception ex)
			{
				text = new DeviceIdBuilder().AddMotherboardSerialNumber().ToString();
			}
			bool flag = Program.NotMotherboard(text);
			if (flag)
			{
				text = new DeviceIdBuilder().AddMotherboardSerialNumber().ToString();
				bool flag2 = Program.NotMotherboard(text);
				if (flag2)
				{
					text = new DeviceIdBuilder().AddProcessorId().ToString();
					bool flag3 = Program.NotMotherboard(text);
					if (flag3)
					{
						text = new DeviceIdBuilder().AddSystemDriveSerialNumber().ToString();
						bool flag4 = Program.NotMotherboard(text);
						if (flag4)
						{
							text = new DeviceIdBuilder().AddUserName().ToString() + new DeviceIdBuilder().AddMachineName().ToString();
							bool flag5 = Program.NotMotherboard(text);
							if (flag5)
							{
								text = "No Detect System ID";
							}
							else
							{
								text = "Username+MachineName:" + text;
							}
						}
						else
						{
							text = "DriveSerial:" + text;
						}
					}
					else
					{
						text = "cpu_id:" + text;
					}
				}
			}
			return text;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00010F40 File Offset: 0x0000F140
		public static string getHardDiskID()
		{
			ManagementObject managementObject = new ManagementObject("win32_logicaldisk.deviceid=\"c:\"");
			managementObject.Get();
			return managementObject["VolumeSerialNumber"].ToString();
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00010F78 File Offset: 0x0000F178
		public static string ReadLastLine(string path)
		{
			string text = Program.ReadLastLine(path, Encoding.ASCII, "\n");
			bool flag = text.Contains("@--@");
			string text2;
			if (flag)
			{
				text2 = text;
			}
			else
			{
				text2 = Program.ReadLastLine(path, Encoding.ASCII, "IN");
			}
			return text2;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00010FC0 File Offset: 0x0000F1C0
		public static string ReadLastLine(string path, Encoding encoding, string newline)
		{
			int byteCount = encoding.GetByteCount(newline);
			byte[] array = encoding.GetBytes(newline);
			using (FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read))
			{
				long num = fileStream.Length / (long)byteCount;
				for (long num2 = (long)byteCount; num2 < num; num2 += (long)byteCount)
				{
					fileStream.Seek(-num2, SeekOrigin.End);
					fileStream.Read(array, 0, array.Length);
					bool flag = encoding.GetString(array) == newline;
					if (flag)
					{
						array = new byte[fileStream.Length - fileStream.Position];
						fileStream.Read(array, 0, array.Length);
						return encoding.GetString(array);
					}
				}
			}
			return null;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00011088 File Offset: 0x0000F288
		public static bool IsNullOrEmpty(this Array array)
		{
			return array == null || array.Length == 0;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000110AC File Offset: 0x0000F2AC
		public static int check_software()
		{
			bool flag = Environment.OSVersion.Version.Major >= 6 && Program.DwmIsCompositionEnabled();
			int num;
			if (flag)
			{
				Process[] processes = Process.GetProcesses();
				string[] array = new string[]
				{
					"scnrec", "scnrecportable", "action_svc", "camrecorder", "aiseesoft screen recorder", "allcapture", "anymp4 screen recorder", "apowersoft screen recorder pro 2", "screen recorder 6", "fonepaw screen recorder",
					"smm_hypercam_business", "smartscreen", "obs64", "obs32", "ocam", "screenrecorder", "screen_recorder", "screen-recorder", "Screenpresso", "screenpresso",
					"screen.pressoportable", "snagit32", "snagit64", "anydesk", "teamViewer", "teamviewer_service", "bdcam", "iscrrec", "discord", "apeaksoft screen recorder"
				};
				foreach (Process process in processes)
				{
					string text = process.ProcessName;
					text = text.ToLower();
					foreach (string text2 in array)
					{
						bool flag2 = text.CompareTo(text2) == 0;
						if (flag2)
						{
							Process[] processesByName = Process.GetProcessesByName(text2);
							foreach (Process process2 in processesByName)
							{
								string text3 = process2.ProcessName;
								text3 = text3.ToLower();
								bool flag3 = text3 == text2;
								if (flag3)
								{
									try
									{
										process2.Kill();
										process2.Dispose();
										bool flag4 = text3 == "action_svc" || text3 == "scnrec" || text3 == "ScnRecPortable" || text3 == "apeaksoft screen recorder";
										if (flag4)
										{
											return 2;
										}
									}
									catch
									{
										bool flag5 = text3 == "action_svc" || text3 == "scnrec" || text3 == "ScnRecPortable" || text3 == "apeaksoft screen recorder";
										if (flag5)
										{
											return 2;
										}
									}
								}
							}
						}
					}
				}
				bool terminalServerSession = SystemInformation.TerminalServerSession;
				bool flag6 = terminalServerSession;
				if (flag6)
				{
					num = 3;
				}
				else
				{
					num = 0;
				}
			}
			else
			{
				num = 1;
			}
			return num;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00011394 File Offset: 0x0000F594
		[STAThread]
		private static void Main(string[] args)
		{
			bool flag = !args.IsNullOrEmpty();
			if (flag)
			{
				Program.associatefile = args[0];
			}
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
			DateTimeZone dateTimeZone = DateTimeZoneProviders.Tzdb["Universal"];
			try
			{
				TcpClient tcpClient = new TcpClient("time.nist.gov", 13);
				using (StreamReader streamReader = new StreamReader(tcpClient.GetStream()))
				{
					string text = streamReader.ReadToEnd();
					string text2 = text.Substring(7, 17);
					DateTime dateTime = DateTime.ParseExact(text2, "yy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal);
					DateTime dateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second);
					DateTime dateTime3 = dateTime2.ToUniversalTime();
					Program.date_pc = string.Concat(new string[]
					{
						dateTime3.Year.ToString(),
						"/",
						dateTime3.Month.ToString(),
						"/",
						dateTime3.Day.ToString()
					});
				}
			}
			catch
			{
				LocalDate date = SystemClock.Instance.GetCurrentInstant().InZone(dateTimeZone).Date;
				Program.date_pc = string.Concat(new string[]
				{
					date.Year.ToString(),
					"/",
					date.Month.ToString(),
					"/",
					date.Day.ToString()
				});
			}
			Program.pfc = new PrivateFontCollection();
			int num = Resources.bnazanin.Length;
			byte[] bnazanin = Resources.bnazanin;
			IntPtr intPtr = Marshal.AllocCoTaskMem(num);
			Marshal.Copy(bnazanin, 0, intPtr, num);
			Program.pfc.AddMemoryFont(intPtr, num);
			Application.Run(new player());
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000115AC File Offset: 0x0000F7AC
		public static bool check_enviroment()
		{
			try
			{
				using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("Select * from Win32_ComputerSystem"))
				{
					using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
					{
						foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
						{
							string text = managementBaseObject["Manufacturer"].ToString().ToLower();
							bool flag = (text == "microsoft corporation" && managementBaseObject["Model"].ToString().ToUpperInvariant().Contains("VIRTUAL")) || text.Contains("vmware") || managementBaseObject["Model"].ToString() == "VirtualBox";
							if (flag)
							{
								return true;
							}
						}
					}
				}
			}
			catch
			{
				return false;
			}
			return false;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000116DC File Offset: 0x0000F8DC
		public static void set_account_info(string activecode, string hardwareid, string elfo, string su, string token, bool bySMS = false)
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\" + Program.AppName);
			bool flag = registryKey != null;
			if (flag)
			{
				Registry.CurrentUser.DeleteSubKey("SOFTWARE\\" + Program.AppName);
			}
			RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\" + Program.AppName);
			string text = Cipher.Encrypt(hardwareid, Program.passEncr);
			string text2 = Cipher.Encrypt(token, Program.passEncr);
			bool flag2 = Program.base_url != "" && Program.base_url != null;
			if (flag2)
			{
				registryKey2.SetValue("server", Program.base_url);
			}
			registryKey2.SetValue("hardwareId", text);
			registryKey2.SetValue("token", text2);
			if (bySMS)
			{
				registryKey2.SetValue("phone_number", Program.phone_number);
			}
			else
			{
				string text3 = Cipher.Encrypt(Program.password, Program.passEncr);
				registryKey2.SetValue("username", Program.username);
				registryKey2.SetValue("password", text3);
			}
			registryKey2.Close();
			Program.Key = Encoding.Unicode.GetBytes(activecode);
			Program.KeyString = activecode;
			Program.elfo = elfo;
			Program.water = su;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00011824 File Offset: 0x0000FA24
		public static string GetIPAddress()
		{
			string text = "";
			WebRequest webRequest = WebRequest.Create("http://checkip.dyndns.org/");
			using (WebResponse response = webRequest.GetResponse())
			{
				using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
				{
					text = streamReader.ReadToEnd();
				}
			}
			int num = text.IndexOf("Address: ") + 9;
			int num2 = text.LastIndexOf("</body>");
			text = text.Substring(num, num2 - num);
			return text;
		}

		// Token: 0x040000DC RID: 220
		public static int cu_t_interval;

		// Token: 0x040000DD RID: 221
		public static int cu_t_duration;

		// Token: 0x040000DE RID: 222
		public static bool change_pos_sub_play;

		// Token: 0x040000DF RID: 223
		public static string AppName = "Lavin24Player";

		// Token: 0x040000E0 RID: 224
		public static string username;

		// Token: 0x040000E1 RID: 225
		public static string phone_number;

		// Token: 0x040000E2 RID: 226
		public static Version version;

		// Token: 0x040000E3 RID: 227
		public static string password;

		// Token: 0x040000E4 RID: 228
		public static string SkuProduct;

		// Token: 0x040000E5 RID: 229
		public static string PathFile;

		// Token: 0x040000E6 RID: 230
		public static string KeyString;

		// Token: 0x040000E7 RID: 231
		public static string elfo;

		// Token: 0x040000E8 RID: 232
		public static string water;

		// Token: 0x040000E9 RID: 233
		public static string base_url;

		// Token: 0x040000EA RID: 234
		public static int duration_show_s;

		// Token: 0x040000EB RID: 235
		public static int interval_show_s;

		// Token: 0x040000EC RID: 236
		public static string date_pc;

		// Token: 0x040000ED RID: 237
		public static string passEncr = "lavin24@" + Program.AppName + "@";

		// Token: 0x040000EE RID: 238
		public static byte[] Key;

		// Token: 0x040000EF RID: 239
		public static byte[] IV = new byte[] { 61, 18, 233, 140, 234, 36, 97, 240 };

		// Token: 0x040000F0 RID: 240
		public static string stringForHash = "Lavin24";

		// Token: 0x040000F1 RID: 241
		public static string stringForHashPhp = "Lavin24HashData";

		// Token: 0x040000F2 RID: 242
		public static int ChunkSize = 1048576;

		// Token: 0x040000F3 RID: 243
		public static string associatefile = "";

		// Token: 0x040000F4 RID: 244
		public static PrivateFontCollection pfc;

		// Token: 0x040000F5 RID: 245
		public static bool playlist_ON = false;

		// Token: 0x040000F6 RID: 246
		public static bool position_random_sub = false;
	}
}
