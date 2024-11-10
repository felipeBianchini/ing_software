using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UIAutomationTests
{
    public class Selenium
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            this.driver = new ChromeDriver();   
        }

        [Test]
        public void Enter_To_List_Of_Countries_Test()
        {
            // Arrange
            var URL = "http://localhost:8080/";

            // Maximiza la pantalla
            this.driver.Manage().Window.Maximize();

            // Act
            this.driver.Navigate().GoToUrl(URL);

            // Assert
            Assert.IsNotNull(this.driver);
        }

        [Test]
        public void Enter_To_Create_Country_Form_Test()
        {
            // Arrange
            var URL = "http://localhost:8080/pais";

            // Maximiza la pantalla
            this.driver.Manage().Window.Maximize();

            // Act
            this.driver.Navigate().GoToUrl(URL);

            // Assert
            Assert.IsNotNull(this.driver);
        }

        [Test]
        public void Write_Country_Name_Test()
        {
            // Arrange
            var URL = "http://localhost:8080/pais";
            this.driver.Manage().Window.Maximize();

            // Act
            this.driver.Navigate().GoToUrl(URL);

            IWebElement countryNameInput = driver.FindElement(By.Id("name"));
            IWebElement countryContinentInput = driver.FindElement(By.Id("continente"));
            IWebElement countryLanguageInput = driver.FindElement(By.Id("idioma"));
            IWebElement submitButton = driver.FindElement(By.Id("submitButton"));

            countryNameInput.SendKeys("Sudáfrica");
            countryContinentInput.SendKeys("Africa");
            countryLanguageInput.SendKeys("Inglés");

            submitButton.Click();

            // Assert
            var nextURL = "http://localhost:8080/";
            this.driver.Manage().Window.Maximize();
            this.driver.Navigate().GoToUrl(nextURL);
            IWebElement lista = driver.FindElement(By.Id("lista"));
            IReadOnlyCollection<IWebElement> countries = lista.FindElements(By.TagName("tr"));
            IWebElement lastAdded = countries.Last();
            Assert.That(lastAdded.Text, Is.EqualTo("Sudáfrica Africa Inglés EditarEliminar"));
        }
    }
}
