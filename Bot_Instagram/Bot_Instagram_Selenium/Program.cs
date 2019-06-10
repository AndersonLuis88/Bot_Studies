using OpenQA.Selenium;
using prmToolkit.Configuration;
using prmToolkit.Selenium;
using prmToolkit.Selenium.Enum;
using System;
using System.Threading;

namespace Bot_Instagram_Selenium
{
    class Program
    {
        static void Main(string[] args)
        {
            var usuario = Configuration.GetKeyAppSettings("username");
            var password = Configuration.GetKeyAppSettings("password");

            //Local do driver do navegador usado para o selenium.
            IWebDriver webDriver = WebDriverFactory.CreateWebDriver(Browser.Chrome, @"E:\00.ESTUDOS\00.GITHUB");

            try
            {
                webDriver.LoadPage(TimeSpan.FromSeconds(10), "http://www.instagram.com/accounts/login/");

                webDriver.SetText(By.Name("username"), usuario);
                webDriver.SetText(By.Name("password"), password);
                webDriver.Submit(By.TagName("button"));

                Thread.Sleep(TimeSpan.FromSeconds(10));
                // xxxxx = Perfil a ser acessado
                webDriver.LoadPage(TimeSpan.FromSeconds(10), "http://www.instagram.com/xxxxx/");
                //webDriver.FindElement(By.XPath("//button[contains(text(), 'Seguir')]")).Click();
                IWebElement btnSeguir = null;

                try
                {
                    btnSeguir = webDriver.FindElement(By.XPath("//button[contains(text(), 'Seguir')]"));
                    btnSeguir.Click();
                }
                catch (NoSuchElementException ex)
                {

                    Console.WriteLine("Usuário já seguido!");
                }
                
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
            finally
            {
                webDriver.Close();
                webDriver.Dispose();
            }




            Console.ReadKey();
        }
    }
}

