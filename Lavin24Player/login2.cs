using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Microsoft.Win32;

namespace player
{
	// Token: 0x0200000C RID: 12
	public partial class login2 : Form
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00002294 File Offset: 0x00000494
		// (set) Token: 0x06000046 RID: 70 RVA: 0x0000229C File Offset: 0x0000049C
		public string link_recovery { get; set; }

		// Token: 0x06000047 RID: 71 RVA: 0x000022A5 File Offset: 0x000004A5
		public login2(player player)
		{
			this._player = player;
			this.InitializeComponent();
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000021F3 File Offset: 0x000003F3
		private void buttonClosethisForm2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000528C File Offset: 0x0000348C
		private void pictureBoxCopy_Click(object sender, EventArgs e)
		{
			Clipboard.Clear();
			Clipboard.SetText(this.textBoxID.Text);
			this.labelCopied.Text = this._player.rm.GetString("login2_lbl_copy", this._player.ci);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000022C4 File Offset: 0x000004C4
		private void panelBack2_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000052E0 File Offset: 0x000034E0
		private void panelBack2_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00005344 File Offset: 0x00003544
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

		// Token: 0x0600004D RID: 77 RVA: 0x00005384 File Offset: 0x00003584
		private void setLocs(bool is_english)
		{
			bool isEnglish = this._player.isEnglish;
			if (isEnglish)
			{
				this.pictureBoxID.Location = new Point(37, 151);
				this.pictureBoxCopy.Location = new Point(448, 154);
				this.labelCopied.Location = new Point(450, 193);
				this.textBoxID.Location = new Point(158, 161);
				this.textBoxCode.Location = new Point(158, 256);
			}
			else
			{
				this.pictureBoxID.Location = new Point(64, 151);
				this.pictureBoxCopy.Location = new Point(28, 154);
				this.labelCopied.Location = new Point(30, 193);
				this.textBoxID.Location = new Point(73, 161);
				this.textBoxCode.Location = new Point(45, 257);
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000054A8 File Offset: 0x000036A8
		private void login2_Load(object sender, EventArgs e)
		{
			this.panelBack.BackgroundImage = (Image)this._player.rm.GetObject("login2_back", this._player.ci);
			this.pictureBoxID.Image = (Image)this._player.rm.GetObject("login2_systemid", this._player.ci);
			this.pictureBoxCode.Image = (Image)this._player.rm.GetObject("login2_activationcode", this._player.ci);
			this.buttonXGet.Image = (Image)this._player.rm.GetObject("login2_btn_link", this._player.ci);
			this.buttonXactivation.Image = (Image)this._player.rm.GetObject("login2_btn_activate", this._player.ci);
			this.setLocs(this._player.isEnglish);
			string text = "(@--@)";
			string text2 = Program.ReadLastLine(Program.PathFile);
			this.info = Regex.Split(text2, text);
			this.link_recovery = Cipher.Decrypt(this.info[2], Program.stringForHash) + "/activation";
			this.mb_serial = Program.getMotherBoardID();
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\" + Program.AppName);
			bool flag = registryKey != null;
			if (flag)
			{
				Program.username = Convert.ToString(registryKey.GetValue("username"));
				Program.password = Cipher.Decrypt(Convert.ToString(registryKey.GetValue("password")), Program.passEncr);
				Program.SkuProduct = Cipher.Decrypt(this.info[6], Program.stringForHash);
			}
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(executingAssembly.Location);
			Program.version = new Version(versionInfo.ProductVersion);
			string[] array = new string[9];
			array[0] = Program.username;
			array[1] = "|-|";
			array[2] = Program.password;
			array[3] = "|-|";
			array[4] = Program.SkuProduct;
			array[5] = "|-|";
			array[6] = this.mb_serial;
			array[7] = "|-|";
			int num = 8;
			Version version = Program.version;
			array[num] = ((version != null) ? version.ToString() : null);
			this.SystemID = string.Concat(array);
			try
			{
				SHA256 sha = SHA256.Create();
				byte[] array2 = sha.ComputeHash(Encoding.ASCII.GetBytes(Program.stringForHashPhp));
				byte[] array3 = new byte[16];
				string text3 = Cipher.EncryptStringphp(this.SystemID, array2, array3);
				this.textBoxID.Text = text3;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + "-error: 211");
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00005780 File Offset: 0x00003980
		private void buttonXGet_Click(object sender, EventArgs e)
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo(this.link_recovery);
			Process.Start(processStartInfo);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000057A4 File Offset: 0x000039A4
		private void buttonXactivation_Click(object sender, EventArgs e)
		{
			bool flag = this.textBoxCode.Text == "";
			if (flag)
			{
				MessageBox.Show(this._player.rm.GetString("login2_message_emptyactivecodeerror", this._player.ci));
			}
			else
			{
				SHA256 sha = SHA256.Create();
				byte[] array = sha.ComputeHash(Encoding.ASCII.GetBytes(Program.stringForHashPhp));
				byte[] array2 = new byte[16];
				try
				{
					string text = Cipher.DecryptStringphp(this.textBoxCode.Text, array, array2);
					string text2 = "(@--@)";
					string[] array3 = Regex.Split(text, text2);
					string text3 = Convert.ToString(array3[2]);
					string text4 = Convert.ToString(array3[4]);
					string text5 = Convert.ToString(array3[6]);
					string text6 = Convert.ToString(array3[8]);
					string text7 = Convert.ToString(array3[10]);
					string text8 = Convert.ToString(array3[12]);
					DateTime now = DateTime.Now;
					bool flag2 = text7 != "";
					if (flag2)
					{
						bool flag3 = Program.date_pc == text7;
						if (flag3)
						{
							bool flag4 = text4 == Program.getMotherBoardID();
							if (flag4)
							{
								Program.set_account_info(text3, text4, text5, text6, text8, false);
								base.Close();
							}
							else
							{
								MessageBox.Show(this._player.rm.GetString("login2_message_106error", this._player.ci));
							}
						}
						else
						{
							MessageBox.Show(this._player.rm.GetString("get_new_license", this._player.ci));
						}
					}
					else
					{
						bool flag5 = text4 == Program.getMotherBoardID();
						if (flag5)
						{
							Program.set_account_info(text3, text4, text5, text6, text8, false);
							base.Close();
						}
						else
						{
							MessageBox.Show(this._player.rm.GetString("login2_message_106error", this._player.ci));
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x0400002D RID: 45
		public string SystemID;

		// Token: 0x0400002E RID: 46
		public string un_hashed;

		// Token: 0x0400002F RID: 47
		public string pw_hashed;

		// Token: 0x04000030 RID: 48
		public string sp_hashed;

		// Token: 0x04000031 RID: 49
		public string mb_hashed;

		// Token: 0x04000032 RID: 50
		public string mb_serial;

		// Token: 0x04000033 RID: 51
		public string[] info;

		// Token: 0x04000035 RID: 53
		private player _player;

		// Token: 0x04000036 RID: 54
		private Point lastPoint;
	}
}
