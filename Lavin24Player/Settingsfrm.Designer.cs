namespace player
{
	// Token: 0x02000013 RID: 19
	public partial class Settingsfrm : global::System.Windows.Forms.Form
	{
		// Token: 0x060000F8 RID: 248 RVA: 0x000121F0 File Offset: 0x000103F0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00012228 File Offset: 0x00010428
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::player.Settingsfrm));
			this.comboBox_languages = new global::System.Windows.Forms.ComboBox();
			this.rbtnDefault = new global::System.Windows.Forms.RadioButton();
			this.rbtnBlue = new global::System.Windows.Forms.RadioButton();
			this.rbtnBrown = new global::System.Windows.Forms.RadioButton();
			this.rbtnPurple = new global::System.Windows.Forms.RadioButton();
			this.rbtnRed = new global::System.Windows.Forms.RadioButton();
			this.rbtnGreen = new global::System.Windows.Forms.RadioButton();
			this.panelBack = new global::System.Windows.Forms.Panel();
			this.buttonClosethisForm = new global::DevComponents.DotNetBar.ButtonX();
			this.btnDefault = new global::DevComponents.DotNetBar.ButtonX();
			this.btnSave = new global::DevComponents.DotNetBar.ButtonX();
			this.panelBack.SuspendLayout();
			base.SuspendLayout();
			this.comboBox_languages.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
			this.comboBox_languages.BackColor = global::System.Drawing.Color.WhiteSmoke;
			this.comboBox_languages.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f);
			this.comboBox_languages.ForeColor = global::System.Drawing.Color.Black;
			this.comboBox_languages.FormattingEnabled = true;
			this.comboBox_languages.Location = new global::System.Drawing.Point(313, 247);
			this.comboBox_languages.Name = "comboBox_languages";
			this.comboBox_languages.Size = new global::System.Drawing.Size(62, 23);
			this.comboBox_languages.TabIndex = 10;
			this.comboBox_languages.Text = "fa-IR";
			this.comboBox_languages.SelectionChangeCommitted += new global::System.EventHandler(this.comboBox_languages_SelectionChangeCommitted);
			this.rbtnDefault.AutoSize = true;
			this.rbtnDefault.BackColor = global::System.Drawing.Color.Transparent;
			this.rbtnDefault.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.rbtnDefault.ForeColor = global::System.Drawing.Color.White;
			this.rbtnDefault.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("rbtnDefault.Image");
			this.rbtnDefault.Location = new global::System.Drawing.Point(185, 68);
			this.rbtnDefault.Name = "rbtnDefault";
			this.rbtnDefault.Size = new global::System.Drawing.Size(94, 61);
			this.rbtnDefault.TabIndex = 14;
			this.rbtnDefault.TabStop = true;
			this.rbtnDefault.UseVisualStyleBackColor = false;
			this.rbtnBlue.AutoSize = true;
			this.rbtnBlue.BackColor = global::System.Drawing.Color.Transparent;
			this.rbtnBlue.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.rbtnBlue.ForeColor = global::System.Drawing.Color.White;
			this.rbtnBlue.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("rbtnBlue.Image");
			this.rbtnBlue.Location = new global::System.Drawing.Point(185, 134);
			this.rbtnBlue.Name = "rbtnBlue";
			this.rbtnBlue.Size = new global::System.Drawing.Size(96, 59);
			this.rbtnBlue.TabIndex = 15;
			this.rbtnBlue.TabStop = true;
			this.rbtnBlue.UseVisualStyleBackColor = false;
			this.rbtnBrown.AutoSize = true;
			this.rbtnBrown.BackColor = global::System.Drawing.Color.Transparent;
			this.rbtnBrown.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			this.rbtnBrown.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.rbtnBrown.ForeColor = global::System.Drawing.Color.White;
			this.rbtnBrown.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("rbtnBrown.Image");
			this.rbtnBrown.Location = new global::System.Drawing.Point(396, 135);
			this.rbtnBrown.Name = "rbtnBrown";
			this.rbtnBrown.Size = new global::System.Drawing.Size(97, 61);
			this.rbtnBrown.TabIndex = 16;
			this.rbtnBrown.TabStop = true;
			this.rbtnBrown.UseVisualStyleBackColor = false;
			this.rbtnPurple.AutoSize = true;
			this.rbtnPurple.BackColor = global::System.Drawing.Color.Transparent;
			this.rbtnPurple.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			this.rbtnPurple.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.rbtnPurple.ForeColor = global::System.Drawing.Color.White;
			this.rbtnPurple.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("rbtnPurple.Image");
			this.rbtnPurple.Location = new global::System.Drawing.Point(291, 137);
			this.rbtnPurple.Name = "rbtnPurple";
			this.rbtnPurple.Size = new global::System.Drawing.Size(93, 57);
			this.rbtnPurple.TabIndex = 19;
			this.rbtnPurple.TabStop = true;
			this.rbtnPurple.UseVisualStyleBackColor = false;
			this.rbtnRed.AutoSize = true;
			this.rbtnRed.BackColor = global::System.Drawing.Color.Transparent;
			this.rbtnRed.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			this.rbtnRed.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.rbtnRed.ForeColor = global::System.Drawing.Color.White;
			this.rbtnRed.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("rbtnRed.Image");
			this.rbtnRed.Location = new global::System.Drawing.Point(394, 68);
			this.rbtnRed.Name = "rbtnRed";
			this.rbtnRed.Size = new global::System.Drawing.Size(96, 57);
			this.rbtnRed.TabIndex = 18;
			this.rbtnRed.TabStop = true;
			this.rbtnRed.UseVisualStyleBackColor = false;
			this.rbtnGreen.AutoSize = true;
			this.rbtnGreen.BackColor = global::System.Drawing.Color.Transparent;
			this.rbtnGreen.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			this.rbtnGreen.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.rbtnGreen.ForeColor = global::System.Drawing.Color.White;
			this.rbtnGreen.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("rbtnGreen.Image");
			this.rbtnGreen.Location = new global::System.Drawing.Point(290, 69);
			this.rbtnGreen.Name = "rbtnGreen";
			this.rbtnGreen.Size = new global::System.Drawing.Size(94, 57);
			this.rbtnGreen.TabIndex = 17;
			this.rbtnGreen.TabStop = true;
			this.rbtnGreen.UseVisualStyleBackColor = false;
			this.panelBack.BackColor = global::System.Drawing.Color.Transparent;
			this.panelBack.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("panelBack.BackgroundImage");
			this.panelBack.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.panelBack.Controls.Add(this.buttonClosethisForm);
			this.panelBack.Controls.Add(this.btnDefault);
			this.panelBack.Controls.Add(this.btnSave);
			this.panelBack.Controls.Add(this.comboBox_languages);
			this.panelBack.Controls.Add(this.rbtnPurple);
			this.panelBack.Controls.Add(this.rbtnDefault);
			this.panelBack.Controls.Add(this.rbtnRed);
			this.panelBack.Controls.Add(this.rbtnBlue);
			this.panelBack.Controls.Add(this.rbtnGreen);
			this.panelBack.Controls.Add(this.rbtnBrown);
			this.panelBack.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panelBack.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.panelBack.Location = new global::System.Drawing.Point(0, 0);
			this.panelBack.Name = "panelBack";
			this.panelBack.Size = new global::System.Drawing.Size(516, 300);
			this.panelBack.TabIndex = 19;
			this.panelBack.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panelBack_Paint);
			this.panelBack.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panelBack_MouseDown);
			this.panelBack.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panelBack_MouseMove);
			this.buttonClosethisForm.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonClosethisForm.BackColor = global::System.Drawing.Color.Transparent;
			this.buttonClosethisForm.ColorTable = global::DevComponents.DotNetBar.eButtonColor.Flat;
			this.buttonClosethisForm.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.buttonClosethisForm.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonClosethisForm.Location = new global::System.Drawing.Point(495, -1);
			this.buttonClosethisForm.Name = "buttonClosethisForm";
			this.buttonClosethisForm.Size = new global::System.Drawing.Size(22, 24);
			this.buttonClosethisForm.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.buttonClosethisForm.TabIndex = 23;
			this.buttonClosethisForm.Text = "x";
			this.buttonClosethisForm.TextColor = global::System.Drawing.Color.Black;
			this.buttonClosethisForm.Click += new global::System.EventHandler(this.buttonClosethisForm_Click);
			this.btnDefault.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.btnDefault.BackColor = global::System.Drawing.Color.Transparent;
			this.btnDefault.ColorTable = global::DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnDefault.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnDefault.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.btnDefault.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("btnDefault.Image");
			this.btnDefault.ImagePosition = global::DevComponents.DotNetBar.eImagePosition.Top;
			this.btnDefault.Location = new global::System.Drawing.Point(22, 133);
			this.btnDefault.Name = "btnDefault";
			this.btnDefault.Shape = new global::DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12);
			this.btnDefault.Size = new global::System.Drawing.Size(131, 29);
			this.btnDefault.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnDefault.TabIndex = 22;
			this.btnDefault.Click += new global::System.EventHandler(this.btnDefault_Click);
			this.btnSave.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.btnSave.BackColor = global::System.Drawing.Color.Transparent;
			this.btnSave.ColorTable = global::DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnSave.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnSave.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.btnSave.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("btnSave.Image");
			this.btnSave.ImagePosition = global::DevComponents.DotNetBar.eImagePosition.Top;
			this.btnSave.Location = new global::System.Drawing.Point(22, 76);
			this.btnSave.Name = "btnSave";
			this.btnSave.Shape = new global::DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12);
			this.btnSave.Size = new global::System.Drawing.Size(131, 30);
			this.btnSave.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnSave.TabIndex = 20;
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(516, 300);
			base.Controls.Add(this.panelBack);
			this.ForeColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Settingsfrm";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Settings";
			base.Load += new global::System.EventHandler(this.Settings_Load);
			this.panelBack.ResumeLayout(false);
			this.panelBack.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000100 RID: 256
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000101 RID: 257
		private global::System.Windows.Forms.ComboBox comboBox_languages;

		// Token: 0x04000102 RID: 258
		private global::System.Windows.Forms.RadioButton rbtnDefault;

		// Token: 0x04000103 RID: 259
		private global::System.Windows.Forms.RadioButton rbtnBlue;

		// Token: 0x04000104 RID: 260
		private global::System.Windows.Forms.RadioButton rbtnBrown;

		// Token: 0x04000105 RID: 261
		private global::System.Windows.Forms.RadioButton rbtnPurple;

		// Token: 0x04000106 RID: 262
		private global::System.Windows.Forms.RadioButton rbtnRed;

		// Token: 0x04000107 RID: 263
		private global::System.Windows.Forms.RadioButton rbtnGreen;

		// Token: 0x04000108 RID: 264
		private global::System.Windows.Forms.Panel panelBack;

		// Token: 0x04000109 RID: 265
		private global::DevComponents.DotNetBar.ButtonX btnDefault;

		// Token: 0x0400010A RID: 266
		private global::DevComponents.DotNetBar.ButtonX btnSave;

		// Token: 0x0400010B RID: 267
		private global::DevComponents.DotNetBar.ButtonX buttonClosethisForm;
	}
}
