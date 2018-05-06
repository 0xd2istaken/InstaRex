using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace deneme
{
	// Token: 0x02000005 RID: 5
	public partial class Form3 : MetroForm
	{
		// Token: 0x06000018 RID: 24 RVA: 0x00002093 File Offset: 0x00000293
		public Form3()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000020AC File Offset: 0x000002AC
		private void Form3_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000020AF File Offset: 0x000002AF
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://0x96.org/");
		}
	}
}
