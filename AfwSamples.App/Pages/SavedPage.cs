using OpenQA.Selenium;

namespace AfwSamples.App.Pages
{
    public class SavedPage
    {
        SavedPageMap Map;
        public SavedPage(WebDriver driver)
        {
            Map = new(driver);
        }

        public bool IsHeaderVisible => Map.Header.Displayed;
    }
    internal class SavedPageMap
    {
        WebDriver _driver;
        public SavedPageMap(WebDriver driver)
        {
            _driver = driver;
        }

        public WebElement Header => (WebElement)_driver.FindElement(By.XPath("//android.widget.TextView[@text=\"Saved\"]"));
    }
}
