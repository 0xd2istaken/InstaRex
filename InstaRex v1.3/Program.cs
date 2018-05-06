using System;
using System.Windows.Forms;

namespace deneme
{
	// Token: 0x02000006 RID: 6
	internal static class Program
	{
		// Token: 0x0600001D RID: 29 RVA: 0x000020BC File Offset: 0x000002BC
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
