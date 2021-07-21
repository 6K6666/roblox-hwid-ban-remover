using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace RobloxHwidTool
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public static Icon IconFromBytes(byte[] bytes)
		{
			Icon result;
			using (MemoryStream memoryStream = new MemoryStream(bytes))
			{
				result = new Icon(memoryStream);
			}
			return result;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000208C File Offset: 0x0000028C
		public Form1()
		{
			this.InitializeComponent();
			NotifyIcon notifyIcon = new NotifyIcon();
			byte[] bytes = Convert.FromBase64String(this.richTextBox1.Text);
			notifyIcon.Icon = Form1.IconFromBytes(bytes);
			notifyIcon.Visible = true;
			notifyIcon.Click += delegate(object sender, EventArgs args)
			{
				this.RobloxHwidTool();
			};
			base.WindowState = FormWindowState.Minimized;
			base.Hide();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002104 File Offset: 0x00000304
		private void RobloxHwidTool()
		{
			bool flag = this.running;
			if (!flag)
			{
				this.running = true;
				WebResponse response = WebRequest.Create("http://setup.roblox.com/version").GetResponse();
				string text = "0";
				using (Stream responseStream = response.GetResponseStream())
				{
					StreamReader streamReader = new StreamReader(responseStream);
					text = streamReader.ReadToEnd();
				}
				response.Close();
				bool flag2 = text == "0";
				if (flag2)
				{
					this.running = false;
				}
				else
				{
					string text2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\..\\Local\\Roblox\\Versions\\" + text;
					bool flag3 = !Directory.Exists(text2);
					if (flag3)
					{
						this.running = false;
					}
					else
					{
						bool flag4 = !File.Exists(text2 + "\\d3d9.dll");
						if (flag4)
						{
							File.Copy(Directory.GetCurrentDirectory() + "\\d3d9.dll", text2 + "\\d3d9.dll", true);
							bool flag5 = File.Exists(text2 + "\\d3d9.dll");
							if (flag5)
							{
								MessageBox.Show("Installed d3d9.dll into roblox path.", "d3d9.dll", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
								this.running = false;
							}
						}
						this.running = false;
					}
				}
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002240 File Offset: 0x00000440
		private void timer1_Tick(object sender, EventArgs e)
		{
			this.RobloxHwidTool();
		}

		// Token: 0x04000001 RID: 1
		public bool running = false;
	}
}
