using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using player.Modula;
using player.Properties;
using player.Repository;
using player.Service;

namespace player
{
	// Token: 0x0200000E RID: 14
	public partial class LoginByUsername : Form
	{
		// Token: 0x06000064 RID: 100 RVA: 0x0000233F File Offset: 0x0000053F
		public LoginByUsername(player player)
		{
			this._player = player;
			this.InitializeComponent();
			this.textBoxUserName.BorderStyle = BorderStyle.None;
			this.textBoxPassword.BorderStyle = BorderStyle.None;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000021F3 File Offset: 0x000003F3
		private void buttonClosethisForm2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002378 File Offset: 0x00000578
		private void panelBack_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00007B00 File Offset: 0x00005D00
		private void panelBack_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00007B64 File Offset: 0x00005D64
		private void setLocs(bool is_english)
		{
			bool isEnglish = this._player.isEnglish;
			if (isEnglish)
			{
				this.textBoxUserName.Location = new Point(183, 149);
				this.buttonActive.Location = new Point(323, 238);
				this.textBoxPassword.Location = new Point(183, 200);
				this.pictureBoxForgetPass.Location = new Point(79, 248);
			}
			else
			{
				this.textBoxUserName.Location = new Point(81, 149);
				this.buttonActive.Location = new Point(76, 238);
				this.textBoxPassword.Location = new Point(81, 200);
				this.pictureBoxForgetPass.Location = new Point(302, 245);
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00007C54 File Offset: 0x00005E54
		private void LoginByUsername_Load(object sender, EventArgs e)
		{
			string text = "(@--@)";
			string text2 = Program.ReadLastLine(Program.PathFile);
			this.info = Regex.Split(text2, text);
			this.link = Cipher.Decrypt(this.info[10], Program.stringForHash);
			this.panelBack.BackgroundImage = (Image)this._player.rm.GetObject("lbup_back", this._player.ci);
			this.pictureBox_username.Image = (Image)this._player.rm.GetObject("lbup_user_back", this._player.ci);
			this.buttonActive.Image = (Image)this._player.rm.GetObject("login2_btn_activate", this._player.ci);
			this.pictureBoxForgetPass.Image = (Image)this._player.rm.GetObject("lbup_pass_rec", this._player.ci);
			this.pictureBox_pass.Image = (Image)this._player.rm.GetObject("lbup_pass_back", this._player.ci);
			this.setLocs(this._player.isEnglish);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00007DA0 File Offset: 0x00005FA0
		private void SetLoading(bool displayLoader)
		{
			if (displayLoader)
			{
				base.Invoke(new MethodInvoker(delegate
				{
					this.picLoader.Visible = true;
					this.Cursor = Cursors.WaitCursor;
				}));
			}
			else
			{
				base.Invoke(new MethodInvoker(delegate
				{
					this.picLoader.Visible = false;
					this.Cursor = Cursors.Default;
				}));
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00007DE0 File Offset: 0x00005FE0
		private void buttonActive_Click(object sender, EventArgs e)
		{
			string text = DateTime.Now.ToString("d");
			string text2 = (string)Settings.Default["LastTry"];
			bool flag = text2 == "" || text2 != text;
			if (flag)
			{
				Settings.Default["NumberOfTry"] = 0;
			}
			int num = (int)Settings.Default["NumberOfTry"];
			bool flag2 = num > 40;
			if (flag2)
			{
				MessageBox.Show(this._player.rm.GetString("cannot_try_anymore", this._player.ci));
			}
			else
			{
				num++;
				Settings.Default["LastTry"] = text;
				Settings.Default["NumberOfTry"] = num;
				this.SetLoading(true);
				Program.username = this.textBoxUserName.Text;
				Program.password = this.textBoxPassword.Text;
				string text3 = "(@--@)";
				string text4 = Program.ReadLastLine(Program.PathFile);
				this.info = Regex.Split(text4, text3);
				Program.base_url = Cipher.Decrypt(this.info[2], Program.stringForHash);
				try
				{
					bool flag3 = this.textBoxUserName.Text.Trim() != "" && this.textBoxPassword.Text.Trim() != "";
					if (flag3)
					{
						ActivateService activateService = new ActivateService(new WpWebServiceRepository(Program.username, Program.password, Cipher.Decrypt(this.info[2], Program.stringForHash)));
						tokenResponse tokenResponse = activateService.AuthenticateUser();
						bool flag4 = tokenResponse.status == 200;
						if (flag4)
						{
							Assembly executingAssembly = Assembly.GetExecutingAssembly();
							FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(executingAssembly.Location);
							Program.version = new Version(versionInfo.ProductVersion);
							ApiResponse apiResponse = activateService.CheckOrder(Cipher.Decrypt(this.info[6], Program.stringForHash), Program.getMotherBoardID(), tokenResponse.token, Program.version);
							bool flag5 = apiResponse.statusCode == "200";
							if (flag5)
							{
								Cipher.Encrypt(Program.password, "lavin24");
								Program.set_account_info(apiResponse.statusText, Program.getMotherBoardID(), apiResponse.elfo, Program.convert_Subtitle_to_string(apiResponse.su), tokenResponse.token, false);
								this.SetLoading(false);
								base.Close();
							}
							else
							{
								bool flag6 = apiResponse.statusCode == "98";
								if (flag6)
								{
									this.SetLoading(false);
									bool flag7 = MessageBox.Show(this._player.rm.GetString("download_last_version", this._player.ci), this._player.rm.GetString("downlod_btn", this._player.ci), MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes;
									if (flag7)
									{
										Process.Start(apiResponse.statusText);
									}
								}
								else
								{
									this.SetLoading(false);
									MessageBox.Show(apiResponse.statusText);
								}
							}
						}
						else
						{
							bool flag8 = tokenResponse.status == 100;
							if (flag8)
							{
								this.SetLoading(false);
								MessageBox.Show(this._player.rm.GetString("login_message_connectionerror", this._player.ci));
							}
							else
							{
								bool flag9 = tokenResponse.status == 102;
								if (flag9)
								{
									this.SetLoading(false);
									bool flag10 = MessageBox.Show(this._player.rm.GetString("Connect_to_the_Internet", this._player.ci), "", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes;
									if (flag10)
									{
										this.SetLoading(false);
										Program.SkuProduct = Cipher.Decrypt(this.info[6], Program.stringForHash);
										base.Hide();
										new login2(new player())
										{
											TopMost = true
										}.ShowDialog();
									}
								}
								else
								{
									this.SetLoading(false);
									Program.SkuProduct = Cipher.Decrypt(this.info[6], Program.stringForHash);
									base.Hide();
									new login2(new player())
									{
										TopMost = true
									}.ShowDialog();
								}
							}
						}
					}
					else
					{
						this.SetLoading(false);
						MessageBox.Show(this._player.rm.GetString("Username_password_cannot_be_empty", this._player.ci));
					}
				}
				catch (Exception ex)
				{
					this.SetLoading(false);
					Program.SkuProduct = Cipher.Decrypt(this.info[6], Program.stringForHash);
					base.Hide();
					new login2(new player())
					{
						TopMost = true
					}.ShowDialog();
				}
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000082CC File Offset: 0x000064CC
		private void pictureBoxForgetPass_Click(object sender, EventArgs e)
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo(this.link);
			Process.Start(processStartInfo);
		}

		// Token: 0x04000055 RID: 85
		public string[] info;

		// Token: 0x04000056 RID: 86
		private string link;

		// Token: 0x04000057 RID: 87
		private player _player;

		// Token: 0x04000058 RID: 88
		private Point lastPoint;
	}
}
