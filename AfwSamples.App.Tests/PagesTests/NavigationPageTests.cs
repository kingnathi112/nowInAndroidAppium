using AfwSamples.App.Pages;

namespace AfwSamples.App.Tests.PagesTests
{
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    public class NavigationPageTests
    {
        private AndroidDriver _driver;
        NavigationPage navigationPage;

        [OneTimeSetUp]
        public void SetUp()
        {
            var serverUri = new Uri(Environment.GetEnvironmentVariable("APPIUM_HOST") ?? "http://127.0.0.1:4723/");
            var driverOptions = new AppiumOptions()
            {
                AutomationName = AutomationName.AndroidUIAutomator2,
                PlatformName = "Android",
                DeviceName = "TRJDU19927006922",
            };

            driverOptions.AddAdditionalAppiumOption("appPackage", "com.google.samples.apps.nowinandroid");
            driverOptions.AddAdditionalAppiumOption("appActivity", ".MainActivity");
            driverOptions.AddAdditionalAppiumOption("appium:ensureWebviewsHavePages", true);
            driverOptions.AddAdditionalAppiumOption("appium:nativeWebScreenshot", true);
            driverOptions.AddAdditionalAppiumOption("noReset", true);

            _driver = new AndroidDriver(serverUri, driverOptions, TimeSpan.FromSeconds(180));
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            navigationPage = new(_driver);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _driver.Dispose();
        }

        [Test, Order (10)]
        public void GivenThatApplicationIsLaunchedThenNavigationIsVisible()
        {
            Assert.That(navigationPage.IsForYouVisible, Is.True);
            Assert.That(navigationPage.IsSavedVisible, Is.True);
            Assert.That(navigationPage.IsInterestsVisible, Is.True);
        }
    }
}