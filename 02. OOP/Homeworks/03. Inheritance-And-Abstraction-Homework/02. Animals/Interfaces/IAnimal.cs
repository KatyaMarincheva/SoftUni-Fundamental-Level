// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IAnimal.cs" company="Katya">
//   Katya.com. All rights reserved.
// </copyright>
// // <summary>
//   The Animal interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace _02.Animals.Interfaces
{
    using _02.Animals.Enums;

    /// <summary>
    /// The Animal interface.
    /// </summary>
    internal interface IAnimal : ISoundProducible
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the age.
        /// </summary>
        int Age { get; set; }

        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        Gender Gender { get; set; }
    }
}