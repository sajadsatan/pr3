using System;
using System.Net;
using Newtonsoft.Json;
using player.Modula;

namespace player.Service
{
	// Token: 0x02000016 RID: 22
	public class SMSService
	{
		// Token: 0x0600010A RID: 266 RVA: 0x000130DC File Offset: 0x000112DC
		public SettingServer GetSettings(string baseUrl)
		{
			string text = baseUrl + "/wp-json/jwt-auth/v1/serversettings";
			string text2 = "POST";
			string text3 = JsonConvert.SerializeObject(new { });
			WebClient webClient = new WebClient();
			webClient.Headers["Content-Type"] = "application/json";
			webClient.Proxy = WebRequest.DefaultWebProxy;
			SettingServer settingServer2;
			try
			{
				bool flag = Program.CheckForInternetConnection();
				if (flag)
				{
					string text4 = webClient.UploadString(text, text2, text3);
					SettingServer settingServer = JsonConvert.DeserializeObject<SettingServer>(text4);
					settingServer2 = settingServer;
				}
				else
				{
					settingServer2 = new SettingServer
					{
						Method = 0
					};
				}
			}
			catch
			{
				try
				{
					text = text.Replace("https:", "http:");
					bool flag2 = Program.CheckForInternetConnection();
					if (flag2)
					{
						string text5 = webClient.UploadString(text, text2, text3);
						SettingServer settingServer3 = JsonConvert.DeserializeObject<SettingServer>(text5);
						settingServer2 = settingServer3;
					}
					else
					{
						settingServer2 = new SettingServer
						{
							Method = 0
						};
					}
				}
				catch
				{
					settingServer2 = new SettingServer
					{
						Method = 0
					};
				}
			}
			return settingServer2;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000131E8 File Offset: 0x000113E8
		public SMScodeActivation GetCode(string baseUrl, string phoneNumber)
		{
			string text = baseUrl + "/wp-json/jwt-auth/v1/smscode";
			string text2 = "POST";
			string text3 = JsonConvert.SerializeObject(new
			{
				phone_number = phoneNumber,
				userip = Program.GetIPAddress()
			});
			WebClient webClient = new WebClient();
			webClient.Headers["Content-Type"] = "application/json";
			webClient.Proxy = WebRequest.DefaultWebProxy;
			SMScodeActivation smscodeActivation2;
			try
			{
				bool flag = Program.CheckForInternetConnection();
				if (flag)
				{
					string text4 = webClient.UploadString(text, text2, text3);
					SMScodeActivation smscodeActivation = JsonConvert.DeserializeObject<SMScodeActivation>(text4);
					smscodeActivation2 = smscodeActivation;
				}
				else
				{
					smscodeActivation2 = new SMScodeActivation
					{
						status = 300,
						message = "No Internet"
					};
				}
			}
			catch
			{
				try
				{
					bool flag2 = Program.CheckForInternetConnection();
					if (flag2)
					{
						text = text.Replace("https:", "http:");
						string text5 = webClient.UploadString(text, text2, text3);
						SMScodeActivation smscodeActivation3 = JsonConvert.DeserializeObject<SMScodeActivation>(text5);
						smscodeActivation2 = smscodeActivation3;
					}
					else
					{
						smscodeActivation2 = new SMScodeActivation
						{
							status = 300,
							message = "No Internet"
						};
					}
				}
				catch (Exception ex)
				{
					smscodeActivation2 = new SMScodeActivation
					{
						status = 301,
						message = ex.Message
					};
				}
			}
			return smscodeActivation2;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00013330 File Offset: 0x00011530
		public SMScodeActivation ActivationRequest(string baseUrl, string phoneNumber, string code)
		{
			string text = baseUrl + "/wp-json/jwt-auth/v1/smscode/validate";
			string text2 = "POST";
			string text3 = JsonConvert.SerializeObject(new
			{
				phone_number = phoneNumber,
				req_code = code
			});
			WebClient webClient = new WebClient();
			webClient.Headers["Content-Type"] = "application/json";
			webClient.Proxy = WebRequest.DefaultWebProxy;
			SMScodeActivation smscodeActivation2;
			try
			{
				bool flag = Program.CheckForInternetConnection();
				if (flag)
				{
					string text4 = webClient.UploadString(text, text2, text3);
					SMScodeActivation smscodeActivation = JsonConvert.DeserializeObject<SMScodeActivation>(text4);
					smscodeActivation2 = smscodeActivation;
				}
				else
				{
					smscodeActivation2 = new SMScodeActivation
					{
						status = 300,
						message = "No Internet"
					};
				}
			}
			catch
			{
				try
				{
					bool flag2 = Program.CheckForInternetConnection();
					if (flag2)
					{
						text = text.Replace("https:", "http:");
						string text5 = webClient.UploadString(text, text2, text3);
						SMScodeActivation smscodeActivation3 = JsonConvert.DeserializeObject<SMScodeActivation>(text5);
						smscodeActivation2 = smscodeActivation3;
					}
					else
					{
						smscodeActivation2 = new SMScodeActivation
						{
							status = 300,
							message = "No Internet"
						};
					}
				}
				catch (Exception ex)
				{
					smscodeActivation2 = new SMScodeActivation
					{
						status = 301,
						message = ex.Message
					};
				}
			}
			return smscodeActivation2;
		}
	}
}
