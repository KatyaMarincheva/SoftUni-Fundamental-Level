// <copyright file="EventHolder.cs" company="Katya.com">
//     Katya.com. All rights reserved.
// </copyright>
// <author>Katya</author>
namespace _01.FormatedSourceCode
{
    using System;

    /// <summary>
    /// class EventHolder
    /// </summary>
    public class EventHolder
    {
        /// <summary>
        /// The events by title
        /// </summary>
        private readonly MultiDictionary<string, Event> eventsByTitle =
            new MultiDictionary<string, Event>(true);

        /// <summary>
        /// The events by date
        /// </summary>
        private readonly OrderedMultiDictionary<DateTime, Event> eventsByDate =
            new OrderedMultiDictionary<DateTime, Event>(true);

        /// <summary>
        /// Adds an event.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <param name="title">The title.</param>
        /// <param name="location">The location.</param>
        public void AddEvent(DateTime date, string title, string location)
        {
            Event newEvent = new Event(date, title, location);
            string eventTitleLowerCase = newEvent.Title.ToLowerInvariant();

            this.eventsByTitle.Add(eventTitleLowerCase, newEvent);
            this.eventsByDate.Add(newEvent.Date, newEvent);

            Messages.EventAdded();
        }

        /// <summary>
        /// Deletes events by title.
        /// </summary>
        /// <param name="eventTitle">The event title.</param>
        public void DeleteEvents(string eventTitle)
        {
            string eventTitleLowerCase = eventTitle.ToLowerInvariant();
            var eventsToDelete = this.eventsByTitle[eventTitleLowerCase];
            int deletedCount = eventsToDelete.Count;

            // Delete from this.eventsByDate
            foreach (Event e in eventsToDelete)
            {
                this.eventsByDate.Remove(e.Date, e);
            }

            // Delete from this.eventsByTitle
            this.eventsByTitle.Remove(eventTitleLowerCase);

            Messages.EventDeleted(deletedCount);
        }

        /// <summary>
        /// Lists the events.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <param name="count">The count.</param>
        public void ListEvents(DateTime date, int count)
        {
            var matchedEvents =
                from e in this.eventsByDate
                .RangeFrom(date, true)
                .Values
                select e;

            int showed = 0;

            foreach (var eventToShow in matchedEvents)
            {
                if (showed == count)
                {
                    break;
                }

                Messages.PrintEvent(eventToShow);
                showed++;
            }

            if (showed == 0)
            {
                Messages.NoEventsFound();
            }
        }
    } 
}