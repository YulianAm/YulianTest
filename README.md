 using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

public test()
{

        public static IWebDriver GetNewWebDriver()
        {
            ChromeOptions options = new ChromeOptions();

            options.AddAdditionalCapability("useAutomationExtension", false);
            
            //options.AddArguments("headless");

            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            return new ChromeDriver(outPutDirectory, options);
            
        }


////web driver wait
public void stuffToWaitFor{
   public static IWebElement WaitUntilElementVisible(IWebDriver driver, By elementLocator, int timeout = 10)
        {
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
                return wait.Until(ExpectedConditions.ElementIsVisible(elementLocator));
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element with locator: '" + elementLocator + "' was not found.");
                throw;
            }
        }
}




    
/////////////////////main
public static main()
             {
            Driver = DriverInit.GetNewWebDriver();

            loginPage = new LoginPage(Driver, "PDK");

            loginPage.LoginToDgx();

            Driver.SwitchTo().Window(Driver.WindowHandles.Last());
            }
            
            By tableLocatorInsideWidget = By.CssSelector(".data-cell.scheme-text.scheme-odd");

            Utils.PageObjectUtils.WaitUntilElementVisible(Driver, widgetsLocator, 12);

}
