// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InputHandler.cs" company="Katya">
//      Katya.com. All rights reserved.
// </copyright>
// <summary>
//   The input handler.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace _01.FormatedSourceCode.IO
{
    using System;

    /// <summary>
    /// The input handler.
    /// </summary>
    public sealed class InputHandler
    {
        /// <summary>
        /// Prevents a default instance of the <see cref="InputHandler"/> class from being created.
        /// </summary>
        private InputHandler()
        {
        }

        /// <summary>
        /// Gets the this class's instance.
        /// </summary>
        public static InputHandler GetInstance
        {
            get
            {
                return InputHandlerImplementation.Instance;
            }
        }

        /// <summary>
        /// Gets the parameters.
        /// </summary>
        /// <param name="commandForExecution">
        /// The command for execution.
        /// </param>
        /// <param name="commandType">
        /// Type of the command.
        /// </param>
        /// <param name="dateAndTime">
        /// The date and time.
        /// </param>
        /// <param name="eventTitle">
        /// The event title.
        /// </param>
        /// <param name="eventLocation">
        /// The event location.
        /// </param>
        public void GetEventParameters(
            string commandForExecution, 
            string commandType, 
            out DateTime dateAndTime, 
            out string eventTitle, 
            out string eventLocation)
        {
            dateAndTime = this.GetDate(commandForExecution, commandType);

            int firstPipeIndex = commandForExecution.IndexOf('|');
            int lastPipeIndex = commandForExecution.LastIndexOf('|');

            if (firstPipeIndex == lastPipeIndex)
            {
                eventTitle = commandForExecution.Substring(firstPipeIndex + 1).Trim();

                eventLocation = string.Empty;
            }
            else
            {
                eventTitle =
                    commandForExecution.Substring(firstPipeIndex + 1, lastPipeIndex - firstPipeIndex - 1).Trim();

                eventLocation = commandForExecution.Substring(lastPipeIndex + 1).Trim();
            }
        }

        /// <summary>
        /// Gets the date.
        /// </summary>
        /// <param name="command">
        /// The command.
        /// </param>
        /// <param name="commandType">
        /// Type of the command.
        /// </param>
        /// <returns>
        /// Return vale: date.
        /// </returns>
        public DateTime GetDate(string command, string commandType)
        {
            DateTime date = DateTime.Parse(command.Substring(commandType.Length + 1, 20));

            return date;
        }

        /// <summary>
        /// The input handler implementation.
        /// </summary>
        private static class InputHandlerImplementation
        {
            /// <summary>
            /// The single InputHandler class instance.
            /// </summary>
            internal static readonly InputHandler Instance = new InputHandler();
        }
    }
}