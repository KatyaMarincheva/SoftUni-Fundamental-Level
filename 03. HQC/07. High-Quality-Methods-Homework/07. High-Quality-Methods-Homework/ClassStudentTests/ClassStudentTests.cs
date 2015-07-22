// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ClassStudentTests.cs" company="Katya">
//   Katya.com. All rights reserved.
// </copyright>
// // <summary>
//   The class student tests.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ClassStudentTests
{
    using System;
    using Methods;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The class student tests.
    /// </summary>
    [TestClass]
    public class ClassStudentTests
    {
        /// <summary>
        /// Testing the firstName property when first name is empty - should throw ArgumentNullException.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FirstName_WhenFirstNameIsEmpty_ShouldThrowArgumentNullException()
        {
            Student katya = new Student
            {
                FirstName = string.Empty, 
                LastName = "Marincheva"
            };
        }

        /// <summary>
        /// Testing the lastName property when last name is empty - should throw ArgumentNullException.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void LastName_WhenLastNameIsEmpty_ShouldThrowArgumentNullException()
        {
            Student katya = new Student
            {
                FirstName = "Katya", 
                LastName = string.Empty
            };
        }

        /// <summary>
        /// Testing the creation of a Student object with valid names- should pass test.
        /// </summary>
        [TestMethod]
        public void Student_CreateStudentWithValidNames_ShouldPassTest()
        {
            Student katya = new Student
            {
                FirstName = "Katya", 
                LastName = "Marincheva"
            };
        }

        /// <summary>
        /// Testing the date of birth extraction when date of birth info is missing - should throw FormatException.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void GetDateOfBirth_WhenDateOfBirthInfoIsMissing_ShouldThrowFormatException()
        {
            Student katya = new Student
            {
                FirstName = "Katya", 
                LastName = "Marincheva", 
                AdditionalInfo = "From Sofia, born at"
            };

            DateTime dateOfBirth = katya.GetDateOfBirth(katya.AdditionalInfo);
        }

        /// <summary>
        /// Testing the date of birth extraction when date of birth info is in wrong format - should throw FormatException.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void GetDateOfBirth_WhenDateOfBirthInfoIsInWrongFormat_ShouldThrowFormatException()
        {
            Student katya = new Student
            {
                FirstName = "Katya", 
                LastName = "Marincheva", 
                AdditionalInfo = "From Sofia, born at 04.20.1963"
            };

            DateTime dateOfBirth = katya.GetDateOfBirth(katya.AdditionalInfo);
        }

        /// <summary>
        /// Testing the date of birth extraction when date of birth info is correct - should pass test.
        /// </summary>
        [TestMethod]
        public void GetDateOfBirth_WhenDateOfBirthInfoIsCorrect_ShouldPassTest()
        {
            Student katya = new Student
            {
                FirstName = "Katya", 
                LastName = "Marincheva", 
                AdditionalInfo = "From Sofia, born at 04.04.1963"
            };

            DateTime dateOfBirth = katya.GetDateOfBirth(katya.AdditionalInfo);
        }

        /// <summary>
        /// Tests the IsOlderThan method when date of birth info for one or both students is missing - should throw ArgumentException.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsOlderThan_WhenDateOfBirthInfoForOneOrBothStudentsIsMissing_ShouldThrowArgumentException()
        {
            Student katya = new Student
            {
                FirstName = "Katya", 
                LastName = "Marincheva", 
                AdditionalInfo = "From Sofia, born at 04.04.1963"
            };

            Student dimitrina = new Student 
            {
                FirstName = "Dimitrina", 
                LastName = "Yaneva", 
                AdditionalInfo = "From Dabovetz, born at 10.28.1941"
            };

            katya.IsOlderThan(dimitrina);
        }

        /// <summary>
        /// Tests the IsOlderThan method when date of birth info for both students is correct - should pass test.
        /// </summary>
        [TestMethod]
        public void IsOlderThan_WhenDateOfBirthInfoForBothStudentsIsCorrect_ShouldPassTest()
        {
            Student katya = new Student
            {
                FirstName = "Katya", 
                LastName = "Marincheva", 
                AdditionalInfo = "From Sofia, born at 04.04.1963"
            };

            Student dimitrina = new Student
            {
                FirstName = "Dimitrina", 
                LastName = "Yaneva", 
                AdditionalInfo = "From Dabovetz, born at 28.10.1941"
            };

            katya.IsOlderThan(dimitrina);
        }
    }
}