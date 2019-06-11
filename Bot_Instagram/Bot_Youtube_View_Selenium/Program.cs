using OpenQA.Selenium;
using prmToolkit.Configuration;
using prmToolkit.Selenium;
using prmToolkit.Selenium.Enum;
using System;
using System.Threading;

namespace Bot_Youtube_View_Selenium
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver webDriver = WebDriverFactory.CreateWebDriver(Browser.Chrome, @"E:\00.ESTUDOS\00.GITHUB");

            try
            {
                //Link do video!
                webDriver.LoadPage(TimeSpan.FromSeconds(20), "http://www.youtube.com/video");

                IWebElement btnPularProp = null;
                try
                {
                    //Pegar a tag do botão de fechar anúncio
                    btnPularProp = webDriver.FindElement(By.ClassName("videoAdUiFixedPaddingSkipButtonText"));                                        
                    Console.WriteLine("Fechando Anuncio...");
                    btnPularProp.Click();                                     

                    Thread.Sleep(TimeSpan.FromSeconds(20));
                }
                catch (NoSuchElementException ex)
                {
                    Console.WriteLine(ex.ToString());
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
