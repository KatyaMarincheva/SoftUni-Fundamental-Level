// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FormatedSourceCodeMain.cs" company="Katya">
//      Katya.com. All rights reserved.
// </copyright>
// <summary>
//   Main program
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace _01.FormatedSourceCode
{
    using _01.FormatedSourceCode.IO;

    /// <summary>
    ///     Main program
    /// </summary>
    internal class FormatedSourceCodeMain
    {
        /// <summary>
        /// The engine.
        /// </summary>
        private static readonly EventEngine Engine = EventEngine.GetInstance;

        /// <summary>
        /// The renderer.
        /// </summary>
        private static readonly ConsoleRenderer Renderer = ConsoleRenderer.GetInstance;

        /// <summary>
        ///     Defines the entry point of the application.
        /// </summary>
        public static void Main()
        {
            while (Engine.ExecuteNextCommand())
            {
            }

            Renderer.PrintMessages();
        }
    }
}