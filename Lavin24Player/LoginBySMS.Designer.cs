namespace player
{
	// Token: 0x0200000D RID: 13
	public partial class LoginBySMS : global::System.Windows.Forms.Form
	{
		// Token: 0x06000062 RID: 98 RVA: 0x00007018 File Offset: 0x00005218
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00007050 File Offset: 0x00005250
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::player.LoginBySMS));
			this.panelBack = new global::System.Windows.Forms.Panel();
			this.labelCodetxt = new global::System.Windows.Forms.Label();
			this.pictureBoxResendCode = new global::System.Windows.Forms.PictureBox();
			this.buttonActive = new global::DevComponents.DotNetBar.ButtonX();
			this.labelTimer = new global::System.Windows.Forms.Label();
			this.buttonGetCode = new global::DevComponents.DotNetBar.ButtonX();
			this.textBoxPhoneNumber = new global::System.Windows.Forms.TextBox();
			this.pictureBoxBackNO = new global::System.Windows.Forms.PictureBox();
			this.pictureBoxLoginByUsername = new global::System.Windows.Forms.PictureBox();
			this.buttonClosethisForm2 = new global::DevComponents.DotNetBar.ButtonX();
			this.timer_sms = new global::System.Windows.Forms.Timer(this.components);
			this.panelBack.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxResendCode).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxBackNO).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxLoginByUsername).BeginInit();
			base.SuspendLayout();
			this.panelBack.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("panelBack.BackgroundImage");
			this.panelBack.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.panelBack.Controls.Add(this.labelCodetxt);
			this.panelBack.Controls.Add(this.pictureBoxResendCode);
			this.panelBack.Controls.Add(this.buttonActive);
			this.panelBack.Controls.Add(this.labelTimer);
			this.panelBack.Controls.Add(this.buttonGetCode);
			this.panelBack.Controls.Add(this.textBoxPhoneNumber);
			this.panelBack.Controls.Add(this.pictureBoxBackNO);
			this.panelBack.Controls.Add(this.pictureBoxLoginByUsername);
			this.panelBack.Controls.Add(this.buttonClosethisForm2);
			this.panelBack.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panelBack.Location = new global::System.Drawing.Point(0, 0);
			this.panelBack.Name = "panelBack";
			this.panelBack.Size = new global::System.Drawing.Size(500, 276);
			this.panelBack.TabIndex = 0;
			this.panelBack.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panelBack_MouseDown);
			this.panelBack.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panelBack_MouseMove);
			this.labelCodetxt.AutoSize = true;
			this.labelCodetxt.BackColor = global::System.Drawing.Color.FromArgb(73, 73, 73);
			this.labelCodetxt.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelCodetxt.ForeColor = global::System.Drawing.Color.White;
			this.labelCodetxt.Location = new global::System.Drawing.Point(127, 160);
			this.labelCodetxt.Name = "labelCodetxt";
			this.labelCodetxt.Size = new global::System.Drawing.Size(55, 17);
			this.labelCodetxt.TabIndex = 25;
			this.labelCodetxt.Text = "Code :";
			this.labelCodetxt.Visible = false;
			this.pictureBoxResendCode.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBoxResendCode.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureBoxResendCode.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBoxResendCode.Image");
			this.pictureBoxResendCode.Location = new global::System.Drawing.Point(79, 213);
			this.pictureBoxResendCode.Name = "pictureBoxResendCode";
			this.pictureBoxResendCode.Size = new global::System.Drawing.Size(89, 16);
			this.pictureBoxResendCode.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxResendCode.TabIndex = 23;
			this.pictureBoxResendCode.TabStop = false;
			this.pictureBoxResendCode.Visible = false;
			this.pictureBoxResendCode.Click += new global::System.EventHandler(this.pictureBoxResendCode_Click);
			this.buttonActive.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonActive.BackColor = global::System.Drawing.Color.Transparent;
			this.buttonActive.ColorTable = global::DevComponents.DotNetBar.eButtonColor.Flat;
			this.buttonActive.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.buttonActive.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonActive.Image");
			this.buttonActive.ImagePosition = global::DevComponents.DotNetBar.eImagePosition.Right;
			this.buttonActive.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.buttonActive.Location = new global::System.Drawing.Point(324, 222);
			this.buttonActive.Name = "buttonActive";
			this.buttonActive.Shape = new global::DevComponents.DotNetBar.RoundRectangleShapeDescriptor(3);
			this.buttonActive.Size = new global::System.Drawing.Size(103, 38);
			this.buttonActive.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.buttonActive.TabIndex = 22;
			this.buttonActive.Visible = false;
			this.buttonActive.Click += new global::System.EventHandler(this.buttonActive_Click);
			this.labelTimer.AutoSize = true;
			this.labelTimer.BackColor = global::System.Drawing.Color.FromArgb(73, 73, 73);
			this.labelTimer.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelTimer.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.labelTimer.Location = new global::System.Drawing.Point(385, 162);
			this.labelTimer.Name = "labelTimer";
			this.labelTimer.Size = new global::System.Drawing.Size(34, 15);
			this.labelTimer.TabIndex = 21;
			this.labelTimer.Text = "120''";
			this.labelTimer.Visible = false;
			this.buttonGetCode.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonGetCode.BackColor = global::System.Drawing.Color.Transparent;
			this.buttonGetCode.ColorTable = global::DevComponents.DotNetBar.eButtonColor.Flat;
			this.buttonGetCode.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.buttonGetCode.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonGetCode.Image");
			this.buttonGetCode.ImagePosition = global::DevComponents.DotNetBar.eImagePosition.Right;
			this.buttonGetCode.Location = new global::System.Drawing.Point(324, 205);
			this.buttonGetCode.Name = "buttonGetCode";
			this.buttonGetCode.Shape = new global::DevComponents.DotNetBar.RoundRectangleShapeDescriptor(3);
			this.buttonGetCode.Size = new global::System.Drawing.Size(103, 38);
			this.buttonGetCode.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.buttonGetCode.TabIndex = 19;
			this.buttonGetCode.Click += new global::System.EventHandler(this.buttonGetCode_Click);
			this.textBoxPhoneNumber.BackColor = global::System.Drawing.Color.FromArgb(73, 73, 73);
			this.textBoxPhoneNumber.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.textBoxPhoneNumber.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f);
			this.textBoxPhoneNumber.ForeColor = global::System.Drawing.SystemColors.Window;
			this.textBoxPhoneNumber.ImeMode = global::System.Windows.Forms.ImeMode.Disable;
			this.textBoxPhoneNumber.Location = new global::System.Drawing.Point(215, 158);
			this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
			this.textBoxPhoneNumber.Size = new global::System.Drawing.Size(134, 22);
			this.textBoxPhoneNumber.TabIndex = 14;
			this.pictureBoxBackNO.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBoxBackNO.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.pictureBoxBackNO.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBoxBackNO.Image");
			this.pictureBoxBackNO.Location = new global::System.Drawing.Point(72, 148);
			this.pictureBoxBackNO.Name = "pictureBoxBackNO";
			this.pictureBoxBackNO.Size = new global::System.Drawing.Size(355, 46);
			this.pictureBoxBackNO.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxBackNO.TabIndex = 0;
			this.pictureBoxBackNO.TabStop = false;
			this.pictureBoxBackNO.Click += new global::System.EventHandler(this.pictureBoxBackNO_Click);
			this.pictureBoxLoginByUsername.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBoxLoginByUsername.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureBoxLoginByUsername.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBoxLoginByUsername.Image");
			this.pictureBoxLoginByUsername.Location = new global::System.Drawing.Point(79, 213);
			this.pictureBoxLoginByUsername.Name = "pictureBoxLoginByUsername";
			this.pictureBoxLoginByUsername.Size = new global::System.Drawing.Size(229, 17);
			this.pictureBoxLoginByUsername.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxLoginByUsername.TabIndex = 20;
			this.pictureBoxLoginByUsername.TabStop = false;
			this.pictureBoxLoginByUsername.Click += new global::System.EventHandler(this.pictureBoxLoginByUsername_Click);
			this.buttonClosethisForm2.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonClosethisForm2.BackColor = global::System.Drawing.Color.Transparent;
			this.buttonClosethisForm2.ColorTable = global::DevComponents.DotNetBar.eButtonColor.Flat;
			this.buttonClosethisForm2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.buttonClosethisForm2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonClosethisForm2.Location = new global::System.Drawing.Point(478, 0);
			this.buttonClosethisForm2.Name = "buttonClosethisForm2";
			this.buttonClosethisForm2.Size = new global::System.Drawing.Size(22, 24);
			this.buttonClosethisForm2.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.buttonClosethisForm2.TabIndex = 24;
			this.buttonClosethisForm2.Text = "x";
			this.buttonClosethisForm2.TextColor = global::System.Drawing.Color.White;
			this.buttonClosethisForm2.Click += new global::System.EventHandler(this.buttonClosethisForm2_Click);
			this.timer_sms.Interval = 1000;
			this.timer_sms.Tick += new global::System.EventHandler(this.timer_sms_Tick);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(500, 276);
			base.Controls.Add(this.panelBack);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "LoginBySMS";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			base.TransparencyKey = global::System.Drawing.Color.LimeGreen;
			base.Load += new global::System.EventHandler(this.LoginBySMS_Load);
			this.panelBack.ResumeLayout(false);
			this.panelBack.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxResendCode).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxBackNO).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxLoginByUsername).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000049 RID: 73
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.Panel panelBack;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.PictureBox pictureBoxBackNO;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.TextBox textBoxPhoneNumber;

		// Token: 0x0400004D RID: 77
		private global::DevComponents.DotNetBar.ButtonX buttonGetCode;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.PictureBox pictureBoxLoginByUsername;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Forms.Label labelTimer;

		// Token: 0x04000050 RID: 80
		private global::System.Windows.Forms.PictureBox pictureBoxResendCode;

		// Token: 0x04000051 RID: 81
		private global::DevComponents.DotNetBar.ButtonX buttonActive;

		// Token: 0x04000052 RID: 82
		private global::DevComponents.DotNetBar.ButtonX buttonClosethisForm2;

		// Token: 0x04000053 RID: 83
		private global::System.Windows.Forms.Timer timer_sms;

		// Token: 0x04000054 RID: 84
		private global::System.Windows.Forms.Label labelCodetxt;
	}
}
