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

            var UserNameField = driver.FindElement(By.Id("userNameInput"));
            UserNameField.SendKeys(UserName);
            var PasswordField = driver.FindElement(By.Id("passwordInput"));
            PasswordField.SendKeys(Password);
            PasswordField.Submit();

         
        }

        static void Enterlicense(IWebDriver driver, string License )

        {
          try
            {
                var Checker = driver.FindElement(By.XPath("//*[@ng-model='values.license']"));
                Checker.SendKeys(License);
                Console.WriteLine("License enterd");
                Checker.Submit();
             }
          catch
            {
                Console.WriteLine("License all redy exist");
            }    


        }
        static void Main(string[] args)
        {
            string SiteIp = "10.171.16.76";
            string UserName = "root";
            string Password = "Zertodata1!";
            string License = "PXYB5WXKY6MQXF59BQMJVCFKRR43AEFU55TLB6YWNZ";
           /* Console.WriteLine("Please prvoide the ZVM IP address");
                SiteIp = Console.ReadLine();
                Console.WriteLine("Please prvoide the ZVM User Name ");
                UserName = Console.ReadLine();
                Console.WriteLine("Please prvoide the ZVM Password");
                Password = Console.ReadLine();
           */
            var URL = "https://" + SiteIp + ":9669";

                IWebDriver driver = new ChromeDriver();
                driver.Manage().Window.Maximize();        
                driver.Url = URL;
                login(driver, UserName, Password);
                Enterlicense(driver, License);


            Console.ReadKey();
                driver.Close();

            }
        }
}
