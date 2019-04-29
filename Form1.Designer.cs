namespace VRRP_Launcher
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000009 RID: 9
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000A RID: 10
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::VRRP_Launcher.Form1));
			this.button1 = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.button1.BackColor = global::System.Drawing.Color.Transparent;
			this.button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderColor = global::System.Drawing.Color.White;
			this.button1.FlatAppearance.BorderSize = 2;
			this.button1.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Black;
			this.button1.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Transparent;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Microsoft JhengHei", 15f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.button1.Location = new global::System.Drawing.Point(125, 354);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(258, 44);
			this.button1.TabIndex = 0;
			this.button1.Text = "Click here to play";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.pictureBox1.BackColor = global::System.Drawing.Color.Black;
			this.pictureBox1.Image = global::VRRP_Launcher.Properties.Resources.Logo_Servidor;
			this.pictureBox1.Location = new global::System.Drawing.Point(95, -3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(317, 335);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::VRRP_Launcher.Properties.Resources.Vinewood_grand_theft_auto_v_41569864_1023_611;
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			base.ClientSize = new global::System.Drawing.Size(503, 450);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.button1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form1";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "NewOldRP Launcher";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000003 RID: 3
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.PictureBox pictureBox1;
	}
}
