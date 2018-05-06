using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;


namespace deneme
{

	public partial class Form1 : MetroForm
	{
		
		public Form1()
		{
			this.InitializeComponent();

		}

		private void Gecikme(int saniye)
		{
			if (saniye >= 1)
			{
				DateTime t = DateTime.Now.AddSeconds((double)saniye);
				while (DateTime.Now < t)
				{
					Application.DoEvents();
				}
			}
		}

		private void Gecikme2(int saniyee)
		{
			if (saniyee >= 1)
			{
				DateTime t = DateTime.Now.AddSeconds((double)saniyee);
				while (DateTime.Now < t)
				{
					Application.DoEvents();
				}
			}
		}

		private void Gecikme3(int saniye)
		{
			if (saniye >= 1)
			{
				DateTime t = DateTime.Now.AddSeconds((double)saniye);
				while (DateTime.Now < t)
				{
					Application.DoEvents();
				}
			}
		}

		private void Gecikme1(int saniyee)
		{
			if (saniyee >= 1)
			{
				DateTime t = DateTime.Now.AddSeconds((double)saniyee);
				while (DateTime.Now < t)
				{
					Application.DoEvents();
				}
			}
		}

		private void Gecikme1x(int saniyee)
		{
			if (saniyee >= 1)
			{
				DateTime t = DateTime.Now.AddSeconds((double)saniyee);
				while (DateTime.Now < t)
				{
					Application.DoEvents();
				}
			}
		}

		private void Gecikme4(int saniyee)
		{
			if (saniyee >= 1)
			{
				DateTime t = DateTime.Now.AddSeconds((double)saniyee);
				while (DateTime.Now < t)
				{
					Application.DoEvents();
				}
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.webBrowser1.Navigate("http://instagram.com/");
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			for (int i = 1; i < this.listBox1.Items.Count; i++)
			{
				this.say++;
				this.label5.Text = "Instagram'a Yönlendiriliyor !";
				this.Gecikme(8);
				foreach (object obj in this.webBrowser1.Document.All.GetElementsByName("emailOrPhone"))
				{
					HtmlElement htmlElement = (HtmlElement)obj;
					htmlElement.Focus();
					SendKeys.Send(this.listBox1.Items[this.say].ToString());
					SendKeys.Send("{tab}");
					SendKeys.Send("Coder Ex");
					SendKeys.Send("{tab}");
					SendKeys.Send("{tab}");
					this.label5.Text = "Mail - Ad Soyad - Kullanıcı Adı Girildi !";
				}
				this.Gecikme1(3);
				SendKeys.Send("123123123aA.!s");
				SendKeys.Send("{tab}");
				SendKeys.Send("{enter}");
				this.label5.Text = "Şifre Girildi !";
				this.Gecikme2(4);
				HtmlElementCollection elementsByTagName = this.webBrowser1.Document.GetElementsByTagName("input");
				foreach (object obj2 in elementsByTagName)
				{
					HtmlElement htmlElement2 = (HtmlElement)obj2;
					if (htmlElement2.GetAttribute("name") == "file")
					{
						this.SelectFile();
						htmlElement2.InvokeMember("Click");
					}
				}
				this.Gecikme1(3);
				this.webBrowser1.Navigate("https://instagram.com/" + this.textBox1.Text);
				this.label5.Text = "Kişiyi Takip etmek İçin Profile Gidiliyor !";
				this.Gecikme(3);
				foreach (object obj3 in this.webBrowser1.Document.GetElementsByTagName("button"))
				{
					HtmlElement htmlElement3 = (HtmlElement)obj3;
					if (htmlElement3.GetAttribute("className") == "_qv64e _gexxb _r9b8f _njrw0")
					{
						htmlElement3.InvokeMember("Click");
						break;
					}
				}
				this.label5.Text = "Takip Ediliyor !";
				this.Gecikme3(7);
				this.webBrowser1.Navigate("https://www.instagram.com/accounts/edit/");
				this.Gecikme1x(4);
				HtmlElementCollection elementsByTagName2 = this.webBrowser1.Document.GetElementsByTagName("button");
				foreach (object obj4 in elementsByTagName2)
				{
					HtmlElement htmlElement2 = (HtmlElement)obj4;
					if (htmlElement2.GetAttribute("className") == "_3xjwv")
					{
						this.SelectFilee();
						htmlElement2.InvokeMember("Click");
					}
				}
				this.Gecikme(4);
				string[] files = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Cookies));
				int num = 0;
				foreach (string path in files)
				{
					try
					{
						File.Delete(path);
					}
					catch (Exception ex)
					{
						num++;
					}
				}
				Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess " + 255);
				Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess " + 2);
				Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess " + 2048);
				Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess " + 8192);
				Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess " + 16384);
				this.label5.Text = "Geçmiş Temizlendi !";
				this.Gecikme4(20);
				this.webBrowser1.Navigate("https://instagram.com/");
			}
		}

		private void SelectFile()
		{
			throw new NotImplementedException();
		}

		public async void SelectFilee()
		{
			await Task.Delay(2000);
			SendKeys.Send("C:\\Images\\1.jpg{ENTER}");
		}

		private void button3_Click_1(object sender, EventArgs e)
		{
			if (this.FileDialog.ShowDialog() == DialogResult.OK)
			{
				StreamReader streamReader = new StreamReader(this.FileDialog.FileName);
				for (string text = streamReader.ReadLine(); text != null; text = streamReader.ReadLine())
				{
					this.listBox1.Items.Add(text);
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form2 form = new Form2();
			form.Show();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.textBox1.Enabled = true;
			this.listBox1.Enabled = true;
			this.button1.Enabled = true;
			this.button2.Enabled = true;
			this.button3.Enabled = true;
			this.radioButton1.Enabled = true;
			new Form3().Show();
			this.button4.Visible = false;
		}

		private int say = 1;
	}
}
