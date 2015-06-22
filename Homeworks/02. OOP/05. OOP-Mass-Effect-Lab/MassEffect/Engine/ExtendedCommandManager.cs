using MassEffect.Engine.Commands;

namespace MassEffect.Engine
{
    class ExtendedCommandManager : CommandManager
    {
        public override void SeedCommands()
        {
            base.SeedCommands();

            this.commandsByName["system-report"] = new SystemReportCommand(this.Engine);
        }
    }
}
