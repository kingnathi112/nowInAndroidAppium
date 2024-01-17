using OpenQA.Selenium;

namespace AfwSamples.App.Pages
{
    public class NavigationPage
    {
        NavigationPageMap Map;
        public NavigationPage(WebDriver driver)
        {
            Map = new(driver);
        }

        public void ClickForYou() => Map.ForYouBtn.Click();
        public void ClickSaved() => Map.SavedBtn.Click();
        public void ClickInterets() => Map.InterestsBtn.Click();

        public bool IsForYouVisible => Map.ForYouBtn.Displayed;
        public bool IsSavedVisible => Map.SavedBtn.Displayed;
        public bool IsInterestsVisible => Map.InterestsBtn.Displayed;
    }

    internal class NavigationPageMap
    {
        WebDriver _driver;
        public NavigationPageMap(WebDriver driver)
        {
            _driver = driver;
        }

        public WebElement ForYouBtn => (WebElement)_driver.FindElement(By.XPath("//android.widget.TextView[@text=\"For you\"]"));
        public WebElement SavedBtn => (WebElement)_driver.FindElement(By.XPath("//android.widget.TextView[@text=\"Saved\"]"));
        public WebElement InterestsBtn => (WebElement)_driver.FindElement(By.XPath("//android.widget.TextView[@text=\"Interests\"]"));
    }
}
