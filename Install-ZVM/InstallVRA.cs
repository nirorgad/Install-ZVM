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
                var setupTab = driver.FindElement(By.XPath("//*[@class='promotional-tooltip__content']"));
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
                var HostSelect = driver.FindElement(By.XPath("//*[@aria-label='Selected host']"));
                HostSelect.Click();
                var Host = driver.FindElement(By.XPath("//*[@aria-label='"+HostIp+"']"));
                Host.Click();
                //Data store select 
                var DatastoreSelect = driver.FindElement(By.XPath("//*[@aria-label='Selected datastore']"));
                DatastoreSelect.Click();
                var DataStore = driver.FindElement(By.XPath("//*[contains(@aria-label,'"+DataStoreName+"')]"));
                DataStore.Click();


            }
            catch
            {
                Console.WriteLine("VRA Already Installed");
            }
        }
    }
}
