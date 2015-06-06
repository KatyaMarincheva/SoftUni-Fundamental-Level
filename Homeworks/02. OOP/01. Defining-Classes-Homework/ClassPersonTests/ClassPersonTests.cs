﻿using _01.Persons;
using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassPersonTests
{
    [TestClass]
    public class ClassPersonTests
    {
        // We use the ExpectedExceptionAttribute attribute to assert that the right exception has been thrown. 
        // The attribute causes the test to fail unless an ArgumentNullException is thrown.
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Name_WhenNameIsEmpty_ShouldThrowArgumentNullException()
        {
            var personWithEmptyName = new Person("", 12);
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentOutOfRangeException))]
        public void Age_WhenAgeIsMoreThan100_ShouldThrowArgumentOutOfRangeException()
        {
            var personWithAgeMoreThan100 = new Person("H", 122);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Age_WhenAgeIsLessThan1_ShouldThrowArgumentOutOfRangeException()
        {
            var personWithAgeMoreThan100 = new Person("H", -2);
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentException))]
        public void Email_InvalidEmailFormat_ShouldThrowArgumentException()
        {
            var personWithInvalidEmail = new Person("X", 100, "asdf");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Email_EmptyStringEmail_ShouldThrowArgumentException()
        {
            var personWithEmptyStringEmail = new Person("X", 100, "");
        }

        [TestMethod]
        public void Person_PersonWithValidNameAndAge_ShouldPassTest()
        {
            Person personWithValidNameAndAge = new Person("X", 1);
        }

        [TestMethod]
        public void Person_PersonWithValidNameAgeAndEmail_ShouldPassTest()
        {
            var personWithValidNameAgeAndEmail = new Person("X", 100, "x@outlook.com");
        } 
    }
}
