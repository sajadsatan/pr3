using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Newtonsoft.Json;
using player.Modula;

namespace player.Repository
{
	// Token: 0x02000018 RID: 24
	public class WpWebServiceRepository : IRepository
	{
		// Token: 0x06000110 RID: 272 RVA: 0x00013474 File Offset: 0x00011674
		public WpWebServiceRepository(string username = "", string password = "", string baseUrl = "")
		{
			this._baseUrl = baseUrl;
			this._username = username;
			this._password = password;
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, new RemoteCertificateValidationCallback((object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) => true));
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000134E4 File Offset: 0x000116E4
		public tokenResponse AuthenticateUser()
		{
			string text = this._baseUrl + "/wp-json/jwt-auth/v1/token";
			string text2 = "POST";
			string text3 = JsonConvert.SerializeObject(new
			{
				username = this._username,
				password = this._password,
				userip = Program.GetIPAddress()
			});
			WebClient webClient = new WebClient();
			webClient.Headers["Content-Type"] = "application/json";
			webClient.Proxy = WebRequest.DefaultWebProxy;
			tokenResponse tokenResponse2;
			try
			{
				bool flag = Program.CheckForInternetConnection();
				if (flag)
				{
					string text4 = webClient.UploadString(text, text2, text3);
					tokenResponse tokenResponse = JsonConvert.DeserializeObject<tokenResponse>(text4);
					bool flag2 = tokenResponse.token != null;
					if (flag2)
					{
						tokenResponse.status = 200;
						this._Token = tokenResponse.token;
						this._UserEmail = tokenResponse.user_email;
						tokenResponse2 = tokenResponse;
					}
					else
					{
						tokenResponse2 = new tokenResponse
						{
							status = 100
						};
					}
				}
				else
				{
					tokenResponse2 = new tokenResponse
					{
						status = 102
					};
				}
			}
			catch (Exception ex)
			{
				bool flag3 = ex.Message == "The remote server returned an error: (403) Forbidden.";
				if (flag3)
				{
					tokenResponse2 = new tokenResponse
					{
						status = 100
					};
				}
				else
				{
					try
					{
						WebClient webClient2 = new WebClient();
						webClient2.Headers["Content-Type"] = "application/json";
						webClient2.Proxy = WebRequest.DefaultWebProxy;
						this._baseUrl = this._baseUrl.Replace("https:", "http:");
						text = this._baseUrl + "/wp-json/jwt-auth/v1/token";
						string text5 = webClient2.UploadString(text, text2, text3);
						tokenResponse tokenResponse3 = JsonConvert.DeserializeObject<tokenResponse>(text5);
						bool flag4 = tokenResponse3.token != null;
						if (flag4)
						{
							tokenResponse3.status = 200;
							this._Token = tokenResponse3.token;
							this._UserEmail = tokenResponse3.user_email;
							tokenResponse2 = tokenResponse3;
						}
						else
						{
							tokenResponse2 = new tokenResponse
							{
								status = 100
							};
						}
					}
					catch (Exception ex2)
					{
						bool flag5 = ex2.Message == "The remote server returned an error: (403) Forbidden.";
						if (flag5)
						{
							tokenResponse2 = new tokenResponse
							{
								status = 100
							};
						}
						else
						{
							tokenResponse2 = new tokenResponse
							{
								status = 101
							};
						}
					}
				}
			}
			return tokenResponse2;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00013740 File Offset: 0x00011940
		private ValidateToken CheckValidateToken(string token)
		{
			string text = this._baseUrl + "/wp-json/jwt-auth/v1/token/validate";
			Uri uri = new Uri(text);
			WebRequest webRequest = WebRequest.Create(uri);
			HttpWebRequest httpWebRequest = (HttpWebRequest)webRequest;
			httpWebRequest.PreAuthenticate = true;
			httpWebRequest.Headers.Add("Authorization", "Bearer " + token);
			httpWebRequest.Accept = "application/json";
			httpWebRequest.UseDefaultCredentials = true;
			httpWebRequest.Proxy.Credentials = CredentialCache.DefaultCredentials;
			WebResponse response = webRequest.GetResponse();
			Stream responseStream = response.GetResponseStream();
			bool flag = responseStream == null;
			ValidateToken validateToken;
			if (flag)
			{
				validateToken = null;
			}
			else
			{
				StreamReader streamReader = new StreamReader(responseStream, Encoding.Default);
				string text2 = streamReader.ReadToEnd();
				responseStream.Close();
				response.Close();
				validateToken = JsonConvert.DeserializeObject<ValidateToken>(Convert.ToString(text2));
			}
			return validateToken;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00013818 File Offset: 0x00011A18
		public ApiResponse CheckOrder(string productSku, string hardwareID, string token, Version version)
		{
			string text = string.Concat(new string[]
			{
				this._baseUrl,
				"/wp-json/player/v1/checkorder/?productSku=",
				productSku,
				"&hardwareID=",
				hardwareID,
				"&version=",
				(version != null) ? version.ToString() : null
			});
			ApiResponse apiResponse;
			try
			{
				Uri uri = new Uri(text);
				WebRequest webRequest = WebRequest.Create(uri);
				HttpWebRequest httpWebRequest = (HttpWebRequest)webRequest;
				httpWebRequest.PreAuthenticate = true;
				httpWebRequest.Headers.Add("Authorization", "Bearer " + token);
				httpWebRequest.Accept = "application/json";
				httpWebRequest.UseDefaultCredentials = true;
				httpWebRequest.Proxy.Credentials = CredentialCache.DefaultCredentials;
				httpWebRequest.AllowAutoRedirect = true;
				WebResponse response = webRequest.GetResponse();
				Stream responseStream = response.GetResponseStream();
				bool flag = responseStream == null;
				if (flag)
				{
					apiResponse = null;
				}
				else
				{
					StreamReader streamReader = new StreamReader(responseStream, Encoding.Default);
					string text2 = streamReader.ReadToEnd();
					responseStream.Close();
					response.Close();
					apiResponse = JsonConvert.DeserializeObject<ApiResponse>(Convert.ToString(text2));
				}
			}
			catch
			{
				try
				{
					text = text.Replace("https:", "http:");
					Uri uri2 = new Uri(text);
					WebRequest webRequest2 = WebRequest.Create(uri2);
					HttpWebRequest httpWebRequest2 = (HttpWebRequest)webRequest2;
					httpWebRequest2.PreAuthenticate = true;
					httpWebRequest2.Headers.Add("Authorization", "Bearer " + token);
					httpWebRequest2.Accept = "application/json";
					httpWebRequest2.UseDefaultCredentials = true;
					httpWebRequest2.Proxy.Credentials = CredentialCache.DefaultCredentials;
					httpWebRequest2.AllowAutoRedirect = true;
					WebResponse response2 = webRequest2.GetResponse();
					Stream responseStream2 = response2.GetResponseStream();
					bool flag2 = responseStream2 == null;
					if (flag2)
					{
						apiResponse = null;
					}
					else
					{
						StreamReader streamReader2 = new StreamReader(responseStream2, Encoding.Default);
						string text3 = streamReader2.ReadToEnd();
						responseStream2.Close();
						response2.Close();
						apiResponse = JsonConvert.DeserializeObject<ApiResponse>(Convert.ToString(text3));
					}
				}
				catch (Exception ex)
				{
					bool flag3 = ex.Message == "The remote server returned an error: (401) Unauthorized." || ex.Message == "The remote server returned an error: (403) Forbidden.";
					if (flag3)
					{
						apiResponse = new ApiResponse
						{
							statusCode = "97"
						};
					}
					else
					{
						apiResponse = new ApiResponse
						{
							statusCode = "96",
							statusText = ex.Message
						};
					}
				}
			}
			return apiResponse;
		}

		// Token: 0x04000112 RID: 274
		private string _baseUrl;

		// Token: 0x04000113 RID: 275
		private string _Token;

		// Token: 0x04000114 RID: 276
		private string _UserEmail;

		// Token: 0x04000115 RID: 277
		private string _username;

		// Token: 0x04000116 RID: 278
		private string _password;
	}
}
