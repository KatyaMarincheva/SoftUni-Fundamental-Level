// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExtendedCommandManager.cs" company="Katya">
//   Katya.com. All rights reserved.
// </copyright>
// // <summary>
//   The extended command manager.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace MassEffect.Engine
{
    using Commands;

    /// <summary>
    ///     The extended command manager.
    /// </summary>
    public class ExtendedCommandManager : CommandManager
    {
        /// <summary>
        ///     The seed commands.
        /// </summary>
        public override void SeedCommands()
        {
            base.SeedCommands();

            this.commandsByName["system-report"] = new SystemReportCommand(this.Engine);
        }
    }
}