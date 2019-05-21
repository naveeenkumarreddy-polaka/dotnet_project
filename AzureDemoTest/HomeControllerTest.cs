using System;
using System.Web.Mvc;
using DemoApp.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.CSharp;
namespace AzureDemoTest
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
