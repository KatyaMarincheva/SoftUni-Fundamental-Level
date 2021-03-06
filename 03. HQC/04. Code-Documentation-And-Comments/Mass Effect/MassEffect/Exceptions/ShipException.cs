﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ShipException.cs" company="Katya">
//   Katya.com. All rights reserved.
// </copyright>
// // <summary>
//   The ship exception.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace MassEffect.Exceptions
{
    using System;

    /// <summary>
    ///     The ship exception.
    /// </summary>
    public class ShipException : ApplicationException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipException"/> class.
        /// </summary>
        /// <param name="msg">
        /// The msg.
        /// </param>
        public ShipException(string msg)
            : base(msg)
        {
        }
    }
}