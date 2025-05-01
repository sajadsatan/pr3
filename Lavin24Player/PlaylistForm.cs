using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Newtonsoft.Json;
using player.Properties;

namespace player
{
	// Token: 0x02000010 RID: 16
	public partial class PlaylistForm : Form
	{
		// Token: 0x060000B7 RID: 183 RVA: 0x0000E9EC File Offset: 0x0000CBEC
		public PlaylistForm(player player)
		{
			this._player = player;
			this.InitializeComponent();
			base.StartPosition = FormStartPosition.Manual;
			base.Location = this._player.formLoc;
			this.AllowDrop = true;
			base.DragEnter += this.playlist_DragEnter;
			base.DragDrop += this.playlist_DragDrop;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00009458 File Offset: 0x00007658
		private void playlist_DragEnter(object sender, DragEventArgs e)
		{
			bool dataPresent = e.Data.GetDataPresent(DataFormats.FileDrop);
			if (dataPresent)
			{
				e.Effect = DragDropEffects.Copy;
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000EA90 File Offset: 0x0000CC90
		private void playlist_DragDrop(object sender, DragEventArgs e)
		{
			string[] array = (string[])e.Data.GetData(DataFormats.FileDrop);
			foreach (string text in array)
			{
				PlaylistForm.fileInfo fileInfo = new PlaylistForm.fileInfo();
				fileInfo.name = Path.GetFileName(text);
				fileInfo.address = text;
				this.list_of_files.Add(fileInfo);
				this.listBoxPlaylist.Items.Add(fileInfo.name);
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000EB10 File Offset: 0x0000CD10
		private void PlaylistForm_Load(object sender, EventArgs e)
		{
			string text = Settings.Default["Language"].ToString();
			string text2 = Settings.Default["themeName"].ToString();
			this.setBackImage(text, text2);
			this.toolTip1.SetToolTip(this.pictureBoxAdd, this._player.rm.GetString("plst_tooltip1_add", this._player.ci));
			this.toolTip1.SetToolTip(this.pictureBoxClear, this._player.rm.GetString("plst_tooltip1_remove", this._player.ci));
			this.toolTip1.SetToolTip(this.pictureBoxSave, this._player.rm.GetString("plst_tooltip1_save", this._player.ci));
			this.toolTip1.SetToolTip(this.pictureBoxDel, this._player.rm.GetString("plst_tooltip1_delete", this._player.ci));
			this.toolTip1.SetToolTip(this.pictureBoxUP, this._player.rm.GetString("plst_tooltip1_up", this._player.ci));
			this.toolTip1.SetToolTip(this.pictureBoxDW, this._player.rm.GetString("plst_tooltip1_dw", this._player.ci));
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000EC80 File Offset: 0x0000CE80
		private void setBackImage(string lang_name, string theme_name)
		{
			bool flag = lang_name == "fa-IR";
			if (flag)
			{
				bool flag2 = theme_name == "default";
				if (flag2)
				{
					this.panelBack.BackgroundImage = Resources.playlist_back_default;
				}
				bool flag3 = theme_name == "blue";
				if (flag3)
				{
					this.panelBack.BackgroundImage = Resources.playlist_back_blue;
				}
				bool flag4 = theme_name == "red";
				if (flag4)
				{
					this.panelBack.BackgroundImage = Resources.playlist_back_red;
				}
				bool flag5 = theme_name == "purple";
				if (flag5)
				{
					this.panelBack.BackgroundImage = Resources.playlist_back_purple;
				}
				bool flag6 = theme_name == "brown";
				if (flag6)
				{
					this.panelBack.BackgroundImage = Resources.playlist_back_brown;
				}
				bool flag7 = theme_name == "green";
				if (flag7)
				{
					this.panelBack.BackgroundImage = Resources.playlist_back_green;
				}
			}
			else
			{
				bool flag8 = theme_name == "default";
				if (flag8)
				{
					this.panelBack.BackgroundImage = Resources.playlist_back_default_en;
				}
				bool flag9 = theme_name == "blue";
				if (flag9)
				{
					this.panelBack.BackgroundImage = Resources.playlist_back_blue_en;
				}
				bool flag10 = theme_name == "red";
				if (flag10)
				{
					this.panelBack.BackgroundImage = Resources.playlist_back_red_en;
				}
				bool flag11 = theme_name == "purple";
				if (flag11)
				{
					this.panelBack.BackgroundImage = Resources.playlist_back_purple_en;
				}
				bool flag12 = theme_name == "brown";
				if (flag12)
				{
					this.panelBack.BackgroundImage = Resources.playlist_back_brown_en;
				}
				bool flag13 = theme_name == "green";
				if (flag13)
				{
					this.panelBack.BackgroundImage = Resources.playlist_back_green_en;
				}
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002589 File Offset: 0x00000789
		private void comboBox_playlistName_DropDown(object sender, EventArgs e)
		{
			this.fillComboBox();
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000EE3C File Offset: 0x0000D03C
		public void fillComboBox()
		{
			try
			{
				string text = this.PlayListDir();
				string[] files = Directory.GetFiles(text, "*.json");
				List<string> list = new List<string>();
				foreach (string text2 in files)
				{
					list.Add(Path.GetFileNameWithoutExtension(text2));
				}
				foreach (string text3 in list)
				{
					bool flag = !this.comboBox_playlistName.Items.Contains(text3);
					if (flag)
					{
						this.comboBox_playlistName.Items.Add(text3);
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002593 File Offset: 0x00000793
		private void comboBox_playlistName_SelectionChangeCommitted(object sender, EventArgs e)
		{
			this.LoadPlaylist(this.comboBox_playlistName.SelectedItem.ToString());
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000EF14 File Offset: 0x0000D114
		public void LoadPlaylist(string playlist_name)
		{
			this.listBoxPlaylist.Items.Clear();
			this.list_of_files.Clear();
			string text = this.PlayListDir();
			string[] files = Directory.GetFiles(text, "*.json");
			List<string> list = new List<string>();
			foreach (string text2 in files)
			{
				list.Add(Path.GetFileNameWithoutExtension(text2));
			}
			foreach (string text3 in list)
			{
				bool flag = text3 == playlist_name;
				if (flag)
				{
					string text4 = text3 + ".json";
					string text5 = Path.Combine(text, text4);
					string text6 = File.ReadAllText(text5);
					this.list_of_files = JsonConvert.DeserializeObject<List<PlaylistForm.fileInfo>>(text6);
					break;
				}
			}
			foreach (PlaylistForm.fileInfo fileInfo in this.list_of_files)
			{
				this.listBoxPlaylist.Items.Add(fileInfo.name);
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000025AD File Offset: 0x000007AD
		private void buttonClose_Click(object sender, EventArgs e)
		{
			Program.playlist_ON = false;
			base.Close();
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000F05C File Offset: 0x0000D25C
		private void panelTop_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000025BD File Offset: 0x000007BD
		private void panelTop_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000025D7 File Offset: 0x000007D7
		private void pictureBoxSave_Click(object sender, EventArgs e)
		{
			this.savePlaylist();
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000F0C0 File Offset: 0x0000D2C0
		private void savePlaylist()
		{
			bool flag = this.listBoxPlaylist.Items.Count != 0;
			if (flag)
			{
				bool flag2 = this.comboBox_playlistName.Text.Length != 0;
				if (flag2)
				{
					string text = JsonConvert.SerializeObject(this.list_of_files);
					string text2 = this.PlayListDir();
					string text3 = text2 + "\\" + this.comboBox_playlistName.Text + ".json";
					bool flag3 = !Directory.Exists(text2);
					if (flag3)
					{
						Directory.CreateDirectory(text2);
					}
					File.WriteAllText(text3, text);
					MessageBox.Show(this._player.rm.GetString("plst_message_saved", this._player.ci));
				}
				else
				{
					string text4 = JsonConvert.SerializeObject(this.list_of_files);
					string text5 = this.PlayListDir();
					string text6 = text5 + "\\Untitled.json";
					bool flag4 = !Directory.Exists(text5);
					if (flag4)
					{
						Directory.CreateDirectory(text5);
					}
					File.WriteAllText(text6, text4);
					MessageBox.Show(text6);
				}
			}
			else
			{
				MessageBox.Show(this._player.rm.GetString("plst_message_nofiletosave", this._player.ci));
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000F1F8 File Offset: 0x0000D3F8
		private void pictureBoxAdd_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Multiselect = true;
			openFileDialog.Filter = "Video File (enc,mp4,avi,mov,wmd,ivf,mpg,mpeg,3gp) |*.enc;*.mp4;*.avi;*.mov;*.wmd;*.ivf;*.mpg;*.mpeg;*.3gp";
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				string[] fileNames = openFileDialog.FileNames;
				string[] safeFileNames = openFileDialog.SafeFileNames;
				for (int i = 0; i < fileNames.Length; i++)
				{
					PlaylistForm.fileInfo fileInfo = new PlaylistForm.fileInfo();
					fileInfo.name = safeFileNames[i];
					fileInfo.address = fileNames[i];
					this.list_of_files.Add(fileInfo);
					this.listBoxPlaylist.Items.Add(safeFileNames[i]);
				}
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000F29C File Offset: 0x0000D49C
		public void MoveItem(int direction)
		{
			bool flag = this.listBoxPlaylist.SelectedItem == null || this.listBoxPlaylist.SelectedIndex < 0;
			if (!flag)
			{
				int num = this.listBoxPlaylist.SelectedIndex + direction;
				bool flag2 = num < 0 || num >= this.listBoxPlaylist.Items.Count;
				if (!flag2)
				{
					object selectedItem = this.listBoxPlaylist.SelectedItem;
					this.listBoxPlaylist.Items.Remove(selectedItem);
					this.listBoxPlaylist.Items.Insert(num, selectedItem);
					this.listBoxPlaylist.SetSelected(num, true);
					foreach (object obj in this.listBoxPlaylist.Items)
					{
						List<PlaylistForm.fileInfo> list = new List<PlaylistForm.fileInfo>();
						foreach (PlaylistForm.fileInfo fileInfo in this.list_of_files)
						{
							list.Add(fileInfo);
						}
						this.list_of_files.Clear();
						for (int i = 0; i < this.listBoxPlaylist.Items.Count; i++)
						{
							foreach (PlaylistForm.fileInfo fileInfo2 in list)
							{
								PlaylistForm.fileInfo fileInfo3 = new PlaylistForm.fileInfo();
								fileInfo3 = fileInfo2;
								bool flag3 = fileInfo3.name.ToString() == this.listBoxPlaylist.Items[i].ToString();
								if (flag3)
								{
									this.list_of_files.Add(fileInfo3);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000025E1 File Offset: 0x000007E1
		private void pictureBoxUP_Click(object sender, EventArgs e)
		{
			this.MoveItem(-1);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000025EC File Offset: 0x000007EC
		private void pictureBoxDW_Click(object sender, EventArgs e)
		{
			this.MoveItem(1);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000F4D4 File Offset: 0x0000D6D4
		private void pictureBoxClear_Click(object sender, EventArgs e)
		{
			string text = this.PlayListDir();
			string text2 = this.comboBox_playlistName.Text + ".json";
			string text3 = Path.Combine(text, text2);
			bool flag = File.Exists(text3);
			if (flag)
			{
				DialogResult dialogResult = MessageBox.Show(this._player.rm.GetString("plst_message_remove", this._player.ci), this._player.rm.GetString("plst_message_removetitle", this._player.ci), MessageBoxButtons.YesNo);
				bool flag2 = dialogResult == DialogResult.Yes;
				if (flag2)
				{
					File.Delete(text3);
					this.comboBox_playlistName.Text = "";
					this.list_of_files.Clear();
					this.listBoxPlaylist.Items.Clear();
					this.comboBox_playlistName.Items.Remove(this.comboBox_playlistName.SelectedItem.ToString());
				}
			}
			else
			{
				MessageBox.Show(this._player.rm.GetString("plst_message_nolisttoremove", this._player.ci));
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000F5EC File Offset: 0x0000D7EC
		public string PlayListDir()
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			char[] array = new char[]
			{
				'L', 'a', 'v', 'i', 'n', '2', '4', 'P', 'y', 'l',
				'e', 'r', '.', 'x'
			};
			string text = folderPath.TrimEnd(array);
			return text + "\\\\Playlists";
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000F630 File Offset: 0x0000D830
		private void listBoxPlaylist_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this._player._mp.Stop();
			this._player.trackBar1.Value = 0;
			this._player.isPlaying = false;
			this.Play_fromPlaylist(this.listBoxPlaylist.SelectedIndex);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000F680 File Offset: 0x0000D880
		private void Play_fromPlaylist(int indx)
		{
			try
			{
				this.playlingVideoIndx = indx;
				this.videoPath = this.list_of_files[this.playlingVideoIndx].address;
				bool flag = File.Exists(this.videoPath);
				if (flag)
				{
					this.playByExtension(this.videoPath);
				}
				else
				{
					MessageBox.Show(this._player.rm.GetString("plst_message_nofiletoplay", this._player.ci));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(this._player.rm.GetString("plst_message_nofiletoplay", this._player.ci));
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000F734 File Offset: 0x0000D934
		private void playByExtension(string path)
		{
			bool flag = Path.GetExtension(path) == ".enc";
			if (flag)
			{
				this._player.play_video_file(path);
				this.timer1.Start();
			}
			else
			{
				Program.water = null;
				this._player.PlayViaVLC(this._player.isPlaying, path);
				this.timer1.Start();
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000025F7 File Offset: 0x000007F7
		private void GoNext(int i)
		{
			this.playByExtension(this.list_of_files[i + 1].address);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000F7A0 File Offset: 0x0000D9A0
		private void timer1_Tick(object sender, EventArgs e)
		{
			bool flag = this._player.IsFinished();
			if (flag)
			{
				this.timer1.Stop();
				this.timer2.Start();
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000F7D8 File Offset: 0x0000D9D8
		private void timer2_Tick(object sender, EventArgs e)
		{
			this.playlingVideoIndx++;
			bool flag = this.playlingVideoIndx < this.list_of_files.Count<PlaylistForm.fileInfo>();
			if (flag)
			{
				this.listBoxPlaylist.SelectedIndex = this.playlingVideoIndx;
				this.videoPath = this.list_of_files[this.playlingVideoIndx].address;
				this.timer1.Start();
				this.playByExtension(this.videoPath);
				this.timer2.Stop();
			}
			else
			{
				this.timer2.Stop();
				MessageBox.Show(this._player.rm.GetString("plst_message_plstfinished", this._player.ci));
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000F898 File Offset: 0x0000DA98
		private void pictureBoxDel_Click(object sender, EventArgs e)
		{
			int selectedIndex = this.listBoxPlaylist.SelectedIndex;
			bool flag = selectedIndex == -1;
			if (!flag)
			{
				this.list_of_files.RemoveAt(selectedIndex);
				this.listBoxPlaylist.Items.RemoveAt(selectedIndex);
			}
		}

		// Token: 0x040000C0 RID: 192
		private List<string> addresses_list = new List<string>();

		// Token: 0x040000C1 RID: 193
		private List<string> names_list = new List<string>();

		// Token: 0x040000C2 RID: 194
		private string videoPath;

		// Token: 0x040000C3 RID: 195
		private List<PlaylistForm.fileInfo> list_of_files = new List<PlaylistForm.fileInfo>();

		// Token: 0x040000C4 RID: 196
		private player _player;

		// Token: 0x040000C5 RID: 197
		private bool finished = false;

		// Token: 0x040000C6 RID: 198
		private int playlingVideoIndx;

		// Token: 0x040000C7 RID: 199
		private Point lastPoint;

		// Token: 0x040000C8 RID: 200
		private int j = 0;

		// Token: 0x02000011 RID: 17
		public class fileInfo
		{
			// Token: 0x1700000C RID: 12
			// (get) Token: 0x060000D4 RID: 212 RVA: 0x00002614 File Offset: 0x00000814
			// (set) Token: 0x060000D5 RID: 213 RVA: 0x0000261C File Offset: 0x0000081C
			public string address { get; set; }

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x060000D6 RID: 214 RVA: 0x00002625 File Offset: 0x00000825
			// (set) Token: 0x060000D7 RID: 215 RVA: 0x0000262D File Offset: 0x0000082D
			public string name { get; set; }
		}
	}
}
