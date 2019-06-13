using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace Install_ZVM
{
    class LoginSite
    {
        public void Login(IWebDriver driver, string UserName, string Password)
        {

            var UserNameField = driver.FindElement(By.Id("userNameInput"));
            UserNameField.SendKeys(UserName);
            var PasswordField = driver.FindElement(By.Id("passwordInput"));
            PasswordField.SendKeys(Password);
            PasswordField.Submit();


        }

        public void Enterlicense(IWebDriver driver, string License)

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


    }
}
