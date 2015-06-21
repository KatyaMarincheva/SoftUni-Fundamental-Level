// <copyright file="VersionAttribute.cs" company="Katya">
//     Katya All rights reserved.
// </copyright>
// <author>Katya</author>
namespace _03.Genereic_List_and_Version
{
    using System;

    /// <summary>
    /// Provides version information for the GenericList
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Struct |
        AttributeTargets.Class |
        AttributeTargets.Enum |
        AttributeTargets.Interface |
        AttributeTargets.Method)]
    public class VersionAttribute : Attribute
    {
        /// <summary>
        /// The minor version
        /// </summary>
        private int minorVersion;

        /// <summary>
        /// The major version
        /// </summary>
        private int majorVersion;

        /// <summary>
        /// Initializes a new instance of the <see cref="VersionAttribute"/> class.
        /// </summary>
        /// <param name="majorVersion">The major version.</param>
        /// <param name="minorVersion">The minor version.</param>
        public VersionAttribute(int majorVersion, int minorVersion)
        {
            this.MajorVersion = majorVersion;
            this.MinorVersion = minorVersion;
        }

        /// <summary>
        /// Gets the major version.
        /// </summary>
        /// <value>
        /// The major version.
        /// </value>
        /// <exception cref="System.ArgumentOutOfRangeException">majorVersion;Value for major version cannot be negative.</exception>
        public int MajorVersion
        {
            get
            {
                return this.majorVersion;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("majorVersion", "Value for major version cannot be negative.");
                }

                this.majorVersion = value;
            }
        }

        /// <summary>
        /// Gets the minor version.
        /// </summary>
        /// <value>
        /// The minor version.
        /// </value>
        /// <exception cref="System.ArgumentOutOfRangeException">minorVersion;Value for minor version cannot be negative.</exception>
        public int MinorVersion
        {
            get
            {
                return this.minorVersion;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("minorVersion", "Value for minor version cannot be negative.");
                }

                this.minorVersion = value;
            }
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            string result = string.Format(
                "Version {0}.{1}",
                this.MajorVersion,
                this.MinorVersion.ToString("X2"));

            return result;
        }
    }
}