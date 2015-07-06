// <copyright file="Messages.cs" company="Katya.com">
//     Katya.com. All rights reserved.
// </copyright>
// <author>Katya</author>
namespace _01.FormatedSourceCode
{
    using System.Text;

    /// <summary>
    /// class Messages - creates the notification messages.
    /// </summary>
    public static class Messages
    {
        /// <summary>
        /// The output
        /// </summary>
        public static readonly StringBuilder Output = new StringBuilder();

        /// <summary>
        /// Event added notification.
        /// </summary>
        public static void EventAdded()
        {
            Output.Append("Event added\n");
        }

        /// <summary>
        /// Events deleted notification.
        /// </summary>
        /// <param name="x">The x.</param>
        public static void EventDeleted(int x)
        {
            if (x == 0)
            {
                NoEventsFound();
            }
            else
            {
                Output.AppendFormat("{0} events deleted\n", x);
            }
        }

        /// <summary>
        /// No events found notification.
        /// </summary>
        public static void NoEventsFound()
        {
            Output.Append("No events found\n");
        }

        /// <summary>
        /// Prints the event.
        /// </summary>
        /// <param name="eventToPrint">The event to print.</param>
        public static void PrintEvent(Event eventToPrint)
        {
            if (eventToPrint != null)
            {
                Output.Append(eventToPrint + "\n");
            }
        }
    }
}