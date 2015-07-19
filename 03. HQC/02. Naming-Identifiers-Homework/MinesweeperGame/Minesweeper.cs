// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Minesweeper.cs" company="Katya">
//   Katya.com. All rights reserved.
// </copyright>
// // <summary>
//   Minesweeper Game.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace MinesweeperGame
{
    using System;

    /// <summary>
    ///     Minesweeper Game.
    /// </summary>
    public class Minesweeper
    {
        /// <summary>
        ///     Defines the entry point of the application.
        /// </summary>
        public static void Main()
        {
            GameEngine game = new GameEngine();
            game.Run();

            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }
    }
}