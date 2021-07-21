namespace RobloxHwidTool
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000005 RID: 5 RVA: 0x0000224C File Offset: 0x0000044C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002284 File Offset: 0x00000484
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::RobloxHwidTool.Form1));
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			base.SuspendLayout();
			this.timer1.Interval = 3600000;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			this.richTextBox1.Location = new global::System.Drawing.Point(105, 18);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new global::System.Drawing.Size(100, 96);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = componentResourceManager.GetString("richTextBox1.Text");
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(336, 0);
			base.Controls.Add(this.richTextBox1);
			base.Name = "Form1";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "Roblox Hwid Tool";
			base.ResumeLayout(false);
		}

		// Token: 0x04000002 RID: 2
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.RichTextBox richTextBox1;
	}
}
