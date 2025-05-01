namespace player
{
	// Token: 0x02000010 RID: 16
	public partial class PlaylistForm : global::System.Windows.Forms.Form
	{
		// Token: 0x060000D2 RID: 210 RVA: 0x0000F8DC File Offset: 0x0000DADC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000F914 File Offset: 0x0000DB14
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::player.PlaylistForm));
			this.pictureBoxClear = new global::System.Windows.Forms.PictureBox();
			this.comboBox_playlistName = new global::System.Windows.Forms.ComboBox();
			this.listBoxPlaylist = new global::System.Windows.Forms.ListBox();
			this.pictureBoxAdd = new global::System.Windows.Forms.PictureBox();
			this.pictureBoxUP = new global::System.Windows.Forms.PictureBox();
			this.pictureBoxDW = new global::System.Windows.Forms.PictureBox();
			this.pictureBoxSave = new global::System.Windows.Forms.PictureBox();
			this.panelTop = new global::System.Windows.Forms.Panel();
			this.labelName = new global::DevComponents.DotNetBar.LabelX();
			this.buttonClose = new global::DevComponents.DotNetBar.ButtonX();
			this.ofd = new global::System.Windows.Forms.OpenFileDialog();
			this.toolTip1 = new global::System.Windows.Forms.ToolTip(this.components);
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.timer2 = new global::System.Windows.Forms.Timer(this.components);
			this.panelBack = new global::System.Windows.Forms.Panel();
			this.pictureBoxDel = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxClear).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxAdd).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxUP).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxDW).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxSave).BeginInit();
			this.panelTop.SuspendLayout();
			this.panelBack.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxDel).BeginInit();
			base.SuspendLayout();
			this.pictureBoxClear.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBoxClear.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureBoxClear.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBoxClear.Image");
			this.pictureBoxClear.Location = new global::System.Drawing.Point(197, 542);
			this.pictureBoxClear.Name = "pictureBoxClear";
			this.pictureBoxClear.Size = new global::System.Drawing.Size(15, 15);
			this.pictureBoxClear.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBoxClear.TabIndex = 46;
			this.pictureBoxClear.TabStop = false;
			this.pictureBoxClear.Click += new global::System.EventHandler(this.pictureBoxClear_Click);
			this.comboBox_playlistName.BackColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.comboBox_playlistName.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.comboBox_playlistName.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f);
			this.comboBox_playlistName.ForeColor = global::System.Drawing.SystemColors.MenuText;
			this.comboBox_playlistName.FormattingEnabled = true;
			this.comboBox_playlistName.Location = new global::System.Drawing.Point(11, 37);
			this.comboBox_playlistName.MaxDropDownItems = 100;
			this.comboBox_playlistName.Name = "comboBox_playlistName";
			this.comboBox_playlistName.Size = new global::System.Drawing.Size(149, 23);
			this.comboBox_playlistName.TabIndex = 0;
			this.comboBox_playlistName.DropDown += new global::System.EventHandler(this.comboBox_playlistName_DropDown);
			this.comboBox_playlistName.SelectionChangeCommitted += new global::System.EventHandler(this.comboBox_playlistName_SelectionChangeCommitted);
			this.listBoxPlaylist.BackColor = global::System.Drawing.Color.FromArgb(107, 107, 107);
			this.listBoxPlaylist.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.listBoxPlaylist.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f);
			this.listBoxPlaylist.ForeColor = global::System.Drawing.Color.FromArgb(253, 190, 13);
			this.listBoxPlaylist.FormattingEnabled = true;
			this.listBoxPlaylist.ItemHeight = 15;
			this.listBoxPlaylist.Location = new global::System.Drawing.Point(3, 71);
			this.listBoxPlaylist.Name = "listBoxPlaylist";
			this.listBoxPlaylist.Size = new global::System.Drawing.Size(242, 450);
			this.listBoxPlaylist.TabIndex = 1;
			this.listBoxPlaylist.MouseDoubleClick += new global::System.Windows.Forms.MouseEventHandler(this.listBoxPlaylist_MouseDoubleClick);
			this.pictureBoxAdd.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBoxAdd.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureBoxAdd.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBoxAdd.Image");
			this.pictureBoxAdd.Location = new global::System.Drawing.Point(10, 541);
			this.pictureBoxAdd.Name = "pictureBoxAdd";
			this.pictureBoxAdd.Size = new global::System.Drawing.Size(15, 15);
			this.pictureBoxAdd.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBoxAdd.TabIndex = 43;
			this.pictureBoxAdd.TabStop = false;
			this.toolTip1.SetToolTip(this.pictureBoxAdd, "اضافه کردن فایل");
			this.pictureBoxAdd.Click += new global::System.EventHandler(this.pictureBoxAdd_Click);
			this.pictureBoxUP.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBoxUP.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureBoxUP.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBoxUP.Image");
			this.pictureBoxUP.Location = new global::System.Drawing.Point(32, 541);
			this.pictureBoxUP.Name = "pictureBoxUP";
			this.pictureBoxUP.Size = new global::System.Drawing.Size(15, 15);
			this.pictureBoxUP.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBoxUP.TabIndex = 42;
			this.pictureBoxUP.TabStop = false;
			this.pictureBoxUP.Click += new global::System.EventHandler(this.pictureBoxUP_Click);
			this.pictureBoxDW.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBoxDW.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureBoxDW.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBoxDW.Image");
			this.pictureBoxDW.Location = new global::System.Drawing.Point(54, 541);
			this.pictureBoxDW.Name = "pictureBoxDW";
			this.pictureBoxDW.Size = new global::System.Drawing.Size(15, 15);
			this.pictureBoxDW.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBoxDW.TabIndex = 41;
			this.pictureBoxDW.TabStop = false;
			this.pictureBoxDW.Click += new global::System.EventHandler(this.pictureBoxDW_Click);
			this.pictureBoxSave.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBoxSave.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureBoxSave.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBoxSave.Image");
			this.pictureBoxSave.Location = new global::System.Drawing.Point(221, 541);
			this.pictureBoxSave.Name = "pictureBoxSave";
			this.pictureBoxSave.Size = new global::System.Drawing.Size(15, 15);
			this.pictureBoxSave.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBoxSave.TabIndex = 40;
			this.pictureBoxSave.TabStop = false;
			this.pictureBoxSave.Click += new global::System.EventHandler(this.pictureBoxSave_Click);
			this.panelTop.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTop.Controls.Add(this.labelName);
			this.panelTop.Controls.Add(this.buttonClose);
			this.panelTop.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panelTop.Location = new global::System.Drawing.Point(0, 0);
			this.panelTop.Name = "panelTop";
			this.panelTop.Size = new global::System.Drawing.Size(250, 31);
			this.panelTop.TabIndex = 39;
			this.panelTop.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
			this.panelTop.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
			this.labelName.BackColor = global::System.Drawing.Color.Transparent;
			this.labelName.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.labelName.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.labelName.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("labelName.Image");
			this.labelName.Location = new global::System.Drawing.Point(0, 0);
			this.labelName.Name = "labelName";
			this.labelName.PaddingLeft = 5;
			this.labelName.Size = new global::System.Drawing.Size(89, 31);
			this.labelName.TabIndex = 47;
			this.buttonClose.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonClose.BackColor = global::System.Drawing.Color.Transparent;
			this.buttonClose.ColorTable = global::DevComponents.DotNetBar.eButtonColor.Flat;
			this.buttonClose.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.buttonClose.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.buttonClose.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonClose.Image");
			this.buttonClose.Location = new global::System.Drawing.Point(222, 0);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new global::System.Drawing.Size(28, 31);
			this.buttonClose.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.buttonClose.TabIndex = 0;
			this.buttonClose.TextColor = global::System.Drawing.Color.Black;
			this.buttonClose.Click += new global::System.EventHandler(this.buttonClose_Click);
			this.ofd.Multiselect = true;
			this.toolTip1.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.toolTip1.IsBalloon = true;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			this.timer2.Interval = 2500;
			this.timer2.Tick += new global::System.EventHandler(this.timer2_Tick);
			this.panelBack.BackgroundImage = global::player.Properties.Resources.playlist_back_brown;
			this.panelBack.Controls.Add(this.pictureBoxDel);
			this.panelBack.Controls.Add(this.pictureBoxClear);
			this.panelBack.Controls.Add(this.panelTop);
			this.panelBack.Controls.Add(this.pictureBoxAdd);
			this.panelBack.Controls.Add(this.listBoxPlaylist);
			this.panelBack.Controls.Add(this.pictureBoxUP);
			this.panelBack.Controls.Add(this.pictureBoxDW);
			this.panelBack.Controls.Add(this.comboBox_playlistName);
			this.panelBack.Controls.Add(this.pictureBoxSave);
			this.panelBack.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panelBack.Location = new global::System.Drawing.Point(0, 0);
			this.panelBack.Name = "panelBack";
			this.panelBack.Size = new global::System.Drawing.Size(250, 566);
			this.panelBack.TabIndex = 0;
			this.pictureBoxDel.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBoxDel.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureBoxDel.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBoxDel.Image");
			this.pictureBoxDel.Location = new global::System.Drawing.Point(76, 541);
			this.pictureBoxDel.Name = "pictureBoxDel";
			this.pictureBoxDel.Size = new global::System.Drawing.Size(15, 15);
			this.pictureBoxDel.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxDel.TabIndex = 47;
			this.pictureBoxDel.TabStop = false;
			this.pictureBoxDel.Click += new global::System.EventHandler(this.pictureBoxDel_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(250, 566);
			base.Controls.Add(this.panelBack);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "PlaylistForm";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.Load += new global::System.EventHandler(this.PlaylistForm_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxClear).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxAdd).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxUP).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxDW).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxSave).EndInit();
			this.panelTop.ResumeLayout(false);
			this.panelBack.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxDel).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040000C9 RID: 201
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000CA RID: 202
		private global::System.Windows.Forms.Panel panelTop;

		// Token: 0x040000CB RID: 203
		private global::DevComponents.DotNetBar.ButtonX buttonClose;

		// Token: 0x040000CC RID: 204
		private global::System.Windows.Forms.PictureBox pictureBoxAdd;

		// Token: 0x040000CD RID: 205
		private global::System.Windows.Forms.PictureBox pictureBoxUP;

		// Token: 0x040000CE RID: 206
		private global::System.Windows.Forms.PictureBox pictureBoxDW;

		// Token: 0x040000CF RID: 207
		private global::System.Windows.Forms.PictureBox pictureBoxSave;

		// Token: 0x040000D0 RID: 208
		private global::System.Windows.Forms.ListBox listBoxPlaylist;

		// Token: 0x040000D1 RID: 209
		private global::System.Windows.Forms.OpenFileDialog ofd;

		// Token: 0x040000D2 RID: 210
		private global::System.Windows.Forms.ComboBox comboBox_playlistName;

		// Token: 0x040000D3 RID: 211
		private global::System.Windows.Forms.PictureBox pictureBoxClear;

		// Token: 0x040000D4 RID: 212
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x040000D5 RID: 213
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x040000D6 RID: 214
		private global::System.Windows.Forms.Timer timer2;

		// Token: 0x040000D7 RID: 215
		private global::System.Windows.Forms.Panel panelBack;

		// Token: 0x040000D8 RID: 216
		private global::DevComponents.DotNetBar.LabelX labelName;

		// Token: 0x040000D9 RID: 217
		private global::System.Windows.Forms.PictureBox pictureBoxDel;
	}
}
