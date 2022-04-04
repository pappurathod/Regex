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
        public void WhenGiven_Proper_FirstName_ShouldReturn_Valid()
        {
            Result = userRegistration.validFirstName("Swaraj");
            Assert.AreEqual("First Name is valid", Result);
        }
        [Test]
        public void WhenGiven_Proper_LastName_ShouldReturn_Valid()
        {            
            Result = userRegistration.validLastName("RaThod");
            Assert.AreEqual("Last Name is valid", Result);
        }
        [Test]
        public void WhenGiven_Proper_Email_ShouldReturn_Valid()
        {
            Result = userRegistration.validEmail("rajrathod@bl.co.in");
            Assert.AreEqual("EmailId is valid", Result);
        }
        [Test]
        public void WhenGiven_Proper_MobileNumber_ShouldReturn_Valid()
        {
            Result = userRegistration.validMobileNo("91 9876543210");
            Assert.AreEqual("MobileNo is valid", Result);
        }
        [Test]
        public void WhenGiven_Proper_Password_ShouldReturn_Valid()
        {
            Result = userRegistration.validPassword("AsdFg123");
            Assert.AreEqual("Password is valid", Result);
        }

    }
}

