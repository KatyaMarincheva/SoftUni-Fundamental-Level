// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Student.cs" company="Katya">
//   Katya.com. All rights reserved.
// </copyright>
// // <summary>
//   The student.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Methods
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Threading;

    /// <summary>
    /// The Student class.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// The Student first name.
        /// </summary>
        private string firstName;

        /// <summary>
        /// The Student last name.
        /// </summary>
        private string lastName;

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <exception cref="ArgumentNullException">First name cannot be null or empty.
        /// </exception>
        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("firstName", "First name cannot be null or empty.");
                }

                this.firstName = value;
            }
        }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <exception cref="ArgumentNullException">Last name cannot be null or empty.
        /// </exception>
        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("lastName", "Last name cannot be null or empty.");
                }

                this.lastName = value;
            }
        }

        /// <summary>
        /// Gets or sets the additional info property.
        /// </summary>
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Checks if a a student is older than another one.
        /// </summary>
        /// <param name="other">
        /// The other student.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>true or false.
        /// </returns>
        /// <exception cref="ArgumentException">One or both students do not have valid date of birth information provided.
        /// </exception>
        public bool IsOlderThan(Student other)
        {
            try
            {
                DateTime thisStudentDateOfBirth = this.GetDateOfBirth(this.AdditionalInfo);
                DateTime otherStudentDateOfBirth = other.GetDateOfBirth(other.AdditionalInfo);
                return thisStudentDateOfBirth < otherStudentDateOfBirth;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new ArgumentException("One or both students do not have valid date of birth information provided.");
            }
        }

        /// <summary>
        /// Gets the date of birth.
        /// </summary>
        /// <param name="info">
        /// The input info.
        /// </param>
        /// <returns>
        /// The <see cref="DateTime"/>.
        /// </returns>
        /// <exception cref="FormatException">Invalid date format.
        /// </exception>
        public DateTime GetDateOfBirth(string info)
        {
            string[] paramArgs = info.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            string dateInfo = paramArgs.Last().Substring(8).Trim();

            if (!IsValidBulgarianFormatDate(dateInfo))
            {
                throw new FormatException("Invalid date format.");
            }

            DateTime date = DateTime.Parse(dateInfo);

            return date;
        }

        /// <summary>
        /// Checks if the provided date of birth info string can be parsed into a valid date.
        /// </summary>
        /// <param name="dateInfo">
        /// The date of birth info string.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        /// <exception cref="ArgumentNullException">Date if birth information is not provided.
        /// </exception>
        private static bool IsValidBulgarianFormatDate(string dateInfo)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
            DateTime date;
            bool isValiDate = DateTime.TryParse(dateInfo, out date);

            return isValiDate;
        }
    }
}