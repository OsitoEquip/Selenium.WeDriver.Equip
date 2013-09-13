﻿using OpenQA.Selenium;
using SeleniumExtension;
using TestWebPages.UIFramework.Pages;

namespace Medrio.QA.UITestFramework.Pages
{
    public class IndexPage : BasePage, IPage
    {
        public static string Url = "/TestWebPages/Index.html";

        #region Static By Selectors

        public static By ByAjaxyControlLink = By.LinkText("AjaxyControl Page");

        #endregion

        #region IWebElement properties

        public IWebElement AjaxyControlLink { get { return Driver.FindElement(ByAjaxyControlLink); } }

        #endregion

        #region constructors

        public IndexPage(IWebDriver driver)
            : base(driver)
        {

        }

        public IndexPage()
        {
        }

        #endregion

        #region public methods

        public bool IsPageLoaded()
        {
            return Driver.WaitUntilExists(ByAjaxyControlLink);
        }

        #endregion
    }
}