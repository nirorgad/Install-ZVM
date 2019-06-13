﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Install_ZVM
{
    class Program
    {
      
        static void Main(string[] args)
        {
            string DataStoreName = "DS1";
            string HostIp = "10.171.32.35";
            string SiteIp = "10.171.32.199";
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
            Thread.Sleep(3000);

            //Loging to GUI//
            LoginSite Site1 = new LoginSite();
            Site1.Login(driver, UserName, Password);
            Thread.Sleep(3000);
            Site1.Enterlicense(driver, License);
            Thread.Sleep(5000);

            //Install VRA //
            InstallVRA VRA1 = new InstallVRA();
            VRA1.MoveToSetupTab(driver, HostIp);
            VRA1.VRAInfo(driver, HostIp, DataStoreName);



            //End OF Code//
            Console.ReadKey();
            driver.Close();

            }
        }
}
