using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace player.Lang
{
	// Token: 0x02000024 RID: 36
	[CompilerGenerated]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	internal class langres
	{
		// Token: 0x060001AE RID: 430 RVA: 0x00002726 File Offset: 0x00000926
		internal langres()
		{
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001AF RID: 431 RVA: 0x0001469C File Offset: 0x0001289C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = langres.resourceMan == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("player.Lang.langres", typeof(langres).Assembly);
					langres.resourceMan = resourceManager;
				}
				return langres.resourceMan;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x000146E4 File Offset: 0x000128E4
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x00002A2B File Offset: 0x00000C2B
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return langres.resourceCulture;
			}
			set
			{
				langres.resourceCulture = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x000146FC File Offset: 0x000128FC
		internal static Bitmap accinfo_btn_logout
		{
			get
			{
				object @object = langres.ResourceManager.GetObject("accinfo_btn_logout", langres.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x0001472C File Offset: 0x0001292C
		internal static Bitmap accinfo_server_text
		{
			get
			{
				object @object = langres.ResourceManager.GetObject("accinfo_server_text", langres.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x0001475C File Offset: 0x0001295C
		internal static Bitmap accinfo_username_text
		{
			get
			{
				object @object = langres.ResourceManager.GetObject("accinfo_username_text", langres.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x0001478C File Offset: 0x0001298C
		internal static Bitmap btn_logout
		{
			get
			{
				object @object = langres.ResourceManager.GetObject("btn_logout", langres.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x000147BC File Offset: 0x000129BC
		internal static string cannot_try_anymore
		{
			get
			{
				return langres.ResourceManager.GetString("cannot_try_anymore", langres.resourceCulture);
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x000147E4 File Offset: 0x000129E4
		internal static string close_recorder_app
		{
			get
			{
				return langres.ResourceManager.GetString("close_recorder_app", langres.resourceCulture);
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x0001480C File Offset: 0x00012A0C
		internal static string Connect_to_the_Internet
		{
			get
			{
				return langres.ResourceManager.GetString("Connect_to_the_Internet", langres.resourceCulture);
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x00014834 File Offset: 0x00012A34
		internal static Bitmap default_setting
		{
			get
			{
				object @object = langres.ResourceManager.GetObject("default_setting", langres.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00014864 File Offset: 0x00012A64
		internal static string download_last_version
		{
			get
			{
				return langres.ResourceManager.GetString("download_last_version", langres.resourceCulture);
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001BB RID: 443 RVA: 0x0001488C File Offset: 0x00012A8C
		internal static string downlod_btn
		{
			get
			{
				return langres.ResourceManager.GetString("downlod_btn", langres.resourceCulture);
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001BC RID: 444 RVA: 0x000148B4 File Offset: 0x00012AB4
		internal static string expire_token
		{
			get
			{
				return langres.ResourceManager.GetString("expire_token", langres.resourceCulture);
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001BD RID: 445 RVA: 0x000148DC File Offset: 0x00012ADC
		internal static Bitmap flag
		{
			get
			{
				object @object = langres.ResourceManager.GetObject("flag", langres.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001BE RID: 446 RVA: 0x0001490C File Offset: 0x00012B0C
		internal static Bitmap frmlogout_cancel
		{
			get
			{
				object @object = langres.ResourceManager.GetObject("frmlogout_cancel", langres.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001BF RID: 447 RVA: 0x0001493C File Offset: 0x00012B3C
		internal static Bitmap frmlogout_logout
		{
			get
			{
				object @object = langres.ResourceManager.GetObject("frmlogout_logout", langres.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x0001496C File Offset: 0x00012B6C
		internal static string get_new_license
		{
			get
			{
				return langres.ResourceManager.GetString("get_new_license", langres.resourceCulture);
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x00014994 File Offset: 0x00012B94
		internal static string lang_name
		{
			get
			{
				return langres.ResourceManager.GetString("lang_name", langres.resourceCulture);
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x000149BC File Offset: 0x00012BBC
		internal static Bitmap lbsms_back
		{
			get
			{
				object @object = langres.ResourceManager.GetObject("lbsms_back", langres.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x000149EC File Offset: 0x00012BEC
		internal static Bitmap lbsms_back_entercode
		{
			get
			{
				object @object = langres.ResourceManager.GetObject("lbsms_back_entercode", langres.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x00014A1C File Offset: 0x00012C1C
		internal static Bitmap lbsms_btn_getcode
		{
			get
			{
				object @object = langres.ResourceManager.GetObject("lbsms_btn_getcode", langres.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x00014A4C File Offset: 0x00012C4C
		internal static Bitmap lbsms_resend
		{
			get
			{
				object @object = langres.ResourceManager.GetObject("lbsms_resend", langres.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x00014A7C File Offset: 0x00012C7C
		internal static Bitmap lbsms_to_lbup
		{
			get
			{
				object @object = langres.ResourceManager.GetObject("lbsms_to_lbup", langres.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x00014AAC File Offset: 0x00012CAC
		internal static Bitmap lbup_back
		{
			get
			{
				object @object = langres.ResourceManager.GetObject("lbup_back", langres.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x00014ADC File Offset: 0x00012CDC
		internal static Bitmap lbup_pass_back
		{
			get
			{
				object @object = langres.ResourceManager.GetObject("lbup_pass_back", langres.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x00014B0C File Offset: 0x00012D0C
		internal static Bitmap lbup_pass_rec
		{
			get
			{
				object @object = langres.ResourceManager.GetObject("lbup_pass_rec", langres.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001CA RID: 458 RVA: 0x00014B3C File Offset: 0x00012D3C
		internal static Bitmap lbup_user_back
		{
			get
			{
				object @object = langres.ResourceManager.GetObject("lbup_user_back", langres.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001CB RID: 459 RVA: 0x00014B6C File Offset: 0x00012D6C
		internal static Bitmap login_back
		{
			get
			{
				object @object = langres.ResourceManager.GetObject("login_back", langres.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001CC RID: 460 RVA: 0x00014B9C File Offset: 0x00012D9C
		internal static Bitmap login_btn_activation
		{
			get
			{
				object @object = langres.ResourceManager.GetObject("login_btn_activation", langres.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001CD RID: 461 RVA: 0x00014BCC File Offset: 0x00012DCC
		internal static Bitmap login_btn_recovery
		{
			get
			{
				object @object = langres.ResourceManager.GetObject("login_btn_recovery", langres.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00014BFC File Offset: 0x00012DFC
		internal static string login_message_connectionerror
		{
			get
			{
				return langres.ResourceManager.GetString("login_message_connectionerror", langres.resourceCulture);
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001CF RID: 463 RVA: 0x00014C24 File Offset: 0x00012E24
		internal static Bitmap login_pass
		{
			get
			{
				object @object = langres.ResourceManager.GetObject("login_pass", langres.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x00014C54 File Offset: 0x00012E54
		internal static string login_pass_locx
		{
			get
			{
				return langres.ResourceManager.GetString("login_pass_locx", langres.resourceCulture);
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x00014C7C File Offset: 0x00012E7C
		internal static string login_pass_locy
		{
			get
			{
				return langres.ResourceManager.GetString("login_pass_locy", langres.resourceCulture);
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x00014CA4 File Offset: 0x00012EA4
		internal static string login_tb_pass_locx
		{
			get
			{
				return langres.ResourceManager.GetString("login_tb_pass_locx", langres.resourceCulture);
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x00014CCC File Offset: 0x00012ECC
		internal static string login_tb_pass_locy
		{
			get
			{
				return langres.ResourceManager.GetString("login_tb_pass_locy", langres.resourceCulture);
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x00014CF4 File Offset: 0x00012EF4
		internal static string login_tb_username_locx
		{
			get
			{
				return langres.ResourceManager.GetString("login_tb_username_locx", langres.resourceCulture);
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00014D1C File Offset: 0x00012F1C
		internal static string login_tb_username_locy
		{
			get
			{
				return langres.ResourceManager.GetString("login_tb_username_locy", langres.resourceCulture);
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x00014D44 File Offset: 0x00012F44
		internal static Bitmap login_username
		{
			get
			{
				object @object = langres.ResourceManager.GetObject("login_username", langres.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x00014D74 File Offset: 0x00012F74
		internal static string login_username_locx
		{
			get
			{
				return langres.ResourceManager.GetString("login_username_locx", langres.resourceCulture);
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x00014D9C File Offset: 0x00012F9C
		internal static string login_username_locy
		{
			get
			{
				return langres.ResourceManager.GetString("login_username_locy", langres.resourceCulture);
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x00014DC4 File Offset: 0x00012FC4
		internal static Bitmap login2_activationcode
		{
			get
			{
				object @object = langres.ResourceManager.GetObject("login2_activationcode", langres.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001DA RID: 474 RVA: 0x00014DF4 File Offset: 0x00012FF4
		internal static Bitmap login2_back
		{
			get
			{
				object @object = langres.ResourceManager.GetObject("login2_back", langres.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001DB RID: 475 RVA: 0x00014E24 File Offset: 0x00013024
		internal static Bitmap login2_btn_activate
		{
			get
			{
				object @object = langres.ResourceManager.GetObject("login2_btn_activate", langres.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001DC RID: 476 RVA: 0x00014E54 File Offset: 0x00013054
		internal static Bitmap login2_btn_link
		{
			get
			{
				object @object = langres.ResourceManager.GetObject("login2_btn_link", langres.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001DD RID: 477 RVA: 0x00014E84 File Offset: 0x00013084
		internal static string login2_lbl_copy
		{
			get
			{
				return langres.ResourceManager.GetString("login2_lbl_copy", langres.resourceCulture);
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001DE RID: 478 RVA: 0x00014EAC File Offset: 0x000130AC
		internal static string login2_message_106error
		{
			get
			{
				return langres.ResourceManager.GetString("login2_message_106error", langres.resourceCulture);
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001DF RID: 479 RVA: 0x00014ED4 File Offset: 0x000130D4
		internal static string login2_message_emptyactivecodeerror
		{
			get
			{
				return langres.ResourceManager.GetString("login2_message_emptyactivecodeerror", langres.resourceCulture);
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x00014EFC File Offset: 0x000130FC
		internal static Bitmap login2_systemid
		{
			get
			{
				object @object = langres.ResourceManager.GetObject("login2_systemid", langres.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x00014F2C File Offset: 0x0001312C
		internal static string logout_btn_cancel
		{
			get
			{
				return langres.ResourceManager.GetString("logout_btn_cancel", langres.resourceCulture);
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x00014F54 File Offset: 0x00013154
		internal static string logout_btn_logout
		{
			get
			{
				return langres.ResourceManager.GetString("logout_btn_logout", langres.resourceCulture);
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x00014F7C File Offset: 0x0001317C
		internal static string logout_lbllogouttext1
		{
			get
			{
				return langres.ResourceManager.GetString("logout_lbllogouttext1", langres.resourceCulture);
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x00014FA4 File Offset: 0x000131A4
		internal static string logout_lbllogouttext2
		{
			get
			{
				return langres.ResourceManager.GetString("logout_lbllogouttext2", langres.resourceCulture);
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x00014FCC File Offset: 0x000131CC
		internal static string message_107error
		{
			get
			{
				return langres.ResourceManager.GetString("message_107error", langres.resourceCulture);
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x00014FF4 File Offset: 0x000131F4
		internal static string message_connectionerror
		{
			get
			{
				return langres.ResourceManager.GetString("message_connectionerror", langres.resourceCulture);
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x0001501C File Offset: 0x0001321C
		internal static string not_running_on_vm
		{
			get
			{
				return langres.ResourceManager.GetString("not_running_on_vm", langres.resourceCulture);
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x00015044 File Offset: 0x00013244
		internal static Bitmap open_file
		{
			get
			{
				object @object = langres.ResourceManager.GetObject("open_file", langres.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x00015074 File Offset: 0x00013274
		internal static string phone_number_cannot_be_empty
		{
			get
			{
				return langres.ResourceManager.GetString("phone_number_cannot_be_empty", langres.resourceCulture);
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060001EA RID: 490 RVA: 0x0001509C File Offset: 0x0001329C
		internal static string playbtn_nofile
		{
			get
			{
				return langres.ResourceManager.GetString("playbtn_nofile", langres.resourceCulture);
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060001EB RID: 491 RVA: 0x000150C4 File Offset: 0x000132C4
		internal static Bitmap playlist_back
		{
			get
			{
				object @object = langres.ResourceManager.GetObject("playlist_back", langres.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060001EC RID: 492 RVA: 0x000150F4 File Offset: 0x000132F4
		internal static string plst_message_nofiletoplay
		{
			get
			{
				return langres.ResourceManager.GetString("plst_message_nofiletoplay", langres.resourceCulture);
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060001ED RID: 493 RVA: 0x0001511C File Offset: 0x0001331C
		internal static string plst_message_nofiletosave
		{
			get
			{
				return langres.ResourceManager.GetString("plst_message_nofiletosave", langres.resourceCulture);
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060001EE RID: 494 RVA: 0x00015144 File Offset: 0x00013344
		internal static string plst_message_nolisttoremove
		{
			get
			{
				return langres.ResourceManager.GetString("plst_message_nolisttoremove", langres.resourceCulture);
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060001EF RID: 495 RVA: 0x0001516C File Offset: 0x0001336C
		internal static string plst_message_plstfinished
		{
			get
			{
				return langres.ResourceManager.GetString("plst_message_plstfinished", langres.resourceCulture);
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x00015194 File Offset: 0x00013394
		internal static string plst_message_remove
		{
			get
			{
				return langres.ResourceManager.GetString("plst_message_remove", langres.resourceCulture);
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x000151BC File Offset: 0x000133BC
		internal static string plst_message_removetitle
		{
			get
			{
				return langres.ResourceManager.GetString("plst_message_removetitle", langres.resourceCulture);
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x000151E4 File Offset: 0x000133E4
		internal static string plst_message_saved
		{
			get
			{
				return langres.ResourceManager.GetString("plst_message_saved", langres.resourceCulture);
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x0001520C File Offset: 0x0001340C
		internal static string plst_tooltip1_add
		{
			get
			{
				return langres.ResourceManager.GetString("plst_tooltip1_add", langres.resourceCulture);
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x00015234 File Offset: 0x00013434
		internal static string plst_tooltip1_delete
		{
			get
			{
				return langres.ResourceManager.GetString("plst_tooltip1_delete", langres.resourceCulture);
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x0001525C File Offset: 0x0001345C
		internal static string plst_tooltip1_dw
		{
			get
			{
				return langres.ResourceManager.GetString("plst_tooltip1_dw", langres.resourceCulture);
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x00015284 File Offset: 0x00013484
		internal static string plst_tooltip1_remove
		{
			get
			{
				return langres.ResourceManager.GetString("plst_tooltip1_remove", langres.resourceCulture);
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x000152AC File Offset: 0x000134AC
		internal static string plst_tooltip1_save
		{
			get
			{
				return langres.ResourceManager.GetString("plst_tooltip1_save", langres.resourceCulture);
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x000152D4 File Offset: 0x000134D4
		internal static string plst_tooltip1_up
		{
			get
			{
				return langres.ResourceManager.GetString("plst_tooltip1_up", langres.resourceCulture);
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x000152FC File Offset: 0x000134FC
		internal static string quit_acc_label
		{
			get
			{
				return langres.ResourceManager.GetString("quit_acc_label", langres.resourceCulture);
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00015324 File Offset: 0x00013524
		internal static Bitmap save_setting
		{
			get
			{
				object @object = langres.ResourceManager.GetObject("save_setting", langres.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060001FB RID: 507 RVA: 0x00015354 File Offset: 0x00013554
		internal static string server_label
		{
			get
			{
				return langres.ResourceManager.GetString("server_label", langres.resourceCulture);
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060001FC RID: 508 RVA: 0x0001537C File Offset: 0x0001357C
		internal static Bitmap setting_back
		{
			get
			{
				object @object = langres.ResourceManager.GetObject("setting_back", langres.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060001FD RID: 509 RVA: 0x000153AC File Offset: 0x000135AC
		internal static string Settings_lbllang
		{
			get
			{
				return langres.ResourceManager.GetString("Settings_lbllang", langres.resourceCulture);
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060001FE RID: 510 RVA: 0x000153D4 File Offset: 0x000135D4
		internal static string tooltip1_lang
		{
			get
			{
				return langres.ResourceManager.GetString("tooltip1_lang", langres.resourceCulture);
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060001FF RID: 511 RVA: 0x000153FC File Offset: 0x000135FC
		internal static string tooltip1_logout
		{
			get
			{
				return langres.ResourceManager.GetString("tooltip1_logout", langres.resourceCulture);
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000200 RID: 512 RVA: 0x00015424 File Offset: 0x00013624
		internal static string tooltip1_pause
		{
			get
			{
				return langres.ResourceManager.GetString("tooltip1_pause", langres.resourceCulture);
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000201 RID: 513 RVA: 0x0001544C File Offset: 0x0001364C
		internal static string tooltip1_play
		{
			get
			{
				return langres.ResourceManager.GetString("tooltip1_play", langres.resourceCulture);
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000202 RID: 514 RVA: 0x00015474 File Offset: 0x00013674
		internal static string tooltip1_playlist
		{
			get
			{
				return langres.ResourceManager.GetString("tooltip1_playlist", langres.resourceCulture);
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000203 RID: 515 RVA: 0x0001549C File Offset: 0x0001369C
		internal static string tooltip1_version
		{
			get
			{
				return langres.ResourceManager.GetString("tooltip1_version", langres.resourceCulture);
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000204 RID: 516 RVA: 0x000154C4 File Offset: 0x000136C4
		internal static string user_label
		{
			get
			{
				return langres.ResourceManager.GetString("user_label", langres.resourceCulture);
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000205 RID: 517 RVA: 0x000154EC File Offset: 0x000136EC
		internal static string user_name_label
		{
			get
			{
				return langres.ResourceManager.GetString("user_name_label", langres.resourceCulture);
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000206 RID: 518 RVA: 0x00015514 File Offset: 0x00013714
		internal static string user_server_label
		{
			get
			{
				return langres.ResourceManager.GetString("user_server_label", langres.resourceCulture);
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000207 RID: 519 RVA: 0x0001553C File Offset: 0x0001373C
		internal static string Username_password_cannot_be_empty
		{
			get
			{
				return langres.ResourceManager.GetString("Username_password_cannot_be_empty", langres.resourceCulture);
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000208 RID: 520 RVA: 0x00015564 File Offset: 0x00013764
		internal static string varsion_isuptodate
		{
			get
			{
				return langres.ResourceManager.GetString("varsion_isuptodate", langres.resourceCulture);
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000209 RID: 521 RVA: 0x0001558C File Offset: 0x0001378C
		internal static string version_update_
		{
			get
			{
				return langres.ResourceManager.GetString("version_update?", langres.resourceCulture);
			}
		}

		// Token: 0x04000141 RID: 321
		private static ResourceManager resourceMan;

		// Token: 0x04000142 RID: 322
		private static CultureInfo resourceCulture;
	}
}
