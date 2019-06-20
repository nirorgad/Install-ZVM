using System;
using OpenQA.Selenium;

namespace Install_ZVM
{
    class InstallVRA
    {
        public void MoveToSetupTab(IWebDriver driver, string HostIp)
        {
            try
            {
               IWebElement setupTab = driver.FindElement(By.XPath("//*[@class='promotional-tooltip__content']"));
                setupTab.Click();
            }
            catch
            {
                Console.WriteLine("VRA on Host:" + HostIp + "already Installed");

            }

        }

        public void VRAInfo(IWebDriver driver, string HostIp, string DataStoreName)
        {

            try
            {
                //Host select
                IWebElement HostSelect = driver.FindElement(By.XPath("//*[@aria-label='Selected host']"));
                HostSelect.Click();
                IWebElement Host = driver.FindElement(By.XPath("//*[@aria-label='"+HostIp+"']"));
                Host.Click();
                //Data store select 
                IWebElement DatastoreSelect = driver.FindElement(By.XPath("//*[@aria-label='Selected datastore']"));
                DatastoreSelect.Click();
                IWebElement DataStore = driver.FindElement(By.XPath("//*[contains(@aria-label,'"+DataStoreName+"')]"));
                DataStore.Click();


            }
            catch
            {
                Console.WriteLine("VRA Already Installed");
            }
        }
    }
}
