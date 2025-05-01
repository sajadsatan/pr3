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
	// Token: 0x0200000D RID: 13
	public partial class LoginBySMS : Form
	{
		// Token: 0x06000055 RID: 85 RVA: 0x000064E4 File Offset: 0x000046E4
		public LoginBySMS(player player)
		{
			this._player = player;
			this._settings = this._player.settings;
			this._activeCode = this._player.activeCodeSMS;
			this.InitializeComponent();
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000021F3 File Offset: 0x000003F3
		private void buttonClosethisForm2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002316 File Offset: 0x00000516
		private void panelBack_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00006538 File Offset: 0x00004738
		private void panelBack_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000659C File Offset: 0x0000479C
		private void setLocs(bool is_english)
		{
			bool isEnglish = this._player.isEnglish;
			if (isEnglish)
			{
				this.buttonGetCode.Location = new Point(324, 205);
				this.buttonActive.Location = new Point(324, 205);
				this.pictureBoxLoginByUsername.Location = new Point(79, 213);
				this.pictureBoxResendCode.Location = new Point(79, 213);
			}
			else
			{
				this.buttonGetCode.Location = new Point(77, 205);
				this.buttonActive.Location = new Point(77, 205);
				this.pictureBoxLoginByUsername.Location = new Point(234, 213);
				this.pictureBoxResendCode.Location = new Point(340, 213);
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000668C File Offset: 0x0000488C
		private void LoginBySMS_Load(object sender, EventArgs e)
		{
			this.panelBack.BackgroundImage = (Image)this._player.rm.GetObject("lbsms_back", this._player.ci);
			this.buttonGetCode.Image = (Image)this._player.rm.GetObject("lbsms_btn_getcode", this._player.ci);
			this.buttonActive.Image = (Image)this._player.rm.GetObject("login2_btn_activate", this._player.ci);
			this.pictureBoxLoginByUsername.Image = (Image)this._player.rm.GetObject("lbsms_to_lbup", this._player.ci);
			this.pictureBoxResendCode.Image = (Image)this._player.rm.GetObject("lbsms_resend", this._player.ci);
			this.labelTimer.ForeColor = Color.White;
			this.buttonActive.Enabled = false;
			this.setLocs(this._player.isEnglish);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000067C0 File Offset: 0x000049C0
		private void start_timer()
		{
			this.current_time = this._settings.Interval;
			this.labelTimer.Text = this.current_time.ToString() + "''";
			this.timer_sms.Start();
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000680C File Offset: 0x00004A0C
		private void timer_sms_Tick(object sender, EventArgs e)
		{
			bool flag = this.current_time < 0;
			if (flag)
			{
				this.labelTimer.Enabled = false;
				this.buttonActive.Enabled = false;
				this.pictureBoxResendCode.Visible = true;
				this.timer_sms.Stop();
			}
			else
			{
				bool flag2 = this.current_time < 10;
				if (flag2)
				{
					this.labelTimer.ForeColor = Color.Red;
				}
				this.labelTimer.Text = this.current_time.ToString() + "''";
				this.current_time--;
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000068AC File Offset: 0x00004AAC
		private void buttonGetCode_Click(object sender, EventArgs e)
		{
			bool flag = this.textBoxPhoneNumber.Text.Trim() == "";
			if (flag)
			{
				MessageBox.Show(this._player.rm.GetString("phone_number_cannot_be_empty", this._player.ci));
			}
			else
			{
				string text = DateTime.Now.ToString("d");
				string text2 = (string)Settings.Default["LastTry"];
				bool flag2 = text2 == "" || text2 != text;
				if (flag2)
				{
					Settings.Default["NumberOfTry"] = 0;
				}
				int num = (int)Settings.Default["NumberOfTry"];
				bool flag3 = num > 40;
				if (flag3)
				{
					MessageBox.Show(this._player.rm.GetString("cannot_try_anymore", this._player.ci));
				}
				else
				{
					num++;
					Settings.Default["LastTry"] = text;
					Settings.Default["NumberOfTry"] = num;
					Program.phone_number = this.textBoxPhoneNumber.Text;
					string text3 = "(@--@)";
					string text4 = Program.ReadLastLine(Program.PathFile);
					this.info = Regex.Split(text4, text3);
					Program.base_url = Cipher.Decrypt(this.info[2], Program.stringForHash);
					this.start_timer();
					this.panelBack.BackgroundImage = (Image)this._player.rm.GetObject("lbsms_back_entercode", this._player.ci);
					this.labelTimer.Visible = true;
					this.labelTimer.Enabled = true;
					this.buttonActive.Visible = true;
					this.buttonActive.Enabled = true;
					this.pictureBoxResendCode.Visible = false;
					this.buttonGetCode.Visible = false;
					this.buttonGetCode.Enabled = false;
					this.pictureBoxLoginByUsername.Visible = false;
					this.textBoxPhoneNumber.Text = "";
					this.textBoxPhoneNumber.Select();
					try
					{
						this._activeCode = this._player.SMSService.GetCode(Program.base_url, Program.phone_number);
						bool flag4 = this._activeCode.status == 200;
						if (flag4)
						{
							Program.phone_number = this._activeCode.phone_number;
						}
						else
						{
							MessageBox.Show(this._activeCode.message);
							base.Close();
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
						base.Close();
					}
				}
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002330 File Offset: 0x00000530
		private void pictureBoxBackNO_Click(object sender, EventArgs e)
		{
			this.textBoxPhoneNumber.Select();
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00006B74 File Offset: 0x00004D74
		private void pictureBoxLoginByUsername_Click(object sender, EventArgs e)
		{
			base.Hide();
			new LoginByUsername(this._player)
			{
				TopMost = true
			}.ShowDialog();
			base.Close();
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00006BAC File Offset: 0x00004DAC
		private void pictureBoxResendCode_Click(object sender, EventArgs e)
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
				this._activeCode = this._player.SMSService.GetCode(Program.base_url, Program.phone_number);
				bool flag3 = this._activeCode.status == 200;
				if (flag3)
				{
					this.textBoxPhoneNumber.Text = "";
					this.labelTimer.ForeColor = Color.White;
					this.labelTimer.Enabled = true;
					this.buttonActive.Enabled = true;
					this.pictureBoxResendCode.Visible = false;
					this.start_timer();
				}
				else
				{
					MessageBox.Show(this._activeCode.message);
				}
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00006D30 File Offset: 0x00004F30
		private void buttonActive_Click(object sender, EventArgs e)
		{
			string text = this.textBoxPhoneNumber.Text;
			try
			{
				bool flag = this.textBoxPhoneNumber.Text.Trim() != "";
				if (flag)
				{
					this._activeCode = this._player.SMSService.ActivationRequest(Program.base_url, Program.phone_number, text);
					bool flag2 = this._activeCode.status == 200;
					if (flag2)
					{
						Assembly executingAssembly = Assembly.GetExecutingAssembly();
						FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(executingAssembly.Location);
						Program.version = new Version(versionInfo.ProductVersion);
						ActivateService activateService = new ActivateService(new WpWebServiceRepository("", "", Program.base_url));
						ApiResponse apiResponse = activateService.CheckOrder(Cipher.Decrypt(this.info[6], Program.stringForHash), Program.getMotherBoardID(), this._activeCode.message, Program.version);
						bool flag3 = apiResponse.statusCode == "200";
						if (flag3)
						{
							Cipher.Encrypt(Program.password, "lavin24");
							Program.set_account_info(apiResponse.statusText, Program.getMotherBoardID(), apiResponse.elfo, Program.convert_Subtitle_to_string(apiResponse.su), this._activeCode.message, true);
							base.Close();
						}
						else
						{
							bool flag4 = apiResponse.statusCode == "98";
							if (flag4)
							{
								bool flag5 = MessageBox.Show(this._player.rm.GetString("download_last_version", this._player.ci), this._player.rm.GetString("downlod_btn", this._player.ci), MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes;
								if (flag5)
								{
									Process.Start(apiResponse.statusText);
								}
							}
							else
							{
								MessageBox.Show(apiResponse.statusText);
							}
						}
					}
					else
					{
						bool flag6 = this._activeCode.status == 100 || this._activeCode.status == 101 || this._activeCode.status == 102 || this._activeCode.status == 300;
						if (flag6)
						{
							MessageBox.Show(this._activeCode.message);
						}
						else
						{
							Program.SkuProduct = Cipher.Decrypt(this.info[6], Program.stringForHash);
							base.Hide();
							new login2(new player())
							{
								TopMost = true
							}.ShowDialog();
						}
					}
				}
				else
				{
					MessageBox.Show("enter phone number");
				}
			}
			catch (Exception ex)
			{
				Program.SkuProduct = Cipher.Decrypt(this.info[6], Program.stringForHash);
				base.Hide();
				new login2(new player())
				{
					TopMost = true
				}.ShowDialog();
			}
		}

		// Token: 0x04000043 RID: 67
		private player _player;

		// Token: 0x04000044 RID: 68
		private SettingServer _settings;

		// Token: 0x04000045 RID: 69
		private SMScodeActivation _activeCode;

		// Token: 0x04000046 RID: 70
		private int current_time = 0;

		// Token: 0x04000047 RID: 71
		public string[] info;

		// Token: 0x04000048 RID: 72
		private Point lastPoint;
	}
}
