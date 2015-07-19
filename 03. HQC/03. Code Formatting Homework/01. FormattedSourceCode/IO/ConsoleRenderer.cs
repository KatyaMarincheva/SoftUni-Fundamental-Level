// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConsoleRenderer.cs" company="Katya">
//      Katya.com. All rights reserved.
// </copyright>
// <summary>
//   The console renderer.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace _01.FormatedSourceCode.IO
{
    using System;

    using _01.FormatedSourceCode.Factories;

    /// <summary>
    /// The console renderer.
    /// </summary>
    public sealed class ConsoleRenderer
    {
        /// <summary>
        /// Prevents a default instance of the <see cref="ConsoleRenderer"/> class from being created.
        /// </summary>
        private ConsoleRenderer()
        {
        }

        /// <summary>
        /// Gets the get instance.
        /// </summary>
        public static ConsoleRenderer GetInstance
        {
            get
            {
                return ConsoleRendererImplementation.Instance;
            }
        }

        /// <summary>
        /// The print messages.
        /// </summary>
        public void PrintMessages()
        {
            Console.WriteLine(Messages.Output);
        }

        /// <summary>
        /// The console renderer implementation.
        /// </summary>
        private static class ConsoleRendererImplementation
        {
            /// <summary>
            /// The instance.
            /// </summary>
            internal static readonly ConsoleRenderer Instance = new ConsoleRenderer();
        }
    }
}