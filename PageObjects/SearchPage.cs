using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using OpenQA.Selenium.Support.PageObjects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects
{
    public class SearchPage
    {
        IWebDriver driver;

        #region Constuctors
        public SearchPage(IWebDriver Driver)
        {
            //This constructor needs to initialize the WebElements that are listed in the "Page Elements" region.
            //If using PageFactory, just use the PageFactory.initElements(WebDriver, pageObjects.SearchPage) method.
        }
        #endregion

        #region Page Elements

        // USE THE [FindsBy] NOTATION OF THE PAGEFACTORY CLASS
        //    TO LOCATE AND IDENTIFY THESE WEB PAGE ELEMENTS:

        [FindsBy(How = How.Name, Using = "filter-category-select")]
        public IWebElement whatSelect { get; set; }

        
            public IWebElement subCategorySelect;

            public IWebElement byResortSelect;

            public IWebElement okSubmitButton;

            List<IWebElement> searchResults;
        

        #endregion

        #region Methods

        public List<String> SearchFor(String what, String subCategory, String byResort)
            {
                List<String> results = new List<String>();
                results.Add("This just initializes the list so the code will compile. Delete this entire line of code.");
                //TODO Enter the parameters into the correct page elements.
                //TODO Click the 'OK" button.
                //TODO Get a string representing each result from the ListingResults-item section of the web page.This can be the 'title,' the 'copy,' or whatever.
                //TODO Add each String to the list of results.
                //TODO return the results.
                return results;
            }
        #endregion
    }

}