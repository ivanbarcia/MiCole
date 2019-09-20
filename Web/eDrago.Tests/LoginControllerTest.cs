using eDrago.Controllers;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web;
using eDrago.Filters;
using System.Security.Principal;
using eDrago.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace eDrago.Resources
{
    [TestClass]
    public class LoginControllerTest
    {
        Mock<ControllerContext> context = new Mock<ControllerContext>();
        Mock<HttpSessionStateBase> session = new Mock<HttpSessionStateBase>();

        private class MockHttpContext : HttpContextBase
        {
            private readonly IPrincipal user;

            public MockHttpContext(IPrincipal principal)
            {
                this.user = principal;
            }

            public override IPrincipal User
            {
                get
                {
                    return user;
                }
                set
                {
                    base.User = value;
                }
            }
        }

        public LoginControllerTest()
        {
            context.Setup(m => m.HttpContext.Session).Returns(session.Object);

            //var principal = new CustomPrincipal("2038786");
            //principal.ClieAlias = "2038786";
            //principal.FirstName = "Test";
            //principal.LastName = "User";

            //context.Setup(m => m.HttpContext.User).Returns(principal);
        }

        //[TestMethod]
        //public void LoginActionReturnsPage()
        //{
        //    var loginModel = new Login { UserName = "123456", Password = "XXX" };

        //    // Arrange
        //    var controller = new LoginController();
        //    controller.ControllerContext = context.Object;

        //    // Act
        //    var result = controller.Login() as ViewResult;

        //    // Assert
        //    Assert.AreEqual("", result.ViewName);
        //    Assert.IsTrue(controller.ModelState.IsValid);
        //}

        //[TestMethod]
        //public void LoginPostActionIncompleteModel()
        //{
        //    var loginModel = new Login { UserName = "123456" };
            
        //    // Arrange
        //    var controller = new LoginController();
        //    controller.ControllerContext = context.Object;

        //    // Act
        //    SimulateValidation(controller, loginModel);
        //    var result = controller.Login(loginModel, "") as ViewResult;

        //    // Assert
        //    Assert.AreEqual("", result.ViewName);
        //    Assert.IsFalse(controller.ModelState.IsValid);
        //}

        //[TestMethod]
        //public void LoginPostActionWrongCaptcha()
        //{
        //    var loginModel = new Login { UserName = "123456", Password = "XXX" };
        //    context.Setup(m => m.HttpContext.Session["IntentosFallidos"]).Returns(2);
        //    context.Setup(m => m.HttpContext.Request["g-recaptcha-response"]).Returns("");

        //    // Arrange
        //    var controller = new LoginController();
        //    controller.ControllerContext = context.Object;

        //    // Act
        //    SimulateValidation(controller, loginModel);
        //    var result = controller.Login(loginModel, "") as ViewResult;

        //    // Assert
        //    Assert.AreEqual("", result.ViewName);
        //    Assert.IsFalse(controller.ModelState.IsValid);
        //}

        //[TestMethod]
        //public void LoginPostActionMoreThanOneAccess()
        //{
        //    var loginModel = new Login { UserName = "123456", Password = "XXX" };
        //    context.Setup(m => m.HttpContext.Session["IntentosFallidos"]).Returns(2);
        //    context.Setup(m => m.HttpContext.Request["g-recaptcha-response"]).Returns("6LdD6KYUAAAAAJrIeryLvJVxAL-i8NM4rskyS9Te");

        //    // Arrange
        //    var controller = new LoginController();
        //    controller.ControllerContext = context.Object;

        //    // Act
        //    SimulateValidation(controller, loginModel);
        //    var result = controller.Login(loginModel, "") as ViewResult;

        //    // Assert
        //    Assert.AreEqual("", result.ViewName);
        //    Assert.IsFalse(controller.ModelState.IsValid);
        //}

        //private void SimulateValidation(Controller controller, object model)
        //{
        //    // mimic the behaviour of the model binder which is responsible for Validating the Model
        //    var validationContext = new ValidationContext(model, null, null);
        //    var validationResults = new List<ValidationResult>();
        //    Validator.TryValidateObject(model, validationContext, validationResults, true);
        //    foreach (var validationResult in validationResults)
        //    {
        //        controller.ModelState.AddModelError(validationResult.MemberNames.First(), validationResult.ErrorMessage);
        //    }
        //}
    }
}
