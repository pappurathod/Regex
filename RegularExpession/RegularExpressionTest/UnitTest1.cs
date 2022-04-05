using NUnit.Framework;
using RegularExpession;

namespace RegularExpressionTest
{
    public class Tests
    {
        Program program;
        UserRegistration userRegistration;
        string Result;
        [SetUp]
        public void Setup()
        {
            userRegistration = new UserRegistration();
            program = new Program();
        }

        [Test]
        public void Given_FirstName_When_valid_ShouldReturn_Valid()
        {
            Result = userRegistration.validFirstName("Swaraj");
            Assert.AreEqual("First Name is valid", Result);
        }
        [Test]
        public void Given_LaststName_When_valid_ShouldReturn_Valid()
        {            
            Result = userRegistration.validLastName("RaThod");
            Assert.AreEqual("Last Name is valid", Result);
        }
        [Test]
        public void Given_EmailId_When_valid_ShouldReturn_Valid()
        {
            Result = userRegistration.validEmail("rajrathod@bl.co.in");
            Assert.AreEqual("EmailId is valid", Result);
        }
        [Test]
        public void Given_MobileNo_When_valid_ShouldReturn_Valid()
        {
            Result = userRegistration.validMobileNo("91 9876543210");
            Assert.AreEqual("MobileNo is valid", Result);
        }
        [Test]
        public void Given_Password_When_valid_ShouldReturn_Valid()
        {
            Result = userRegistration.validPassword("AsdFg123");
            Assert.AreEqual("Password is valid", Result);
        }
        [TestCase("abc@yahoo.com")]
        [TestCase("abc-100@yahoo.com")]
        [TestCase("abc.100@yahoo.com")]
        [TestCase("abc111@abc.com")]
        [TestCase("abc-100@abc.net")]
        [TestCase("abc.100@abc.com.au")]
        [TestCase("abc@gmail.com.com")]
        [TestCase("abc+100@gmail.com")]
        public void Given_Email_When_valid_ShouldReturn_Valid(string email)
        {
            Result = userRegistration.validCheckEmailSample(email);
            Assert.AreEqual("Email is valid", Result);
        }
    }
}

