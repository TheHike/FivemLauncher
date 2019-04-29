using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using VRRP_Launcher.Properties;

namespace VRRP_Launcher
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : Form
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1
		// (set) Token: 0x06000002 RID: 2
		public string Ip { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3
		// (set) Token: 0x06000004 RID: 4
		public int Port { get; set; }

		// Token: 0x06000005 RID: 5
		public Form1()
		{
			this.InitializeComponent();
			this.Ip = "185.113.141.19";
			this.Port = 30120;
		}

		// Token: 0x06000006 RID: 6
		private void Form1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000007 RID: 7
		private void button1_Click(object sender, EventArgs e)
		{
			Process.Start(string.Format("fivem://connect/{0}:{1}", this.Ip, this.Port));
		}

		// Token: 0x06000008 RID: 8
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}
	}
}
