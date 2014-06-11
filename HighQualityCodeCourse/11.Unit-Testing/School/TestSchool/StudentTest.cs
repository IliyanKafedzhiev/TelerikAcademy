using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TelerikSchool;


namespace TelerikSchool
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNameSetterIsEmptyString()
        {
            Student testStudent = new Student("",12345);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNameSetterIsNullString()
        {
            Student testStudent = new Student(null,12345);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestIdSetterIsReturnCorrectException()
        {
            Student testStudent = new Student("Peter",9999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestIdSetterIsReturnCorrectExceptionOboveRange()
        {
            Student testStudent = new Student("Peter", 100000);
        }

        [TestMethod]
        public void TestCreationOfOneInstance()
        {
            Student testStudet = new Student("Peter", 10345);

            //Assert.AreEqual("Peter", testStudet.Name);
           // Assert.AreEqual(10345, testStudet.Id);
        }
    }
}
