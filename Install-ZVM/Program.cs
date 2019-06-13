using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Install_ZVM
{
    class Program
    {
      
        static void Main(string[] args)
        {
            string SiteIp = "10.171.16.76";
            string UserName = "root";
            string Password = "Zertodata1!";
            string License = "PXYB5WXKY6MQXF59BQMJVCFKRR43AEFU55TLB6YWNZ";
            var URL = "https://" + SiteIp + ":9669";


            /* Console.WriteLine("Please prvoide the ZVM IP address");
                 SiteIp = Console.ReadLine();
                 Console.WriteLine("Please prvoide the ZVM User Name ");
                 UserName = Console.ReadLine();
                 Console.WriteLine("Please prvoide the ZVM Password");
                 Password = Console.ReadLine();
            */



            //Open Chrome and enter ZVM GUI //
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();        
            driver.Url = URL;


            //Loging to GUI//
            LoginSite Site1 = new LoginSite();
            Site1.Login(driver, UserName, Password);
            Site1.Enterlicense(driver, License);

            Console.ReadKey();
            driver.Close();

            }
        }
}
