using DentistBookingSystem.ApplicationServices.API.Authentication;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DentistBookingSystem.Tests
{
    [TestClass]
    public class PasswordHashingTest
    {
        [TestMethod]
        public void Login()
        {
            //Arrange
            PasswordHashing passwordHashing = new PasswordHashing()
            {
                Password = "password123",
                Salt = "iq5ydw1gd4bz+yUUGwR55Q=="
            };


            //Act
            var hashedPass = passwordHashing.Login();



            //Assert
            Assert.AreEqual(hashedPass, "S1A2T1SROJ30eHvh6bsCTf8tUICp9YkOl0W96WUzPK8=");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void LoginFailed()
        {
            //Arrange
            PasswordHashing passwordHashing = new PasswordHashing()
            {
                Password = " ",
                Salt = null
            };

            //Act
            var hashedPass = passwordHashing.Login();

            
        }


        [TestMethod]
        public void Login_usingTryCatch()
        {
            //Arrange
            PasswordHashing passwordHashing = new PasswordHashing()
            {
                Password = null,
                Salt = "iq5ydw1gd4bz+yUUGwR55Q=="
            };


            //Act
            try
            {
                var hashedPass = passwordHashing.Login();
            }
            catch (ArgumentNullException)
            {

                return;
            }



            //Assert
            Assert.Fail("Call to Login() did NOT throw ArgumentNullException");
        }
    }
}
