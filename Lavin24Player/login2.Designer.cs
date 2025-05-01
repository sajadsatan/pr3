namespace player
{
	// Token: 0x0200000C RID: 12
	public partial class login2 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000051 RID: 81 RVA: 0x000059C8 File Offset: 0x00003BC8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00005A00 File Offset: 0x00003C00
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::player.login2));
			this.picLoader = new global::System.Windows.Forms.PictureBox();
			this.buttonClosethisForm2 = new global::DevComponents.DotNetBar.ButtonX();
			this.buttonXactivation = new global::DevComponents.DotNetBar.ButtonX();
			this.buttonXGet = new global::DevComponents.DotNetBar.ButtonX();
			this.pictureBoxCode = new global::System.Windows.Forms.PictureBox();
			this.pictureBoxID = new global::System.Windows.Forms.PictureBox();
			this.pictureBoxCopy = new global::System.Windows.Forms.PictureBox();
			this.labelCopied = new global::System.Windows.Forms.Label();
			this.panelBack = new global::System.Windows.Forms.Panel();
			this.textBoxCode = new global::System.Windows.Forms.TextBox();
			this.textBoxID = new global::System.Windows.Forms.TextBox();
			((global::System.ComponentModel.ISupportInitialize)this.picLoader).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxCode).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxID).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxCopy).BeginInit();
			this.panelBack.SuspendLayout();
			base.SuspendLayout();
			this.picLoader.BackColor = global::System.Drawing.Color.Transparent;
			this.picLoader.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("picLoader.Image");
			this.picLoader.Location = new global::System.Drawing.Point(158, 98);
			this.picLoader.Name = "picLoader";
			this.picLoader.Size = new global::System.Drawing.Size(203, 193);
			this.picLoader.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picLoader.TabIndex = 10;
			this.picLoader.TabStop = false;
			this.picLoader.Visible = false;
			this.buttonClosethisForm2.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonClosethisForm2.BackColor = global::System.Drawing.Color.Transparent;
			this.buttonClosethisForm2.ColorTable = global::DevComponents.DotNetBar.eButtonColor.Flat;
			this.buttonClosethisForm2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.buttonClosethisForm2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonClosethisForm2.Location = new global::System.Drawing.Point(476, 1);
			this.buttonClosethisForm2.Name = "buttonClosethisForm2";
			this.buttonClosethisForm2.Size = new global::System.Drawing.Size(22, 24);
			this.buttonClosethisForm2.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.buttonClosethisForm2.TabIndex = 4;
			this.buttonClosethisForm2.Text = "x";
			this.buttonClosethisForm2.TextColor = global::System.Drawing.Color.White;
			this.buttonClosethisForm2.Click += new global::System.EventHandler(this.buttonClosethisForm2_Click);
			this.buttonXactivation.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonXactivation.BackColor = global::System.Drawing.Color.Black;
			this.buttonXactivation.ColorTable = global::DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.buttonXactivation.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonXactivation.Image");
			this.buttonXactivation.ImagePosition = global::DevComponents.DotNetBar.eImagePosition.Right;
			this.buttonXactivation.Location = new global::System.Drawing.Point(202, 303);
			this.buttonXactivation.Name = "buttonXactivation";
			this.buttonXactivation.Shape = new global::DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
			this.buttonXactivation.Size = new global::System.Drawing.Size(103, 39);
			this.buttonXactivation.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.buttonXactivation.TabIndex = 3;
			this.buttonXactivation.Click += new global::System.EventHandler(this.buttonXactivation_Click);
			this.buttonXGet.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonXGet.BackColor = global::System.Drawing.Color.Transparent;
			this.buttonXGet.ColorTable = global::DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.buttonXGet.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonXGet.Image");
			this.buttonXGet.ImagePosition = global::DevComponents.DotNetBar.eImagePosition.Right;
			this.buttonXGet.Location = new global::System.Drawing.Point(102, 203);
			this.buttonXGet.Name = "buttonXGet";
			this.buttonXGet.Shape = new global::DevComponents.DotNetBar.RoundRectangleShapeDescriptor(11);
			this.buttonXGet.Size = new global::System.Drawing.Size(294, 34);
			this.buttonXGet.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.buttonXGet.TabIndex = 1;
			this.buttonXGet.Click += new global::System.EventHandler(this.buttonXGet_Click);
			this.pictureBoxCode.BackColor = global::System.Drawing.Color.Black;
			this.pictureBoxCode.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBoxCode.Image");
			this.pictureBoxCode.Location = new global::System.Drawing.Point(34, 245);
			this.pictureBoxCode.Name = "pictureBoxCode";
			this.pictureBoxCode.Size = new global::System.Drawing.Size(433, 46);
			this.pictureBoxCode.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxCode.TabIndex = 1;
			this.pictureBoxCode.TabStop = false;
			this.pictureBoxID.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBoxID.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBoxID.Image");
			this.pictureBoxID.Location = new global::System.Drawing.Point(37, 151);
			this.pictureBoxID.Name = "pictureBoxID";
			this.pictureBoxID.Size = new global::System.Drawing.Size(405, 46);
			this.pictureBoxID.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxID.TabIndex = 0;
			this.pictureBoxID.TabStop = false;
			this.pictureBoxCopy.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBoxCopy.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureBoxCopy.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBoxCopy.Image");
			this.pictureBoxCopy.Location = new global::System.Drawing.Point(448, 154);
			this.pictureBoxCopy.Name = "pictureBoxCopy";
			this.pictureBoxCopy.Size = new global::System.Drawing.Size(35, 33);
			this.pictureBoxCopy.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBoxCopy.TabIndex = 2;
			this.pictureBoxCopy.TabStop = false;
			this.pictureBoxCopy.Click += new global::System.EventHandler(this.pictureBoxCopy_Click);
			this.labelCopied.AutoSize = true;
			this.labelCopied.BackColor = global::System.Drawing.Color.Transparent;
			this.labelCopied.Font = new global::System.Drawing.Font("Arial Narrow", 7f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelCopied.ForeColor = global::System.Drawing.Color.White;
			this.labelCopied.Location = new global::System.Drawing.Point(450, 193);
			this.labelCopied.Name = "labelCopied";
			this.labelCopied.Size = new global::System.Drawing.Size(0, 14);
			this.labelCopied.TabIndex = 11;
			this.panelBack.BackColor = global::System.Drawing.Color.Black;
			this.panelBack.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("panelBack.BackgroundImage");
			this.panelBack.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.panelBack.Controls.Add(this.picLoader);
			this.panelBack.Controls.Add(this.textBoxCode);
			this.panelBack.Controls.Add(this.textBoxID);
			this.panelBack.Controls.Add(this.pictureBoxID);
			this.panelBack.Controls.Add(this.buttonClosethisForm2);
			this.panelBack.Controls.Add(this.labelCopied);
			this.panelBack.Controls.Add(this.buttonXactivation);
			this.panelBack.Controls.Add(this.pictureBoxCopy);
			this.panelBack.Controls.Add(this.buttonXGet);
			this.panelBack.Controls.Add(this.pictureBoxCode);
			this.panelBack.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panelBack.Location = new global::System.Drawing.Point(0, 0);
			this.panelBack.Name = "panelBack";
			this.panelBack.Size = new global::System.Drawing.Size(500, 362);
			this.panelBack.TabIndex = 0;
			this.panelBack.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panelBack2_MouseDown);
			this.panelBack.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panelBack2_MouseMove);
			this.textBoxCode.BackColor = global::System.Drawing.Color.FromArgb(73, 73, 73);
			this.textBoxCode.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.textBoxCode.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f);
			this.textBoxCode.ForeColor = global::System.Drawing.SystemColors.Window;
			this.textBoxCode.ImeMode = global::System.Windows.Forms.ImeMode.Disable;
			this.textBoxCode.Location = new global::System.Drawing.Point(158, 256);
			this.textBoxCode.Name = "textBoxCode";
			this.textBoxCode.Size = new global::System.Drawing.Size(302, 22);
			this.textBoxCode.TabIndex = 16;
			this.textBoxID.BackColor = global::System.Drawing.Color.FromArgb(73, 73, 73);
			this.textBoxID.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.textBoxID.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f);
			this.textBoxID.ForeColor = global::System.Drawing.SystemColors.Window;
			this.textBoxID.ImeMode = global::System.Windows.Forms.ImeMode.Disable;
			this.textBoxID.Location = new global::System.Drawing.Point(158, 161);
			this.textBoxID.Name = "textBoxID";
			this.textBoxID.ReadOnly = true;
			this.textBoxID.Size = new global::System.Drawing.Size(274, 22);
			this.textBoxID.TabIndex = 15;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.LimeGreen;
			base.ClientSize = new global::System.Drawing.Size(500, 362);
			base.Controls.Add(this.panelBack);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "login2";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "login2";
			base.TransparencyKey = global::System.Drawing.Color.Transparent;
			base.Load += new global::System.EventHandler(this.login2_Load);
			base.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panelBack2_MouseDown);
			base.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panelBack2_MouseMove);
			((global::System.ComponentModel.ISupportInitialize)this.picLoader).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxCode).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxID).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxCopy).EndInit();
			this.panelBack.ResumeLayout(false);
			this.panelBack.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000037 RID: 55
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Forms.PictureBox pictureBoxID;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Forms.PictureBox pictureBoxCopy;

		// Token: 0x0400003A RID: 58
		private global::System.Windows.Forms.PictureBox pictureBoxCode;

		// Token: 0x0400003B RID: 59
		private global::DevComponents.DotNetBar.ButtonX buttonXactivation;

		// Token: 0x0400003C RID: 60
		private global::DevComponents.DotNetBar.ButtonX buttonXGet;

		// Token: 0x0400003D RID: 61
		private global::DevComponents.DotNetBar.ButtonX buttonClosethisForm2;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.PictureBox picLoader;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.Label labelCopied;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.Panel panelBack;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.TextBox textBoxID;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.TextBox textBoxCode;
	}
}
