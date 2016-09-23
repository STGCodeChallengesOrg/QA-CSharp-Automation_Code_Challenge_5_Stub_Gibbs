using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using PageObjects;

[TestClass]
public class VerificationTests {
    public IWebDriver driver;
    ChromeDriverService service;
    ChromeOptions opts;
    TimeSpan thirtySeconds;
    SearchPage searchPage;

    [AssemblyInitialize]
    public void Pretest()
    {
        service = ChromeDriverService.CreateDefaultService();
        opts = new ChromeOptions();
        thirtySeconds = new TimeSpan(0, 0, 30);
        driver = new ChromeDriver(service, opts, thirtySeconds);
        try
        {
            driver.Url= "https://www.skiutah.com/members/listing";
            searchPage = new SearchPage(driver);
        }
        catch (Exception e)
        {
            Console.Write(e.Message);
        }
    }

    #region Tests
    [TestMethod]
    public void verifyWhatSelectIsFound()
    {
        Assert.IsNotNull(searchPage.whatSelect);
    }

    [TestMethod]
    public void verifySubCategorySelectIsFound()
    {
        Assert.IsNotNull(searchPage.subCategorySelect);
    }

    [TestMethod]
    public void verifyByResortSelectIsFound()
    {
        Assert.IsNotNull(searchPage.byResortSelect);
    }

    [TestMethod]
    public void verifyOkSubmitButtonFound()
    {
        Assert.IsNotNull(searchPage.okSubmitButton);
    }

    [TestMethod]
    public void verifySearchResults1()
    {
        Assert.IsFalse(searchPage.SearchFor("Activities", "", "").Count>0);
    }

   
    [TestMethod]
    public void verifySearchResults2()
    {
        Assert.IsFalse(searchPage.SearchFor("Ski School", "", "").Count > 0);
    }

   
    [TestMethod]
    public void verifySearchResults3()
    {
        Assert.IsFalse(searchPage.SearchFor("Ski School", "Clinics", "Sundance").Count > 0);
    }
    #endregion

    [AssemblyCleanup]
    public void TearDown()
    {
        driver.Close();
    }
}