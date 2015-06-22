namespace ClassStudentTests
{
    using System;
    using _04.Student;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ClassStudentTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Name_WhenNameIsEmpty_ShouldThrowArgumentNullException()
        {
            var personWithEmptyName = new Student(string.Empty, 12);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Age_WhenAgeIsNegative_ShouldThrowArgumentOutOfRangeException()
        {
            var personWithAgeMoreThan100 = new Student("A", -2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Age_WhenAgeIsMoreThan150_ShouldThrowArgumentOutOfRangeException()
        {
            var personWithAgeMoreThan100 = new Student("A", 152);
        }

        [TestMethod]
        public void Person_PersonWithValidNameAndAge_ShouldPassTest()
        {
            var personWithValidNameAndAge = new Student("X", 1);
        }

        [TestMethod]
        public void Test_ThatMyAgeChangedEventIsRaised()
        {
            string actual = null;
            Student student = new Student("A", 2);

            student.PropertyChanged += delegate(object sender, PropertyChangedEventArgs e)
            {
                actual = e.PropertyName;
            };

            student.Age = 6;
            Assert.IsNotNull(actual);
            Assert.AreEqual("Age", actual);
        }

        [TestMethod]
        public void Test_ThatMyNameChangedEventIsRaised()
        {
            string actual = null;
            Student student = new Student("Ekaterina", 2);

            student.PropertyChanged += delegate(object sender, PropertyChangedEventArgs e)
            {
                actual = e.PropertyName;
            };

            student.Name = "Katya";
            Assert.IsNotNull(actual);
            Assert.AreEqual("Name", actual);
        }
    }
}