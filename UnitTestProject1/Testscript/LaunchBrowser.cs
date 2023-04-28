using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.Testscript
{
    //[TestClass]
    public class LaunchBrowser
    {
       // [TestMethod]
        public void method1()
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
    //Q2 using navigate command
   // [TestClass]
    public class USingNavigate
    {
       // [TestMethod]
        public void testmethod()
        {
            IWebDriver driver = new ChromeDriver();
           // driver.Url = "https://www.amazon.in/";
            driver.Navigate().GoToUrl("https://www.amazon.in/");
            //driver.navigate().to("www.url.com");  
            String url1 = driver.Url;
            Console.WriteLine(url1);
            driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("The Bhagvad Gita");
            driver.FindElement(By.XPath("//input[@value='Go']")).Click();

           String url2 = driver.Url;
            Console.WriteLine(url2);
            driver.Navigate().Back();
            //driver.navigate().back(); 
            String url3 = driver.Url;
            Console.WriteLine(url3);
            driver.Navigate().Forward();
            //driver.navigate().forward();  
            String url4 = driver.Url;
            Console.WriteLine(url4);
            driver.Navigate().Refresh();
            //driver.navigate().refresh();  

            String Lasturl =driver.Url;
            Console.WriteLine(Lasturl);

           // driver.Dispose ();  


        }
    }
   // [TestClass]
    public class RemoveTextFromTextBox
    {
       // [TestMethod]
        public void removeText()
        {
            IWebDriver driver = new ChromeDriver(); 
            driver.Url= "https://demo.actitime.com/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//input[@id='username']")).SendKeys("admin");

            driver.FindElement(By.XPath("//input[@id='username']")).Clear();
            driver.Quit();
            //driver.FindElement(By.id)
        }
    }
    //Q Child Window Popup
    [TestClass]
    public class PrintAllWindowHAndles
    {
        [TestMethod]
        public void PrintAllWindows() {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://secure.indeed.com/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("apple-signin-button")).Click();
            driver.FindElement(By.Id("login-facebook-button")).Click();
            System.Collections.ObjectModel.ReadOnlyCollection<string> allWhs = driver.WindowHandles;
            int count = allWhs.Count;
            Console.WriteLine(count);
            foreach(string whs in allWhs) 
            {
                Console.WriteLine(whs);
            }
            driver.Dispose();   
        }
    }
    
}
