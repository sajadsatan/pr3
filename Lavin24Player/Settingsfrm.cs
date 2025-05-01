using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using player.Properties;

namespace player
{
	// Token: 0x02000013 RID: 19
	public partial class Settingsfrm : Form
	{
		// Token: 0x060000ED RID: 237 RVA: 0x00011948 File Offset: 0x0000FB48
		public Settingsfrm(player player)
		{
			this._player = player;
			this.InitializeComponent();
			base.StartPosition = FormStartPosition.CenterParent;
			this.BackColor = Color.Black;
			this.comboBox_languages.Items.Add("fa-IR");
			this.comboBox_languages.Items.Add("en-US");
			this.comboBox_languages.SelectedItem = Settings.Default["Language"].ToString();
			string text = Settings.Default["themeName"].ToString();
			this.checkRBT(text);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000119F0 File Offset: 0x0000FBF0
		private void checkRBT(string themN)
		{
			bool flag = themN == "default";
			if (flag)
			{
				this.rbtnDefault.Checked = true;
			}
			bool flag2 = themN == "blue";
			if (flag2)
			{
				this.rbtnBlue.Checked = true;
			}
			bool flag3 = themN == "brown";
			if (flag3)
			{
				this.rbtnBrown.Checked = true;
			}
			bool flag4 = themN == "green";
			if (flag4)
			{
				this.rbtnGreen.Checked = true;
			}
			bool flag5 = themN == "red";
			if (flag5)
			{
				this.rbtnRed.Checked = true;
			}
			bool flag6 = themN == "purple";
			if (flag6)
			{
				this.rbtnPurple.Checked = true;
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00011AAC File Offset: 0x0000FCAC
		private void btnSave_Click(object sender, EventArgs e)
		{
			bool @checked = this.rbtnBlue.Checked;
			if (@checked)
			{
				this.R = 35;
				this.G = 46;
				this.B = 60;
				this.R2 = 35;
				this.G2 = 46;
				this.B2 = 59;
				this.themeName = "blue";
			}
			bool checked2 = this.rbtnBrown.Checked;
			if (checked2)
			{
				this.R = 32;
				this.G = 25;
				this.B = 19;
				this.R2 = 57;
				this.G2 = 41;
				this.B2 = 36;
				this.themeName = "brown";
			}
			bool checked3 = this.rbtnDefault.Checked;
			if (checked3)
			{
				this.R = 17;
				this.G = 17;
				this.B = 17;
				this.R2 = 32;
				this.G2 = 32;
				this.B2 = 32;
				this.themeName = "default";
			}
			bool checked4 = this.rbtnGreen.Checked;
			if (checked4)
			{
				this.R = 15;
				this.G = 22;
				this.B = 15;
				this.R2 = 25;
				this.G2 = 34;
				this.B2 = 24;
				this.themeName = "green";
			}
			bool checked5 = this.rbtnRed.Checked;
			if (checked5)
			{
				this.R = 38;
				this.G = 22;
				this.B = 20;
				this.R2 = 53;
				this.G2 = 34;
				this.B2 = 31;
				this.themeName = "red";
			}
			bool checked6 = this.rbtnPurple.Checked;
			if (checked6)
			{
				this.R = 49;
				this.G = 43;
				this.B = 58;
				this.R2 = 50;
				this.G2 = 44;
				this.B2 = 59;
				this.themeName = "purple";
			}
			Settings.Default["Language"] = this.comboBox_languages.SelectedItem.ToString();
			Settings.Default["themeName"] = this.themeName;
			Settings.Default["R"] = this.R.ToString();
			Settings.Default["G"] = this.G.ToString();
			Settings.Default["B"] = this.B.ToString();
			Settings.Default["R2"] = this.R2.ToString();
			Settings.Default["G2"] = this.G2.ToString();
			Settings.Default["B2"] = this.B2.ToString();
			Settings.Default.Save();
			this.ApplySettings(this.R, this.G, this.B, this.R2, this.G2, this.B2, this.themeName);
			base.Close();
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000021F3 File Offset: 0x000003F3
		private void buttonClosethisForm_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002636 File Offset: 0x00000836
		private void btnDefault_Click(object sender, EventArgs e)
		{
			this.rbtnDefault.Checked = true;
			this.comboBox_languages.SelectedItem = "Persian-IR";
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000021FD File Offset: 0x000003FD
		private void panelBack_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00011DA4 File Offset: 0x0000FFA4
		private void panelBack_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002657 File Offset: 0x00000857
		private void panelBack_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000021FD File Offset: 0x000003FD
		private void comboBox_languages_SelectionChangeCommitted(object sender, EventArgs e)
		{
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00011E08 File Offset: 0x00010008
		private void Settings_Load(object sender, EventArgs e)
		{
			base.StartPosition = FormStartPosition.CenterParent;
			this.panelBack.BackgroundImage = (Image)this._player.rm.GetObject("setting_back", this._player.ci);
			this.btnDefault.Image = (Image)this._player.rm.GetObject("default_setting", this._player.ci);
			this.btnSave.Image = (Image)this._player.rm.GetObject("save_setting", this._player.ci);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00011EB4 File Offset: 0x000100B4
		private void ApplySettings(int r, int g, int b, int r2, int g2, int b2, string theme_name)
		{
			this._player.panelTop.Style.BackColor1.Color = Color.FromArgb(r, g, b);
			this._player.panelRight.Style.BackColor1.Color = Color.FromArgb(r, g, b);
			this._player.panelLeft.Style.BackColor1.Color = Color.FromArgb(r, g, b);
			this._player.panelEx3.Style.BackColor1.Color = Color.FromArgb(r, g, b);
			this._player.panelControls.Style.BackColor1.Color = Color.FromArgb(r, g, b);
			this._player.trackBar1.BackColor = Color.FromArgb(r, g, b);
			this._player.trackBar2.BackColor = Color.FromArgb(r2, g2, b2);
			bool flag = theme_name == "default";
			if (flag)
			{
				this._player.panelControls.Style.BackgroundImage = Resources.back_btn_default;
				this._player.panelPlayPause.Style.BackgroundImage = Resources.play_pause_default;
			}
			bool flag2 = theme_name == "blue";
			if (flag2)
			{
				this._player.panelControls.Style.BackgroundImage = Resources.back_btn_blue;
				this._player.panelPlayPause.Style.BackgroundImage = Resources.play_pause_blue;
			}
			bool flag3 = theme_name == "brown";
			if (flag3)
			{
				this._player.panelControls.Style.BackgroundImage = Resources.back_btn_brown;
				this._player.panelPlayPause.Style.BackgroundImage = Resources.play_pause_brown;
			}
			bool flag4 = theme_name == "green";
			if (flag4)
			{
				this._player.panelControls.Style.BackgroundImage = Resources.back_btn_green;
				this._player.panelPlayPause.Style.BackgroundImage = Resources.play_pause_green;
			}
			bool flag5 = theme_name == "red";
			if (flag5)
			{
				this._player.panelControls.Style.BackgroundImage = Resources.back_btn_red;
				this._player.panelPlayPause.Style.BackgroundImage = Resources.play_pause_red;
			}
			bool flag6 = theme_name == "purple";
			if (flag6)
			{
				this._player.panelControls.Style.BackgroundImage = Resources.back_btn_purple;
				this._player.panelPlayPause.Style.BackgroundImage = Resources.play_pause_purple;
			}
			bool flag7 = this.comboBox_languages.SelectedItem.ToString() == "fa-IR";
			if (flag7)
			{
				this._player.ci = new CultureInfo("fa-IR");
				this._player.isEnglish = false;
				this._player.setLangChanges(this._player.ci);
			}
			else
			{
				this._player.ci = new CultureInfo("en-US");
				this._player.isEnglish = true;
				this._player.setLangChanges(this._player.ci);
			}
		}

		// Token: 0x040000F7 RID: 247
		private player _player;

		// Token: 0x040000F8 RID: 248
		private int R;

		// Token: 0x040000F9 RID: 249
		private int G;

		// Token: 0x040000FA RID: 250
		private int B;

		// Token: 0x040000FB RID: 251
		private int R2;

		// Token: 0x040000FC RID: 252
		private int G2;

		// Token: 0x040000FD RID: 253
		private int B2;

		// Token: 0x040000FE RID: 254
		private string themeName;

		// Token: 0x040000FF RID: 255
		private Point lastPoint;
	}
}
