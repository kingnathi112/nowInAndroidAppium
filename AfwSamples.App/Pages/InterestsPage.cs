using OpenQA.Selenium;

namespace AfwSamples.App.Pages
{
    public class InterestsPage
    {
        InterestsPageMap Map;
        public InterestsPage(WebDriver driver)
        {
            Map = new(driver);
        }

        public bool IsHeaderVisible => Map.Header.Displayed;
    }
    internal class InterestsPageMap
    {
        WebDriver _driver;
        public InterestsPageMap(WebDriver driver)
        {
            _driver = driver;
        }

        public WebElement Header => (WebElement)_driver.FindElement(By.XPath("//android.widget.TextView[@text=\"Interests\"]"));
    }
}
