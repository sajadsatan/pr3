using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using BoxedAppSDK;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Metro.ColorTables;
using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;
using player.Modula;
using player.Properties;
using player.Repository;
using player.Service;

namespace player
{
	// Token: 0x0200000F RID: 15
	public partial class player : Form
	{
		// Token: 0x06000071 RID: 113
		[DllImport("user32.dll")]
		public static extern uint SetWindowDisplayAffinity(IntPtr hWnd, uint dwAffinity);

		// Token: 0x06000072 RID: 114 RVA: 0x00008BFC File Offset: 0x00006DFC
		public void setLangChanges(CultureInfo ci)
		{
			Thread.CurrentThread.CurrentCulture = ci;
			Thread.CurrentThread.CurrentUICulture = ci;
			this.pictureBoxUserName.Image = (Image)this.rm.GetObject("accinfo_username_text", ci);
			this.pictureBoxServerName.Image = (Image)this.rm.GetObject("accinfo_server_text", ci);
			this.labelQuitAcc.Image = (Image)this.rm.GetObject("accinfo_btn_logout", ci);
			this.toolTip1.SetToolTip(this.pictureBox_playlist, this.rm.GetString("tooltip1_playlist", ci));
			this.toolTip1.SetToolTip(this.labelVersion, this.rm.GetString("tooltip1_version", ci));
			this.pictureBoxOpenfile.Image = (Image)this.rm.GetObject("open_file", ci);
			bool flag = this.isEnglish;
			if (flag)
			{
				this.textBoxUserName.Location = new Point(92, 39);
				this.textBoxServerName.Location = new Point(92, 78);
			}
			else
			{
				this.textBoxUserName.Location = new Point(28, 39);
				this.textBoxServerName.Location = new Point(28, 79);
			}
			List<Form> list = new List<Form>();
			foreach (object obj in Application.OpenForms)
			{
				Form form = (Form)obj;
				list.Add(form);
			}
			foreach (Form form2 in list)
			{
				bool flag2 = form2.Name != "player";
				if (flag2)
				{
					form2.Close();
					Program.playlist_ON = false;
				}
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00008E10 File Offset: 0x00007010
		public void event_handler2(object sender, MediaPlayerLengthChangedEventArgs e)
		{
			bool invokeRequired = this.trackBar1.InvokeRequired;
			if (invokeRequired)
			{
				this.trackBar1.Invoke(new MethodInvoker(delegate
				{
					this.trackBar1.Maximum = (int)this._mp.Length / 1000;
					this.t = new global::System.Windows.Forms.Timer();
					this.t.Interval = 1000;
					this.t.Tick += this.t_Tick;
					this.t.Start();
					this.duration(this.trackBar1.Maximum);
					this.lbl_max_timer.Visible = true;
					this.current_time(this.trackBar1.Value);
					this.lbl_timer.Visible = true;
					this.pictureBox1.Image = Resources.puse;
					bool flag2 = Program.duration_show_s != 0 && Program.interval_show_s != 0;
					if (flag2)
					{
						this.show_watermark_with_duration();
					}
				}));
			}
			else
			{
				this.trackBar1.Maximum = (int)this._mp.Length / 1000;
				this.t = new global::System.Windows.Forms.Timer();
				this.t.Interval = 1000;
				this.t.Tick += this.t_Tick;
				this.t.Start();
				this.duration(this.trackBar1.Maximum);
				this.lbl_max_timer.Visible = true;
				this.current_time(this.trackBar1.Value);
				this.lbl_timer.Visible = true;
				this.pictureBox1.Image = Resources.puse;
				bool flag = Program.duration_show_s != 0 && Program.interval_show_s != 0;
				if (flag)
				{
					this.show_watermark_with_duration();
				}
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000021FD File Offset: 0x000003FD
		public void event_handler_Playing(object sender, EventArgs e)
		{
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000021FD File Offset: 0x000003FD
		public void event_handler_TimeChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00008F1C File Offset: 0x0000711C
		public void show_watermark_with_duration()
		{
			this.t_w = new global::System.Windows.Forms.Timer();
			Program.change_pos_sub_play = false;
			Program.cu_t_interval = 0;
			Program.cu_t_duration = 0;
			this.t_w.Interval = 1000;
			this.t_w.Tick += this.tw_Tick;
			this.t_w.Start();
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00008F7C File Offset: 0x0000717C
		private void tw_Tick(object sender, EventArgs e)
		{
			bool flag = Program.interval_show_s != 0;
			if (flag)
			{
				bool flag2 = Program.cu_t_interval == Program.interval_show_s;
				if (flag2)
				{
					bool flag3 = Program.position_random_sub && Program.change_pos_sub_play;
					if (flag3)
					{
						Program.change_pos_sub_play = false;
						this._mp.SetMarqueeInt(VideoMarqueeOption.Position, Program.random_position_sub());
					}
					this._mp.SetMarqueeInt(VideoMarqueeOption.Enable, 1);
					Program.cu_t_duration++;
					bool flag4 = Program.cu_t_duration == Program.duration_show_s;
					if (flag4)
					{
						Program.change_pos_sub_play = true;
						Program.cu_t_interval = 0;
						Program.cu_t_duration = 0;
					}
				}
				else
				{
					this._mp.SetMarqueeInt(VideoMarqueeOption.Enable, 0);
					Program.cu_t_interval++;
				}
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00009038 File Offset: 0x00007238
		public void EndReached_play(object sender, EventArgs e)
		{
			bool invokeRequired = this.lbl_timer.InvokeRequired;
			if (invokeRequired)
			{
				this.lbl_timer.Invoke(new MethodInvoker(delegate
				{
					this.lbl_timer.Visible = false;
				}));
			}
			bool invokeRequired2 = this.lbl_max_timer.InvokeRequired;
			if (invokeRequired2)
			{
				this.lbl_max_timer.Invoke(new MethodInvoker(delegate
				{
					this.lbl_max_timer.Visible = false;
				}));
			}
			bool invokeRequired3 = this.pictureBox1.InvokeRequired;
			if (invokeRequired3)
			{
				this.pictureBox1.Invoke(new MethodInvoker(delegate
				{
					this.pictureBox1.Image = Resources.play_btn1;
					this.toolTip1.SetToolTip(this.pictureBox1, this.rm.GetString("tooltip1_play", this.ci));
				}));
			}
			bool invokeRequired4 = this.trackBar1.InvokeRequired;
			if (invokeRequired4)
			{
				this.trackBar1.Invoke(new MethodInvoker(delegate
				{
					this.t.Stop();
					this.trackBar1.Value = 0;
				}));
			}
			this.isPlaying = false;
			this.pictureBox1.Image = Resources.play_btn1;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00009104 File Offset: 0x00007304
		public player()
		{
			NativeMethods.BoxedAppSDK_SetContext("fb101395-1311-482f-8c38-05c947671fc7");
			NativeMethods.BoxedAppSDK_Init();
			this.InitializeComponent();
			this.pictureBoxLoadingGIF.Visible = true;
			this.key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\" + Program.AppName);
			this.labelVersion.ForeColor = Color.Gray;
			this.labelVersion.Text = "v " + this.Version_lable_txt();
			this.CultureSetter();
			bool flag = Program.check_enviroment();
			if (flag)
			{
				MessageBox.Show(this.rm.GetString("not_running_on_vm", this.ci));
				Application.Exit();
				base.Close();
			}
			try
			{
				Core.Initialize(null);
				base.KeyPreview = true;
				this.oldVideoSize = this.videoView1.Size;
				this.oldFormSize = base.Size;
				this.oldVideoLocation = this.videoView1.Location;
				this._libVLC = new LibVLC(new string[0]);
				this._mp = new MediaPlayer(this._libVLC);
				this.videoView1.MediaPlayer = this._mp;
				this._mp.SetSpuDelay(999999999999999999L);
				this.pictureBoxLoadingGIF.Visible = false;
				this._mp.EnableHardwareDecoding = false;
				this._mp.EnableMouseInput = false;
				this._mp.EnableKeyInput = false;
				this._mp.LengthChanged += this.event_handler2;
				this._mp.EndReached += this.EndReached_play;
				base.KeyDown += this.ShortcutEvent;
				bool flag2 = Program.associatefile != "";
				if (flag2)
				{
					bool flag3 = Path.GetExtension(Program.associatefile) == ".enc";
					if (flag3)
					{
						bool flag4 = this._mp.State == VLCState.Playing;
						if (flag4)
						{
							this._mp.Pause();
						}
						Program.KeyString = "";
						this.play_video_file(Program.associatefile);
					}
				}
				this.AllowDrop = true;
				base.DragEnter += this.Form1_DragEnter;
				base.DragDrop += this.Form1_DragDrop;
			}
			catch (Exception ex)
			{
				string text = "";
				bool is64BitProcess = Environment.Is64BitProcess;
				string text2;
				if (is64BitProcess)
				{
					text2 = "CPU architecture: x64";
				}
				else
				{
					text2 = "CPU architecture: x86";
				}
				bool is64BitOperatingSystem = Environment.Is64BitOperatingSystem;
				string text3;
				if (is64BitOperatingSystem)
				{
					text3 = "Windows architecture: x64";
				}
				else
				{
					text3 = "Windows architecture: x86";
				}
				MessageBox.Show(string.Concat(new string[] { ex.Message, "\n", text, "\n", text2, "\n", text3 }));
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00009458 File Offset: 0x00007658
		private void Form1_DragEnter(object sender, DragEventArgs e)
		{
			bool dataPresent = e.Data.GetDataPresent(DataFormats.FileDrop);
			if (dataPresent)
			{
				e.Effect = DragDropEffects.Copy;
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00009484 File Offset: 0x00007684
		private void Form1_DragDrop(object sender, DragEventArgs e)
		{
			string[] array = (string[])e.Data.GetData(DataFormats.FileDrop);
			foreach (string text in array)
			{
				bool flag = Path.GetExtension(text) == ".enc";
				if (flag)
				{
					bool flag2 = this._mp.State == VLCState.Playing;
					if (flag2)
					{
						this._mp.Pause();
					}
					Program.KeyString = "";
					this.play_video_file(text);
					break;
				}
				this._mp.Play(new Media(this._libVLC, text, FromType.FromPath, new string[0]));
				this.isPlaying = true;
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00009538 File Offset: 0x00007738
		public void ShortcutEvent(object sender, KeyEventArgs e)
		{
			bool flag = this.isPlaying;
			if (flag)
			{
				bool flag2 = e.KeyCode == Keys.Space;
				if (flag2)
				{
					bool flag3 = this._mp.State == VLCState.Playing;
					if (flag3)
					{
						this._mp.Pause();
					}
					else
					{
						this._mp.Play();
					}
				}
				bool flag4 = e.KeyCode == Keys.J;
				if (flag4)
				{
					this._mp.Position -= 0.01f;
				}
				bool flag5 = e.KeyCode == Keys.L;
				if (flag5)
				{
					this._mp.Position += 0.01f;
				}
			}
			bool flag6 = e.KeyCode == Keys.OemOpenBrackets;
			if (flag6)
			{
				this.backward_action();
			}
			bool flag7 = e.KeyCode == Keys.OemCloseBrackets;
			if (flag7)
			{
				this.forward_action();
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00009620 File Offset: 0x00007820
		public void show_loginForm(string baseURL)
		{
			this.pictureBoxLoadingGIF.Visible = false;
			try
			{
				this.settings = this.SMSService.GetSettings(baseURL);
			}
			catch
			{
				this.settings = new SettingServer
				{
					Method = 0
				};
			}
			bool flag = this.settings.Method == 1;
			if (flag)
			{
				this.pictureBoxLoadingGIF.Visible = false;
				LoginBySMS loginBySMS = new LoginBySMS(this);
				loginBySMS.ShowDialog();
			}
			else
			{
				this.pictureBoxLoadingGIF.Visible = false;
				LoginByUsername loginByUsername = new LoginByUsername(this);
				loginByUsername.ShowDialog();
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000096C8 File Offset: 0x000078C8
		public void play_video_file(string pathfile)
		{
			Program.water = null;
			Program.Key = null;
			Program.PathFile = pathfile;
			string text = "(@--@)";
			string text2 = Program.ReadLastLine(Program.PathFile);
			this.info = Regex.Split(text2, text);
			this.key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\" + Program.AppName);
			if (this.key == null)
			{
				this.show_loginForm(Cipher.Decrypt(this.info[2], Program.stringForHash));
				if (Program.Key != null && Program.PathFile != "")
				{
					if (Program.elfo != "on")
					{
						RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Users-" + Program.AppName);
						Program.SkuProduct = Cipher.Decrypt(this.info[6], Program.stringForHash);
						registryKey.SetValue(Cipher.Encrypt(Program.SkuProduct, Program.passEncr), Cipher.Encrypt(Program.KeyString, Program.passEncr));
						registryKey.SetValue(Cipher.Encrypt(Program.SkuProduct + "|-|su", Program.passEncr), Cipher.Encrypt(Program.water, Program.passEncr));
						registryKey.Close();
					}
					Program.SkuProduct = "";
					Program.KeyString = "";
					this.PlayEncryptedVideo(Program.PathFile);
					return;
				}
			}
			else
			{
				Program.base_url = Cipher.Decrypt(this.info[2], Program.stringForHash);
				RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Users-" + Program.AppName, true);
				if (registryKey2 != null)
				{
					string text3 = Cipher.Encrypt(Cipher.Decrypt(this.info[6], Program.stringForHash) + "|-|su", Program.passEncr);
					if (registryKey2.GetValue(text3) != null)
					{
						Program.water = Cipher.Decrypt(Convert.ToString(registryKey2.GetValue(text3)), Program.passEncr);
						string text4 = Cipher.Encrypt(Cipher.Decrypt(this.info[6], Program.stringForHash), Program.passEncr);
						if (registryKey2.GetValue(text4) != null)
						{
							string text5 = Convert.ToString(registryKey2.GetValue(text4));
							if (text5 != "")
							{
								Program.KeyString = Cipher.Decrypt(text5, Program.passEncr);
								Program.Key = Encoding.Unicode.GetBytes(Program.KeyString);
							}
							else
							{
								Program.KeyString = "";
							}
						}
						else
						{
							Program.KeyString = "";
						}
					}
					registryKey2.Close();
				}
				else
				{
					Program.KeyString = "";
				}
				if (Program.KeyString == "")
				{
					Program.base_url = Cipher.Decrypt(this.info[2], Program.stringForHash);
					ActivateService activateService = new ActivateService(new WpWebServiceRepository(Cipher.Decrypt(this.info[2], Program.stringForHash), "", Program.base_url));
					string text6 = Cipher.Decrypt(this.key.GetValue("token").ToString(), Program.passEncr);
					Program.version = new Version(FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion);
					ApiResponse apiResponse = activateService.CheckOrder(Cipher.Decrypt(this.info[6], Program.stringForHash), Program.getMotherBoardID(), text6, Program.version);
					if (apiResponse.statusCode == "200")
					{
						Program.Key = Encoding.Unicode.GetBytes(apiResponse.statusText);
						Program.KeyString = apiResponse.statusText;
						if (Program.KeyString != null)
						{
							RegistryKey registryKey3 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Users-" + Program.AppName);
							Program.SkuProduct = Cipher.Decrypt(this.info[6], Program.stringForHash);
							if (apiResponse.elfo != "on")
							{
								registryKey3.SetValue(Cipher.Encrypt(Program.SkuProduct, Program.passEncr), Cipher.Encrypt(apiResponse.statusText, Program.passEncr));
							}
							if (apiResponse.su != null)
							{
								Program.water = Program.convert_Subtitle_to_string(apiResponse.su);
								registryKey3.SetValue(Cipher.Encrypt(Program.SkuProduct + "|-|su", Program.passEncr), Cipher.Encrypt(Program.convert_Subtitle_to_string(apiResponse.su), Program.passEncr));
							}
							registryKey3.Close();
							Program.SkuProduct = "";
							Program.KeyString = "";
							this.PlayEncryptedVideo(Program.PathFile);
							return;
						}
					}
					else
					{
						if (!(apiResponse.statusCode == "98"))
						{
							apiResponse.statusCode == "97";
							this.PlayEncryptedVideo(Program.PathFile);
							return;
						}
						if (MessageBox.Show(this.rm.GetString("download_last_version", this.ci), this.rm.GetString("downlod_btn", this.ci), MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
						{
							Process.Start(apiResponse.statusText);
							return;
						}
					}
				}
				else
				{
					if (Cipher.Decrypt(Convert.ToString(this.key.GetValue("hardwareId")), Program.passEncr) == Program.getMotherBoardID())
					{
						this.PlayEncryptedVideo(Program.PathFile);
						return;
					}
					MessageBox.Show(this.rm.GetString("message_107error", this.ci));
				}
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00009BE0 File Offset: 0x00007DE0
		private void pictureBoxOpenfile_Click(object sender, EventArgs e)
		{
			bool flag = this._mp.State == VLCState.Playing;
			if (flag)
			{
				this._mp.Pause();
			}
			this.pictureBox1.Image = Resources.play_btn1;
			this.toolTip1.SetToolTip(this.pictureBox1, this.rm.GetString("tooltip1_play", this.ci));
			this.openFileDialog1.FileName = "";
			this.openFileDialog1.Filter = "Video File (enc,mp4,avi,mov,wmd,ivf,mpg,mpeg,3gp,m4v,mkv) |*.enc;*.mp4;*.avi;*.mov;*.wmd;*.ivf;*.mpg;*.mpeg;*.3gp;*.m4v;*.mkv";
			bool flag2 = this.openFileDialog1.ShowDialog() == DialogResult.OK;
			if (flag2)
			{
				bool flag3 = Path.GetExtension(this.openFileDialog1.FileName) == ".enc";
				if (flag3)
				{
					Program.KeyString = "";
					this.play_video_file(this.openFileDialog1.FileName);
				}
				else
				{
					bool flag4 = Path.GetExtension(this.openFileDialog1.FileName) != ".enc";
					if (flag4)
					{
						Program.show_subtitle("", this._mp);
						this._mp.Play(new Media(this._libVLC, this.openFileDialog1.FileName, FromType.FromPath, new string[0]));
						this.isPlaying = true;
					}
				}
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000023CA File Offset: 0x000005CA
		public void WMP_url_add(string path)
		{
			this._mp.Play(new Media(this._libVLC, path, FromType.FromPath, new string[0]));
			this.isPlaying = true;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00009D20 File Offset: 0x00007F20
		public void PlayEncryptedVideo(string path)
		{
			try
			{
				using (new SafeFileHandle(NativeMethods.BoxedAppSDK_CreateVirtualFileBasedOnIStream("1.avi", NativeMethods.EFileAccess.GenericWrite, NativeMethods.EFileShare.Read, IntPtr.Zero, NativeMethods.ECreationDisposition.New, NativeMethods.EFileAttributes.Normal, IntPtr.Zero, new VirtualFileStream(path)), true))
				{
				}
				this.PlayViaVLC(this.isPlaying, "1.avi");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000023F3 File Offset: 0x000005F3
		private void t_Tick(object sender, EventArgs e)
		{
			this.trackBar1.Value = (int)this._mp.Time / 1000;
			this.current_time(this.trackBar1.Value);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00009DB0 File Offset: 0x00007FB0
		private void ApplySettings(int r, int g, int b, int r2, int g2, int b2, string theme_name)
		{
			this.panelTop.Style.BackColor1.Color = Color.FromArgb(r, g, b);
			this.panelRight.Style.BackColor1.Color = Color.FromArgb(r, g, b);
			this.panelLeft.Style.BackColor1.Color = Color.FromArgb(r, g, b);
			this.panelEx3.Style.BackColor1.Color = Color.FromArgb(r, g, b);
			this.panelControls.Style.BackColor1.Color = Color.FromArgb(r, g, b);
			this.trackBar1.BackColor = Color.FromArgb(r, g, b);
			this.trackBar2.BackColor = Color.FromArgb(r2, g2, b2);
			bool flag = theme_name == "default";
			if (flag)
			{
				this.panelControls.Style.BackgroundImage = Resources.back_btn_default;
				this.panelPlayPause.Style.BackgroundImage = Resources.play_pause_default;
			}
			bool flag2 = theme_name == "blue";
			if (flag2)
			{
				this.panelControls.Style.BackgroundImage = Resources.back_btn_blue;
				this.panelPlayPause.Style.BackgroundImage = Resources.play_pause_blue;
			}
			bool flag3 = theme_name == "brown";
			if (flag3)
			{
				this.panelControls.Style.BackgroundImage = Resources.back_btn_brown;
				this.panelPlayPause.Style.BackgroundImage = Resources.play_pause_brown;
			}
			bool flag4 = theme_name == "green";
			if (flag4)
			{
				this.panelControls.Style.BackgroundImage = Resources.back_btn_green;
				this.panelPlayPause.Style.BackgroundImage = Resources.play_pause_green;
			}
			bool flag5 = theme_name == "red";
			if (flag5)
			{
				this.panelControls.Style.BackgroundImage = Resources.back_btn_red;
				this.panelPlayPause.Style.BackgroundImage = Resources.play_pause_red;
			}
			bool flag6 = theme_name == "purple";
			if (flag6)
			{
				this.panelControls.Style.BackgroundImage = Resources.back_btn_purple;
				this.panelPlayPause.Style.BackgroundImage = Resources.play_pause_purple;
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00009FF8 File Offset: 0x000081F8
		private void player_Load(object sender, EventArgs e)
		{
			player.SetWindowDisplayAffinity(base.Handle, 1U);
			string text = Settings.Default["themeName"].ToString();
			this.ci = new CultureInfo(Settings.Default["Language"].ToString());
			bool flag = Settings.Default["Language"].ToString() == "fa-IR";
			if (flag)
			{
				this.isEnglish = false;
			}
			else
			{
				this.isEnglish = true;
			}
			int num = int.Parse(Settings.Default["R"].ToString());
			int num2 = int.Parse(Settings.Default["B"].ToString());
			int num3 = int.Parse(Settings.Default["G"].ToString());
			int num4 = int.Parse(Settings.Default["R2"].ToString());
			int num5 = int.Parse(Settings.Default["B2"].ToString());
			int num6 = int.Parse(Settings.Default["G2"].ToString());
			this.setLangChanges(this.ci);
			this.ApplySettings(num, num3, num2, num4, num6, num5, text);
			this.infoPanelOpen = true;
			this.accountInfo_panel_handler();
			this.show_account_info_on_player();
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000A150 File Offset: 0x00008350
		public void show_account_info_on_player()
		{
			this.key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\" + Program.AppName);
			bool flag = this.key != null;
			if (flag)
			{
				this.panelAccInfBack.Visible = true;
				bool flag2 = this.key.GetValue("username") != null;
				if (flag2)
				{
					this.textBoxUserName.Text = Convert.ToString(this.key.GetValue("username"));
				}
				bool flag3 = this.key.GetValue("phone_number") != null;
				if (flag3)
				{
					this.textBoxUserName.Text = Convert.ToString(this.key.GetValue("phone_number"));
				}
				bool flag4 = this.key.GetValue("server") != null;
				if (flag4)
				{
					this.textBoxServerName.Text = Convert.ToString(this.key.GetValue("server"));
				}
				else
				{
					this.textBoxServerName.Text = "-";
				}
			}
			else
			{
				this.panelAccInfBack.Visible = false;
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000A270 File Offset: 0x00008470
		private void current_time(int tBar_value)
		{
			this.timer_h = tBar_value / 3600;
			this.timer_min = tBar_value / 60 - tBar_value / 3600 * 60;
			this.timer_sec = tBar_value % 60;
			bool flag = this.timer_h == 0;
			if (flag)
			{
				bool flag2 = (this.timer_min < 10) & (this.timer_sec < 10);
				if (flag2)
				{
					this.lbl_timer.Text = "0" + this.timer_min.ToString() + ":0" + this.timer_sec.ToString();
				}
				bool flag3 = (this.timer_min < 10) & (this.timer_sec > 9);
				if (flag3)
				{
					this.lbl_timer.Text = "0" + this.timer_min.ToString() + ":" + this.timer_sec.ToString();
				}
				bool flag4 = (this.timer_min > 9) & (this.timer_sec < 10);
				if (flag4)
				{
					this.lbl_timer.Text = this.timer_min.ToString() + ":0" + this.timer_sec.ToString();
				}
				bool flag5 = (this.timer_min > 9) & (this.timer_sec > 9);
				if (flag5)
				{
					this.lbl_timer.Text = this.timer_min.ToString() + ":" + this.timer_sec.ToString();
				}
			}
			else
			{
				bool flag6 = (this.timer_min < 10) & (this.timer_sec < 10);
				if (flag6)
				{
					this.lbl_timer.Text = string.Concat(new string[]
					{
						this.timer_h.ToString(),
						":0",
						this.timer_min.ToString(),
						":0",
						this.timer_sec.ToString()
					});
				}
				bool flag7 = (this.timer_min < 10) & (this.timer_sec > 9);
				if (flag7)
				{
					this.lbl_timer.Text = string.Concat(new string[]
					{
						this.timer_h.ToString(),
						":0",
						this.timer_min.ToString(),
						":",
						this.timer_sec.ToString()
					});
				}
				bool flag8 = (this.timer_min > 9) & (this.timer_sec < 10);
				if (flag8)
				{
					this.lbl_timer.Text = string.Concat(new string[]
					{
						this.timer_h.ToString(),
						":",
						this.timer_min.ToString(),
						":0",
						this.timer_sec.ToString()
					});
				}
				bool flag9 = (this.timer_min > 9) & (this.timer_sec > 9);
				if (flag9)
				{
					this.lbl_timer.Text = string.Concat(new string[]
					{
						this.timer_h.ToString(),
						":",
						this.timer_min.ToString(),
						":",
						this.timer_sec.ToString()
					});
				}
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000A594 File Offset: 0x00008794
		public void duration(int tBar_max)
		{
			this.max_timer_h = tBar_max / 3600;
			this.max_timer_min = tBar_max / 60 - tBar_max / 3600 * 60;
			this.max_timer_sec = tBar_max % 60;
			bool flag = this.max_timer_h == 0;
			if (flag)
			{
				bool flag2 = (this.max_timer_min < 10) & (this.max_timer_sec < 10);
				if (flag2)
				{
					this.lbl_max_timer.Text = "0" + this.max_timer_min.ToString() + ":0" + this.max_timer_sec.ToString();
				}
				bool flag3 = (this.max_timer_min < 10) & (this.max_timer_sec > 9);
				if (flag3)
				{
					this.lbl_max_timer.Text = "0" + this.max_timer_min.ToString() + ":" + this.max_timer_sec.ToString();
				}
				bool flag4 = (this.max_timer_min > 9) & (this.max_timer_sec < 10);
				if (flag4)
				{
					this.lbl_max_timer.Text = this.max_timer_min.ToString() + ":0" + this.max_timer_sec.ToString();
				}
				bool flag5 = (this.max_timer_min > 9) & (this.max_timer_sec > 9);
				if (flag5)
				{
					this.lbl_max_timer.Text = this.max_timer_min.ToString() + ":" + this.max_timer_sec.ToString();
				}
			}
			else
			{
				bool flag6 = (this.max_timer_min < 10) & (this.max_timer_sec < 10);
				if (flag6)
				{
					this.lbl_max_timer.Text = string.Concat(new string[]
					{
						this.max_timer_h.ToString(),
						":0",
						this.max_timer_min.ToString(),
						":0",
						this.max_timer_sec.ToString()
					});
				}
				bool flag7 = (this.max_timer_min < 10) & (this.max_timer_sec > 9);
				if (flag7)
				{
					this.lbl_max_timer.Text = string.Concat(new string[]
					{
						this.max_timer_h.ToString(),
						":0",
						this.max_timer_min.ToString(),
						":",
						this.max_timer_sec.ToString()
					});
				}
				bool flag8 = (this.max_timer_min > 9) & (this.max_timer_sec < 10);
				if (flag8)
				{
					this.lbl_max_timer.Text = string.Concat(new string[]
					{
						this.max_timer_h.ToString(),
						":",
						this.max_timer_min.ToString(),
						":0",
						this.max_timer_sec.ToString()
					});
				}
				bool flag9 = (this.max_timer_min > 9) & (this.max_timer_sec > 9);
				if (flag9)
				{
					this.lbl_max_timer.Text = string.Concat(new string[]
					{
						this.max_timer_h.ToString(),
						":",
						this.max_timer_min.ToString(),
						":",
						this.max_timer_sec.ToString()
					});
				}
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002426 File Offset: 0x00000626
		public void trackBar1_Scroll(object sender, EventArgs e)
		{
			this._mp.Time = (long)(this.trackBar1.Value * 1000);
			this.current_time(this.trackBar1.Value);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000A8B8 File Offset: 0x00008AB8
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.labelSpeed.Visible = false;
			bool flag = this.isPlaying;
			if (flag)
			{
				bool flag2 = this._mp.State == VLCState.Playing;
				if (flag2)
				{
					this._mp.Pause();
					this.pictureBox1.Image = Resources.play_btn1;
					this.toolTip1.SetToolTip(this.pictureBox1, this.rm.GetString("tooltip1_play", this.ci));
				}
				else
				{
					this._mp.Play();
					this.pictureBox1.Image = Resources.puse;
					this.toolTip1.SetToolTip(this.pictureBox1, this.rm.GetString("tooltip1_pause", this.ci));
				}
			}
			else
			{
				MessageBox.Show(this.rm.GetString("playbtn_nofile", this.ci));
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000A9A4 File Offset: 0x00008BA4
		private void fullScreener()
		{
			this.show_account_info_on_player();
			bool flag = !this.modescreen;
			if (flag)
			{
				base.WindowState = FormWindowState.Maximized;
				this.videoView1.Dock = DockStyle.Fill;
				this.videoView1.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
				this.pictureBox3.Image = Resources.full_back;
				this.panelLeft.Visible = false;
				this.panelRight.Visible = false;
				this.panelTop.Visible = false;
				this.panelEx3.Visible = false;
				this.panelAccInfBack.Visible = false;
				this.modescreen = true;
			}
			else
			{
				base.WindowState = FormWindowState.Normal;
				this.pictureBox3.Image = Resources.fullscreen;
				this.buttonX3.Image = Resources.large;
				this.videoView1.Dock = DockStyle.Fill;
				this.videoView1.Size = new Size(768, 452);
				this.panelLeft.Visible = true;
				this.panelRight.Visible = true;
				this.panelTop.Visible = true;
				this.panelEx3.Visible = true;
				this.infoPanelOpen = true;
				this.accountInfo_panel_handler();
				this.modescreen = false;
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002459 File Offset: 0x00000659
		private void pictureBox3_Click(object sender, EventArgs e)
		{
			this.fullScreener();
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000AB10 File Offset: 0x00008D10
		private void player_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				bool flag2 = this.modescreen;
				if (flag2)
				{
					base.WindowState = FormWindowState.Normal;
					this.modescreen = false;
					this.panelLeft.Visible = true;
					this.panelRight.Visible = true;
					this.panelTop.Visible = true;
					this.panelEx3.Visible = true;
					this.panelAccInfBack.Visible = true;
					this.infoPanelOpen = true;
					this.accountInfo_panel_handler();
					this.pictureBox3.Image = Resources.fullscreen;
					this.buttonX3.Image = Resources.large;
				}
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000ABC0 File Offset: 0x00008DC0
		private void trackBar2_Scroll(object sender, EventArgs e)
		{
			this._mp.Volume = this.trackBar2.Value * 10;
			bool flag = this._mp.Volume == 0;
			if (flag)
			{
				this.pictureBox4.Image = Resources.sound_off;
			}
			else
			{
				this.pictureBox4.Image = Resources.sound_on;
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000AC24 File Offset: 0x00008E24
		private void pictureBox4_Click(object sender, EventArgs e)
		{
			bool flag = this._mp.Volume == 0;
			if (flag)
			{
				this._mp.Volume = 100;
				this.trackBar2.Value = 10;
				this.pictureBox4.Image = Resources.sound_on;
			}
			else
			{
				this._mp.Volume = 0;
				this.trackBar2.Value = 0;
				this.pictureBox4.Image = Resources.sound_off;
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000021FD File Offset: 0x000003FD
		private void lbl_version_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000021FD File Offset: 0x000003FD
		private void labelVersion_MouseHover(object sender, EventArgs e)
		{
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000021FD File Offset: 0x000003FD
		private void labelVersion_MouseLeave(object sender, EventArgs e)
		{
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000ACA4 File Offset: 0x00008EA4
		private string Version_lable_txt()
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(executingAssembly.Location);
			Version version = new Version(versionInfo.ProductVersion);
			return Convert.ToString(version);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000021FD File Offset: 0x000003FD
		private void plylist_DragEnter(object sender, DragEventArgs e)
		{
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000021FD File Offset: 0x000003FD
		private void plylist_DragDrop(object sender, DragEventArgs e)
		{
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000ACDC File Offset: 0x00008EDC
		private string getFilename(string path)
		{
			return Path.GetFileNameWithoutExtension(path);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002463 File Offset: 0x00000663
		private void buttonX1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000246D File Offset: 0x0000066D
		private void buttonX4_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000ACF4 File Offset: 0x00008EF4
		private void buttonX3_Click(object sender, EventArgs e)
		{
			bool flag = base.WindowState == FormWindowState.Normal;
			if (flag)
			{
				base.WindowState = FormWindowState.Maximized;
				this.buttonX3.Image = Resources.normalize;
			}
			else
			{
				bool flag2 = base.WindowState == FormWindowState.Maximized;
				if (flag2)
				{
					base.WindowState = FormWindowState.Normal;
					this.buttonX3.Image = Resources.large;
				}
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002478 File Offset: 0x00000678
		private void panelEx3_MouseLeave(object sender, EventArgs e)
		{
			this.panelEx3.Visible = false;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000AD54 File Offset: 0x00008F54
		private void panelTop_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002488 File Offset: 0x00000688
		private void panelTop_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000ADB8 File Offset: 0x00008FB8
		private void forward_action()
		{
			bool flag = this._mp.Rate >= 10f;
			if (flag)
			{
				this._mp.SetRate(1f);
				this.labelSpeed.Visible = false;
			}
			else
			{
				this._mp.SetRate((float)((double)this._mp.Rate + 0.1));
				bool flag2 = (double)this._mp.Rate > 0.95 && (double)this._mp.Rate < 1.05;
				if (flag2)
				{
					this._mp.SetRate(1f);
					this.labelSpeed.Visible = false;
				}
				else
				{
					this.labelSpeed.Text = this._mp.Rate.ToString("0.0") + "x";
					this.labelSpeed.Visible = true;
				}
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000024A2 File Offset: 0x000006A2
		private void pictureBox_forward_Click(object sender, EventArgs e)
		{
			this.forward_action();
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000AEC0 File Offset: 0x000090C0
		private void backward_action()
		{
			bool flag = this._mp.Rate <= -10f;
			if (flag)
			{
				this._mp.SetRate(1f);
				this.labelSpeed.Visible = false;
			}
			float rate = this._mp.Rate;
			bool flag2 = (double)rate == 0.03;
			if (flag2)
			{
				this._mp.SetRate(0.03f);
				this.labelSpeed.Text = "0.03x";
				this.labelSpeed.Visible = true;
			}
			bool flag3 = rate == 0.1f;
			if (flag3)
			{
				this._mp.SetRate(0.03f);
				this.labelSpeed.Text = "0.03x";
				this.labelSpeed.Visible = true;
			}
			this._mp.SetRate((float)((double)this._mp.Rate - 0.1));
			bool flag4 = (double)this._mp.Rate > 0.95 && (double)this._mp.Rate < 1.05;
			if (flag4)
			{
				this._mp.SetRate(1f);
				this.labelSpeed.Visible = false;
			}
			else
			{
				this.labelSpeed.Text = this._mp.Rate.ToString("0.0") + "x";
				this.labelSpeed.Visible = true;
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000024AC File Offset: 0x000006AC
		private void pictureBox_backward_Click(object sender, EventArgs e)
		{
			this.backward_action();
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000B04C File Offset: 0x0000924C
		public bool IsFinished()
		{
			return this.trackBar1.Value == this.trackBar1.Maximum || this.trackBar1.Value > this.trackBar1.Maximum - 2;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000B0A0 File Offset: 0x000092A0
		public int trackbarMax()
		{
			return this.trackBar1.Maximum;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000B0C0 File Offset: 0x000092C0
		private void pictureBox_playlist_Click(object sender, EventArgs e)
		{
			bool flag = base.WindowState == FormWindowState.Maximized;
			if (flag)
			{
				this.formLoc.X = base.DesktopLocation.X;
				this.formLoc.Y = base.DesktopLocation.Y;
			}
			else
			{
				this.formLoc.X = base.DesktopLocation.X - 250;
				this.formLoc.Y = base.DesktopLocation.Y;
			}
			PlaylistForm playlistForm = new PlaylistForm(this);
			bool flag2 = !Program.playlist_ON;
			if (flag2)
			{
				Program.playlist_ON = true;
				playlistForm.Show();
			}
			else
			{
				foreach (object obj in Application.OpenForms)
				{
					Form form = (Form)obj;
					form.BringToFront();
				}
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000B1D0 File Offset: 0x000093D0
		private void pictureBoxSettings_Click(object sender, EventArgs e)
		{
			Settingsfrm settingsfrm = new Settingsfrm(this);
			settingsfrm.ShowDialog();
			settingsfrm.TopMost = true;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000B1F4 File Offset: 0x000093F4
		private void videoView1_MouseMove_1(object sender, MouseEventArgs e)
		{
			bool flag = this.modescreen;
			if (flag)
			{
				Point mousePosition = Control.MousePosition;
				int num = 19 * this.videoView1.Size.Height / 20;
				bool flag2 = mousePosition.Y > num;
				if (flag2)
				{
					this.panelEx3.Visible = true;
				}
				else
				{
					this.panelEx3.Visible = false;
				}
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000B25C File Offset: 0x0000945C
		public void CultureSetter()
		{
			bool flag = Settings.Default["Language"].ToString() == "fa-IR";
			if (flag)
			{
				this.isEnglish = false;
				this.ci = new CultureInfo("fa-IR");
			}
			else
			{
				this.isEnglish = true;
				this.ci = new CultureInfo("en-US");
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000B2C0 File Offset: 0x000094C0
		public void PlayViaVLC(bool isplaying, string vidpath)
		{
			bool flag = !isplaying;
			if (flag)
			{
				this.pictureBox1.Image = Resources.puse;
				this.toolTip1.SetToolTip(this.pictureBox1, this.rm.GetString("tooltip1_pause", this.ci));
			}
			bool flag2 = Program.water != null;
			if (flag2)
			{
				Program.show_subtitle(Program.water, this._mp);
			}
			else
			{
				Program.show_subtitle("", this._mp);
			}
			this.show_account_info_on_player();
			this._mp.Play(new Media(this._libVLC, vidpath, FromType.FromPath, new string[0]));
			this.isPlaying = true;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000024B6 File Offset: 0x000006B6
		private void buttonXAcountInfo_MouseEnter(object sender, EventArgs e)
		{
			this.infoPanelOpen = false;
			this.accountInfo_panel_handler();
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000024C7 File Offset: 0x000006C7
		private void panelAccInfBack_MouseLeave(object sender, EventArgs e)
		{
			this.infoPanelOpen = true;
			this.accountInfo_panel_handler();
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000024C7 File Offset: 0x000006C7
		private void videoView1_MouseEnter(object sender, EventArgs e)
		{
			this.infoPanelOpen = true;
			this.accountInfo_panel_handler();
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000B374 File Offset: 0x00009574
		public void accountInfo_panel_handler()
		{
			bool flag = this.infoPanelOpen;
			if (flag)
			{
				this.panelAccInfBack.Size = new Size(38, 30);
				int num = this.panelTop.Width - 56 - this.panelAccInfBack.Width;
				this.panelAccInfBack.Location = new Point(num, 0);
			}
			else
			{
				this.panelAccInfBack.Size = new Size(407, 145);
				int num2 = this.panelTop.Width - 56 - this.panelAccInfBack.Width;
				this.panelAccInfBack.Location = new Point(num2, 0);
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000B420 File Offset: 0x00009620
		private void labelQuitAcc_Click(object sender, EventArgs e)
		{
			frm_logout frm_logout = new frm_logout(this);
			frm_logout.ShowDialog();
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000024D8 File Offset: 0x000006D8
		private void labelQuitAcc_MouseHover(object sender, EventArgs e)
		{
			this.labelQuitAcc.ForeColor = Color.Red;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000024EC File Offset: 0x000006EC
		private void labelQuitAcc_MouseLeave(object sender, EventArgs e)
		{
			this.labelQuitAcc.ForeColor = Color.White;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000021FD File Offset: 0x000003FD
		private void labelName_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000063 RID: 99
		private global::System.Windows.Forms.Timer t;

		// Token: 0x04000064 RID: 100
		private global::System.Windows.Forms.Timer t_w;

		// Token: 0x04000065 RID: 101
		public RegistryKey key;

		// Token: 0x04000066 RID: 102
		public string[] info;

		// Token: 0x04000067 RID: 103
		private const uint WDA_NONE = 0U;

		// Token: 0x04000068 RID: 104
		private const uint WDA_MONITOR = 1U;

		// Token: 0x04000069 RID: 105
		public bool modescreen = false;

		// Token: 0x0400006A RID: 106
		public bool infoPanelOpen = false;

		// Token: 0x0400006B RID: 107
		public double speed;

		// Token: 0x0400006C RID: 108
		public int timer_h;

		// Token: 0x0400006D RID: 109
		public int timer_min;

		// Token: 0x0400006E RID: 110
		public int timer_sec;

		// Token: 0x0400006F RID: 111
		public int max_timer_h;

		// Token: 0x04000070 RID: 112
		public int max_timer_min;

		// Token: 0x04000071 RID: 113
		public int max_timer_sec;

		// Token: 0x04000072 RID: 114
		public Point formLoc;

		// Token: 0x04000073 RID: 115
		public SMSService SMSService = new SMSService();

		// Token: 0x04000074 RID: 116
		public SettingServer settings;

		// Token: 0x04000075 RID: 117
		public SMScodeActivation activeCodeSMS;

		// Token: 0x04000076 RID: 118
		public static Assembly a = Assembly.Load(Program.AppName);

		// Token: 0x04000077 RID: 119
		public ResourceManager rm = new ResourceManager("player.Lang.langres", player.a);

		// Token: 0x04000078 RID: 120
		public CultureInfo ci;

		// Token: 0x04000079 RID: 121
		public bool isEnglish;

		// Token: 0x0400007A RID: 122
		public LibVLC _libVLC;

		// Token: 0x0400007B RID: 123
		public MediaPlayer _mp;

		// Token: 0x0400007C RID: 124
		public Media media;

		// Token: 0x0400007D RID: 125
		public bool isFullscreen = false;

		// Token: 0x0400007E RID: 126
		public bool isPlaying = false;

		// Token: 0x0400007F RID: 127
		public Size oldVideoSize;

		// Token: 0x04000080 RID: 128
		public Size oldFormSize;

		// Token: 0x04000081 RID: 129
		public Point oldVideoLocation;

		// Token: 0x04000082 RID: 130
		public int cu_t_w;

		// Token: 0x04000083 RID: 131
		public int dur;

		// Token: 0x04000084 RID: 132
		private Point lastPoint;
	}
}
