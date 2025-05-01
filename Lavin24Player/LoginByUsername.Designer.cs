namespace player
{
	// Token: 0x0200000E RID: 14
	public partial class LoginByUsername : global::System.Windows.Forms.Form
	{
		// Token: 0x0600006D RID: 109 RVA: 0x000082F0 File Offset: 0x000064F0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00008328 File Offset: 0x00006528
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::player.LoginByUsername));
			this.panelBack = new global::System.Windows.Forms.Panel();
			this.picLoader = new global::System.Windows.Forms.PictureBox();
			this.pictureBoxForgetPass = new global::System.Windows.Forms.PictureBox();
			this.buttonActive = new global::DevComponents.DotNetBar.ButtonX();
			this.textBoxPassword = new global::System.Windows.Forms.TextBox();
			this.textBoxUserName = new global::System.Windows.Forms.TextBox();
			this.pictureBox_pass = new global::System.Windows.Forms.PictureBox();
			this.pictureBox_username = new global::System.Windows.Forms.PictureBox();
			this.buttonClosethisForm2 = new global::DevComponents.DotNetBar.ButtonX();
			this.panelBack.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.picLoader).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxForgetPass).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox_pass).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox_username).BeginInit();
			base.SuspendLayout();
			this.panelBack.BackColor = global::System.Drawing.Color.Transparent;
			this.panelBack.BackgroundImage = global::player.Properties.Resources.login_by_username_back_fa;
			this.panelBack.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.panelBack.Controls.Add(this.picLoader);
			this.panelBack.Controls.Add(this.pictureBoxForgetPass);
			this.panelBack.Controls.Add(this.buttonActive);
			this.panelBack.Controls.Add(this.textBoxPassword);
			this.panelBack.Controls.Add(this.textBoxUserName);
			this.panelBack.Controls.Add(this.pictureBox_pass);
			this.panelBack.Controls.Add(this.pictureBox_username);
			this.panelBack.Controls.Add(this.buttonClosethisForm2);
			this.panelBack.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panelBack.Location = new global::System.Drawing.Point(0, 0);
			this.panelBack.Name = "panelBack";
			this.panelBack.Size = new global::System.Drawing.Size(500, 298);
			this.panelBack.TabIndex = 0;
			this.panelBack.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panelBack_MouseDown);
			this.panelBack.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panelBack_MouseMove);
			this.picLoader.BackColor = global::System.Drawing.Color.Transparent;
			this.picLoader.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("picLoader.Image");
			this.picLoader.Location = new global::System.Drawing.Point(149, 53);
			this.picLoader.Name = "picLoader";
			this.picLoader.Size = new global::System.Drawing.Size(203, 193);
			this.picLoader.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picLoader.TabIndex = 26;
			this.picLoader.TabStop = false;
			this.picLoader.Visible = false;
			this.pictureBoxForgetPass.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBoxForgetPass.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureBoxForgetPass.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBoxForgetPass.Image");
			this.pictureBoxForgetPass.Location = new global::System.Drawing.Point(79, 248);
			this.pictureBoxForgetPass.Name = "pictureBoxForgetPass";
			this.pictureBoxForgetPass.Size = new global::System.Drawing.Size(166, 17);
			this.pictureBoxForgetPass.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxForgetPass.TabIndex = 20;
			this.pictureBoxForgetPass.TabStop = false;
			this.pictureBoxForgetPass.Click += new global::System.EventHandler(this.pictureBoxForgetPass_Click);
			this.buttonActive.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonActive.BackColor = global::System.Drawing.Color.Transparent;
			this.buttonActive.ColorTable = global::DevComponents.DotNetBar.eButtonColor.Flat;
			this.buttonActive.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.buttonActive.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonActive.Image");
			this.buttonActive.ImagePosition = global::DevComponents.DotNetBar.eImagePosition.Right;
			this.buttonActive.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.buttonActive.Location = new global::System.Drawing.Point(323, 238);
			this.buttonActive.Name = "buttonActive";
			this.buttonActive.Shape = new global::DevComponents.DotNetBar.RoundRectangleShapeDescriptor(3);
			this.buttonActive.Size = new global::System.Drawing.Size(103, 38);
			this.buttonActive.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.buttonActive.TabIndex = 18;
			this.buttonActive.Click += new global::System.EventHandler(this.buttonActive_Click);
			this.textBoxPassword.BackColor = global::System.Drawing.Color.FromArgb(73, 73, 73);
			this.textBoxPassword.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.textBoxPassword.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.textBoxPassword.ForeColor = global::System.Drawing.SystemColors.Window;
			this.textBoxPassword.Location = new global::System.Drawing.Point(183, 200);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new global::System.Drawing.Size(240, 19);
			this.textBoxPassword.TabIndex = 17;
			this.textBoxUserName.BackColor = global::System.Drawing.Color.FromArgb(73, 73, 73);
			this.textBoxUserName.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.textBoxUserName.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.textBoxUserName.ForeColor = global::System.Drawing.SystemColors.Window;
			this.textBoxUserName.ImeMode = global::System.Windows.Forms.ImeMode.Disable;
			this.textBoxUserName.Location = new global::System.Drawing.Point(183, 149);
			this.textBoxUserName.Name = "textBoxUserName";
			this.textBoxUserName.Size = new global::System.Drawing.Size(240, 19);
			this.textBoxUserName.TabIndex = 14;
			this.pictureBox_pass.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBox_pass.Image = global::player.Properties.Resources.login_by_username_p_PicBox_fa;
			this.pictureBox_pass.Location = new global::System.Drawing.Point(74, 188);
			this.pictureBox_pass.Name = "pictureBox_pass";
			this.pictureBox_pass.Size = new global::System.Drawing.Size(356, 44);
			this.pictureBox_pass.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox_pass.TabIndex = 1;
			this.pictureBox_pass.TabStop = false;
			this.pictureBox_username.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBox_username.Image = global::player.Properties.Resources.login_by_username_u_PicBox_fa;
			this.pictureBox_username.Location = new global::System.Drawing.Point(74, 137);
			this.pictureBox_username.Name = "pictureBox_username";
			this.pictureBox_username.Size = new global::System.Drawing.Size(357, 45);
			this.pictureBox_username.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox_username.TabIndex = 0;
			this.pictureBox_username.TabStop = false;
			this.buttonClosethisForm2.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonClosethisForm2.BackColor = global::System.Drawing.Color.Transparent;
			this.buttonClosethisForm2.ColorTable = global::DevComponents.DotNetBar.eButtonColor.Flat;
			this.buttonClosethisForm2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.buttonClosethisForm2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonClosethisForm2.Location = new global::System.Drawing.Point(478, 0);
			this.buttonClosethisForm2.Name = "buttonClosethisForm2";
			this.buttonClosethisForm2.Size = new global::System.Drawing.Size(22, 24);
			this.buttonClosethisForm2.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.buttonClosethisForm2.TabIndex = 25;
			this.buttonClosethisForm2.Text = "x";
			this.buttonClosethisForm2.TextColor = global::System.Drawing.Color.White;
			this.buttonClosethisForm2.Click += new global::System.EventHandler(this.buttonClosethisForm2_Click);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(500, 298);
			base.Controls.Add(this.panelBack);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "LoginByUsername";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			base.TransparencyKey = global::System.Drawing.Color.LimeGreen;
			base.Load += new global::System.EventHandler(this.LoginByUsername_Load);
			this.panelBack.ResumeLayout(false);
			this.panelBack.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.picLoader).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxForgetPass).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox_pass).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox_username).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000059 RID: 89
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400005A RID: 90
		private global::System.Windows.Forms.Panel panelBack;

		// Token: 0x0400005B RID: 91
		private global::System.Windows.Forms.PictureBox pictureBox_username;

		// Token: 0x0400005C RID: 92
		private global::System.Windows.Forms.PictureBox pictureBox_pass;

		// Token: 0x0400005D RID: 93
		private global::System.Windows.Forms.TextBox textBoxUserName;

		// Token: 0x0400005E RID: 94
		private global::System.Windows.Forms.TextBox textBoxPassword;

		// Token: 0x0400005F RID: 95
		private global::DevComponents.DotNetBar.ButtonX buttonActive;

		// Token: 0x04000060 RID: 96
		private global::System.Windows.Forms.PictureBox pictureBoxForgetPass;

		// Token: 0x04000061 RID: 97
		private global::DevComponents.DotNetBar.ButtonX buttonClosethisForm2;

		// Token: 0x04000062 RID: 98
		private global::System.Windows.Forms.PictureBox picLoader;
	}
}
