// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EventHolder.cs" company="Katya">
//      Katya.com. All rights reserved.
// </copyright>
// <summary>
//   class EventHolder
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace _01.FormatedSourceCode.Factories
{
    using System;
    using System.Linq;

    using _01.FormatedSourceCode.Models;

    using Wintellect.PowerCollections;

    /// <summary>
    ///     class EventHolder
    /// </summary>
    public sealed class EventHolder
    {
        /// <summary>
        ///     The events by title
        /// </summary>
        private static readonly MultiDictionary<string, Event> EventsByTitle = new MultiDictionary<string, Event>(true);

        /// <summary>
        ///     The events by date
        /// </summary>
        private static readonly OrderedMultiDictionary<DateTime, Event> EventsByDate =
            new OrderedMultiDictionary<DateTime, Event>(true);

        /// <summary>
        /// Prevents a default instance of the <see cref="EventHolder"/> class from being created.
        /// </summary>
        private EventHolder()
        {
        }

        /// <summary>
        /// Gets the get instance.
        /// </summary>
        public static EventHolder GetInstance
        {
            get
            {
                return EventHolderImplementation.Instance;
            }
        }

        /// <summary>
        /// Adds an event.
        /// </summary>
        /// <param name="date">
        /// The date.
        /// </param>
        /// <param name="title">
        /// The title.
        /// </param>
        /// <param name="location">
        /// The location.
        /// </param>
        public void AddEventToDatabases(DateTime date, string title, string location)
        {
            Event newEvent = new Event(date, title, location);
            string eventTitleLowerCase = newEvent.Title.ToLowerInvariant();

            EventsByTitle.Add(eventTitleLowerCase, newEvent);
            EventsByDate.Add(newEvent.Date, newEvent);

            Messages.EventAdded();
        }

        /// <summary>
        /// Deletes events by title.
        /// </summary>
        /// <param name="eventTitle">
        /// The event title.
        /// </param>
        public void DeleteEventFromDatabases(string eventTitle)
        {
            string eventTitleLowerCase = eventTitle.ToLowerInvariant();
            var eventsToDelete = EventsByTitle[eventTitleLowerCase];
            int deletedCount = eventsToDelete.Count;

            // Delete from this.eventsByDate
            foreach (Event e in eventsToDelete)
            {
                EventsByDate.Remove(e.Date, e);
            }

            // Delete from this.eventsByTitle
            EventsByTitle.Remove(eventTitleLowerCase);

            Messages.EventDeleted(deletedCount);
        }

        /// <summary>
        /// Lists the events.
        /// </summary>
        /// <param name="date">
        /// The date.
        /// </param>
        /// <param name="count">
        /// The count.
        /// </param>
        public void ListEvents(DateTime date, int count)
        {
            var matchedEvents = from e in EventsByDate.RangeFrom(date, true).Values select e;

            int showed = 0;

            foreach (var eventToShow in matchedEvents.TakeWhile(eventToShow => showed != count))
            {
                Messages.PrintEvent(eventToShow);
                showed++;
            }

            if (showed == 0)
            {
                Messages.NoEventsFound();
            }
        }

        /// <summary>
        /// The event holder implementation.
        /// </summary>
        private static class EventHolderImplementation
        {
            /// <summary>
            /// The instance.
            /// </summary>
            internal static readonly EventHolder Instance = new EventHolder();
        }
    }
}