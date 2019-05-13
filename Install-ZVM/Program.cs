using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using System.IO;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace Install_ZVM
{
    class Program
    {
        static void login(IWebDriver driver, string UserName, string Password)
        {

            var UserNameField = driver.FindElement(By.Id("usernameInput"));
            UserNameField.SendKeys(UserName);
            var PasswordField = driver.FindElement(By.Id("passwordInput"));
            PasswordField.SendKeys(Password);
            PasswordField.Submit();
        }
         static void Main(string[] args)
        {
                string SiteIp = "";
                string UserName = "administrator";
                string Password = "zertodata";

                Console.WriteLine("Please prvoide the ZVM IP address");
                SiteIp = Console.ReadLine();
                Console.WriteLine("Please prvoide the ZVM User Name ");
                UserName = Console.ReadLine();
                Console.WriteLine("Please prvoide the ZVM Password");
                Password = Console.ReadLine();

                var URL = "https://" + SiteIp + ":9669";

                IWebDriver driver = new ChromeDriver();
                driver.Manage().Window.Maximize();        
                driver.Url = URL;
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
                login(driver, UserName, Password);

            

                driver.Close();

            }
        }
}
