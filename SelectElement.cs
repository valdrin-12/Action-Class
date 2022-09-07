using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace ActionsClass
{
    internal class SelectElement
    {
        private IWebElement countryDrop;

        public SelectElement(IWebElement countryDrop)
        {
            this.countryDrop = countryDrop;
        }

        public static IList<IWebElement> Options { get; internal set; }

        internal void SelectByText(string v)
        {
            throw new NotImplementedException();
        }
    }
}