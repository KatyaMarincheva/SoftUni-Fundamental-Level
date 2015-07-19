// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InputHandler.cs" company="Katya">
//   Katya.com. All rights reserved.
// </copyright>
// // <summary>
//   The input handler.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ProductOrders.IO
{
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    ///     The input handler.
    /// </summary>
    public static class InputHandler
    {
        /// <summary>
        /// The read file lines.
        /// </summary>
        /// <param name="filename">
        /// The filename.
        /// </param>
        /// <param name="hasHeader">
        /// The has header.
        /// </param>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public static List<string> ReadFileLines(string filename, bool hasHeader)
        {
            var allLines = new List<string>();
            using (var reader = new StreamReader(filename))
            {
                string currentLine;
                if (hasHeader)
                {
                    reader.ReadLine();
                }

                while ((currentLine = reader.ReadLine()) != null)
                {
                    allLines.Add(currentLine);
                }
            }

            return allLines;
        }
    }
}