namespace player
{
	// Token: 0x0200000B RID: 11
	public partial class login : global::System.Windows.Forms.Form
	{
		// Token: 0x06000041 RID: 65 RVA: 0x00004838 File Offset: 0x00002A38
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00004870 File Offset: 0x00002A70
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::player.login));
			this.picLoader = new global::System.Windows.Forms.PictureBox();
			this.pictureBoxUsername = new global::System.Windows.Forms.PictureBox();
			this.pictureBoxPassword = new global::System.Windows.Forms.PictureBox();
			this.buttonActive = new global::DevComponents.DotNetBar.ButtonX();
			this.textBoxXpassword = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.textBoxXuserName = new global::DevComponents.DotNetBar.Controls.TextBoxX();
			this.buttonXForget = new global::DevComponents.DotNetBar.ButtonX();
			this.buttonClosethisForm = new global::DevComponents.DotNetBar.ButtonX();
			this.styleManager1 = new global::DevComponents.DotNetBar.StyleManager(this.components);
			this.panelBack = new global::System.Windows.Forms.Panel();
			((global::System.ComponentModel.ISupportInitialize)this.picLoader).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxUsername).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxPassword).BeginInit();
			this.panelBack.SuspendLayout();
			base.SuspendLayout();
			this.picLoader.BackColor = global::System.Drawing.Color.Transparent;
			this.picLoader.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("picLoader.Image");
			this.picLoader.Location = new global::System.Drawing.Point(224, 135);
			this.picLoader.Name = "picLoader";
			this.picLoader.Size = new global::System.Drawing.Size(203, 193);
			this.picLoader.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picLoader.TabIndex = 6;
			this.picLoader.TabStop = false;
			this.picLoader.Visible = false;
			this.pictureBoxUsername.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBoxUsername.Image");
			this.pictureBoxUsername.ImageLocation = "";
			this.pictureBoxUsername.Location = new global::System.Drawing.Point(433, 294);
			this.pictureBoxUsername.Name = "pictureBoxUsername";
			this.pictureBoxUsername.Size = new global::System.Drawing.Size(102, 34);
			this.pictureBoxUsername.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBoxUsername.TabIndex = 4;
			this.pictureBoxUsername.TabStop = false;
			this.pictureBoxPassword.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBoxPassword.Image");
			this.pictureBoxPassword.Location = new global::System.Drawing.Point(432, 338);
			this.pictureBoxPassword.Name = "pictureBoxPassword";
			this.pictureBoxPassword.Size = new global::System.Drawing.Size(102, 34);
			this.pictureBoxPassword.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBoxPassword.TabIndex = 5;
			this.pictureBoxPassword.TabStop = false;
			this.buttonActive.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonActive.ColorTable = global::DevComponents.DotNetBar.eButtonColor.Flat;
			this.buttonActive.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonActive.Image");
			this.buttonActive.ImagePosition = global::DevComponents.DotNetBar.eImagePosition.Right;
			this.buttonActive.Location = new global::System.Drawing.Point(321, 383);
			this.buttonActive.Name = "buttonActive";
			this.buttonActive.Shape = new global::DevComponents.DotNetBar.RoundRectangleShapeDescriptor(9);
			this.buttonActive.Size = new global::System.Drawing.Size(215, 36);
			this.buttonActive.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.buttonActive.TabIndex = 2;
			this.buttonActive.Click += new global::System.EventHandler(this.buttonActive_Click);
			this.textBoxXpassword.BackColor = global::System.Drawing.Color.White;
			this.textBoxXpassword.Border.BorderBottomColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarCaptionText;
			this.textBoxXpassword.Border.Class = "TextBoxBorder";
			this.textBoxXpassword.Border.CornerDiameter = 11;
			this.textBoxXpassword.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Rounded;
			this.textBoxXpassword.DisabledBackColor = global::System.Drawing.Color.White;
			this.textBoxXpassword.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.textBoxXpassword.ForeColor = global::System.Drawing.Color.Black;
			this.textBoxXpassword.Location = new global::System.Drawing.Point(109, 338);
			this.textBoxXpassword.Margin = new global::System.Windows.Forms.Padding(30, 3, 3, 3);
			this.textBoxXpassword.Name = "textBoxXpassword";
			this.textBoxXpassword.PasswordChar = '*';
			this.textBoxXpassword.PreventEnterBeep = true;
			this.textBoxXpassword.Size = new global::System.Drawing.Size(333, 34);
			this.textBoxXpassword.TabIndex = 1;
			this.textBoxXuserName.BackColor = global::System.Drawing.Color.White;
			this.textBoxXuserName.Border.BorderBottomColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.BarCaptionText;
			this.textBoxXuserName.Border.Class = "TextBoxBorder";
			this.textBoxXuserName.Border.CornerDiameter = 11;
			this.textBoxXuserName.Border.CornerType = global::DevComponents.DotNetBar.eCornerType.Rounded;
			this.textBoxXuserName.DisabledBackColor = global::System.Drawing.Color.White;
			this.textBoxXuserName.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.textBoxXuserName.ForeColor = global::System.Drawing.Color.Black;
			this.textBoxXuserName.Location = new global::System.Drawing.Point(109, 294);
			this.textBoxXuserName.Margin = new global::System.Windows.Forms.Padding(30, 3, 3, 3);
			this.textBoxXuserName.Name = "textBoxXuserName";
			this.textBoxXuserName.PreventEnterBeep = true;
			this.textBoxXuserName.Size = new global::System.Drawing.Size(333, 34);
			this.textBoxXuserName.TabIndex = 0;
			this.buttonXForget.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonXForget.ColorTable = global::DevComponents.DotNetBar.eButtonColor.Flat;
			this.buttonXForget.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonXForget.Image");
			this.buttonXForget.ImagePosition = global::DevComponents.DotNetBar.eImagePosition.Right;
			this.buttonXForget.Location = new global::System.Drawing.Point(107, 382);
			this.buttonXForget.Name = "buttonXForget";
			this.buttonXForget.Shape = new global::DevComponents.DotNetBar.RoundRectangleShapeDescriptor(9);
			this.buttonXForget.Size = new global::System.Drawing.Size(213, 36);
			this.buttonXForget.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.buttonXForget.TabIndex = 3;
			this.buttonXForget.Click += new global::System.EventHandler(this.buttonXForget_Click);
			this.buttonClosethisForm.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonClosethisForm.BackColor = global::System.Drawing.Color.Transparent;
			this.buttonClosethisForm.ColorTable = global::DevComponents.DotNetBar.eButtonColor.Flat;
			this.buttonClosethisForm.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.buttonClosethisForm.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonClosethisForm.Location = new global::System.Drawing.Point(629, -2);
			this.buttonClosethisForm.Name = "buttonClosethisForm";
			this.buttonClosethisForm.Size = new global::System.Drawing.Size(22, 24);
			this.buttonClosethisForm.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.buttonClosethisForm.TabIndex = 4;
			this.buttonClosethisForm.Text = "x";
			this.buttonClosethisForm.TextColor = global::System.Drawing.Color.White;
			this.buttonClosethisForm.Click += new global::System.EventHandler(this.buttonClosethisForm_Click);
			this.styleManager1.ManagerColorTint = global::System.Drawing.Color.Transparent;
			this.styleManager1.ManagerStyle = global::DevComponents.DotNetBar.eStyle.Metro;
			this.styleManager1.MetroColorParameters = new global::DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(global::System.Drawing.Color.WhiteSmoke, global::System.Drawing.Color.FromArgb(43, 87, 154));
			this.panelBack.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("panelBack.BackgroundImage");
			this.panelBack.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.panelBack.Controls.Add(this.buttonClosethisForm);
			this.panelBack.Controls.Add(this.pictureBoxUsername);
			this.panelBack.Controls.Add(this.picLoader);
			this.panelBack.Controls.Add(this.textBoxXuserName);
			this.panelBack.Controls.Add(this.buttonXForget);
			this.panelBack.Controls.Add(this.pictureBoxPassword);
			this.panelBack.Controls.Add(this.textBoxXpassword);
			this.panelBack.Controls.Add(this.buttonActive);
			this.panelBack.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panelBack.Location = new global::System.Drawing.Point(0, 0);
			this.panelBack.Name = "panelBack";
			this.panelBack.Size = new global::System.Drawing.Size(650, 485);
			this.panelBack.TabIndex = 7;
			this.panelBack.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panelBack_Paint);
			this.panelBack.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panelBack_MouseDown);
			this.panelBack.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panelBack_MouseMove);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.ControlLight;
			base.ClientSize = new global::System.Drawing.Size(650, 485);
			base.ControlBox = false;
			base.Controls.Add(this.panelBack);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "login";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			base.Load += new global::System.EventHandler(this.login_Load);
			base.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panelBack_MouseDown);
			base.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panelBack_MouseMove);
			((global::System.ComponentModel.ISupportInitialize)this.picLoader).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxUsername).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxPassword).EndInit();
			this.panelBack.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000022 RID: 34
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000023 RID: 35
		private global::DevComponents.DotNetBar.ButtonX buttonClosethisForm;

		// Token: 0x04000024 RID: 36
		private global::DevComponents.DotNetBar.ButtonX buttonXForget;

		// Token: 0x04000025 RID: 37
		private global::DevComponents.DotNetBar.ButtonX buttonActive;

		// Token: 0x04000026 RID: 38
		private global::DevComponents.DotNetBar.Controls.TextBoxX textBoxXuserName;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.PictureBox pictureBoxPassword;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.PictureBox pictureBoxUsername;

		// Token: 0x04000029 RID: 41
		private global::DevComponents.DotNetBar.StyleManager styleManager1;

		// Token: 0x0400002A RID: 42
		private global::DevComponents.DotNetBar.Controls.TextBoxX textBoxXpassword;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.PictureBox picLoader;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.Panel panelBack;
	}
}
