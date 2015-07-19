// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Event.cs" company="Katya">
//      Katya.com. All rights reserved.
// </copyright>
// <summary>
//   class Event
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace _01.FormatedSourceCode.Models
{
    using System;
    using System.Text;

    /// <summary>
    ///     class Event
    /// </summary>
    public class Event : IComparable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Event"/> class.
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
        public Event(DateTime date, string title, string location)
        {
            this.Date = date;
            this.Title = title;
            this.Location = location;
        }

        /// <summary>
        ///     Gets or sets the date.
        /// </summary>
        /// <value>
        ///     The date.
        /// </value>
        public DateTime Date { get; set; }

        /// <summary>
        ///     Gets or sets the title.
        /// </summary>
        /// <value>
        ///     The title.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        ///     Gets or sets the location.
        /// </summary>
        /// <value>
        ///     The location.
        /// </value>
        public string Location { get; set; }

        /// <summary>
        /// Compares this event to another event.
        /// </summary>
        /// <param name="other">
        /// The other.
        /// </param>
        /// <returns>
        /// Values: 0, 1, or -1.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// otherEvent;OtherEvent cannot be null.
        /// </exception>
        public int CompareTo(object other)
        {
            Event otherEvent = other as Event;

            if (otherEvent.Equals(null))
            {
                throw new ArgumentNullException("otherEvent", "OtherEvent cannot be null.");
            }

            int comparedByDate = this.Date.CompareTo(otherEvent.Date);
            int comparedByTitleTitle = string.Compare(this.Title, otherEvent.Title, StringComparison.Ordinal);
            var comparedByLocation = string.Compare(this.Location, otherEvent.Location, StringComparison.Ordinal);

            if (comparedByDate == 0)
            {
                return comparedByTitleTitle == 0 ? comparedByLocation : comparedByTitleTitle;
            }

            return comparedByDate;
        }

        /// <summary>
        ///     Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        ///     A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(this.Date.ToString("yyyy-MM-ddTHH:mm:ss"));

            output.Append(" | " + this.Title);

            if (!string.IsNullOrEmpty(this.Location))
            {
                output.Append(" | " + this.Location);
            }

            return output.ToString();
        }
    }
}