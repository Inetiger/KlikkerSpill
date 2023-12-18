namespace KlikkerSpill
{
    internal class SuperUpgradeCommand : ICommand
    {
        private ClickerGame _game;
        public char Character => 'S';

        public SuperUpgradeCommand(ClickerGame game)
        {
            _game = game;
        }

        public void Run()
        {
            _game.SuperUpgrade();
        }

    }
}
