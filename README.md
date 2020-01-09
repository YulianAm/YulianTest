 public static class DriverInit
    {

        public static IWebDriver GetNewWebDriver()
        {
            ChromeOptions options = new ChromeOptions();

            options.AddAdditionalCapability("useAutomationExtension", false);
            
            //options.AddArguments("headless");

            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            return new ChromeDriver(outPutDirectory, options);
            
        }





    }
