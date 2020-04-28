using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Drawing;
using System.Threading;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetPageTitle()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://www.google.com";
            driver.Navigate().Refresh();
            driver.Manage().Window.Position = new Point(400, 300);
            Point point = driver.Manage().Window.Position;
            Console.WriteLine(point);
            Console.WriteLine(driver.Title);
            //Console.WriteLine(driver.Url);
            //Console.WriteLine(driver.PageSource);
            //Thread.Sleep(3000);
            driver.Quit();
        }
        [TestMethod]
        public void GetSetSize()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://www.google.com";
            driver.Manage().Window.Size = new Size(500, 400);
            Thread.Sleep(3000);
            driver.Quit();
        }
        [TestMethod]
        public void Exercise()
        {
            IWebDriver driver = new ChromeDriver();
            //IWebDriver driver = new ChromeDriver();
            // Go to google website
            driver.Url = "https://www.google.com";
            Thread.Sleep(2000);

            // Refresh the browser window
            driver.Navigate().Refresh();
            Thread.Sleep(4000);

            // Navigate to techexpozed
            driver.Url = "https://www.techexpozed.co.nz";
            Thread.Sleep(3000);
            // Maximize the window
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            // Click on about menu 
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div/div[2]/div[1]/nav/ul/li[4]/a/span")).Click();

            // Get the url
            Console.WriteLine(driver.Url);

            // Go back and get the title and page source
            Console.WriteLine(driver.Title);
            Console.WriteLine(driver.PageSource);

            // Set the window size(1000,500)
            driver.Manage().Window.Size = new System.Drawing.Size(1000, 500);
            Size size = driver.Manage().Window.Size;
            Console.WriteLine(size);

            // Scroll down to footer and click on the logo
            IJavaScriptExecutor executor = driver as IJavaScriptExecutor;
            Thread.Sleep(2000);
            executor.ExecuteScript("window.scrollBy(0,4500)");
            Thread.Sleep(4000);
            //tech intern 
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div/div/div[5]/ul/li[2]/a/img")).Click();
            Thread.Sleep(4000);
            //Switching between tabs using CTRL + tab keys.
            driver.FindElement(By.CssSelector("body")).SendKeys(Keys.Control + "\t");
            Thread.Sleep(4000);

            //Switch to current selected tab's content.
            //driver.SwitchTo().DefaultContent();
            // Quit the driver
            Thread.Sleep(3000);
            driver.Quit();
        }
        [TestMethod]
        public void GitTut()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://www.techexpozed.co.nz";
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            driver.Quit();
        }
    }
}
