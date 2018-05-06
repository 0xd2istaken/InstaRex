namespace deneme
{
	// Token: 0x02000004 RID: 4
	public partial class Form2 : global::MetroFramework.Forms.MetroForm
	{
		// Token: 0x06000016 RID: 22 RVA: 0x000031D8 File Offset: 0x000013D8
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00003210 File Offset: 0x00001410
		private void InitializeComponent()
		{
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(258, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(234, 199);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 83);
            this.button1.TabIndex = 1;
            this.button1.Text = "Mail Oluştur !";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Kaç Adet !";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(24, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Kaç Karakter !";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 41);
            this.button2.TabIndex = 4;
            this.button2.Text = "Kaydet !";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 290);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Insta*** // Mail Oluşturucu";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000014 RID: 20
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.ListBox listBox1;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.Button button2;
	}
}
