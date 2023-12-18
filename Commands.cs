namespace KlikkerSpill
{
    internal class Commands(ClickerGame game)
    {
        private ICommand[] _commands = new ICommand[]
        {
            new ExitCommand(),
            new ClickCommand(game),
            new UpgradeCommand(game),
            new SuperUpgradeCommand(game),
        };

        public void Run(char commandChar)
        {
            var command = FindCommand(commandChar);
            if (command != null) command.Run();
        }

        private ICommand FindCommand(char commandChar)
        {
            foreach (var command in _commands)
            {
                if (command.Character == commandChar) return command;
            }

            return null;
        }
    }
}
