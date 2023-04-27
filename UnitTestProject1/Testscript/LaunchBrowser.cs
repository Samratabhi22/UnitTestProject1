using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.Testscript
{
    [TestClass]
    public class LaunchBrowser
    {
        [TestMethod]
        public void testmethod()
        {
            //Q1:	Write a script to login to actiTIME application 

            IWebDriver driver = new ChromeDriver();
            // WebDriver driver = new ChromeDriver(); //java
            driver.Url = "https://demo.actitime.com/";
           // driver.get("https://demo.actitime.com/");//java
           
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//input[@id='username']")).SendKeys("admin");
           // driver.findElement(By.xpath("//input[@type='text’]")).sendKeys("admin");//java

            driver.FindElement(By.XPath("//input[@name='pwd']")).SendKeys("manager");
            driver.FindElement(By.XPath("//div[text()='Login ']")).Click();
            //driver.findElement(By.xpath("//div[text() ='Login ']")).click();//java
            driver.Dispose();   
            


        }
    }
}
