namespace player
{
	// Token: 0x0200000F RID: 15
	public partial class player : global::System.Windows.Forms.Form
	{
		// Token: 0x060000AF RID: 175 RVA: 0x0000B43C File Offset: 0x0000963C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000B474 File Offset: 0x00009674
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::player.player));
			this.treeView_joblist = new global::System.Windows.Forms.TreeView();
			this.btn_exit = new global::DevComponents.DotNetBar.ButtonX();
			this.btn_editjob = new global::DevComponents.DotNetBar.ButtonX();
			this.btn_newjob = new global::DevComponents.DotNetBar.ButtonX();
			this.labelX2 = new global::DevComponents.DotNetBar.LabelX();
			this.labelX3 = new global::DevComponents.DotNetBar.LabelX();
			this.labelX5 = new global::DevComponents.DotNetBar.LabelX();
			this.labelX4 = new global::DevComponents.DotNetBar.LabelX();
			this.groupPanel1 = new global::DevComponents.DotNetBar.Controls.GroupPanel();
			this.wizard1 = new global::DevComponents.DotNetBar.Wizard();
			this.openFileDialog1 = new global::System.Windows.Forms.OpenFileDialog();
			this.styleManager1 = new global::DevComponents.DotNetBar.StyleManager(this.components);
			this.background = new global::DevComponents.DotNetBar.PanelEx();
			this.pictureBoxLoadingGIF = new global::System.Windows.Forms.PictureBox();
			this.panelAccInfBack = new global::System.Windows.Forms.Panel();
			this.panelAcountInfo = new global::DevComponents.DotNetBar.PanelEx();
			this.labelQuitAcc = new global::System.Windows.Forms.Label();
			this.buttonXAcountInfo = new global::DevComponents.DotNetBar.ButtonX();
			this.textBoxServerName = new global::System.Windows.Forms.TextBox();
			this.pictureBoxServerName = new global::System.Windows.Forms.PictureBox();
			this.textBoxUserName = new global::System.Windows.Forms.TextBox();
			this.pictureBoxUserName = new global::System.Windows.Forms.PictureBox();
			this.labelSpeed = new global::DevComponents.DotNetBar.LabelX();
			this.videoView1 = new global::LibVLCSharp.WinForms.VideoView();
			this.panelEx3 = new global::DevComponents.DotNetBar.PanelEx();
			this.panelControls = new global::DevComponents.DotNetBar.PanelEx();
			this.pictureBoxSettings = new global::System.Windows.Forms.PictureBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.pictureBox_playlist = new global::System.Windows.Forms.PictureBox();
			this.pictureBoxLineL = new global::System.Windows.Forms.PictureBox();
			this.pictureBoxLineR = new global::System.Windows.Forms.PictureBox();
			this.panelPlayPause = new global::DevComponents.DotNetBar.PanelEx();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.lbl_max_timer = new global::DevComponents.DotNetBar.LabelX();
			this.lbl_timer = new global::DevComponents.DotNetBar.LabelX();
			this.pictureBoxOpenfile = new global::System.Windows.Forms.PictureBox();
			this.pictureBox_backward = new global::System.Windows.Forms.PictureBox();
			this.pictureBox_forward = new global::System.Windows.Forms.PictureBox();
			this.trackBar2 = new global::System.Windows.Forms.TrackBar();
			this.pictureBox3 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox4 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox5 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox6 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox7 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox9 = new global::System.Windows.Forms.PictureBox();
			this.trackBar1 = new global::System.Windows.Forms.TrackBar();
			this.panelTop = new global::DevComponents.DotNetBar.PanelEx();
			this.labelVersion = new global::DevComponents.DotNetBar.LabelX();
			this.labelName = new global::DevComponents.DotNetBar.LabelX();
			this.buttonX4 = new global::DevComponents.DotNetBar.ButtonX();
			this.buttonX3 = new global::DevComponents.DotNetBar.ButtonX();
			this.buttonX1 = new global::DevComponents.DotNetBar.ButtonX();
			this.panelLeft = new global::DevComponents.DotNetBar.PanelEx();
			this.panelRight = new global::DevComponents.DotNetBar.PanelEx();
			this.styleManager2 = new global::DevComponents.DotNetBar.StyleManager(this.components);
			this.imageList1 = new global::System.Windows.Forms.ImageList(this.components);
			this.toolTip1 = new global::System.Windows.Forms.ToolTip(this.components);
			this.groupPanel1.SuspendLayout();
			this.background.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxLoadingGIF).BeginInit();
			this.panelAccInfBack.SuspendLayout();
			this.panelAcountInfo.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxServerName).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxUserName).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.videoView1).BeginInit();
			this.panelEx3.SuspendLayout();
			this.panelControls.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxSettings).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox_playlist).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxLineL).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxLineR).BeginInit();
			this.panelPlayPause.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxOpenfile).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox_backward).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox_forward).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBar2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox4).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox5).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox6).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox7).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox9).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBar1).BeginInit();
			this.panelTop.SuspendLayout();
			base.SuspendLayout();
			this.treeView_joblist.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14.25f);
			this.treeView_joblist.LineColor = global::System.Drawing.Color.Empty;
			this.treeView_joblist.Location = new global::System.Drawing.Point(6, 3);
			this.treeView_joblist.Name = "treeView_joblist";
			this.treeView_joblist.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.treeView_joblist.RightToLeftLayout = true;
			this.treeView_joblist.Size = new global::System.Drawing.Size(405, 402);
			this.treeView_joblist.TabIndex = 0;
			this.btn_exit.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.btn_exit.ColorTable = global::DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btn_exit.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btn_exit.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14.25f);
			this.btn_exit.Location = new global::System.Drawing.Point(27, 371);
			this.btn_exit.Name = "btn_exit";
			this.btn_exit.Shape = new global::DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
			this.btn_exit.Size = new global::System.Drawing.Size(136, 34);
			this.btn_exit.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btn_exit.Symbol = "\uf011";
			this.btn_exit.TabIndex = 14;
			this.btn_editjob.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.btn_editjob.ColorTable = global::DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btn_editjob.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btn_editjob.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14.25f);
			this.btn_editjob.Location = new global::System.Drawing.Point(29, 55);
			this.btn_editjob.Name = "btn_editjob";
			this.btn_editjob.Shape = new global::DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
			this.btn_editjob.Size = new global::System.Drawing.Size(136, 34);
			this.btn_editjob.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btn_editjob.Symbol = "\uf1cd";
			this.btn_editjob.TabIndex = 15;
			this.btn_newjob.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.btn_newjob.ColorTable = global::DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btn_newjob.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btn_newjob.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14.25f);
			this.btn_newjob.Location = new global::System.Drawing.Point(100, 10);
			this.btn_newjob.Name = "btn_newjob";
			this.btn_newjob.Shape = new global::DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
			this.btn_newjob.Size = new global::System.Drawing.Size(136, 34);
			this.btn_newjob.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btn_newjob.Symbol = "59558";
			this.btn_newjob.SymbolSet = global::DevComponents.DotNetBar.eSymbolSet.Material;
			this.btn_newjob.TabIndex = 16;
			this.labelX2.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.labelX2.Location = new global::System.Drawing.Point(3, 139);
			this.labelX2.Name = "labelX2";
			this.labelX2.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.labelX2.Size = new global::System.Drawing.Size(170, 84);
			this.labelX2.TabIndex = 17;
			this.labelX2.WordWrap = true;
			this.labelX3.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.labelX3.Location = new global::System.Drawing.Point(3, 245);
			this.labelX3.Name = "labelX3";
			this.labelX3.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.labelX3.Size = new global::System.Drawing.Size(170, 84);
			this.labelX3.TabIndex = 18;
			this.labelX3.WordWrap = true;
			this.labelX5.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.labelX5.ForeColor = global::System.Drawing.Color.White;
			this.labelX5.ImageTextSpacing = 0;
			this.labelX5.Location = new global::System.Drawing.Point(177, 148);
			this.labelX5.Name = "labelX5";
			this.labelX5.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.labelX5.Size = new global::System.Drawing.Size(16, 23);
			this.labelX5.Symbol = "\uf00c";
			this.labelX5.SymbolSize = 10f;
			this.labelX5.TabIndex = 20;
			this.labelX4.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.labelX4.ImageTextSpacing = 0;
			this.labelX4.Location = new global::System.Drawing.Point(205, 260);
			this.labelX4.Name = "labelX4";
			this.labelX4.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.labelX4.Size = new global::System.Drawing.Size(16, 23);
			this.labelX4.Symbol = "\uf00c";
			this.labelX4.SymbolSize = 10f;
			this.labelX4.TabIndex = 19;
			this.groupPanel1.BackColor = global::System.Drawing.Color.White;
			this.groupPanel1.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.groupPanel1.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.groupPanel1.Controls.Add(this.labelX4);
			this.groupPanel1.Controls.Add(this.labelX5);
			this.groupPanel1.Controls.Add(this.labelX3);
			this.groupPanel1.Controls.Add(this.labelX2);
			this.groupPanel1.Controls.Add(this.btn_newjob);
			this.groupPanel1.Controls.Add(this.btn_editjob);
			this.groupPanel1.Controls.Add(this.btn_exit);
			this.groupPanel1.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.groupPanel1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.groupPanel1.Location = new global::System.Drawing.Point(825, 0);
			this.groupPanel1.Name = "groupPanel1";
			this.groupPanel1.Size = new global::System.Drawing.Size(200, 900);
			this.groupPanel1.Style.BackColor2SchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.groupPanel1.Style.BackColorGradientAngle = 90;
			this.groupPanel1.Style.BackColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.groupPanel1.Style.BorderBottom = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupPanel1.Style.BorderBottomWidth = 1;
			this.groupPanel1.Style.BorderColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.groupPanel1.Style.BorderLeft = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupPanel1.Style.BorderLeftWidth = 1;
			this.groupPanel1.Style.BorderRight = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupPanel1.Style.BorderRightWidth = 1;
			this.groupPanel1.Style.BorderTop = global::DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupPanel1.Style.BorderTopWidth = 1;
			this.groupPanel1.Style.CornerDiameter = 4;
			this.groupPanel1.Style.CornerType = global::DevComponents.DotNetBar.eCornerType.Rounded;
			this.groupPanel1.Style.TextAlignment = global::DevComponents.DotNetBar.eStyleTextAlignment.Center;
			this.groupPanel1.Style.TextColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.groupPanel1.Style.TextLineAlignment = global::DevComponents.DotNetBar.eStyleTextAlignment.Near;
			this.groupPanel1.StyleMouseDown.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.groupPanel1.StyleMouseOver.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.groupPanel1.TabIndex = 1;
			this.wizard1.CancelButtonText = "Cancel";
			this.wizard1.FinishButtonTabIndex = 3;
			this.wizard1.FooterStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.wizard1.HeaderCaptionFont = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.wizard1.HeaderDescriptionFont = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.wizard1.HeaderDescriptionIndent = 16;
			this.wizard1.HeaderStyle.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 255);
			this.wizard1.HeaderStyle.BackColorGradientAngle = 90;
			this.wizard1.HeaderStyle.BorderBottom = global::DevComponents.DotNetBar.eStyleBorderType.Etched;
			this.wizard1.HeaderStyle.BorderBottomWidth = 1;
			this.wizard1.HeaderStyle.BorderColor = global::System.Drawing.SystemColors.Control;
			this.wizard1.HeaderStyle.BorderLeftWidth = 1;
			this.wizard1.HeaderStyle.BorderRightWidth = 1;
			this.wizard1.HeaderStyle.BorderTopWidth = 1;
			this.wizard1.HeaderStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.wizard1.HeaderStyle.TextAlignment = global::DevComponents.DotNetBar.eStyleTextAlignment.Center;
			this.wizard1.HeaderStyle.TextColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.wizard1.Location = new global::System.Drawing.Point(0, 0);
			this.wizard1.Name = "wizard1";
			this.wizard1.Size = new global::System.Drawing.Size(548, 375);
			this.wizard1.TabIndex = 0;
			this.openFileDialog1.FileName = "openFileDialog1";
			this.styleManager1.ManagerColorTint = global::System.Drawing.Color.Transparent;
			this.styleManager1.ManagerStyle = global::DevComponents.DotNetBar.eStyle.Metro;
			this.styleManager1.MetroColorParameters = new global::DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(global::System.Drawing.Color.WhiteSmoke, global::System.Drawing.Color.FromArgb(43, 87, 154));
			this.background.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.background.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.background.Controls.Add(this.pictureBoxLoadingGIF);
			this.background.Controls.Add(this.panelAccInfBack);
			this.background.Controls.Add(this.labelSpeed);
			this.background.Controls.Add(this.videoView1);
			this.background.Controls.Add(this.panelEx3);
			this.background.Controls.Add(this.panelTop);
			this.background.Controls.Add(this.panelLeft);
			this.background.Controls.Add(this.panelRight);
			this.background.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.background.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.background.Location = new global::System.Drawing.Point(0, 0);
			this.background.Name = "background";
			this.background.Size = new global::System.Drawing.Size(1025, 565);
			this.background.Style.Alignment = global::System.Drawing.StringAlignment.Center;
			this.background.Style.BackColor1.Color = global::System.Drawing.Color.FromArgb(17, 17, 17);
			this.background.Style.Border = global::DevComponents.DotNetBar.eBorderType.SingleLine;
			this.background.Style.BorderColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.background.Style.ForeColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.background.Style.GradientAngle = 90;
			this.background.TabIndex = 19;
			this.pictureBoxLoadingGIF.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBoxLoadingGIF.Image");
			this.pictureBoxLoadingGIF.Location = new global::System.Drawing.Point(317, 189);
			this.pictureBoxLoadingGIF.Name = "pictureBoxLoadingGIF";
			this.pictureBoxLoadingGIF.Size = new global::System.Drawing.Size(400, 166);
			this.pictureBoxLoadingGIF.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxLoadingGIF.TabIndex = 52;
			this.pictureBoxLoadingGIF.TabStop = false;
			this.pictureBoxLoadingGIF.Visible = false;
			this.panelAccInfBack.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
			this.panelAccInfBack.BackColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
			this.panelAccInfBack.Controls.Add(this.panelAcountInfo);
			this.panelAccInfBack.ForeColor = global::System.Drawing.Color.FromArgb(17, 17, 17, 10);
			this.panelAccInfBack.Location = new global::System.Drawing.Point(508, 0);
			this.panelAccInfBack.Name = "panelAccInfBack";
			this.panelAccInfBack.Size = new global::System.Drawing.Size(407, 145);
			this.panelAccInfBack.TabIndex = 10;
			this.panelAccInfBack.Visible = false;
			this.panelAccInfBack.MouseLeave += new global::System.EventHandler(this.panelAccInfBack_MouseLeave);
			this.panelAcountInfo.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
			this.panelAcountInfo.CanvasColor = global::System.Drawing.Color.Transparent;
			this.panelAcountInfo.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.panelAcountInfo.Controls.Add(this.labelQuitAcc);
			this.panelAcountInfo.Controls.Add(this.buttonXAcountInfo);
			this.panelAcountInfo.Controls.Add(this.textBoxServerName);
			this.panelAcountInfo.Controls.Add(this.pictureBoxServerName);
			this.panelAcountInfo.Controls.Add(this.textBoxUserName);
			this.panelAcountInfo.Controls.Add(this.pictureBoxUserName);
			this.panelAcountInfo.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.panelAcountInfo.Location = new global::System.Drawing.Point(2, 1);
			this.panelAcountInfo.Name = "panelAcountInfo";
			this.panelAcountInfo.Size = new global::System.Drawing.Size(404, 142);
			this.panelAcountInfo.Style.Alignment = global::System.Drawing.StringAlignment.Center;
			this.panelAcountInfo.Style.BackColor1.Color = global::System.Drawing.Color.FromArgb(3, 3, 3);
			this.panelAcountInfo.Style.BorderColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.panelAcountInfo.Style.CornerDiameter = 55;
			this.panelAcountInfo.Style.ForeColor.Color = global::System.Drawing.Color.Black;
			this.panelAcountInfo.Style.GradientAngle = 90;
			this.panelAcountInfo.TabIndex = 53;
			this.labelQuitAcc.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.labelQuitAcc.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelQuitAcc.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Underline);
			this.labelQuitAcc.ForeColor = global::System.Drawing.Color.White;
			this.labelQuitAcc.Location = new global::System.Drawing.Point(123, 108);
			this.labelQuitAcc.Name = "labelQuitAcc";
			this.labelQuitAcc.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.labelQuitAcc.Size = new global::System.Drawing.Size(168, 25);
			this.labelQuitAcc.TabIndex = 6;
			this.labelQuitAcc.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelQuitAcc.Click += new global::System.EventHandler(this.labelQuitAcc_Click);
			this.labelQuitAcc.MouseLeave += new global::System.EventHandler(this.labelQuitAcc_MouseLeave);
			this.labelQuitAcc.MouseHover += new global::System.EventHandler(this.labelQuitAcc_MouseHover);
			this.buttonXAcountInfo.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonXAcountInfo.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
			this.buttonXAcountInfo.BackColor = global::System.Drawing.Color.Transparent;
			this.buttonXAcountInfo.ColorTable = global::DevComponents.DotNetBar.eButtonColor.Flat;
			this.buttonXAcountInfo.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 13f);
			this.buttonXAcountInfo.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonXAcountInfo.Image");
			this.buttonXAcountInfo.Location = new global::System.Drawing.Point(366, -1);
			this.buttonXAcountInfo.Name = "buttonXAcountInfo";
			this.buttonXAcountInfo.Size = new global::System.Drawing.Size(38, 30);
			this.buttonXAcountInfo.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.buttonXAcountInfo.TabIndex = 9;
			this.buttonXAcountInfo.TextColor = global::System.Drawing.Color.Black;
			this.buttonXAcountInfo.MouseEnter += new global::System.EventHandler(this.buttonXAcountInfo_MouseEnter);
			this.textBoxServerName.BackColor = global::System.Drawing.Color.FromArgb(69, 69, 69);
			this.textBoxServerName.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.textBoxServerName.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11f);
			this.textBoxServerName.ForeColor = global::System.Drawing.SystemColors.Window;
			this.textBoxServerName.Location = new global::System.Drawing.Point(28, 79);
			this.textBoxServerName.Name = "textBoxServerName";
			this.textBoxServerName.ReadOnly = true;
			this.textBoxServerName.Size = new global::System.Drawing.Size(282, 17);
			this.textBoxServerName.TabIndex = 16;
			this.pictureBoxServerName.Location = new global::System.Drawing.Point(14, 66);
			this.pictureBoxServerName.Name = "pictureBoxServerName";
			this.pictureBoxServerName.Size = new global::System.Drawing.Size(373, 43);
			this.pictureBoxServerName.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxServerName.TabIndex = 15;
			this.pictureBoxServerName.TabStop = false;
			this.textBoxUserName.BackColor = global::System.Drawing.Color.FromArgb(69, 69, 69);
			this.textBoxUserName.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.textBoxUserName.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11f);
			this.textBoxUserName.ForeColor = global::System.Drawing.SystemColors.Window;
			this.textBoxUserName.ImeMode = global::System.Windows.Forms.ImeMode.Disable;
			this.textBoxUserName.Location = new global::System.Drawing.Point(28, 39);
			this.textBoxUserName.Name = "textBoxUserName";
			this.textBoxUserName.ReadOnly = true;
			this.textBoxUserName.Size = new global::System.Drawing.Size(282, 17);
			this.textBoxUserName.TabIndex = 13;
			this.pictureBoxUserName.Location = new global::System.Drawing.Point(14, 29);
			this.pictureBoxUserName.Name = "pictureBoxUserName";
			this.pictureBoxUserName.Size = new global::System.Drawing.Size(373, 38);
			this.pictureBoxUserName.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxUserName.TabIndex = 10;
			this.pictureBoxUserName.TabStop = false;
			this.labelSpeed.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
			this.labelSpeed.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.labelSpeed.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14.25f, global::System.Drawing.FontStyle.Bold);
			this.labelSpeed.ForeColor = global::System.Drawing.Color.Silver;
			this.labelSpeed.Location = new global::System.Drawing.Point(939, 47);
			this.labelSpeed.Name = "labelSpeed";
			this.labelSpeed.Size = new global::System.Drawing.Size(41, 37);
			this.labelSpeed.TabIndex = 39;
			this.labelSpeed.TextAlignment = global::System.Drawing.StringAlignment.Center;
			this.labelSpeed.Visible = false;
			this.videoView1.BackColor = global::System.Drawing.Color.Black;
			this.videoView1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.videoView1.Location = new global::System.Drawing.Point(25, 30);
			this.videoView1.MediaPlayer = null;
			this.videoView1.Name = "videoView1";
			this.videoView1.Size = new global::System.Drawing.Size(975, 413);
			this.videoView1.TabIndex = 0;
			this.videoView1.Text = "videoView1";
			this.videoView1.MouseEnter += new global::System.EventHandler(this.videoView1_MouseEnter);
			this.videoView1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.videoView1_MouseMove_1);
			this.panelEx3.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.panelEx3.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.panelEx3.Controls.Add(this.panelControls);
			this.panelEx3.Controls.Add(this.trackBar1);
			this.panelEx3.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.panelEx3.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.panelEx3.Location = new global::System.Drawing.Point(25, 443);
			this.panelEx3.Name = "panelEx3";
			this.panelEx3.Size = new global::System.Drawing.Size(975, 122);
			this.panelEx3.Style.Alignment = global::System.Drawing.StringAlignment.Center;
			this.panelEx3.Style.BackColor1.Color = global::System.Drawing.Color.FromArgb(17, 17, 17);
			this.panelEx3.Style.BorderColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.panelEx3.Style.ForeColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelEx3.Style.GradientAngle = 90;
			this.panelEx3.TabIndex = 4;
			this.panelControls.Anchor = global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right;
			this.panelControls.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.panelControls.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.panelControls.Controls.Add(this.pictureBoxSettings);
			this.panelControls.Controls.Add(this.label1);
			this.panelControls.Controls.Add(this.pictureBox_playlist);
			this.panelControls.Controls.Add(this.pictureBoxLineL);
			this.panelControls.Controls.Add(this.pictureBoxLineR);
			this.panelControls.Controls.Add(this.panelPlayPause);
			this.panelControls.Controls.Add(this.lbl_max_timer);
			this.panelControls.Controls.Add(this.lbl_timer);
			this.panelControls.Controls.Add(this.pictureBoxOpenfile);
			this.panelControls.Controls.Add(this.pictureBox_backward);
			this.panelControls.Controls.Add(this.pictureBox_forward);
			this.panelControls.Controls.Add(this.trackBar2);
			this.panelControls.Controls.Add(this.pictureBox3);
			this.panelControls.Controls.Add(this.pictureBox4);
			this.panelControls.Controls.Add(this.pictureBox2);
			this.panelControls.Controls.Add(this.pictureBox5);
			this.panelControls.Controls.Add(this.pictureBox6);
			this.panelControls.Controls.Add(this.pictureBox7);
			this.panelControls.Controls.Add(this.pictureBox9);
			this.panelControls.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.panelControls.Location = new global::System.Drawing.Point(0, 26);
			this.panelControls.Name = "panelControls";
			this.panelControls.Size = new global::System.Drawing.Size(975, 92);
			this.panelControls.Style.Alignment = global::System.Drawing.StringAlignment.Center;
			this.panelControls.Style.BackColor1.Color = global::System.Drawing.Color.FromArgb(17, 17, 17);
			this.panelControls.Style.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("panelControls.Style.BackgroundImage");
			this.panelControls.Style.BorderColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.panelControls.Style.ForeColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelControls.Style.GradientAngle = 90;
			this.panelControls.TabIndex = 14;
			this.pictureBoxSettings.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right;
			this.pictureBoxSettings.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBoxSettings.BackgroundImage");
			this.pictureBoxSettings.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			this.pictureBoxSettings.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureBoxSettings.Location = new global::System.Drawing.Point(760, 32);
			this.pictureBoxSettings.Name = "pictureBoxSettings";
			this.pictureBoxSettings.Size = new global::System.Drawing.Size(33, 31);
			this.pictureBoxSettings.TabIndex = 52;
			this.pictureBoxSettings.TabStop = false;
			this.pictureBoxSettings.Click += new global::System.EventHandler(this.pictureBoxSettings_Click);
			this.label1.AutoSize = true;
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(206, 30);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(0, 13);
			this.label1.TabIndex = 24;
			this.pictureBox_playlist.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureBox_playlist.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox_playlist.Image");
			this.pictureBox_playlist.Location = new global::System.Drawing.Point(11, 31);
			this.pictureBox_playlist.Name = "pictureBox_playlist";
			this.pictureBox_playlist.Size = new global::System.Drawing.Size(32, 30);
			this.pictureBox_playlist.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox_playlist.TabIndex = 19;
			this.pictureBox_playlist.TabStop = false;
			this.pictureBox_playlist.Click += new global::System.EventHandler(this.pictureBox_playlist_Click);
			this.pictureBoxLineL.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.pictureBoxLineL.Image = global::player.Properties.Resources.line;
			this.pictureBoxLineL.Location = new global::System.Drawing.Point(383, 34);
			this.pictureBoxLineL.Name = "pictureBoxLineL";
			this.pictureBoxLineL.Size = new global::System.Drawing.Size(22, 30);
			this.pictureBoxLineL.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxLineL.TabIndex = 15;
			this.pictureBoxLineL.TabStop = false;
			this.pictureBoxLineR.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.pictureBoxLineR.Image = global::player.Properties.Resources.line;
			this.pictureBoxLineR.Location = new global::System.Drawing.Point(567, 34);
			this.pictureBoxLineR.Name = "pictureBoxLineR";
			this.pictureBoxLineR.Size = new global::System.Drawing.Size(22, 30);
			this.pictureBoxLineR.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxLineR.TabIndex = 14;
			this.pictureBoxLineR.TabStop = false;
			this.panelPlayPause.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.panelPlayPause.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.panelPlayPause.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.panelPlayPause.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.panelPlayPause.Controls.Add(this.pictureBox1);
			this.panelPlayPause.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.panelPlayPause.Location = new global::System.Drawing.Point(435, 7);
			this.panelPlayPause.Name = "panelPlayPause";
			this.panelPlayPause.Size = new global::System.Drawing.Size(104, 82);
			this.panelPlayPause.Style.Alignment = global::System.Drawing.StringAlignment.Center;
			this.panelPlayPause.Style.BackColor1.Color = global::System.Drawing.Color.Transparent;
			this.panelPlayPause.Style.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("panelPlayPause.Style.BackgroundImage");
			this.panelPlayPause.Style.BorderColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.panelPlayPause.Style.ForeColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelPlayPause.Style.GradientAngle = 90;
			this.panelPlayPause.TabIndex = 3;
			this.pictureBox1.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.pictureBox1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureBox1.Image = global::player.Properties.Resources.play_btn1;
			this.pictureBox1.Location = new global::System.Drawing.Point(36, 27);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(32, 30);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click);
			this.lbl_max_timer.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right;
			this.lbl_max_timer.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.lbl_max_timer.ForeColor = global::System.Drawing.Color.White;
			this.lbl_max_timer.Location = new global::System.Drawing.Point(919, 4);
			this.lbl_max_timer.Name = "lbl_max_timer";
			this.lbl_max_timer.Size = new global::System.Drawing.Size(48, 15);
			this.lbl_max_timer.TabIndex = 0;
			this.lbl_max_timer.Text = "00:00";
			this.lbl_max_timer.TextAlignment = global::System.Drawing.StringAlignment.Far;
			this.lbl_max_timer.Visible = false;
			this.lbl_timer.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left;
			this.lbl_timer.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.lbl_timer.ForeColor = global::System.Drawing.Color.White;
			this.lbl_timer.Location = new global::System.Drawing.Point(6, 3);
			this.lbl_timer.Name = "lbl_timer";
			this.lbl_timer.Size = new global::System.Drawing.Size(51, 15);
			this.lbl_timer.TabIndex = 13;
			this.lbl_timer.Text = "00:00";
			this.lbl_timer.Visible = false;
			this.pictureBoxOpenfile.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureBoxOpenfile.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBoxOpenfile.Image");
			this.pictureBoxOpenfile.Location = new global::System.Drawing.Point(44, 34);
			this.pictureBoxOpenfile.Name = "pictureBoxOpenfile";
			this.pictureBoxOpenfile.Size = new global::System.Drawing.Size(102, 26);
			this.pictureBoxOpenfile.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxOpenfile.TabIndex = 13;
			this.pictureBoxOpenfile.TabStop = false;
			this.pictureBoxOpenfile.Click += new global::System.EventHandler(this.pictureBoxOpenfile_Click);
			this.pictureBox_backward.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.pictureBox_backward.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureBox_backward.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox_backward.Image");
			this.pictureBox_backward.InitialImage = null;
			this.pictureBox_backward.Location = new global::System.Drawing.Point(403, 33);
			this.pictureBox_backward.Name = "pictureBox_backward";
			this.pictureBox_backward.Size = new global::System.Drawing.Size(32, 30);
			this.pictureBox_backward.TabIndex = 10;
			this.pictureBox_backward.TabStop = false;
			this.pictureBox_backward.Click += new global::System.EventHandler(this.pictureBox_backward_Click);
			this.pictureBox_forward.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.pictureBox_forward.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureBox_forward.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox_forward.Image");
			this.pictureBox_forward.InitialImage = null;
			this.pictureBox_forward.Location = new global::System.Drawing.Point(536, 33);
			this.pictureBox_forward.Name = "pictureBox_forward";
			this.pictureBox_forward.Size = new global::System.Drawing.Size(32, 30);
			this.pictureBox_forward.TabIndex = 11;
			this.pictureBox_forward.TabStop = false;
			this.pictureBox_forward.Click += new global::System.EventHandler(this.pictureBox_forward_Click);
			this.trackBar2.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right;
			this.trackBar2.BackColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.trackBar2.Location = new global::System.Drawing.Point(864, 38);
			this.trackBar2.Margin = new global::System.Windows.Forms.Padding(0);
			this.trackBar2.MaximumSize = new global::System.Drawing.Size(100, 20);
			this.trackBar2.Name = "trackBar2";
			this.trackBar2.Size = new global::System.Drawing.Size(96, 45);
			this.trackBar2.TabIndex = 3;
			this.trackBar2.TabStop = false;
			this.trackBar2.TickStyle = global::System.Windows.Forms.TickStyle.None;
			this.trackBar2.Value = 10;
			this.trackBar2.Scroll += new global::System.EventHandler(this.trackBar2_Scroll);
			this.pictureBox3.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right;
			this.pictureBox3.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureBox3.Image = global::player.Properties.Resources.fullscreen;
			this.pictureBox3.Location = new global::System.Drawing.Point(800, 32);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new global::System.Drawing.Size(30, 32);
			this.pictureBox3.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 3;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new global::System.EventHandler(this.pictureBox3_Click);
			this.pictureBox4.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right;
			this.pictureBox4.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureBox4.Image = global::player.Properties.Resources.sound_on;
			this.pictureBox4.Location = new global::System.Drawing.Point(833, 35);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new global::System.Drawing.Size(32, 27);
			this.pictureBox4.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox4.TabIndex = 5;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Click += new global::System.EventHandler(this.pictureBox4_Click);
			this.pictureBox2.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left;
			this.pictureBox2.Image = global::player.Properties.Resources.line;
			this.pictureBox2.Location = new global::System.Drawing.Point(33, 31);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(22, 30);
			this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 20;
			this.pictureBox2.TabStop = false;
			this.pictureBox5.Anchor = global::System.Windows.Forms.AnchorStyles.Left;
			this.pictureBox5.Image = global::player.Properties.Resources.line;
			this.pictureBox5.Location = new global::System.Drawing.Point(136, 31);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new global::System.Drawing.Size(22, 30);
			this.pictureBox5.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox5.TabIndex = 21;
			this.pictureBox5.TabStop = false;
			this.pictureBox6.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right;
			this.pictureBox6.Image = global::player.Properties.Resources.line;
			this.pictureBox6.Location = new global::System.Drawing.Point(788, 33);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new global::System.Drawing.Size(22, 30);
			this.pictureBox6.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox6.TabIndex = 22;
			this.pictureBox6.TabStop = false;
			this.pictureBox7.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right;
			this.pictureBox7.Image = global::player.Properties.Resources.line;
			this.pictureBox7.Location = new global::System.Drawing.Point(820, 33);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new global::System.Drawing.Size(22, 30);
			this.pictureBox7.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox7.TabIndex = 23;
			this.pictureBox7.TabStop = false;
			this.pictureBox9.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right;
			this.pictureBox9.Image = global::player.Properties.Resources.line;
			this.pictureBox9.Location = new global::System.Drawing.Point(745, 33);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new global::System.Drawing.Size(22, 30);
			this.pictureBox9.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox9.TabIndex = 53;
			this.pictureBox9.TabStop = false;
			this.trackBar1.BackColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
			this.trackBar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.trackBar1.Location = new global::System.Drawing.Point(0, 0);
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new global::System.Drawing.Size(975, 45);
			this.trackBar1.TabIndex = 2;
			this.trackBar1.TabStop = false;
			this.trackBar1.TickStyle = global::System.Windows.Forms.TickStyle.None;
			this.trackBar1.Scroll += new global::System.EventHandler(this.trackBar1_Scroll);
			this.panelTop.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.panelTop.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.panelTop.Controls.Add(this.labelVersion);
			this.panelTop.Controls.Add(this.labelName);
			this.panelTop.Controls.Add(this.buttonX4);
			this.panelTop.Controls.Add(this.buttonX3);
			this.panelTop.Controls.Add(this.buttonX1);
			this.panelTop.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.panelTop.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panelTop.Location = new global::System.Drawing.Point(25, 0);
			this.panelTop.Name = "panelTop";
			this.panelTop.Size = new global::System.Drawing.Size(975, 30);
			this.panelTop.Style.Alignment = global::System.Drawing.StringAlignment.Center;
			this.panelTop.Style.BackColor1.Color = global::System.Drawing.Color.FromArgb(17, 17, 17);
			this.panelTop.Style.BorderColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.panelTop.Style.ForeColor.Color = global::System.Drawing.Color.Black;
			this.panelTop.Style.GradientAngle = 90;
			this.panelTop.TabIndex = 11;
			this.panelTop.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
			this.panelTop.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
			this.labelVersion.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.labelVersion.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.labelVersion.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 7f);
			this.labelVersion.ForeColor = global::System.Drawing.Color.Gray;
			this.labelVersion.Location = new global::System.Drawing.Point(85, 0);
			this.labelVersion.Name = "labelVersion";
			this.labelVersion.Size = new global::System.Drawing.Size(52, 30);
			this.labelVersion.TabIndex = 8;
			this.labelVersion.Text = "v4.0.0.0";
			this.labelVersion.MouseLeave += new global::System.EventHandler(this.labelVersion_MouseLeave);
			this.labelVersion.MouseHover += new global::System.EventHandler(this.labelVersion_MouseHover);
			this.labelName.BackgroundStyle.CornerType = global::DevComponents.DotNetBar.eCornerType.Square;
			this.labelName.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.labelName.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("labelName.Image");
			this.labelName.Location = new global::System.Drawing.Point(0, 0);
			this.labelName.Name = "labelName";
			this.labelName.Size = new global::System.Drawing.Size(85, 30);
			this.labelName.TabIndex = 0;
			this.labelName.Click += new global::System.EventHandler(this.labelName_Click);
			this.buttonX4.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonX4.BackColor = global::System.Drawing.Color.Transparent;
			this.buttonX4.ColorTable = global::DevComponents.DotNetBar.eButtonColor.Flat;
			this.buttonX4.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.buttonX4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 13f);
			this.buttonX4.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonX4.Image");
			this.buttonX4.Location = new global::System.Drawing.Point(891, 0);
			this.buttonX4.Name = "buttonX4";
			this.buttonX4.Size = new global::System.Drawing.Size(28, 30);
			this.buttonX4.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.buttonX4.TabIndex = 7;
			this.buttonX4.TextColor = global::System.Drawing.Color.Black;
			this.buttonX4.Click += new global::System.EventHandler(this.buttonX4_Click);
			this.buttonX3.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonX3.BackColor = global::System.Drawing.Color.Transparent;
			this.buttonX3.ColorTable = global::DevComponents.DotNetBar.eButtonColor.Flat;
			this.buttonX3.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.buttonX3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.buttonX3.Image = global::player.Properties.Resources.large;
			this.buttonX3.Location = new global::System.Drawing.Point(919, 0);
			this.buttonX3.Name = "buttonX3";
			this.buttonX3.Size = new global::System.Drawing.Size(28, 30);
			this.buttonX3.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.buttonX3.TabIndex = 7;
			this.buttonX3.TextColor = global::System.Drawing.Color.Black;
			this.buttonX3.Click += new global::System.EventHandler(this.buttonX3_Click);
			this.buttonX1.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonX1.BackColor = global::System.Drawing.Color.Transparent;
			this.buttonX1.ColorTable = global::DevComponents.DotNetBar.eButtonColor.Flat;
			this.buttonX1.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.buttonX1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12.25f);
			this.buttonX1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonX1.Image");
			this.buttonX1.Location = new global::System.Drawing.Point(947, 0);
			this.buttonX1.Name = "buttonX1";
			this.buttonX1.Size = new global::System.Drawing.Size(28, 30);
			this.buttonX1.Style = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.buttonX1.TabIndex = 7;
			this.buttonX1.TextColor = global::System.Drawing.Color.Black;
			this.buttonX1.Click += new global::System.EventHandler(this.buttonX1_Click);
			this.panelLeft.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.panelLeft.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.panelLeft.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.panelLeft.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.panelLeft.Location = new global::System.Drawing.Point(0, 0);
			this.panelLeft.Name = "panelLeft";
			this.panelLeft.Size = new global::System.Drawing.Size(25, 565);
			this.panelLeft.Style.Alignment = global::System.Drawing.StringAlignment.Center;
			this.panelLeft.Style.BackColor1.Color = global::System.Drawing.Color.FromArgb(17, 17, 17);
			this.panelLeft.Style.BorderColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.panelLeft.Style.ForeColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelLeft.Style.GradientAngle = 90;
			this.panelLeft.TabIndex = 19;
			this.panelRight.CanvasColor = global::System.Drawing.SystemColors.Control;
			this.panelRight.ColorSchemeStyle = global::DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.panelRight.DisabledBackColor = global::System.Drawing.Color.Empty;
			this.panelRight.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.panelRight.Location = new global::System.Drawing.Point(1000, 0);
			this.panelRight.Name = "panelRight";
			this.panelRight.Size = new global::System.Drawing.Size(25, 565);
			this.panelRight.Style.Alignment = global::System.Drawing.StringAlignment.Center;
			this.panelRight.Style.BackColor1.Color = global::System.Drawing.Color.FromArgb(17, 17, 17);
			this.panelRight.Style.BorderColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.panelRight.Style.ForeColor.ColorSchemePart = global::DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelRight.Style.GradientAngle = 90;
			this.panelRight.TabIndex = 15;
			this.styleManager2.ManagerColorTint = global::System.Drawing.Color.Transparent;
			this.styleManager2.ManagerStyle = global::DevComponents.DotNetBar.eStyle.Metro;
			this.styleManager2.MetroColorParameters = new global::DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(global::System.Drawing.Color.WhiteSmoke, global::System.Drawing.Color.FromArgb(43, 87, 154));
			this.imageList1.ColorDepth = global::System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new global::System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = global::System.Drawing.Color.Transparent;
			this.toolTip1.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.toolTip1.IsBalloon = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1025, 565);
			base.ControlBox = false;
			base.Controls.Add(this.background);
			this.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.KeyPreview = true;
			base.Name = "player";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			base.Load += new global::System.EventHandler(this.player_Load);
			base.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.player_KeyDown);
			this.groupPanel1.ResumeLayout(false);
			this.background.ResumeLayout(false);
			this.background.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxLoadingGIF).EndInit();
			this.panelAccInfBack.ResumeLayout(false);
			this.panelAcountInfo.ResumeLayout(false);
			this.panelAcountInfo.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxServerName).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxUserName).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.videoView1).EndInit();
			this.panelEx3.ResumeLayout(false);
			this.panelEx3.PerformLayout();
			this.panelControls.ResumeLayout(false);
			this.panelControls.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxSettings).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox_playlist).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxLineL).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxLineR).EndInit();
			this.panelPlayPause.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxOpenfile).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox_backward).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox_forward).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBar2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox4).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox5).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox6).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox7).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox9).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBar1).EndInit();
			this.panelTop.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000085 RID: 133
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000086 RID: 134
		private global::System.Windows.Forms.TreeView treeView_joblist;

		// Token: 0x04000087 RID: 135
		private global::DevComponents.DotNetBar.ButtonX btn_exit;

		// Token: 0x04000088 RID: 136
		private global::DevComponents.DotNetBar.ButtonX btn_editjob;

		// Token: 0x04000089 RID: 137
		private global::DevComponents.DotNetBar.ButtonX btn_newjob;

		// Token: 0x0400008A RID: 138
		private global::DevComponents.DotNetBar.LabelX labelX2;

		// Token: 0x0400008B RID: 139
		private global::DevComponents.DotNetBar.LabelX labelX3;

		// Token: 0x0400008C RID: 140
		private global::DevComponents.DotNetBar.LabelX labelX5;

		// Token: 0x0400008D RID: 141
		private global::DevComponents.DotNetBar.LabelX labelX4;

		// Token: 0x0400008E RID: 142
		private global::DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;

		// Token: 0x0400008F RID: 143
		private global::DevComponents.DotNetBar.Wizard wizard1;

		// Token: 0x04000090 RID: 144
		private global::System.Windows.Forms.OpenFileDialog openFileDialog1;

		// Token: 0x04000091 RID: 145
		private global::DevComponents.DotNetBar.StyleManager styleManager1;

		// Token: 0x04000092 RID: 146
		private global::DevComponents.DotNetBar.PanelEx background;

		// Token: 0x04000093 RID: 147
		public global::DevComponents.DotNetBar.PanelEx panelEx3;

		// Token: 0x04000094 RID: 148
		public global::DevComponents.DotNetBar.PanelEx panelControls;

		// Token: 0x04000095 RID: 149
		private global::DevComponents.DotNetBar.LabelX lbl_max_timer;

		// Token: 0x04000096 RID: 150
		private global::DevComponents.DotNetBar.LabelX lbl_timer;

		// Token: 0x04000097 RID: 151
		private global::System.Windows.Forms.PictureBox pictureBox3;

		// Token: 0x04000098 RID: 152
		public global::System.Windows.Forms.TrackBar trackBar1;

		// Token: 0x04000099 RID: 153
		public global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400009A RID: 154
		private global::System.Windows.Forms.PictureBox pictureBox4;

		// Token: 0x0400009B RID: 155
		public global::System.Windows.Forms.TrackBar trackBar2;

		// Token: 0x0400009C RID: 156
		public global::DevComponents.DotNetBar.PanelEx panelTop;

		// Token: 0x0400009D RID: 157
		private global::DevComponents.DotNetBar.LabelX labelVersion;

		// Token: 0x0400009E RID: 158
		private global::DevComponents.DotNetBar.LabelX labelName;

		// Token: 0x0400009F RID: 159
		private global::DevComponents.DotNetBar.ButtonX buttonX4;

		// Token: 0x040000A0 RID: 160
		private global::DevComponents.DotNetBar.ButtonX buttonX3;

		// Token: 0x040000A1 RID: 161
		private global::DevComponents.DotNetBar.ButtonX buttonX1;

		// Token: 0x040000A2 RID: 162
		public global::DevComponents.DotNetBar.PanelEx panelLeft;

		// Token: 0x040000A3 RID: 163
		public global::DevComponents.DotNetBar.PanelEx panelRight;

		// Token: 0x040000A4 RID: 164
		private global::System.Windows.Forms.PictureBox pictureBox_backward;

		// Token: 0x040000A5 RID: 165
		private global::System.Windows.Forms.PictureBox pictureBox_forward;

		// Token: 0x040000A6 RID: 166
		public global::DevComponents.DotNetBar.PanelEx panelPlayPause;

		// Token: 0x040000A7 RID: 167
		private global::System.Windows.Forms.PictureBox pictureBoxOpenfile;

		// Token: 0x040000A8 RID: 168
		private global::DevComponents.DotNetBar.LabelX labelSpeed;

		// Token: 0x040000A9 RID: 169
		private global::System.Windows.Forms.PictureBox pictureBoxLineR;

		// Token: 0x040000AA RID: 170
		private global::System.Windows.Forms.PictureBox pictureBoxLineL;

		// Token: 0x040000AB RID: 171
		private global::System.Windows.Forms.PictureBox pictureBox_playlist;

		// Token: 0x040000AC RID: 172
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x040000AD RID: 173
		private global::System.Windows.Forms.PictureBox pictureBox5;

		// Token: 0x040000AE RID: 174
		private global::System.Windows.Forms.PictureBox pictureBox6;

		// Token: 0x040000AF RID: 175
		private global::System.Windows.Forms.PictureBox pictureBox7;

		// Token: 0x040000B0 RID: 176
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000B1 RID: 177
		private global::DevComponents.DotNetBar.StyleManager styleManager2;

		// Token: 0x040000B2 RID: 178
		private global::System.Windows.Forms.ImageList imageList1;

		// Token: 0x040000B3 RID: 179
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x040000B4 RID: 180
		private global::System.Windows.Forms.PictureBox pictureBoxSettings;

		// Token: 0x040000B5 RID: 181
		private global::System.Windows.Forms.PictureBox pictureBox9;

		// Token: 0x040000B6 RID: 182
		public global::LibVLCSharp.WinForms.VideoView videoView1;

		// Token: 0x040000B7 RID: 183
		private global::DevComponents.DotNetBar.PanelEx panelAcountInfo;

		// Token: 0x040000B8 RID: 184
		private global::DevComponents.DotNetBar.ButtonX buttonXAcountInfo;

		// Token: 0x040000B9 RID: 185
		private global::System.Windows.Forms.Label labelQuitAcc;

		// Token: 0x040000BA RID: 186
		public global::System.Windows.Forms.Panel panelAccInfBack;

		// Token: 0x040000BB RID: 187
		private global::System.Windows.Forms.PictureBox pictureBoxUserName;

		// Token: 0x040000BC RID: 188
		private global::System.Windows.Forms.TextBox textBoxUserName;

		// Token: 0x040000BD RID: 189
		private global::System.Windows.Forms.TextBox textBoxServerName;

		// Token: 0x040000BE RID: 190
		private global::System.Windows.Forms.PictureBox pictureBoxServerName;

		// Token: 0x040000BF RID: 191
		private global::System.Windows.Forms.PictureBox pictureBoxLoadingGIF;
	}
}
