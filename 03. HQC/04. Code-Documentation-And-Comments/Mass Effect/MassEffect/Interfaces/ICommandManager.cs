// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ICommandManager.cs" company="Katya">
//   Katya.com. All rights reserved.
// </copyright>
// // <summary>
//   The CommandManager interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace MassEffect.Interfaces
{
    /// <summary>
    ///     The CommandManager interface.
    /// </summary>
    public interface ICommandManager
    {
        /// <summary>
        ///     Gets or sets the engine.
        /// </summary>
        IGameEngine Engine { get; set; }

        /// <summary>
        /// The process command.
        /// </summary>
        /// <param name="command">
        /// The command.
        /// </param>
        void ProcessCommand(string command);

        /// <summary>
        ///     The seed commands.
        /// </summary>
        void SeedCommands();
    }
}