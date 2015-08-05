// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IHuman.cs" company="Katya">
//   Katya.com. All rights reserved.
// </copyright>
// // <summary>
//   The Human interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace _01.Humans.Interfaces
{
    /// <summary>
    /// The Human interface.
    /// </summary>
    public interface IHuman
    {
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        string LastName { get; set; }

        /// <summary>
        /// The to string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        string ToString();
    }
}