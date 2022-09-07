using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace ActionsClass
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ActionMoveElement()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://uitestpractice.com/Students/Actions";
            Actions actions = new Actions(driver);
            //actions.MoveToElement(driver.FindElement(By.Id("div2")));

            actions.MoveToElement(driver.FindElement(By.Id("div2")), 20, 20);

            actions.ContextClick();

            actions.Build();
            actions.Perform();



        }


        [TestMethod]
        public void ActionClick()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://uitestpractice.com/Students/Actions";
            Thread.Sleep(5000);
            Actions actions = new Actions(driver);
            // IWebElement Clickme= driver.FindElement(By.Name("click"));
            // actions.MoveToElement(Clickme);

            //

            actions.Click(driver.FindElement(By.Name("click"))); // with parameters
            actions.Build();
            actions.Perform();
            Thread.Sleep(16000);
            driver.Quit();









        }
        [TestMethod]
        public void ActionDoubleClick()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://demo.guru99.com/test/simple_context_menu.html";
            //Thread.Sleep(5000);
            Actions actions = new Actions(driver);
            // IWebElement Clickme= driver.FindElement(By.Name("click"));
            // actions.MoveToElement(Clickme);

            //

            actions.DoubleClick(driver.FindElement(By.CssSelector("#authentication > button"))); // with parameters
            actions.Build();
            actions.Perform();
            Thread.Sleep(2000);
            driver.Quit();
        }
        [TestMethod]
        public void ActionsClickAndholdRelease()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://uitestpractice.com/Students/Actions";

            Actions actions = new Actions(driver);


            //  actions.MoveToElement(driver.FindElement(By.Name("one"))); // without parameters
            //  actions.ClickAndHold();
            //  actions.MoveToElement(driver.FindElement(By.Name("twelve")));
            actions.ClickAndHold(driver.FindElement(By.Name("one")));//with parameters
            actions.MoveToElement(driver.FindElement(By.Name("twelve")));
            actions.Release();
            actions.Build();
            actions.Perform();
            Thread.Sleep(2000);
            driver.Quit();
        }
        [TestMethod]
        public void ActionsClickContext()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://uitestpractice.com/Students/Actions";

            Actions actions = new Actions(driver);


            actions.MoveToElement(driver.FindElement(By.Name("four"))); // without parameters

            actions.ContextClick(driver.FindElement(By.Name("four")));


            actions.Build();
            actions.Perform();
            Thread.Sleep(2000);
            driver.Quit();
        }
        [TestMethod]
        public void ActionsMoveByOffset()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://uitestpractice.com/Students/Actions";

            Actions actions = new Actions(driver);

            actions.MoveByOffset(200, 200);
            actions.ContextClick();




            actions.Build();
            actions.Perform();
            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void ActionsDragandDrop()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://uitestpractice.com/Students/Actions";

            Actions actions = new Actions(driver);

            IWebElement drag = driver.FindElement(By.Id("draggable"));
            IWebElement drop = driver.FindElement(By.Id("droppable"));


            actions.DragAndDrop(drag, drop);




            actions.Build();
            actions.Perform();
            Thread.Sleep(2000);
            driver.Quit();
        }
        [TestMethod]
        public void ActionsDragandDropOffset()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://uitestpractice.com/Students/Actions";

            Actions actions = new Actions(driver);

            IWebElement drag = driver.FindElement(By.Id("draggable"));
            //IWebElement drop = driver.FindElement(By.Id("droppable"));


            actions.DragAndDropToOffset(drag, 150, 20);




            actions.Build();
            actions.Perform();
            Thread.Sleep(2000);
            driver.Quit();
        }
        [TestMethod]
        public void ActionsKeyDownKeyUp()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://uitestpractice.com/Students/Actions";

            Actions actions = new Actions(driver);

            actions.KeyDown(Keys.Control);

            actions.KeyDown(Keys.Control).Click(driver.FindElement(By.Name("one")));
            actions.KeyDown(Keys.Control).Click(driver.FindElement(By.Name("six")));
            actions.KeyDown(Keys.Control).Click(driver.FindElement(By.Name("eleven")));
            actions.KeyUp(Keys.Control);





            actions.Build();
            actions.Perform();
            Thread.Sleep(2000);
            driver.Quit();
        }
        [TestMethod]
        public void ActionsSendKeys()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://uitestpractice.com/Students/Actions";

            Actions actions = new Actions(driver);

            actions.SendKeys(Keys.End);
            actions.Perform();
            Thread.Sleep(2000);
            actions.SendKeys(Keys.Home);
            actions.Perform();


            Thread.Sleep(2000);
            driver.Quit();
        }
        [TestMethod]
        public void ActionsCleartextwithoutClear()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.guru99.com/";

            Actions actions = new Actions(driver);

            driver.FindElement(By.Name("emailid")).SendKeys("test@test.com");


            Thread.Sleep(2000);

            actions.Click(driver.FindElement(By.Name("emailid")))
                .KeyDown(Keys.Control)
                .SendKeys("a")
            .KeyUp(Keys.Control)
            .SendKeys(Keys.Backspace)
            .Build();


            actions.Perform();
            Thread.Sleep(2000);

            driver.Quit();
        }
        [TestMethod]
        public void ThreadWaitimplicit()
        {


            //WebDriverManager.
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.ebay.com.au/";

            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            IWebElement element = driver.FindElement(By.XPath("//*[@id=\"mainContent\"]/ div[1]/ul/li[3]/a"));

            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
            //Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"mainContent\"]/ div[1]/ul/li[3]/div[2]/div[1]/nav[2]/ul/li[1]/a")).Click();
            //driver.Quit();


        }
        [TestMethod]
        public void Alerts()
        {
            IWebDriver driver = new ChromeDriver();

            // new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://rahulshettyacademy.com/AutomationPractice/";

            string name = "Rahul";
            driver.FindElement(By.CssSelector("#name")).SendKeys(name);
            driver.FindElement(By.CssSelector("#confirmbtn")).Click();
            Thread.Sleep(3000);
            string alertText = driver.SwitchTo().Alert().Text;
            Thread.Sleep(3000);

            driver.SwitchTo().Alert().Accept();
            // driver.SwitchTo().Alert().Dismiss();
            Thread.Sleep(2000);

            StringAssert.Contains(name, alertText);

        }
        [TestMethod]
        public void ThreadExplicitWait()
        {


            //WebDriverManager.
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.ebay.com.au/";

            driver.Manage().Window.Maximize();

            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            IWebElement element = driver.FindElement(By.XPath("//*[@id=\"mainContent\"]/ div[1]/ul/li[3]/a"));

            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(2000));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"mainContent\"]/ div[1]/ul/li[3]/div[2]/div[1]/nav[2]/ul/li[1]/a"))).Click();




        }
        [TestMethod]
        public void Frame()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://uitestpractice.com/Students/Switchto";
            driver.SwitchTo().Frame("iframe_a");
            driver.FindElement(By.Id("name")).SendKeys("abc");
            driver.SwitchTo().DefaultContent();
            driver.FindElement(By.LinkText("uitestpractice.com")).Click();
            Thread.Sleep(2000);
            driver.Quit();




        }

        [TestMethod]
        public void IFrame()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.guru99.com/test/guru99home/";
            driver.SwitchTo().Frame("a077aa5e");
            driver.FindElement(By.XPath("html/body/a/img")).Click();
            // driver.SwitchTo().DefaultContent();
            // driver.FindElement(By.LinkText("uitestpractice.com")).Click();
            Thread.Sleep(6000);
            driver.Quit();




        }
        [TestMethod]
        public void IFrameW3()
        {
            IWebDriver driver = new ChromeDriver();


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.Url = "https://www.w3schools.com/html/tryit.asp?filename=tryhtml_form_submit";

            driver.SwitchTo().Frame("iframeResult");
            //driver.SwitchTo().Frame(1);


            driver.FindElement(By.Name("fname")).SendKeys("AZ");

            driver.SwitchTo().ParentFrame();



            Thread.Sleep(5000);






            driver.Quit();




        }



        [TestMethod]
        public void Alerts1()
        {
            IWebDriver driver = new ChromeDriver();


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.Url = "https://rahulshettyacademy.com/AutomationPractice/";
        https://www.w3schools.com/js/tryit.asp?filename=tryjs_alert

            string name = "Rahul";
            driver.FindElement(By.CssSelector("#name")).SendKeys(name);
            driver.FindElement(By.CssSelector("#confirmbtn")).Click();
            Thread.Sleep(3000);
            string alertText = driver.SwitchTo().Alert().Text;
            Thread.Sleep(3000);

            driver.SwitchTo().Alert().Accept();
            // driver.SwitchTo().Alert().Dismiss();
            Thread.Sleep(2000);

            StringAssert.Contains(name, alertText);




        }
        [TestMethod]
        public void AlertsW3()
        {
            IWebDriver driver = new ChromeDriver();


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.Url = "https://www.w3schools.com/js/tryit.asp?filename=tryjs_prompt";
            driver.SwitchTo().Frame("iframeResult");
            driver.FindElement(By.XPath("/html/body/button")).Click();
            driver.SwitchTo().Alert().SendKeys("AutomationZone");
            // Thread.Sleep(5000);

            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(5000);

            driver.SwitchTo().ParentFrame();
            driver.Quit();

        }
        [TestMethod]
        public void Dropdown12()
        {
            IWebDriver driver = new ChromeDriver();


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Url = "https://demoqa.com/select-menu";

           // var se = driver.FindElement(By.XPath("//*[@id=\"mySelect\"]"));
            var se = driver.FindElement(By.Id("selectOne"));

            Thread.Sleep(5000);
            var SelectElement = new SelectElement(se);

            SelectElement.SelectByText("Green");







        }

        [TestMethod]
        public void Dropdown13()
        {
            IWebDriver driver = new ChromeDriver();


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Url = "https://rahulshettyacademy.com/loginpagePractise/";
            IWebElement dropdown = driver.FindElement(By.CssSelector("select.form-control"));
            SelectElement s = new SelectElement(dropdown);


            s.SelectByText("Teacher");
            Thread.Sleep(2000);







        }
        [TestMethod]
        public void PrintingProductNAmes()
        {
            IWebDriver driver = new ChromeDriver();


            driver.Navigate().GoToUrl("https://www.amazon.com/s?i=mobile&bbn=7072561011&rh=n%3A7072561011%2Cp_36%3A-30000%2Cp_72%3A2491149011&dc&fs=true&language=en_US&qid=1614961572&rnid=2491147011&ref=sr_pg_");
            IList<IWebElement> elements = driver.FindElements(By.CssSelector("h2>a>span"));
            foreach (IWebElement element in elements)
            {
                Console.WriteLine(element.Text);
            }


        }

        [TestMethod]
        public void PrintingProductNAmes2()
        {
            IWebDriver driver = new ChromeDriver();


            driver.Navigate().GoToUrl("https://www.amazon.com/b?node=24230809011&ref=dlx_deals_gd_dcl_img_0_0de5fc54_dt_sl15_b4");
            IList<IWebElement> elements = driver.FindElements(By.CssSelector("#a-page > div.a-container > div.a-row.apb-browse-two-col-center-pad > div.a-column.a-span12.aok-float-right.apb-browse-col-pad-left.apb-browse-two-col-center-margin-right > div:nth-child(2) > div"));
            foreach (IWebElement element in elements)
            {
                Console.WriteLine(element.Text);
            }


        }



    }
    }





