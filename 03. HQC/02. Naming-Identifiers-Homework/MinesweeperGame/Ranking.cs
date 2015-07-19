// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Ranking.cs" company="Katya">
//   Katya.com. All rights reserved.
// </copyright>
// // <summary>
//   Ranking class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace MinesweeperGame
{
    /// <summary>
    ///     Ranking class.
    /// </summary>
    public class Ranking
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Ranking" /> class.
        /// </summary>
        public Ranking()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ranking"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="points">
        /// The points.
        /// </param>
        public Ranking(string name, int points)
        {
            this.Player = name;
            this.Points = points;
        }

        /// <summary>
        ///     Gets or sets the player.
        /// </summary>
        /// <value>
        ///     The player.
        /// </value>
        public string Player { get; set; }

        /// <summary>
        ///     Gets or sets the points.
        /// </summary>
        /// <value>
        ///     The points.
        /// </value>
        public int Points { get; set; }
    }
}