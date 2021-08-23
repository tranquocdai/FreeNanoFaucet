using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace NanoFaucet
{
    public partial class Form1 : Form
    {
		bool isStop = false;
		public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
		private IWebDriver ExcuseBrowser()
		{
			ChromeOptions options = new ChromeOptions();

				if (File.Exists("C:\\Program Files\\Google\\Chrome\\Application\\Chrome.exe"))
				{
					options.BinaryLocation = "C:\\Program Files\\Google\\Chrome\\Application\\Chrome.exe";
				}
				else
				{
					if (!File.Exists("C:\\Program Files (x86)\\Google\\Chrome\\Application\\Chrome.exe"))
					{
						Invoke((MethodInvoker)delegate
						{
							TXT_Logs.Text = "Please Install Chrome Browser First. Visit https://www.google.com/chrome/";
							Process.Start("https://www.google.com/chrome/");
						});
						return null;
					}
					options.BinaryLocation = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\Chrome.exe";
				}
				options.AddArgument("--disable-gpu");
				options.AddArgument("--log-level=3");
				options.AddArgument("--test-type");
				options.AddArgument("--disable-default-apps");
				options.AddArgument("--disable-volume-adjust-sound");
				options.AddArgument("--mute-audio");
				options.AddArgument("--disable-blink-features=AutomationControlled");
				options.AddExcludedArgument("enable-automation");
				options.AddAdditionalCapability("useAutomationExtension", false);
				options.AddUserProfilePreference("credentials_enable_service", false);
				options.AddUserProfilePreference("profile.password_manager_enabled", false);
				ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
				chromeDriverService.HideCommandPromptWindow = true;
				return new ChromeDriver(chromeDriverService, options, TimeSpan.FromMinutes(3));
		}
		private void Action()
        {
			if (isStop) { return; }

            try
            {
				IWebDriver driver = ExcuseBrowser();
				driver.Manage().Window.Size = new Size(1366,680);
				driver.Navigate().GoToUrl("https://freenanofaucet.com/");
				//Đợi đến khi website load xong hết các đoạn javascript:
				WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60.0));
				wait.Until((x) => { return ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"); });
				string wallet = ""; string result = "";
				Invoke((MethodInvoker)delegate
				{
					wallet = TXT_wallet.Text.Trim();
				});
				if (isStop) goto closeall; 
				Thread.Sleep(2000);
				driver.FindElement(By.Id("nanoAddr")).SendKeys(wallet);
				if (isStop) goto closeall;
				Invoke((MethodInvoker)delegate
				{
					TXT_Logs.AppendText("Nhập địa chỉ ví nano \r\n");
				});
				Thread.Sleep(1000);
				if (isStop) goto closeall;
				driver.FindElement(By.Id("getNano")).Click();
				Thread.Sleep(2000);
				result = driver.FindElement(By.XPath("//*[@id=\"body-body-wrap\"]/div/p")).Text;
				if (isStop) goto closeall;
				Invoke((MethodInvoker)delegate
				{
					TXT_Logs.AppendText("Thông báo:" + result  + "\r\n");
				});

				closeall:
				driver.Close(); driver.Quit();
			}
            catch (Exception ex)
            {
				WriteFile(ex.ToString(), "error.txt");
			}
			
		}
		private void WriteFile(string data_text, string filepath)
		{
			using (StreamWriter sw = new StreamWriter(filepath, true))//Append thì true, ghi đè thì false
			{
				sw.WriteLine(data_text);
			}
		}
		private void BTN_Start_Click(object sender, EventArgs e)
        {
			if (BTN_Start.Text == "START")
			{
				isStop = false;
				BTN_Start.Text = "STOP";
				Thread thread = new Thread((ThreadStart)delegate
				{
					Action();
				});
				thread.IsBackground = true;
				thread.Start();
			}
			else
			{
				isStop = true;
				BTN_Start.Text = "START";
			}
		}

        private void Timer1_Tick(object sender, EventArgs e)
        {
			int hh = DateTime.Now.Hour;
			int mm = DateTime.Now.Minute;
			int ss = DateTime.Now.Second;
			if ((mm%10 == 0) & (ss == 01))
			{
				Invoke((MethodInvoker)delegate ()
				{
					TXT_Logs.AppendText("Tự khởi động lại tool sau mỗi 10 phút \r\n");
				});
				if (BTN_Start.Text == "STOP")
				{
					isStop = false;
					BTN_Start.Text = "START";
				}
				BTN_Start_Click(sender, e);
			}
			LBL_Time.Text = "Time: " + hh + ":" + mm + ":" + ss;
		}

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
			Process.Start(LinkLabel1.Text);
        }
    }
}
