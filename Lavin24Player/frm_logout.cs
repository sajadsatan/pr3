using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Microsoft.Win32;

namespace player
{
	// Token: 0x02000009 RID: 9
	public partial class frm_logout : Form
	{
		// Token: 0x0600002F RID: 47 RVA: 0x000021D4 File Offset: 0x000003D4
		public frm_logout(player player)
		{
			this._player = player;
			this.InitializeComponent();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000039D8 File Offset: 0x00001BD8
		private void btn_logout_Click(object sender, EventArgs e)
		{
			this._player.panelAccInfBack.Visible = false;
			bool flag = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Users-" + Program.AppName, true) != null;
			if (flag)
			{
				Registry.CurrentUser.DeleteSubKey("SOFTWARE\\Users-" + Program.AppName);
			}
			Registry.CurrentUser.DeleteSubKey("SOFTWARE\\" + Program.AppName);
			Program.Key = null;
			Program.SkuProduct = "";
			Program.KeyString = "";
			Program.PathFile = "";
			base.Close();
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000021F3 File Offset: 0x000003F3
		private void btn_cancell_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003A7C File Offset: 0x00001C7C
		private void frm_logout_Load(object sender, EventArgs e)
		{
			this.btn_logout.Image = (Image)this._player.rm.GetObject("frmlogout_logout", this._player.ci);
			this.btn_cancell.Image = (Image)this._player.rm.GetObject("frmlogout_cancel", this._player.ci);
			bool isEnglish = this._player.isEnglish;
			if (isEnglish)
			{
				this.lbl_logout.RightToLeft = RightToLeft.No;
				this.lbl_logout.Font = new Font("Arial", 10f);
			}
			else
			{
				this.lbl_logout.RightToLeft = RightToLeft.Yes;
				this.lbl_logout.Font = new Font(Program.pfc.Families[0], 12f);
			}
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\" + Program.AppName);
			bool flag = registryKey != null;
			if (flag)
			{
				this.lbl_logout.Text = this._player.rm.GetString("logout_lbllogouttext1", this._player.ci) + Convert.ToString(registryKey.GetValue("username")) + this._player.rm.GetString("logout_lbllogouttext2", this._player.ci);
			}
			else
			{
				base.Close();
			}
		}

		// Token: 0x04000017 RID: 23
		private player _player;
	}
}
