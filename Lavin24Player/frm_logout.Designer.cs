namespace player
{
	// Token: 0x02000009 RID: 9
	public partial class frm_logout : global::System.Windows.Forms.Form
	{
		// Token: 0x06000033 RID: 51 RVA: 0x00003BE8 File Offset: 0x00001DE8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00003C20 File Offset: 0x00001E20
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::player.frm_logout));
			this.btn_logout = new global::DevComponents.DotNetBar.ButtonX();
			this.btn_cancell = new global::DevComponents.DotNetBar.ButtonX();
			this.lbl_logout = new global::System.Windows.Forms.Label();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			base.SuspendLayout();
			this.btn_logout.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.btn_logout.BackColor = global::System.Drawing.Color.Transparent;
			this.btn_logout.ColorTable = global::DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btn_logout.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btn_logout.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			this.btn_logout.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("btn_logout.Image");
			this.btn_logout.ImagePosition = global::DevComponents.DotNetBar.eImagePosition.Top;
			this.btn_logout.Location = new global::System.Drawing.Point(44, 46);
			this.btn_logout.Name = "btn_logout";
			this.btn_logout.Shape = new global::DevComponents.DotNetBar.RoundRectangleShapeDescriptor(18);
			this.btn_logout.Size = new global::System.Drawing.Size(163, 22);
			this.btn_logout.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btn_logout.TabIndex = 2;
			this.btn_logout.Click += new global::System.EventHandler(this.btn_logout_Click);
			this.btn_cancell.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.btn_cancell.BackColor = global::System.Drawing.Color.Transparent;
			this.btn_cancell.ColorTable = global::DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btn_cancell.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btn_cancell.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold);
			this.btn_cancell.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("btn_cancell.Image");
			this.btn_cancell.ImagePosition = global::DevComponents.DotNetBar.eImagePosition.Top;
			this.btn_cancell.Location = new global::System.Drawing.Point(230, 46);
			this.btn_cancell.Name = "btn_cancell";
			this.btn_cancell.Shape = new global::DevComponents.DotNetBar.RoundRectangleShapeDescriptor(18);
			this.btn_cancell.Size = new global::System.Drawing.Size(67, 25);
			this.btn_cancell.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btn_cancell.TabIndex = 1;
			this.btn_cancell.Click += new global::System.EventHandler(this.btn_cancell_Click);
			this.lbl_logout.Location = new global::System.Drawing.Point(175, 110);
			this.lbl_logout.Name = "lbl_logout";
			this.lbl_logout.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.lbl_logout.Size = new global::System.Drawing.Size(482, 52);
			this.lbl_logout.TabIndex = 4;
			this.lbl_logout.Text = "شما با نام کاربری ...";
			this.lbl_logout.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(225, 40);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(81, 38);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			this.pictureBox2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox2.Image");
			this.pictureBox2.Location = new global::System.Drawing.Point(38, 39);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(177, 38);
			this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox2.TabIndex = 6;
			this.pictureBox2.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(23, 33, 43);
			base.ClientSize = new global::System.Drawing.Size(347, 110);
			base.ControlBox = false;
			base.Controls.Add(this.btn_logout);
			base.Controls.Add(this.pictureBox2);
			base.Controls.Add(this.btn_cancell);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.lbl_logout);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frm_logout";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			base.Load += new global::System.EventHandler(this.frm_logout_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000018 RID: 24
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000019 RID: 25
		private global::DevComponents.DotNetBar.ButtonX btn_logout;

		// Token: 0x0400001A RID: 26
		private global::DevComponents.DotNetBar.ButtonX btn_cancell;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.Label lbl_logout;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.PictureBox pictureBox2;
	}
}
