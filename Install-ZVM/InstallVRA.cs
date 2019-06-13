using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Install_ZVM
{
    class InstallVRA
    {
        public void MoveToSetupTab(IWebDriver driver)
        {
            try
            {
                var setupTab = driver.FindElement(By.XPath("//*[@class='promotional-tooltip__content']"));
                setupTab.Click();

                var Host = driver.FindElement(By.XPath("//[@aria-label='Selected host']"));
                var select = new SelectElement(Host);
                select.SelectByText("10.171.32.35");
            }
            catch
            {
                Console.WriteLine("VRA Already Installed");
            }  
        }
    }
}
