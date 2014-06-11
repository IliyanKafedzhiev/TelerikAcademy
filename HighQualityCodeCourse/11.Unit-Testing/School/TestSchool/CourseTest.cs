using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TelerikSchool;
using System.Collections.Generic;

namespace TestSchool
{
    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCorrectlyCreationOfInstanceOfCourse()
        {
            Course testCourse = new Course(new List<Student>
                {
                    new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),
                    new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),
                    new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),
                    new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),
                    new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),
                    new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),
                    new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),
                    new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),
                    new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),
                    new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),
           
                });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestCorrectlyCreationOfInstanceOfCourseWithNullArgument()
        {
            Course testCourse = new Course(null);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void TestCourseOverloadingWithJoinMethod()
        {
            Course testCourse = new Course(new List<Student>
                                            {
                                                new Student("Peter",12345),
                                                new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),
                                                new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),
                                                new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),
                                                new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),
                                                new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),
                                                new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),
                                                new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),
                                                
                                            });

            testCourse.Join(new Student("Atanas", 12347));
            testCourse.Join(new Student("Atanas", 12347));// overloded
        }

        [TestMethod]
        public void TestLeavingMethod()
        {
            Course testCourse = new Course(new List<Student>{
                                                new Student("Peter",12345),
                                                new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),
                                                new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),
                                                new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),
                                                new Student("Peter",12345),new Student("Atanas", 12347),new Student("Peter",12345),new Student("Peter",12345),
                                                new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),
                                                new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),
                                                new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345),new Student("Peter",12345), 
                                            });

            Assert.AreEqual(29, testCourse.Students.Count);
            testCourse.Leave(new Student("Atanas", 12347));
            Assert.AreEqual(28, testCourse.Students.Count);
        }
    }
}
