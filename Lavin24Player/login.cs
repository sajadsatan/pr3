using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Metro.ColorTables;
using player.Modula;
using player.Repository;
using player.Service;

namespace player
{
	// Token: 0x0200000B RID: 11
	public partial class login : Form
	{
		// Token: 0x06000037 RID: 55 RVA: 0x00002209 File Offset: 0x00000409
		public login(player player)
		{
			this._player = player;
			this.InitializeComponent();
			this.textBoxXuserName.BorderStyle = BorderStyle.None;
			this.textBoxXpassword.BorderStyle = BorderStyle.None;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00004154 File Offset: 0x00002354
		private void login_Load(object sender, EventArgs e)
		{
			string text = "(@--@)";
			string text2 = Program.ReadLastLine(Program.PathFile);
			this.info = Regex.Split(text2, text);
			this.link = Cipher.Decrypt(this.info[10], Program.stringForHash);
			this.panelBack.BackgroundImage = (Image)this._player.rm.GetObject("login_back", this._player.ci);
			this.pictureBoxUsername.Image = (Image)this._player.rm.GetObject("login_username", this._player.ci);
			this.pictureBoxPassword.Image = (Image)this._player.rm.GetObject("login_pass", this._player.ci);
			this.buttonActive.Image = (Image)this._player.rm.GetObject("login_btn_activation", this._player.ci);
			this.buttonXForget.Image = (Image)this._player.rm.GetObject("login_btn_recovery", this._player.ci);
			this.setLocs(this._player.isEnglish);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000042A0 File Offset: 0x000024A0
		private void setLocs(bool is_english)
		{
			bool isEnglish = this._player.isEnglish;
			if (isEnglish)
			{
				this.pictureBoxUsername.Location = new Point(109, 294);
				this.pictureBoxPassword.Location = new Point(109, 338);
				this.textBoxXuserName.Location = new Point(202, 294);
				this.textBoxXpassword.Location = new Point(202, 338);
			}
			else
			{
				this.pictureBoxUsername.Location = new Point(433, 294);
				this.pictureBoxPassword.Location = new Point(433, 338);
				this.textBoxXuserName.Location = new Point(109, 294);
				this.textBoxXpassword.Location = new Point(109, 338);
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000021F3 File Offset: 0x000003F3
		private void buttonClosethisForm_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00004390 File Offset: 0x00002590
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

		// Token: 0x0600003C RID: 60 RVA: 0x000043D0 File Offset: 0x000025D0
		private void buttonActive_Click(object sender, EventArgs e)
		{
			this.SetLoading(true);
			Program.username = this.textBoxXuserName.Text;
			Program.password = this.textBoxXpassword.Text;
			string text = "(@--@)";
			string text2 = Program.ReadLastLine(Program.PathFile);
			this.info = Regex.Split(text2, text);
			Program.base_url = Cipher.Decrypt(this.info[2], Program.stringForHash);
			try
			{
				bool flag = this.textBoxXuserName.Text.Trim() != "" && this.textBoxXpassword.Text.Trim() != "";
				if (flag)
				{
					ActivateService activateService = new ActivateService(new WpWebServiceRepository(Program.username, Program.password, Cipher.Decrypt(this.info[2], Program.stringForHash)));
					tokenResponse tokenResponse = activateService.AuthenticateUser();
					bool flag2 = tokenResponse.status == 200;
					if (flag2)
					{
						Assembly executingAssembly = Assembly.GetExecutingAssembly();
						FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(executingAssembly.Location);
						Program.version = new Version(versionInfo.ProductVersion);
						ApiResponse apiResponse = activateService.CheckOrder(Cipher.Decrypt(this.info[6], Program.stringForHash), Program.getMotherBoardID(), tokenResponse.token, Program.version);
						bool flag3 = apiResponse.statusCode == "200";
						if (flag3)
						{
							Cipher.Encrypt(Program.password, "lavin24");
							Program.set_account_info(apiResponse.statusText, Program.getMotherBoardID(), apiResponse.elfo, Program.convert_Subtitle_to_string(apiResponse.su), tokenResponse.token, false);
							this.SetLoading(false);
							base.Close();
						}
						else
						{
							bool flag4 = apiResponse.statusCode == "98";
							if (flag4)
							{
								this.SetLoading(false);
								bool flag5 = MessageBox.Show(this._player.rm.GetString("download_last_version", this._player.ci), this._player.rm.GetString("downlod_btn", this._player.ci), MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes;
								if (flag5)
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
						bool flag6 = tokenResponse.status == 100;
						if (flag6)
						{
							this.SetLoading(false);
							MessageBox.Show(this._player.rm.GetString("login_message_connectionerror", this._player.ci));
						}
						else
						{
							bool flag7 = tokenResponse.status == 102;
							if (flag7)
							{
								this.SetLoading(false);
								bool flag8 = MessageBox.Show(this._player.rm.GetString("Connect_to_the_Internet", this._player.ci), "", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes;
								if (flag8)
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

		// Token: 0x0600003D RID: 61 RVA: 0x000047B0 File Offset: 0x000029B0
		private void buttonXForget_Click(object sender, EventArgs e)
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo(this.link);
			Process.Start(processStartInfo);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002242 File Offset: 0x00000442
		private void panelBack_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000047D4 File Offset: 0x000029D4
		private void panelBack_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000021FD File Offset: 0x000003FD
		private void panelBack_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0400001E RID: 30
		public string[] info;

		// Token: 0x0400001F RID: 31
		private string link;

		// Token: 0x04000020 RID: 32
		private player _player;

		// Token: 0x04000021 RID: 33
		private Point lastPoint;
	}
}
