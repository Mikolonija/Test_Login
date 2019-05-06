
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;

namespace _2019_05_06
{
    public class Program
    {
        static void Main(string[] args)
        {
            Logers_server LogService = new Logers_server();
            LogService.Init();

            String driverPath = Environment.CurrentDirectory;
            ChromeOptions chromeOptions = new ChromeOptions();

            

            try
            {
                using (ChromeDriver browserDriver = new ChromeDriver(driverPath, chromeOptions))
                {
                    LogService.WriteLog("Mode");
                    browserDriver.Manage().Window.Maximize();
                    Actions actions = new Actions(browserDriver);
                    browserDriver.Url = "https://www.filmai.in/";
                    browserDriver.FindElementByClassName("loginBtn").Click();
                    browserDriver.FindElementByName("login_name").SendKeys("Mode");
                    browserDriver.FindElementByName("login_password").SendKeys("Mode");
                    browserDriver.FindElementByClassName("btn btn-primary btn-block").Click();
                    LogService.WriteLog("succses");

                }

            }
 

            catch (Exception e)
            {

                LogService.WriteLog(e.ToString());
            }
        }
    }
}
