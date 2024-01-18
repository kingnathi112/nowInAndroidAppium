using OpenQA.Selenium;

namespace AfwSamples.App.Pages
{
    public class ForYouPage
    {
        ForYouPageMap Map;
        public ForYouPage(WebDriver driver)
        {
            Map = new(driver);
        }

        public bool IsHeaderVisible => Map.Header.Displayed;
    }
    internal class ForYouPageMap
    {
        WebDriver _driver;
        public ForYouPageMap(WebDriver driver)
        {
            _driver = driver;
        }

        public WebElement Header => (WebElement)_driver.FindElement(By.XPath("//android.widget.TextView[@text=\"Now in Android\"]"));
    }
}
