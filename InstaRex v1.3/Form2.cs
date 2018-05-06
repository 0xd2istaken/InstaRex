using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace deneme
{
	public partial class Form2 : MetroForm
	{
		public Form2()
		{
			this.InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.listBox1.Items.Clear();
			int num = int.Parse(this.textBox2.Text);
			int num2 = int.Parse(this.textBox1.Text);
			char[] array = "aebcdefghijklmnoprtuvyz".ToCharArray();
			Random random = new Random();
			for (int i = 1; i <= num2; i++)
			{
				string text = "";
				for (int j = 1; j <= num; j++)
				{
					int num3 = random.Next(0, array.Length - 1);
					text += array[num3];
				}
				this.listBox1.Items.Add(text + "1@gmail.com");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Title = "İsimlerin Kayıt Olacağı Yeri Seçiniz.";
			saveFileDialog.OverwritePrompt = true;
			saveFileDialog.Filter = "Metin Belgeleri|*.txt|Bütün Dosyalar|*.*";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName, false))
				{
					foreach (object value in this.listBox1.Items)
					{
						streamWriter.WriteLine(value);
					}
				}
			}
		}
	}
}
