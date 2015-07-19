// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EventEngine.cs" company="Katya">
//      Katya.com. All rights reserved.
// </copyright>
// <summary>
//   The event engine.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace _01.FormatedSourceCode
{
    using System;

    using _01.FormatedSourceCode.Factories;
    using _01.FormatedSourceCode.IO;

    /// <summary>
    /// The event engine.
    /// </summary>
    public sealed class EventEngine
    {
        /// <summary>
        /// The events holder.
        /// </summary>
        private static readonly EventHolder EventsHolder = EventHolder.GetInstance;

        /// <summary>
        /// The input handler.
        /// </summary>
        private static readonly InputHandler InputHandler = InputHandler.GetInstance;

        /// <summary>
        /// Prevents a default instance of the <see cref="EventEngine"/> class from being created.
        /// </summary>
        private EventEngine()
        {
        }

        /// <summary>
        /// Gets the get instance.
        /// </summary>
        public static EventEngine GetInstance
        {
            get
            {
                return EventEngineImplementation.Instance;
            }
        }

        /// <summary>
        ///     Executes the next command.
        /// </summary>
        /// <returns>
        ///     Returns true or false.
        /// </returns>
        /// <exception cref="ArgumentNullException">command;Command cannot be empty.</exception>
        public bool ExecuteNextCommand()
        {
            string command = Console.ReadLine();

            if (string.IsNullOrEmpty(command))
            {
                throw new ArgumentNullException("command", "Command cannot be empty.");
            }

            if (command[0] == 'A')
            {
                AddEvent(command);
                return true;
            }

            if (command[0] == 'D')
            {
                DeleteEvents(command);
                return true;
            }

            if (command[0] == 'L')
            {
                ListEvents(command);
                return true;
            }

            if (command[0] == 'E')
            {
                return false;
            }

            return false;
        }

        /// <summary>
        /// Lists the events.
        /// </summary>
        /// <param name="command">
        /// The command.
        /// </param>
        private static void ListEvents(string command)
        {
            int pipeIndex = command.IndexOf('|');
            DateTime date = InputHandler.GetDate(command, "ListEvents");

            string countString = command.Substring(pipeIndex + 1);
            int count = int.Parse(countString);

            EventsHolder.ListEvents(date, count);
        }

        /// <summary>
        /// Deletes the events.
        /// </summary>
        /// <param name="command">
        /// The command.
        /// </param>
        private static void DeleteEvents(string command)
        {
            string title = command.Substring("DeleteEvents".Length + 1);

            EventsHolder.DeleteEventFromDatabases(title);
        }

        /// <summary>
        /// Adds the event.
        /// </summary>
        /// <param name="command">
        /// The command.
        /// </param>
        private static void AddEvent(string command)
        {
            DateTime date;
            string title;
            string location;

            InputHandler.GetEventParameters(command, "AddEvent", out date, out title, out location);

            EventsHolder.AddEventToDatabases(date, title, location);
        }

        /// <summary>
        /// The event engine implementation.
        /// </summary>
        private static class EventEngineImplementation
        {
            /// <summary>
            /// The instance.
            /// </summary>
            internal static readonly EventEngine Instance = new EventEngine();
        }
    }
}